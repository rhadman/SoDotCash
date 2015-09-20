using System;

namespace OFX.Internal
{
    /// <summary>
    /// Interface for providing information about sending requests for profiles
    /// </summary>
    public interface MessageSetRequestProfile
    {
        /// <summary>
        /// Signon Realm is used in authentication requests
        /// </summary>
        string SignonRealm { get; }

        /// <summary>
        /// URL to communicate with the service on for this MessageSet
        /// </summary>
        Uri ServiceEndpoint { get; }
    }
}