using System.IO;
using System.Xml.Serialization;

namespace OFX
{
    public class OFX1ToOFX2Converter
    {
        public OFX1ToOFX2Converter(Stream ofx1Stream)
        {
            ofx1Reader = new StreamReader(ofx1Stream);
        }


        /// <summary>
        /// Convert input OFX1 data into OFX2 data
        /// </summary>
        /// <returns>Stream of OFX2 formatted data ready to be read</returns>
        public Stream Convert()
        {
            var outStream = new MemoryStream();
            var outWriter = new StreamWriter(outStream, new System.Text.UTF8Encoding(false));
            
            // Write headers
            outWriter.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            outWriter.WriteLine("<?OFX OFXHEADER=\"200\" VERSION=\"211\" SECURITY=\"NONE\" OLDFILEUID=\"NONE\" NEWFILEUID=\"NONE\"?>");

            // Read input file
            bool headersDone = false;
            string line;
            while ((line = ofx1Reader.ReadLine()) != null)
            {
                // Look for end of headers
                if (!headersDone)
                {
                    if (line.StartsWith("<"))
                        headersDone = true;
                    else continue;
                }

                // Process tags in line
                while (line.Length > 0)
                {
                    // Find first end tag
                    int endTagIndex = line.IndexOf(">");

                    // See if this line has multiple values
                    int nextLineIndex = line.IndexOf("<", endTagIndex);

                    
                    string workingLine = line;
                    if (nextLineIndex > -1)
                    {
                        workingLine = line.Substring(0, nextLineIndex);
                        line = line.Substring(nextLineIndex);
                    }
                    else
                    {
                        // Done
                        line = "";
                    }


                    // If there is no content after the start tag, echo the start tag out
                    if (endTagIndex == (workingLine.Length - 1))
                    {
                        outWriter.WriteLine(workingLine);
                        continue;
                    }

                    // Grab start tag
                    string startTag = workingLine.Substring(1, endTagIndex - 1);

                    // Skip intuit-specific tags
                    if (startTag.StartsWith("INTU."))
                        continue;

                    // Sometimes language comes through in lower case - correct
                    if (startTag == "LANGUAGE")
                        workingLine = workingLine.ToUpper();

                    // Single value - write line followed by closing tag
                    outWriter.Write(workingLine);
                    outWriter.WriteLine("</" + startTag + ">");
                }
            }

            // Flush writer
            outWriter.Flush();

            // Reset stream to start
            outStream.Position = 0;
            return outStream;
        }

        /// <summary>
        /// Convert wrapped OFX1 data into an OFX object
        /// </summary>
        /// <returns>OFX object populated with data from the converted input</returns>
        public Protocol.OFX ConvertToOFX()
        {
            // Instantiate an XML serializer which will be used to deserialize the XML data into the Object model
            XmlSerializer serializer = new XmlSerializer(typeof (Protocol.OFX));

            // Deserialize the converted XML data and return
            return (Protocol.OFX) serializer.Deserialize(Convert());
        }

        private readonly StreamReader ofx1Reader;
    }
}
