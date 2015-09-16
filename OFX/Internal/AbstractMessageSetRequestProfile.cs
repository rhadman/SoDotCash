using System;
using OFX.Protocol;

namespace OFX.Internal
{
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
