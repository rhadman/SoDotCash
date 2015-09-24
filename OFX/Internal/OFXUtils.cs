using System;

namespace OFX.Internal
{
    /// <summary>
    /// Wrapper class for OFX utility functions
    /// </summary>
    public class OFXUtils
    {
        /// <summary>
        /// Helper method to convert from a system Date/Time with Offset from GMT into a format that OFX understands
        /// </summary>
        /// <param name="date">The date/time to convert</param>
        /// <returns>Properly formatted OFX date/time string with offset from GMT</returns>
        public static string DateToOFX(DateTimeOffset date)
        {
            return date.ToString("yyyyMMddHHmmss.000[z:\\G\\M\\T]");
        }

        /// <summary>
        /// Helper method to convert from OFX Date/Time string format to system DateTimeOffset
        /// </summary>
        /// <param name="ofxDate">Date to convert</param>
        /// <returns>Converted date</returns>
        public static DateTimeOffset DateFromOFX(string ofxDate)
        {
            // Split at colon to strip the end
            char[] delimiters = { '[', ':' };
            string[] ofxDatePieces = ofxDate.Split(delimiters);
            DateTime dateTime;
            try
            {
                dateTime = DateTime.ParseExact(ofxDatePieces[0], "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (System.FormatException)
            {
                dateTime = DateTime.ParseExact(ofxDatePieces[0], "yyyyMMddHHmmss.000", System.Globalization.CultureInfo.InvariantCulture);
            }
            if (ofxDatePieces.Length < 2)
                return new DateTimeOffset(dateTime);

            // TZ Offset included
            TimeSpan tzOffset = new TimeSpan(Int32.Parse(ofxDatePieces[1]), 0, 0);
            return new DateTimeOffset(dateTime, tzOffset);
        }

        /// <summary>
        /// Convert a decimal number (such as 10.55) string to an integer without the decimal point (1055)
        /// </summary>
        /// <param name="ofxValue">Decimal number in string format</param>
        public static int DecimalStringToFixedInt(string ofxValue)
        {
            // Remove decimal points and convert to a number
            var value = Int32.Parse(ofxValue.Replace(".", ""));

            // If there was no decimal point, this is a dollar value: multiply by 100
            if (!ofxValue.Contains("."))
                value *= 100;
            return value;
        }
    }
}
