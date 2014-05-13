using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace RideBuddy
{
    public partial class LandingPage : PhoneApplicationPage
    {
        #region private properties
        #endregion

        #region public properties 
        #endregion

        #region constructor
        #endregion

        #region navigated methods 
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Loaded += LandingPage_Loaded;
            base.OnNavigatedTo(e);
        }

        void LandingPage_Loaded(object sender, RoutedEventArgs e)
        {
            checkApplicationState();
        }
        #endregion

        #region private methods 
        private void checkApplicationState()
        {
            if (!App.Setting.LocationConsent)
            { 
                //show message box
                AskForLocationMessageBox();
            }
            else if (!App.Setting.LoggedIn)
            {
                //show messagebox
                LoginToAccountMessageBox();
            }
            else
            {
                //its all good 
                return;
            }
        }
        #endregion

        #region public methods 
        #endregion

        #region click and tap events 
        #endregion

        #region messagebox methods 
        private void AskForLocationMessageBox()
        {
            HyperlinkButton hyperlinkButton = new HyperlinkButton()
            {
                Content = "Privacy Statement",
                Margin = new Thickness(0, 28, 0, 8),
                HorizontalAlignment = HorizontalAlignment.Left,
                NavigateUri = new Uri("http://silverlight.codeplex.com/", UriKind.Absolute)
            };

            TiltEffect.SetIsTiltEnabled(hyperlinkButton, true);

            CustomMessageBox messageBox = new CustomMessageBox()
            {
                Caption = "Allow Ride Buddy to access and use your location?",
                Message = "Sharing this information helps Ride Buddy to use the location-based services offered for this phone. We won't use the information to identify or contact you.",
                Content = hyperlinkButton,
                LeftButtonContent = "allow",
                RightButtonContent = "cancel",
                IsFullScreen = true
            };

            messageBox.Dismissed += (s1, e1) =>
            {
                switch (e1.Result)
                {
                    case CustomMessageBoxResult.LeftButton:
                        // prompt the user they need to allow location
                        App.Setting.LocationConsent = true;
                        checkApplicationState();
                        break;
                    case CustomMessageBoxResult.RightButton:
                        // show another textbox that the app wont work
                        justToMakeSureMessageBox();
                        break;
                    case CustomMessageBoxResult.None:
                        break;
                    default:
                        break;
                }
            };

            messageBox.Show();
        }

        private void justToMakeSureMessageBox()
        {
            CustomMessageBox messageBox = new CustomMessageBox()
            {
                Caption = "Well what can we say!",
                Message = "For Ride Buddy to function correctly we need you to agree to location consent and set up an account! If you feel this is too much information we are sorry but you wont be able to use Ride Buddy correctly",
                LeftButtonContent = "Ok",
                RightButtonContent = "Exit",
                IsFullScreen = true
            };

            messageBox.Dismissed += (s1, e1) =>
            {
                switch (e1.Result)
                {
                    case CustomMessageBoxResult.LeftButton:
                        // location
                        checkApplicationState();
                        break;
                    case CustomMessageBoxResult.RightButton:
                        //Exit the app.
                        Application.Current.Terminate();
                        break;
                    case CustomMessageBoxResult.None:
                        // Do something.
                        break;
                    default:
                        break;
                }
            };

            messageBox.Show();
        }

        private void LoginToAccountMessageBox()
        {
            CustomMessageBox messageBox = new CustomMessageBox()
            {
                Caption = "Login to your account",
                Message = "We need you to log in to your Facebook account, this is so we can verify who you are and find other users that you may know. Don't worry we wont use any of your personal details from facebook and we wont keep them.",
                LeftButtonContent = "Login",
                RightButtonContent = "Cancel",
                IsFullScreen = true
            };

            messageBox.Dismissed += (s1, e1) =>
            {
                switch (e1.Result)
                {
                    case CustomMessageBoxResult.LeftButton:
                        // Navigate to account page
                        NavigationService.Navigate(new Uri("/Pages/Account.xaml", UriKind.Relative));
                        break;
                    case CustomMessageBoxResult.RightButton:
                        // Do something.
                        justToMakeSureMessageBox();
                        break;
                    case CustomMessageBoxResult.None:
                        // Do something.
                        break;
                    default:
                        break;
                }
            };

            messageBox.Show();
        }
        #endregion
   
    }
}