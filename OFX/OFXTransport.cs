using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OFX.Protocol;

namespace OFX
{
    /// <summary>
    /// Encapsulates the transport layer of the OFX protocol specification.
    /// Uses HTTPS to send and receive messages
    /// </summary>
    class OFXTransport
    {
        public OFXTransport(Uri serviceEndpoint) 
        {
            m_serviceURI = serviceEndpoint;
        }

        /// <summary>
        /// Format and send a populated OFX request to the service.
        /// 
        /// This is an asycronous call.
        /// </summary>
        /// <param name="request">Populated OFX request object</param>
        /// <returns>The returned task includes a populated OFX response object on successfull call</returns>
        public async Task<Protocol.OFX> sendRequestAsync(Protocol.OFX ofxRequest)
        {
            // Create a HttpContent object wrapping the OFX request object
            var request = OFXStreamContent.Create(ofxRequest);

            // Send and await results
            return await sendRequestAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Wrap and send OFX request message sets to the service and return the response data.
        /// 
        /// This is an asycronous call.
        /// </summary>
        /// <param name="messageSets">Array of populated OFX message requests</param>
        /// <returns>The returned task includes a populated OFX response object on successfull call</returns>
        public async Task<Protocol.OFX> sendRequestAsync(AbstractTopLevelMessageSet[] messageSets)
        {
            // Create a HttpContent object wrapping the message sets
            var request = OFXStreamContent.Create(messageSets);

            // Send and await results
            return await sendRequestAsync(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Send a pre-serialized OFX request to the service, retrieve the response and deserialize into an OFX object.
        /// 
        /// This is an asycronous call.
        /// </summary>
        /// <param name="request">Populated OFX request object</param>
        /// <returns>The returned task includes a populated OFX response object on successfull call</returns>
        public async Task<Protocol.OFX> sendRequestAsync(OFXStreamContent request)
        {
            // Create an HTTPClient to send the request
            using (var client = new System.Net.Http.HttpClient())
            {
                // OFX endpoints do not use 100 Continue responses. Disable default .NET expectation of them.
                client.DefaultRequestHeaders.ExpectContinue = false;

                // POST request and await response
                var response = await client.PostAsync(m_serviceURI.ToString(), request).ConfigureAwait(false);

                // Read into stream
                var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                // Deserialize XML stream into object
                return (Protocol.OFX)m_serializer.Deserialize(responseStream);
            }
        }

        /// <summary>
        /// URI of the remote OFX service endpoint.
        /// </summary>
        protected Uri m_serviceURI;

        /// <summary>
        /// XML serializer capable of converting between XML and Object representation
        /// </summary>
        protected static System.Xml.Serialization.XmlSerializer m_serializer = new System.Xml.Serialization.XmlSerializer(typeof(Protocol.OFX));
    }
}
