using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OFX
{
    /// <summary>
    /// Provides an interface to an online OFX service using the OFX2 protocol
    /// </summary>
    public class OFX2Service
    {
        public OFX2Service(OFXFinancialInstitution financialInstitution, OFXCredentials userCredentials)
        {
            m_financialInstitution = financialInstitution;
            m_userCredentials = userCredentials;
        }

        /// <summary>
        /// List the profiles available from the service. This does not use the provided user credentials.
        /// This call is usually only needed internally, but is exposed publicly for completeness and debugging.
        /// Profiles are the mechanism through which an OFX service specifies supported operations and informs
        ///   the client of communication options.
        /// 
        /// This is an asyncronous call.
        /// </summary>
        /// <returns>The completed task returns an OFX wrapper containing the result of the call and, on success, a ProfileResponseMessageSetV1</returns>
        public async Task<OFX> listProfiles()
        {
            // Populate the profile request
            ProfileRequest profileRequest = new ProfileRequest();
            profileRequest.CLIENTROUTING = ClientRoutingEnum.MSGSET;  // We can support different endpoints for each message
            profileRequest.DTPROFUP = "19970101"; // Use an early date for "last update" so we always retrieve information

            // Wrap the request in a transaction
            ProfileTransactionRequest profileTransaction = new ProfileTransactionRequest();
            profileTransaction.PROFRQ = profileRequest;
            profileTransaction.TRNUID = getNextTransactionId();

            // Transactions are wrapped in the appropriate message set type
            ProfileRequestMessageSetV1 profileMessageSet = new ProfileRequestMessageSetV1();
            profileMessageSet.PROFTRNRQ = new ProfileTransactionRequest[1] { profileTransaction };

            // Gather all message sets in the request
            var requestMessageSets = new List<AbstractTopLevelMessageSet>();
            requestMessageSets.Add(createSignonRequest(new OFXCredentials("anonymous00000000000000000000000", "anonymous00000000000000000000000")));
            requestMessageSets.Add(profileMessageSet);

            // Send to service and await response
            return await new OFXTransport(m_financialInstitution.ServiceEndpoint).sendRequestAsync(requestMessageSets.ToArray());
        }


        /// <summary>
        /// Populates a signon request for this service using the provided user credentials.
        /// Some OFX calls can use special credentials different than a FI account holder, so this method
        ///   allows the caller to specify credentials
        /// </summary>
        /// <param name="credentials">Authentication credentials to use for this request. If no credentials are specified, the default user credentials for the service are used.</param>
        /// <returns></returns>
        protected SignonRequestMessageSetV1 createSignonRequest(OFXCredentials credentials= null)
        {
            // If no credentials are specified, use the default user credentials assigned when the service was constructed
            if (credentials == null)
                credentials = m_userCredentials;

            // Populate the FinancialInstitution data
            FinancialInstitution financialInstitution = new FinancialInstitution();
            financialInstitution.ORG = m_financialInstitution.OrganizationId;
            financialInstitution.FID = m_financialInstitution.FinancialId;

            // Populate a signon request with the current date and provided user credentials
            SignonRequest signonRequest = new SignonRequest();
            signonRequest.DTCLIENT = dateToOFX(new DateTimeOffset(DateTime.Now));
            signonRequest.ItemsElementName = new ItemsChoiceType[2] { ItemsChoiceType.USERID, ItemsChoiceType.USERPASS };
            signonRequest.Items = new string[2] { credentials.UserId, credentials.Password };
            signonRequest.FI = financialInstitution;
            signonRequest.LANGUAGE = LanguageEnum.ENG;
            signonRequest.APPID = m_appId;
            signonRequest.APPVER = m_appVer;
            
            // Wrap the signon request in a signon message set, per protocol
            SignonRequestMessageSetV1 signonMessageSet = new SignonRequestMessageSetV1();
            signonMessageSet.SONRQ = signonRequest;

            // Return the fully populated request
            return signonMessageSet;
        }

        /// <summary>
        /// Helper method to retrieve a unique transaction ID for each transaction.
        /// This implementation simply creates a globally unique identifier (GUID) as the transaction id.
        /// </summary>
        /// <returns>Unique transaction Id in string form</returns>
        protected string getNextTransactionId()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Helper method to convert from a system Date/Time with Offset from GMT into a format that OFX understands
        /// </summary>
        /// <param name="date">The date/time to convert</param>
        /// <returns>Properly formatted OFX date/time string with offset from GMT</returns>
        protected string dateToOFX(DateTimeOffset date)
        {
            return date.ToString("yyyyMMddHHmmss.000[z:\\G\\M\\T]");
        }

        #region MyRegion
        /// <summary>
        /// Properties of the financial institution used for online communication
        /// </summary>
        protected OFXFinancialInstitution m_financialInstitution;

        /// <summary>
        /// Credentials used to authenticate with the OFX service provider
        /// </summary>
        protected OFXCredentials m_userCredentials;

        /// <summary>
        /// Application Id of the product making the call.
        /// Many OFX endpoints use this to handle response quirks. We match the MS Money v16.00 protocol.
        /// Note that this MUST be a value that is on the provider's list of known products.
        /// </summary>
        protected string m_appId = "Money";

        /// <summary>
        /// Application Version of the product making the call.
        /// Many OFX endpoints use this to handle response quirks. We match the MS Money v16.00 protocol.
        /// Note that this MUST be a value that is on the provider's list of known products.
        /// </summary>
        protected string m_appVer = "1600"; 
        #endregion

    }
}
