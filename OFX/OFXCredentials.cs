using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFX
{
    /// <summary>
    /// Container class for authentication credentials provided to OFX.
    /// Supports only UserId and Password currently
    /// </summary>
    public class OFXCredentials
    {
        public OFXCredentials(string userId, string password)
        {
            UserId = userId;
            Password = password;
        }

        /// <summary>
        /// 'userid' field passed in OFX credentials
        /// </summary>
        public string UserId { get; }

        /// <summary>
        /// 'passsword' field passed in OFX credentials
        /// </summary>
        public string Password { get; }
    }
}
