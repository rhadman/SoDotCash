using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFX
{
    /// <summary>
    /// Container class for the basic information needed to identify and communicate with a Financial Institution
    /// </summary>
    public class OFXFinancialInstitution
    {
        public OFXFinancialInstitution(Uri serviceEndpoint, string organizationId, string financialUnitId, bool supportsOnlineRetrieval = true)
        {
            ServiceEndpoint = serviceEndpoint;
            OrganizationId = organizationId;
            FinancialId = financialUnitId;
            SupportsOnlineRetrieval = supportsOnlineRetrieval;
        }

        /// <summary>
        /// URI of the remote OFX service endpoint. This is just the base enddpoint.
        /// The OFX protocol allows the service provider to specify alternative endpoints for specific request types.
        /// </summary>
        public Uri ServiceEndpoint
        {
            get
            {
                return serviceEndpoint;
            }

            set
            {
                serviceEndpoint = value;
            }
        }

        /// <summary>
        /// A string field assigned by the Financial Institution to itself which the client uses to target the proper organization at the
        ///   FI service endpoint. This allows common service endpoints to handle multiple organizations
        /// </summary>
        public string OrganizationId
        {
            get
            {
                return organizationId;
            }

            set
            {
                organizationId = value;
            }
        }

        /// <summary>
        /// A string field assigned by the Financial Institution to itself which the client uses to target a particular financial unit within
        ///   the organization.
        /// </summary>
        public string FinancialId
        {
            get
            {
                return financialId;
            }

            set
            {
                financialId = value;
            }
        }

        /// <summary>
        /// Indicator of whether this FI has online retrieval supported by the library
        /// </summary>
        public bool SupportsOnlineRetrieval
        {
            get
            {
                return supportsOnlineRetrieval;
            }

            set
            {
                supportsOnlineRetrieval = value;
            }
        }


        /// <summary>
        /// URI of the remote OFX service endpoint. This is just the base enddpoint.
        /// The OFX protocol allows the service provider to specify alternative endpoints for specific request types.
        /// </summary>
        private Uri serviceEndpoint;

        /// <summary>
        /// A string field assigned by the Financial Institution to itself which the client uses to target the proper organization at the
        ///   FI service endpoint. This allows common service endpoints to handle multiple organizations
        /// </summary>
        private string organizationId;

        /// <summary>
        /// A string field assigned by the Financial Institution to itself which the client uses to target a particular financial unit within
        ///   the organization.
        /// </summary>
        private string financialId;

        /// <summary>
        /// Indicator of whether this FI has online retrieval supported by the library
        /// </summary>
        private bool supportsOnlineRetrieval;


    }

}
