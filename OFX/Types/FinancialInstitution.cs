using System;

namespace OFX.Types
{
    /// <summary>
    /// Container class for the basic information needed to identify and communicate with a Financial Institution
    /// </summary>
    public class FinancialInstitution
    {
        public FinancialInstitution(string name, Uri serviceEndpoint, string organizationId, string financialUnitId, bool supportsOnlineRetrieval = true)
        {
            Name = name;
            ServiceEndpoint = serviceEndpoint;
            OrganizationId = organizationId;
            FinancialId = financialUnitId;
            SupportsOnlineRetrieval = supportsOnlineRetrieval;
        }

        /// <summary>
        /// Human readable name of the financial institution. Used for displaying and prompting users.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// URI of the remote OFX service endpoint. This is just the base enddpoint.
        /// The OFX protocol allows the service provider to specify alternative endpoints for specific request types.
        /// </summary>
        public Uri ServiceEndpoint { get; }

        /// <summary>
        /// A string field assigned by the Financial Institution to itself which the client uses to target the proper organization at the
        ///   FI service endpoint. This allows common service endpoints to handle multiple organizations
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// A string field assigned by the Financial Institution to itself which the client uses to target a particular financial unit within
        ///   the organization.
        /// </summary>
        public string FinancialId { get; }

        /// <summary>
        /// Indicator of whether this FI has online retrieval supported by the library
        /// </summary>
        public bool SupportsOnlineRetrieval { get; }
    }

}
