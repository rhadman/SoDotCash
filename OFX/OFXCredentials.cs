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
        public string UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }

        /// <summary>
        /// 'passsword' field passed in OFX credentials
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }


        /// <summary>
        /// 'userid' field passed in OFX credentials
        /// </summary>
        private string userId;

        /// <summary>
        /// 'passsword' field passed in OFX credentials
        /// </summary>
        private string password;

    }
}
