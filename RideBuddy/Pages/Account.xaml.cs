using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using RideBuddy.Views;
using RideBuddy.Classes;

namespace RideBuddy.Pages
{
    public partial class Account : PhoneApplicationPage
    {
        #region private properties
        private bool isEditing = false;
        #endregion

        #region public properties 
        #endregion

        #region constructor
        public Account()
        {
            InitializeComponent();
        }
        #endregion

        #region navigated methods 
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Loaded += Account_Loaded;
            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
        }

        void Account_Loaded(object sender, RoutedEventArgs e)
        {
            getCorrectView();
        }
        #endregion

        #region private methods
        private void getCorrectView()
        {
            if (!App.Setting.LoggedIn)
            {
                UserControl control = new Views.AccountLoggedOut();
                accountViewGrid.Children.Add(control);
            }
            else if(App.Setting.LoggedIn)
            {
                UserControl control = new Views.AccountLoggedIn();
                accountViewGrid.Children.Add(control);
            }
            else if (isEditing)
            {
                UserControl control = new Views.AccountEdit();
                accountViewGrid.Children.Add(control);
            }
            else
            { 
                //do something her for errors
            }
            
        }
        #endregion

        #region public methods 
        #endregion

        #region click and tap events 
        private async void UserAccountView_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (App.Setting.LoggedIn)
            {
                return;
            }
            else
            {
                SystemTray.ProgressIndicator = new ProgressIndicator();
                SystemTray.ProgressIndicator.IsIndeterminate = true;
                SystemTray.ProgressIndicator.IsVisible = true;
                SystemTray.ProgressIndicator.Text = "Setting up your account";
                //go ahead and authenticate 
                Authentication authenticate = new Authentication();
                await authenticate.authenticate();
                //justToMakeSureMessageBox();
                NavigationService.Navigate(new Uri("/Pages/EditAccount.xaml", UriKind.Relative));

                SystemTray.ProgressIndicator.IsIndeterminate = false;
                SystemTray.ProgressIndicator.IsVisible = false;
            }
        }
        #endregion

        #region Messagebox functions 
        #endregion

        #region

        #endregion
    }
}