﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SequenceClient.ServiceReference3 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="vadikorzh.com.com.com", ConfigurationName="ServiceReference3.ISequenceServer")]
    public interface ISequenceServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="vadikorzh.com.com.com/ISequenceServer/Reset", ReplyAction="vadikorzh.com.com.com/ISequenceServer/ResetResponse")]
        void Reset();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="vadikorzh.com.com.com/ISequenceServer/Reset", ReplyAction="vadikorzh.com.com.com/ISequenceServer/ResetResponse")]
        System.IAsyncResult BeginReset(System.AsyncCallback callback, object asyncState);
        
        void EndReset(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="vadikorzh.com.com.com/ISequenceServer/Next", ReplyAction="vadikorzh.com.com.com/ISequenceServer/NextResponse")]
        int Next();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="vadikorzh.com.com.com/ISequenceServer/Next", ReplyAction="vadikorzh.com.com.com/ISequenceServer/NextResponse")]
        System.IAsyncResult BeginNext(System.AsyncCallback callback, object asyncState);
        
        int EndNext(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="vadikorzh.com.com.com/ISequenceServer/Current", ReplyAction="vadikorzh.com.com.com/ISequenceServer/CurrentResponse")]
        int Current();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="vadikorzh.com.com.com/ISequenceServer/Current", ReplyAction="vadikorzh.com.com.com/ISequenceServer/CurrentResponse")]
        System.IAsyncResult BeginCurrent(System.AsyncCallback callback, object asyncState);
        
        int EndCurrent(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISequenceServerChannel : SequenceClient.ServiceReference3.ISequenceServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NextCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public NextCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CurrentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public CurrentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SequenceServerClient : System.ServiceModel.ClientBase<SequenceClient.ServiceReference3.ISequenceServer>, SequenceClient.ServiceReference3.ISequenceServer {
        
        private BeginOperationDelegate onBeginResetDelegate;
        
        private EndOperationDelegate onEndResetDelegate;
        
        private System.Threading.SendOrPostCallback onResetCompletedDelegate;
        
        private BeginOperationDelegate onBeginNextDelegate;
        
        private EndOperationDelegate onEndNextDelegate;
        
        private System.Threading.SendOrPostCallback onNextCompletedDelegate;
        
        private BeginOperationDelegate onBeginCurrentDelegate;
        
        private EndOperationDelegate onEndCurrentDelegate;
        
        private System.Threading.SendOrPostCallback onCurrentCompletedDelegate;
        
        public SequenceServerClient() {
        }
        
        public SequenceServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SequenceServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SequenceServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SequenceServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> ResetCompleted;
        
        public event System.EventHandler<NextCompletedEventArgs> NextCompleted;
        
        public event System.EventHandler<CurrentCompletedEventArgs> CurrentCompleted;
        
        public void Reset() {
            base.Channel.Reset();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginReset(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginReset(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndReset(System.IAsyncResult result) {
            base.Channel.EndReset(result);
        }
        
        private System.IAsyncResult OnBeginReset(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginReset(callback, asyncState);
        }
        
        private object[] OnEndReset(System.IAsyncResult result) {
            this.EndReset(result);
            return null;
        }
        
        private void OnResetCompleted(object state) {
            if ((this.ResetCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ResetCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ResetAsync() {
            this.ResetAsync(null);
        }
        
        public void ResetAsync(object userState) {
            if ((this.onBeginResetDelegate == null)) {
                this.onBeginResetDelegate = new BeginOperationDelegate(this.OnBeginReset);
            }
            if ((this.onEndResetDelegate == null)) {
                this.onEndResetDelegate = new EndOperationDelegate(this.OnEndReset);
            }
            if ((this.onResetCompletedDelegate == null)) {
                this.onResetCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnResetCompleted);
            }
            base.InvokeAsync(this.onBeginResetDelegate, null, this.onEndResetDelegate, this.onResetCompletedDelegate, userState);
        }
        
        public int Next() {
            return base.Channel.Next();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginNext(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginNext(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int EndNext(System.IAsyncResult result) {
            return base.Channel.EndNext(result);
        }
        
        private System.IAsyncResult OnBeginNext(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginNext(callback, asyncState);
        }
        
        private object[] OnEndNext(System.IAsyncResult result) {
            int retVal = this.EndNext(result);
            return new object[] {
                    retVal};
        }
        
        private void OnNextCompleted(object state) {
            if ((this.NextCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.NextCompleted(this, new NextCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void NextAsync() {
            this.NextAsync(null);
        }
        
        public void NextAsync(object userState) {
            if ((this.onBeginNextDelegate == null)) {
                this.onBeginNextDelegate = new BeginOperationDelegate(this.OnBeginNext);
            }
            if ((this.onEndNextDelegate == null)) {
                this.onEndNextDelegate = new EndOperationDelegate(this.OnEndNext);
            }
            if ((this.onNextCompletedDelegate == null)) {
                this.onNextCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnNextCompleted);
            }
            base.InvokeAsync(this.onBeginNextDelegate, null, this.onEndNextDelegate, this.onNextCompletedDelegate, userState);
        }
        
        public int Current() {
            return base.Channel.Current();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginCurrent(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCurrent(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int EndCurrent(System.IAsyncResult result) {
            return base.Channel.EndCurrent(result);
        }
        
        private System.IAsyncResult OnBeginCurrent(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginCurrent(callback, asyncState);
        }
        
        private object[] OnEndCurrent(System.IAsyncResult result) {
            int retVal = this.EndCurrent(result);
            return new object[] {
                    retVal};
        }
        
        private void OnCurrentCompleted(object state) {
            if ((this.CurrentCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CurrentCompleted(this, new CurrentCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CurrentAsync() {
            this.CurrentAsync(null);
        }
        
        public void CurrentAsync(object userState) {
            if ((this.onBeginCurrentDelegate == null)) {
                this.onBeginCurrentDelegate = new BeginOperationDelegate(this.OnBeginCurrent);
            }
            if ((this.onEndCurrentDelegate == null)) {
                this.onEndCurrentDelegate = new EndOperationDelegate(this.OnEndCurrent);
            }
            if ((this.onCurrentCompletedDelegate == null)) {
                this.onCurrentCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCurrentCompleted);
            }
            base.InvokeAsync(this.onBeginCurrentDelegate, null, this.onEndCurrentDelegate, this.onCurrentCompletedDelegate, userState);
        }
    }
}
