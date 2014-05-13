using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RideBuddy.Classes
{
    public class Errors
    {
        /// <summary>
        /// this class exists because i was typing error messages far too much 
        /// and with this class it was easy to just add a new error message and forget 
        /// </summary>
        

        #region private properties
        private string notFound = "User not found, please check your details!";
        private string noSignal = "Opps we can't get that information for you";
        private string facebookError = "We couldnt connect to your Facebook, please give it another go!";
        private string loginError = "Well what can we say... Something went wrong, please try logging in again";
        private string userAccountCreated = "Your Account is all set up, now you just need a buddy!";
        private string userAccountNotCreated = "Opps! we can't create your profile at the minute, please try again";
        #endregion

        #region public properties
        public string Notfound
        {
            get { return notFound; }
        }

        public string NoSignal
        {
            get
            {
                return noSignal;
            }
        }

        public string FaceBookError
        {
            get { return facebookError; }
        }

        public string LoginError
        {
            get { return loginError; }
        }

        public string UserAccountCreated
        {
            get { return userAccountCreated; }
        }

        public string UserAccountNotCreated
        {
            get { return userAccountNotCreated; }
        }

        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        #endregion

        #region constructor
        #endregion

        #region private methods
        #endregion

        #region public methods
        #endregion

        #region Inotify methods
        #endregion
    }
}
