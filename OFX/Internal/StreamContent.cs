
using System.Xml.Serialization;
using OFX.Protocol;

namespace OFX.Internal
{

    /// <summary>
    /// Derived HttpContent type for OFX requests 
    /// OFX Requests use the Content-Type of "application/x-ofx". 
    /// </summary>
    public class StreamContent : System.Net.Http.StreamContent
    {
        public StreamContent(System.IO.Stream sourceStream) : base(sourceStream)
        {
            this.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-ofx");
        }

        /// <summary>
        /// Construct an StreamContent from a provided populated OFX object
        /// </summary>
        /// <param name="ofxObject">A populated OFX message with request or response data</param>
        /// <returns>Created StreamContent ready to send with HttpClient.Post</returns>
        public static StreamContent Create(Protocol.OFX ofxObject)
        {
            // Serialized data will be written to a MemoryStream
            var memoryStream = new System.IO.MemoryStream();

            // XMLWriter will be used to encode the data using UTF8Encoding without a Byte Order Marker (BOM)
            var xmlWriter = new System.Xml.XmlTextWriter(memoryStream, new System.Text.UTF8Encoding(false));

            // Write xml processing instruction
            xmlWriter.WriteStartDocument();
            // Our OFX protocol uses a version 2.0.0 header with 2.1.1 protocol body
            xmlWriter.WriteProcessingInstruction("OFX", "OFXHEADER=\"200\" VERSION=\"211\" SECURITY=\"NONE\" OLDFILEUID=\"NONE\" NEWFILEUID=\"NONE\"");

            // Don't include namespaces in the root element
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            // Generate XML to the stream
            m_serializer.Serialize(xmlWriter, ofxObject, ns);

            // Flush writer to stream
            xmlWriter.Flush();

            // Position the stream back to the start for reading
            memoryStream.Position = 0;

            // Wrap in our HttpContent-derived class to provide headers and other HTTP encoding information
            return new StreamContent(memoryStream);
        }

        /// <summary>
        /// Construct an StreamContent from a provided array of AbstractTopLevelMessageSet.
        /// Since all OFX messages are an OFX wrapper around an 1 or more AbstractTopLevelMessageSet entities, this 
        ///   convenience function saves the caller having to construct a wrapper OFX object on each call.
        /// 
        /// Note that the AbstractTopLevelMessageSet order must obey the rules for the OFX protocol. See OFX specification v2.1.1 for details.
        /// </summary>
        /// <param name="messageSets">1 or more populated AbstractTopLevelMessageSet objects representing OFX requests or responses.</param>
        /// <returns>Created StreamContent ready to send with HttpClient.Post</returns>
        public static StreamContent Create(AbstractTopLevelMessageSet[] messageSets)
        {
            // Wrap message sets in OFX object
            Protocol.OFX ofx = new Protocol.OFX();
            ofx.Items = messageSets;

            // Call through to OFX class-based factory method
            return Create(ofx);
        }

        /// <summary>
        /// XML serializer capable of converting between XML and Object representation
        /// </summary>
        protected static System.Xml.Serialization.XmlSerializer m_serializer = new System.Xml.Serialization.XmlSerializer(typeof(Protocol.OFX));
    }
}
