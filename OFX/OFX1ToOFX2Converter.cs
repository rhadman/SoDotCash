﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OFX
{
    public class OFX1ToOFX2Converter
    {
        public OFX1ToOFX2Converter(Stream ofx1Stream)
        {
            ofx1Reader = new StreamReader(ofx1Stream);
        }

        public Stream convert()
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
                    if (line.Length == 0)
                        headersDone = true;
                    continue;
                }

                // Echo file lines
                int endTagIndex = line.IndexOf(">");

                // If there is no content after the start tag, echo the start tag out
                if (endTagIndex == (line.Length - 1))
                {
                    outWriter.WriteLine(line);
                    continue;
                }

                // Grab start tag
                string startTag = line.Substring(1, endTagIndex-1);

                // Write line followed by closing tag
                outWriter.Write(line);
                outWriter.WriteLine("</" + startTag + ">");
            }

            // Flush writer
            outWriter.Flush();

            // Reset stream to start
            outStream.Position = 0;
            return outStream;
        }


        private readonly StreamReader ofx1Reader;
    }
}
