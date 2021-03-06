﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace RideBuddy.ServiceReference1 {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User_Profile", Namespace="http://schemas.datacontract.org/2004/07/RideBuddyIdentityService")]
    public partial class User_Profile : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string CityField;
        
        private string CountyField;
        
        private string EmailField;
        
        private string FirstnameField;
        
        private int IDField;
        
        private string LastnameField;
        
        private string ProfileImageUrlField;
        
        private string UsernameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string County {
            get {
                return this.CountyField;
            }
            set {
                if ((object.ReferenceEquals(this.CountyField, value) != true)) {
                    this.CountyField = value;
                    this.RaisePropertyChanged("County");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Firstname {
            get {
                return this.FirstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstnameField, value) != true)) {
                    this.FirstnameField = value;
                    this.RaisePropertyChanged("Firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lastname {
            get {
                return this.LastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastnameField, value) != true)) {
                    this.LastnameField = value;
                    this.RaisePropertyChanged("Lastname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProfileImageUrl {
            get {
                return this.ProfileImageUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfileImageUrlField, value) != true)) {
                    this.ProfileImageUrlField = value;
                    this.RaisePropertyChanged("ProfileImageUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IIdentyService")]
    public interface IIdentyService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IIdentyService/GetData", ReplyAction="http://tempuri.org/IIdentyService/GetDataResponse")]
        System.IAsyncResult BeginGetData(System.AsyncCallback callback, object asyncState);
        
        string EndGetData(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IIdentyService/CreateUserProfile", ReplyAction="http://tempuri.org/IIdentyService/CreateUserProfileResponse")]
        System.IAsyncResult BeginCreateUserProfile(string username, string firstname, string lastname, string email, string proilfeImageUrl, string city, string county, System.AsyncCallback callback, object asyncState);
        
        bool EndCreateUserProfile(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IIdentyService/GetUserProfile", ReplyAction="http://tempuri.org/IIdentyService/GetUserProfileResponse")]
        System.IAsyncResult BeginGetUserProfile(string username, System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<RideBuddy.ServiceReference1.User_Profile> EndGetUserProfile(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IIdentyService/CreateUser", ReplyAction="http://tempuri.org/IIdentyService/CreateUserResponse")]
        System.IAsyncResult BeginCreateUser(string username, string authToken, string pushId, string authService, string platform, System.AsyncCallback callback, object asyncState);
        
        bool EndCreateUser(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIdentyServiceChannel : RideBuddy.ServiceReference1.IIdentyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreateUserProfileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public CreateUserProfileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetUserProfileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetUserProfileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<RideBuddy.ServiceReference1.User_Profile> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<RideBuddy.ServiceReference1.User_Profile>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreateUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public CreateUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IdentyServiceClient : System.ServiceModel.ClientBase<RideBuddy.ServiceReference1.IIdentyService>, RideBuddy.ServiceReference1.IIdentyService {
        
        private BeginOperationDelegate onBeginGetDataDelegate;
        
        private EndOperationDelegate onEndGetDataDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataCompletedDelegate;
        
        private BeginOperationDelegate onBeginCreateUserProfileDelegate;
        
        private EndOperationDelegate onEndCreateUserProfileDelegate;
        
        private System.Threading.SendOrPostCallback onCreateUserProfileCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetUserProfileDelegate;
        
        private EndOperationDelegate onEndGetUserProfileDelegate;
        
        private System.Threading.SendOrPostCallback onGetUserProfileCompletedDelegate;
        
        private BeginOperationDelegate onBeginCreateUserDelegate;
        
        private EndOperationDelegate onEndCreateUserDelegate;
        
        private System.Threading.SendOrPostCallback onCreateUserCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public IdentyServiceClient() {
        }
        
        public IdentyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IdentyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IdentyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IdentyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetDataCompletedEventArgs> GetDataCompleted;
        
        public event System.EventHandler<CreateUserProfileCompletedEventArgs> CreateUserProfileCompleted;
        
        public event System.EventHandler<GetUserProfileCompletedEventArgs> GetUserProfileCompleted;
        
        public event System.EventHandler<CreateUserCompletedEventArgs> CreateUserCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult RideBuddy.ServiceReference1.IIdentyService.BeginGetData(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetData(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string RideBuddy.ServiceReference1.IIdentyService.EndGetData(System.IAsyncResult result) {
            return base.Channel.EndGetData(result);
        }
        
        private System.IAsyncResult OnBeginGetData(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((RideBuddy.ServiceReference1.IIdentyService)(this)).BeginGetData(callback, asyncState);
        }
        
        private object[] OnEndGetData(System.IAsyncResult result) {
            string retVal = ((RideBuddy.ServiceReference1.IIdentyService)(this)).EndGetData(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataCompleted(object state) {
            if ((this.GetDataCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataAsync() {
            this.GetDataAsync(null);
        }
        
        public void GetDataAsync(object userState) {
            if ((this.onBeginGetDataDelegate == null)) {
                this.onBeginGetDataDelegate = new BeginOperationDelegate(this.OnBeginGetData);
            }
            if ((this.onEndGetDataDelegate == null)) {
                this.onEndGetDataDelegate = new EndOperationDelegate(this.OnEndGetData);
            }
            if ((this.onGetDataCompletedDelegate == null)) {
                this.onGetDataCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataDelegate, null, this.onEndGetDataDelegate, this.onGetDataCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult RideBuddy.ServiceReference1.IIdentyService.BeginCreateUserProfile(string username, string firstname, string lastname, string email, string proilfeImageUrl, string city, string county, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCreateUserProfile(username, firstname, lastname, email, proilfeImageUrl, city, county, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool RideBuddy.ServiceReference1.IIdentyService.EndCreateUserProfile(System.IAsyncResult result) {
            return base.Channel.EndCreateUserProfile(result);
        }
        
        private System.IAsyncResult OnBeginCreateUserProfile(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string username = ((string)(inValues[0]));
            string firstname = ((string)(inValues[1]));
            string lastname = ((string)(inValues[2]));
            string email = ((string)(inValues[3]));
            string proilfeImageUrl = ((string)(inValues[4]));
            string city = ((string)(inValues[5]));
            string county = ((string)(inValues[6]));
            return ((RideBuddy.ServiceReference1.IIdentyService)(this)).BeginCreateUserProfile(username, firstname, lastname, email, proilfeImageUrl, city, county, callback, asyncState);
        }
        
        private object[] OnEndCreateUserProfile(System.IAsyncResult result) {
            bool retVal = ((RideBuddy.ServiceReference1.IIdentyService)(this)).EndCreateUserProfile(result);
            return new object[] {
                    retVal};
        }
        
        private void OnCreateUserProfileCompleted(object state) {
            if ((this.CreateUserProfileCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CreateUserProfileCompleted(this, new CreateUserProfileCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CreateUserProfileAsync(string username, string firstname, string lastname, string email, string proilfeImageUrl, string city, string county) {
            this.CreateUserProfileAsync(username, firstname, lastname, email, proilfeImageUrl, city, county, null);
        }
        
        public void CreateUserProfileAsync(string username, string firstname, string lastname, string email, string proilfeImageUrl, string city, string county, object userState) {
            if ((this.onBeginCreateUserProfileDelegate == null)) {
                this.onBeginCreateUserProfileDelegate = new BeginOperationDelegate(this.OnBeginCreateUserProfile);
            }
            if ((this.onEndCreateUserProfileDelegate == null)) {
                this.onEndCreateUserProfileDelegate = new EndOperationDelegate(this.OnEndCreateUserProfile);
            }
            if ((this.onCreateUserProfileCompletedDelegate == null)) {
                this.onCreateUserProfileCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCreateUserProfileCompleted);
            }
            base.InvokeAsync(this.onBeginCreateUserProfileDelegate, new object[] {
                        username,
                        firstname,
                        lastname,
                        email,
                        proilfeImageUrl,
                        city,
                        county}, this.onEndCreateUserProfileDelegate, this.onCreateUserProfileCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult RideBuddy.ServiceReference1.IIdentyService.BeginGetUserProfile(string username, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetUserProfile(username, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<RideBuddy.ServiceReference1.User_Profile> RideBuddy.ServiceReference1.IIdentyService.EndGetUserProfile(System.IAsyncResult result) {
            return base.Channel.EndGetUserProfile(result);
        }
        
        private System.IAsyncResult OnBeginGetUserProfile(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string username = ((string)(inValues[0]));
            return ((RideBuddy.ServiceReference1.IIdentyService)(this)).BeginGetUserProfile(username, callback, asyncState);
        }
        
        private object[] OnEndGetUserProfile(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<RideBuddy.ServiceReference1.User_Profile> retVal = ((RideBuddy.ServiceReference1.IIdentyService)(this)).EndGetUserProfile(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetUserProfileCompleted(object state) {
            if ((this.GetUserProfileCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetUserProfileCompleted(this, new GetUserProfileCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetUserProfileAsync(string username) {
            this.GetUserProfileAsync(username, null);
        }
        
        public void GetUserProfileAsync(string username, object userState) {
            if ((this.onBeginGetUserProfileDelegate == null)) {
                this.onBeginGetUserProfileDelegate = new BeginOperationDelegate(this.OnBeginGetUserProfile);
            }
            if ((this.onEndGetUserProfileDelegate == null)) {
                this.onEndGetUserProfileDelegate = new EndOperationDelegate(this.OnEndGetUserProfile);
            }
            if ((this.onGetUserProfileCompletedDelegate == null)) {
                this.onGetUserProfileCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetUserProfileCompleted);
            }
            base.InvokeAsync(this.onBeginGetUserProfileDelegate, new object[] {
                        username}, this.onEndGetUserProfileDelegate, this.onGetUserProfileCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult RideBuddy.ServiceReference1.IIdentyService.BeginCreateUser(string username, string authToken, string pushId, string authService, string platform, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCreateUser(username, authToken, pushId, authService, platform, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool RideBuddy.ServiceReference1.IIdentyService.EndCreateUser(System.IAsyncResult result) {
            return base.Channel.EndCreateUser(result);
        }
        
        private System.IAsyncResult OnBeginCreateUser(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string username = ((string)(inValues[0]));
            string authToken = ((string)(inValues[1]));
            string pushId = ((string)(inValues[2]));
            string authService = ((string)(inValues[3]));
            string platform = ((string)(inValues[4]));
            return ((RideBuddy.ServiceReference1.IIdentyService)(this)).BeginCreateUser(username, authToken, pushId, authService, platform, callback, asyncState);
        }
        
        private object[] OnEndCreateUser(System.IAsyncResult result) {
            bool retVal = ((RideBuddy.ServiceReference1.IIdentyService)(this)).EndCreateUser(result);
            return new object[] {
                    retVal};
        }
        
        private void OnCreateUserCompleted(object state) {
            if ((this.CreateUserCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CreateUserCompleted(this, new CreateUserCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CreateUserAsync(string username, string authToken, string pushId, string authService, string platform) {
            this.CreateUserAsync(username, authToken, pushId, authService, platform, null);
        }
        
        public void CreateUserAsync(string username, string authToken, string pushId, string authService, string platform, object userState) {
            if ((this.onBeginCreateUserDelegate == null)) {
                this.onBeginCreateUserDelegate = new BeginOperationDelegate(this.OnBeginCreateUser);
            }
            if ((this.onEndCreateUserDelegate == null)) {
                this.onEndCreateUserDelegate = new EndOperationDelegate(this.OnEndCreateUser);
            }
            if ((this.onCreateUserCompletedDelegate == null)) {
                this.onCreateUserCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCreateUserCompleted);
            }
            base.InvokeAsync(this.onBeginCreateUserDelegate, new object[] {
                        username,
                        authToken,
                        pushId,
                        authService,
                        platform}, this.onEndCreateUserDelegate, this.onCreateUserCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override RideBuddy.ServiceReference1.IIdentyService CreateChannel() {
            return new IdentyServiceClientChannel(this);
        }
        
        private class IdentyServiceClientChannel : ChannelBase<RideBuddy.ServiceReference1.IIdentyService>, RideBuddy.ServiceReference1.IIdentyService {
            
            public IdentyServiceClientChannel(System.ServiceModel.ClientBase<RideBuddy.ServiceReference1.IIdentyService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetData(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetData", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetData(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetData", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginCreateUserProfile(string username, string firstname, string lastname, string email, string proilfeImageUrl, string city, string county, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[7];
                _args[0] = username;
                _args[1] = firstname;
                _args[2] = lastname;
                _args[3] = email;
                _args[4] = proilfeImageUrl;
                _args[5] = city;
                _args[6] = county;
                System.IAsyncResult _result = base.BeginInvoke("CreateUserProfile", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndCreateUserProfile(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("CreateUserProfile", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetUserProfile(string username, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = username;
                System.IAsyncResult _result = base.BeginInvoke("GetUserProfile", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<RideBuddy.ServiceReference1.User_Profile> EndGetUserProfile(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<RideBuddy.ServiceReference1.User_Profile> _result = ((System.Collections.ObjectModel.ObservableCollection<RideBuddy.ServiceReference1.User_Profile>)(base.EndInvoke("GetUserProfile", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginCreateUser(string username, string authToken, string pushId, string authService, string platform, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[5];
                _args[0] = username;
                _args[1] = authToken;
                _args[2] = pushId;
                _args[3] = authService;
                _args[4] = platform;
                System.IAsyncResult _result = base.BeginInvoke("CreateUser", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndCreateUser(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("CreateUser", _args, result)));
                return _result;
            }
        }
    }
}
