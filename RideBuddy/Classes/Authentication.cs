using Facebook.Client;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Facebook;

namespace RideBuddy.Classes
{
    public class Authentication
    {
        /// <summary>
        /// This class is used for authentication and the various methods that go with it
        /// facebook mainly
        /// </summary>
        #region private properties
        private MobileServiceUser user;
        private FacebookSession fbSession;
        #endregion

        #region public properties
        #endregion

        #region constructor
        #endregion

        #region private methods
        //this value will be used as identity if its unique, if not roll the Guid
        public string removeProvider(string username)
        { 
            string[] user = username.Split(':');
            return user[1];
        }
        #endregion

        #region public methods
        public async System.Threading.Tasks.Task authenticate()
        {
            while (user == null)
            {
                try
                {
                    //prompt user to login
                    user = await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.Facebook);

                    //get some details from facebook so we can use them in ride buddy
                    fbSession = await App.FacebookSessionClient.LoginAsync("publish_stream,friends_about_me");
                    var fbclient = new FacebookClient(fbSession.AccessToken);
                    dynamic fbUser = await fbclient.GetTaskAsync("me");

                    //set up to store in iso as json string 
                    AccountDetails accountDetails = new AccountDetails();
                    accountDetails.Username = removeProvider(user.UserId);
                    accountDetails.AuthToken = user.MobileServiceAuthenticationToken;
                    accountDetails.FbAuthToken = fbSession.AccessToken;
                    accountDetails.FbIdentity = fbSession.FacebookId;
                    accountDetails.name = fbUser.name;
                    //this might work!
                    accountDetails.Email = fbUser.email;
                    accountDetails.Platform = "Windows Phone";
                    accountDetails.AuthService = "Facebook";

                    //save details to settings 
                    App.Setting.AccountDetails = JsonConvert.SerializeObject(accountDetails);

                    //save fb details to app
                    App.FacebookId = fbSession.FacebookId;
                    App.FaceBookAccessToken = fbSession.AccessToken;

                    //phew a lot of work!

                }
                catch (InvalidOperationException)
                {
                    App.Error.showMessage(App.Error.FaceBookError);
                }
                catch (Exception)
                {
                    App.Error.showMessage(App.Error.LoginError);
                }
            }
            


        }
        #endregion

        #region Inotify methods
        #endregion
    }
}
