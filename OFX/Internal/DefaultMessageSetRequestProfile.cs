using System;

namespace OFX.Internal
{
    /// <summary>
    /// Simple container for properties associated with a MessageSet
    /// </summary>
    public class DefaultMessageSetRequestProfile : MessageSetRequestProfile
    {
        public DefaultMessageSetRequestProfile(Uri serviceEndpoint, string signonRealm)
        {
            ServiceEndpoint = serviceEndpoint;
            SignonRealm = signonRealm;
        }

        /// <summary>
        /// Signon Realm is used in authentication requests
        /// </summary>
        public string SignonRealm { get; }

        /// <summary>
        /// URL to communicate with the service on for this MessageSet
        /// </summary>
        public Uri ServiceEndpoint { get; }
    }
}