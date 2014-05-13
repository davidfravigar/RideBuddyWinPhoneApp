using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideBuddy.ViewModels
{
    public class UserProfileModel
    {
        public string Username {get; set;}
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string ProfileImageUrl { get; set; }
        public string City { get; set; }
        public string County { get; set; }
    }
}
