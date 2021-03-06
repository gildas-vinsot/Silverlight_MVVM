﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SampleModel", Namespace="http://schemas.datacontract.org/2004/07/TeamCoV5.Sample.MVVM.Models")]
    public partial class SampleModel : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SampleService.ISampleService")]
    public interface ISampleService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ISampleService/GetSampleObjet", ReplyAction="http://tempuri.org/ISampleService/GetSampleObjetResponse")]
        System.IAsyncResult BeginGetSampleObjet(System.AsyncCallback callback, object asyncState);
        
        TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.SampleModel EndGetSampleObjet(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISampleServiceChannel : TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.ISampleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetSampleObjetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetSampleObjetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.SampleModel Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.SampleModel)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleServiceClient : System.ServiceModel.ClientBase<TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.ISampleService>, TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.ISampleService {
        
        private BeginOperationDelegate onBeginGetSampleObjetDelegate;
        
        private EndOperationDelegate onEndGetSampleObjetDelegate;
        
        private System.Threading.SendOrPostCallback onGetSampleObjetCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public SampleServiceClient() {
        }
        
        public SampleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SampleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SampleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<GetSampleObjetCompletedEventArgs> GetSampleObjetCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.ISampleService.BeginGetSampleObjet(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetSampleObjet(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.SampleModel TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.ISampleService.EndGetSampleObjet(System.IAsyncResult result) {
            return base.Channel.EndGetSampleObjet(result);
        }
        
        private System.IAsyncResult OnBeginGetSampleObjet(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.ISampleService)(this)).BeginGetSampleObjet(callback, asyncState);
        }
        
        private object[] OnEndGetSampleObjet(System.IAsyncResult result) {
            TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.SampleModel retVal = ((TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.ISampleService)(this)).EndGetSampleObjet(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetSampleObjetCompleted(object state) {
            if ((this.GetSampleObjetCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetSampleObjetCompleted(this, new GetSampleObjetCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetSampleObjetAsync() {
            this.GetSampleObjetAsync(null);
        }
        
        public void GetSampleObjetAsync(object userState) {
            if ((this.onBeginGetSampleObjetDelegate == null)) {
                this.onBeginGetSampleObjetDelegate = new BeginOperationDelegate(this.OnBeginGetSampleObjet);
            }
            if ((this.onEndGetSampleObjetDelegate == null)) {
                this.onEndGetSampleObjetDelegate = new EndOperationDelegate(this.OnEndGetSampleObjet);
            }
            if ((this.onGetSampleObjetCompletedDelegate == null)) {
                this.onGetSampleObjetCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetSampleObjetCompleted);
            }
            base.InvokeAsync(this.onBeginGetSampleObjetDelegate, null, this.onEndGetSampleObjetDelegate, this.onGetSampleObjetCompletedDelegate, userState);
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
        
        protected override TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.ISampleService CreateChannel() {
            return new SampleServiceClientChannel(this);
        }
        
        private class SampleServiceClientChannel : ChannelBase<TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.ISampleService>, TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.ISampleService {
            
            public SampleServiceClientChannel(System.ServiceModel.ClientBase<TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.ISampleService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetSampleObjet(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetSampleObjet", _args, callback, asyncState);
                return _result;
            }
            
            public TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.SampleModel EndGetSampleObjet(System.IAsyncResult result) {
                object[] _args = new object[0];
                TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.SampleModel _result = ((TeamCoV5.Sample.MVVM.Silverlight.ViewModels.SampleService.SampleModel)(base.EndInvoke("GetSampleObjet", _args, result)));
                return _result;
            }
        }
    }
}
