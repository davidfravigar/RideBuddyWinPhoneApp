using Microsoft.Phone.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideBuddy.Classes
{
    public class PhoneState
    {
        /// <summary>
        /// Again this classes exists because i wanted a quick way to check the phones state 
        /// </summary>
        #region private properties
        private bool networkStatus = DeviceNetworkInformation.IsNetworkAvailable;
        private bool cellularStatus = DeviceNetworkInformation.IsCellularDataEnabled;
        private bool roamingStatus = DeviceNetworkInformation.IsCellularDataRoamingEnabled;
        private bool wifiStatus = DeviceNetworkInformation.IsWiFiEnabled;
        #endregion

        #region public properties
        public bool IsNetworkAvailble()
        {
            return networkStatus;
        }

        public bool IsCellulatEnabled()
        {
            return cellularStatus;
        }

        public bool IsRoamingenabled()
        {
            return roamingStatus;
        }

        private bool IsWifiEnabled()
        {
            return wifiStatus;
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
