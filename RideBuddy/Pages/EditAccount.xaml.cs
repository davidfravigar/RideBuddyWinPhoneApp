using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Newtonsoft.Json;
using RideBuddy.Classes;
using System.Windows.Media.Imaging;
using RideBuddy.ServiceReference1;
using System.Windows.Media;
using RideBuddy.ViewModels;

namespace RideBuddy.Pages
{
    public partial class EditAccount : PhoneApplicationPage
    {
        #region private properties
        private AccountDetails account;
        private RideBuddyService ridebuddyService;
        #endregion

        #region public properties
        #endregion

        #region constructor
        public EditAccount()
        {
            InitializeComponent();
        }
        #endregion

        #region navigated methods 
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Loaded += EditAccount_Loaded;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
        }

        void EditAccount_Loaded(object sender, RoutedEventArgs e)
        {
            LoadUserDetailsFromStroage();
        }
        #endregion

        #region private methods
        private void LoadUserDetailsFromStroage()
        {
            account = JsonConvert.DeserializeObject<AccountDetails>(App.Setting.AccountDetails);
            //change this keep it dry
            string imageUrl = String.Format("http://graph.facebook.com/{0}/picture?type=large", account.FbIdentity);
            profileImage.Source = new BitmapImage(new Uri(imageUrl));
            NameTxt.Text = account.name;
            emailTxt.Text = account.Email;

        }

        
        #endregion

        private void saveProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            ridebuddyService = new RideBuddyService();
            SystemTray.ProgressIndicator = new ProgressIndicator();
            SystemTray.ProgressIndicator.IsIndeterminate = true;
            SystemTray.ProgressIndicator.IsVisible = true;
            SystemTray.ProgressIndicator.Text = "Saving your account details!";

            if (checkCityTextBox() && checkCountyTextBox())
            {
                if (!App.Setting.LoggedIn)
                {
                    //new user 
                    ridebuddyService.CreateUser(cityTxtBox.Text, countyTextBox.Text);
                }
                else
                { 
                    //existing user
                }
            }

            SystemTray.ProgressIndicator.IsIndeterminate = false;
            SystemTray.ProgressIndicator.IsVisible = false;
        }

        void svc_CreateUserProfileCompleted(object sender, CreateUserProfileCompletedEventArgs e)
        {

        }

        void svc_CreateUserCompleted(object sender, CreateUserCompletedEventArgs e)
        {
            
        }

        #region public methods 
        #endregion

        #region click and tap events
        #endregion

        #region messagebox methods 
        #endregion

        #region error checking
        private bool checkCityTextBox()
        {
            if (string.IsNullOrEmpty(cityTxtBox.Text))
            {
                cityText.Text = "*Required, Please enter your hometown";
                cityText.Foreground = new SolidColorBrush(Colors.Red);
                cityTxtBox.BorderBrush = new SolidColorBrush(Colors.Red);

                return false;
            }
            else
            {
                return true;
            }

        }

        private bool checkCountyTextBox()
        {
            if (string.IsNullOrEmpty(countyTextBox.Text))
            {
                countyTxt.Text = "*Required, Please enter your county";
                countyTxt.Foreground = new SolidColorBrush(Colors.Red);
                countyTextBox.BorderBrush = new SolidColorBrush(Colors.Red);

                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}