using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideBuddy.Classes
{
    public class AppSettings : INotifyPropertyChanged
    {
        #region private properties
        private IsolatedStorageSettings settings;

        private const string loggedInSettingsKey = "LoggedIn";
        private const bool logedInDefaultValue = false;

        private const string locationConsentSettingsKey = "LocationConsent";
        private const bool locationConsentDefaultValue = false;

        private const string accountDetailsSettingsKey = "AccountDetails";
        private const string accountDetailsDefaultValue = null;

        private const string userProfileSettingsKey = "UserProfile";
        private const string userProfileDefaultValue = null;
        #endregion

        #region public properties 
        public bool LoggedIn
        {
            get
            {
                return GetValueOrDefault<bool>(loggedInSettingsKey, logedInDefaultValue);
            }
            set
            {
                if (AddorUpdateValue(loggedInSettingsKey, value))
                {
                    Save();
                }
                OnPropertyChanged("LoggedIn");
            }
        }

        public bool LocationConsent
        {
            get
            {
                return GetValueOrDefault<bool>(locationConsentSettingsKey, locationConsentDefaultValue);
            }
            set
            {
                if (AddorUpdateValue(locationConsentSettingsKey, value))
                {
                    Save();
                }
                OnPropertyChanged("LocationConsent");
            }
        }

        public string AccountDetails
        {
            get
            {
                return GetValueOrDefault<string>(accountDetailsSettingsKey, accountDetailsDefaultValue);
            }
            set
            {
                if (AddorUpdateValue(accountDetailsSettingsKey, value))
                {
                    Save();
                }
                OnPropertyChanged("ProfileImage");
            }
        }

        public string UserProfile
        {
            get
            {
                return GetValueOrDefault<string>(userProfileSettingsKey, userProfileDefaultValue);
            }
            set
            {
                if (AddorUpdateValue(userProfileSettingsKey, value))
                {
                    Save();
                }
                OnPropertyChanged("UserProfile");
            }
        }
        #endregion

        #region constructor
        public AppSettings()
        {
            settings = IsolatedStorageSettings.ApplicationSettings;
        }
        #endregion

        #region private methods
        private bool AddorUpdateValue(string key, object value)
        {
            bool valueChanged = false;
            if (settings.Contains(key))
            {
                if (settings[key] != value)
                {
                    settings[key] = value;
                    valueChanged = true;
                }
            }
            else
            {
                settings.Add(key, value);
                valueChanged = true;
            }
            return valueChanged;
        }

        private T GetValueOrDefault<T>(string key, T defaultValue)
        {
            T value;

            if (settings.Contains(key))
            {
                value = (T)settings[key];
            }
            else
            {
                value = defaultValue;
            }
            return value;
        }
        #endregion

        #region public methods 
        public void Save()
        {
            settings.Save();
        }
        #endregion

        #region Inotify methods 
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion
    }
}
