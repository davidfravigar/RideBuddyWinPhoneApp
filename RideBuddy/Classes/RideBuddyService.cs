using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RideBuddy.ViewModels;
using RideBuddy.ServiceReference1;
using Newtonsoft.Json;

namespace RideBuddy.Classes
{
    public class RideBuddyService
    {
        
        #region private properties
        private AccountDetails account;
        private UserProfileModel userProfile;
        #endregion

        #region constructor
        public RideBuddyService()
        {
            account = new AccountDetails();
        }
        #endregion

        #region public methods
        public void CreateUser(string city, string county)
        {
            account = JsonConvert.DeserializeObject<AccountDetails>(App.Setting.AccountDetails);
            string[] name = spiltName(account.name);
            string ProlieImageUrl = formatProfileImageUrl(account.FbIdentity);

            IdentyServiceClient svc = new IdentyServiceClient();
            svc.CreateUserCompleted += svc_CreateUserCompleted;
            svc.CreateUserProfileCompleted += svc_CreateUserProfileCompleted;
            svc.CreateUserAsync(account.Username, account.AuthToken, "no service registered", account.AuthService, account.Platform);
            svc.CreateUserProfileAsync(account.Username, name[0], name[1], account.Email, account.FbIdentity, city, county);
            //now we need to save all this into a json string and then add to iso 

            userProfile = new UserProfileModel();
            userProfile.Username = account.Username;
            userProfile.Firstname = name[0];
            userProfile.Lastname = name[1];
            userProfile.Email = account.Email;
            userProfile.ProfileImageUrl = ProlieImageUrl;
            userProfile.City = city;
            userProfile.County = county;

            App.Setting.UserProfile = JsonConvert.SerializeObject(userProfile);
        }

        void svc_CreateUserProfileCompleted(object sender, CreateUserProfileCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                //why is it in 2 tables i can hear you ask.... I kind of thought that if this app was a proper app
                //the developers would want to know he information in account details for analytics ect, or I would 
                //so I added the table 
                App.Error.showMessage(App.Error.UserAccountCreated);
                App.Setting.LoggedIn = true;
            }
            else
            {
                App.Error.showMessage(App.Error.UserAccountNotCreated);
            }
        }

        void svc_CreateUserCompleted(object sender, CreateUserCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //show an error
                //for debugging as we dont want the user to se this 
                App.Error.showMessage(App.Error.UserAccountNotCreated);
                Console.WriteLine(e.Error);
            }
            else
            {
                Console.WriteLine(e.Result);
            }
        }
        #endregion

        #region private methods
        #endregion

        #region public methods
        //Keeping it DRY or "im sick of writing this"
        public string formatProfileImageUrl(string id)
        {
            return String.Format("http://graph.facebook.com/{0}/picture?type=large", id);
        }

        //spilt the details returned from fb
        public string[] spiltName(string name)
        {
            return name.Split(' ');
        }
        #endregion

    }
}
