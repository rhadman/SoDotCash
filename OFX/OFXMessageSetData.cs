using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFX
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

    /// <summary>
    /// Container for AbstractMessageSetVersion retrieved from remote OFX service.
    /// </summary>
    public class AbstractMessageSetRequestProfile : MessageSetRequestProfile
    {
        public AbstractMessageSetRequestProfile(AbstractMessageSetVersion messageSetVersionData)
        {
            MessageSetVersionData = messageSetVersionData;
        }

        /// <summary>
        /// Signon Realm is used in authentication requests
        /// </summary>
        public string SignonRealm
        {
            get { return MessageSetVersionData.MSGSETCORE.SIGNONREALM; }
        }

        /// <summary>
        /// URL to communicate with the service on for this MessageSet
        /// </summary>
        public Uri ServiceEndpoint
        {
            get { return new Uri(MessageSetVersionData.MSGSETCORE.URL); }
        }

        /// <summary>
        /// Stored AbstractMessageSetVersion from remote
        /// </summary>
        public AbstractMessageSetVersion MessageSetVersionData { get; }
    }


}
