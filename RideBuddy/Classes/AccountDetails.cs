using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideBuddy.Classes
{
    public class AccountDetails
    {
        /// <summary>
        /// This class is for serialization of details 
        /// that serialization is saved to app settings 
        /// </summary>
        public string Username { get; set; }
        public string AuthToken { get; set; }
        public string PushId { get; set; }
        public string AuthService { get; set; }
        public string Platform { get; set; }
        public string name { get; set; }
        public string FbAuthToken { get; set; }
        public string FbIdentity { get; set; }
        public string Email { get; set; }
    }
}
