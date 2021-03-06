﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STS.RelyingPartyApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/ws/2008/06/identity/securitytokenservice", ConfigurationName="ServiceReference1.IWSTrust13Sync")]
    public interface IWSTrust13Sync {
        
        // CODEGEN: Generating message contract since the operation Trust13Cancel is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Cancel", ReplyAction="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTR/CancelFinal")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        STS.RelyingPartyApp.ServiceReference1.Trust13CancelResponse Trust13Cancel(STS.RelyingPartyApp.ServiceReference1.Trust13CancelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Cancel", ReplyAction="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTR/CancelFinal")]
        System.Threading.Tasks.Task<STS.RelyingPartyApp.ServiceReference1.Trust13CancelResponse> Trust13CancelAsync(STS.RelyingPartyApp.ServiceReference1.Trust13CancelRequest request);
        
        // CODEGEN: Generating message contract since the operation Trust13Issue is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Issue", ReplyAction="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTRC/IssueFinal")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        STS.RelyingPartyApp.ServiceReference1.Trust13IssueResponse Trust13Issue(STS.RelyingPartyApp.ServiceReference1.Trust13IssueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Issue", ReplyAction="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTRC/IssueFinal")]
        System.Threading.Tasks.Task<STS.RelyingPartyApp.ServiceReference1.Trust13IssueResponse> Trust13IssueAsync(STS.RelyingPartyApp.ServiceReference1.Trust13IssueRequest request);
        
        // CODEGEN: Generating message contract since the operation Trust13Renew is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Renew", ReplyAction="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTR/RenewFinal")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        STS.RelyingPartyApp.ServiceReference1.Trust13RenewResponse Trust13Renew(STS.RelyingPartyApp.ServiceReference1.Trust13RenewRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Renew", ReplyAction="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTR/RenewFinal")]
        System.Threading.Tasks.Task<STS.RelyingPartyApp.ServiceReference1.Trust13RenewResponse> Trust13RenewAsync(STS.RelyingPartyApp.ServiceReference1.Trust13RenewRequest request);
        
        // CODEGEN: Generating message contract since the operation Trust13Validate is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Validate", ReplyAction="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTR/ValidateFinal")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        STS.RelyingPartyApp.ServiceReference1.Trust13ValidateResponse Trust13Validate(STS.RelyingPartyApp.ServiceReference1.Trust13ValidateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Validate", ReplyAction="http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTR/ValidateFinal")]
        System.Threading.Tasks.Task<STS.RelyingPartyApp.ServiceReference1.Trust13ValidateResponse> Trust13ValidateAsync(STS.RelyingPartyApp.ServiceReference1.Trust13ValidateRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512")]
    public partial class RequestSecurityTokenType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Xml.XmlElement[] itemsField;
        
        private string contextField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.XmlElement[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Context {
            get {
                return this.contextField;
            }
            set {
                this.contextField = value;
                this.RaisePropertyChanged("Context");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512")]
    public partial class RequestSecurityTokenResponseType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Xml.XmlElement[] itemsField;
        
        private string contextField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.XmlElement[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Context {
            get {
                return this.contextField;
            }
            set {
                this.contextField = value;
                this.RaisePropertyChanged("Context");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512")]
    public partial class RequestSecurityTokenResponseCollectionType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private RequestSecurityTokenResponseType[] requestSecurityTokenResponseField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestSecurityTokenResponse", Order=0)]
        public RequestSecurityTokenResponseType[] RequestSecurityTokenResponse {
            get {
                return this.requestSecurityTokenResponseField;
            }
            set {
                this.requestSecurityTokenResponseField = value;
                this.RaisePropertyChanged("RequestSecurityTokenResponse");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Trust13CancelRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512", Order=0)]
        public STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken;
        
        public Trust13CancelRequest() {
        }
        
        public Trust13CancelRequest(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken) {
            this.RequestSecurityToken = RequestSecurityToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Trust13CancelResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512", Order=0)]
        public STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenResponseCollectionType RequestSecurityTokenResponseCollection;
        
        public Trust13CancelResponse() {
        }
        
        public Trust13CancelResponse(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenResponseCollectionType RequestSecurityTokenResponseCollection) {
            this.RequestSecurityTokenResponseCollection = RequestSecurityTokenResponseCollection;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Trust13IssueRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512", Order=0)]
        public STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken;
        
        public Trust13IssueRequest() {
        }
        
        public Trust13IssueRequest(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken) {
            this.RequestSecurityToken = RequestSecurityToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Trust13IssueResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512", Order=0)]
        public STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenResponseCollectionType RequestSecurityTokenResponseCollection;
        
        public Trust13IssueResponse() {
        }
        
        public Trust13IssueResponse(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenResponseCollectionType RequestSecurityTokenResponseCollection) {
            this.RequestSecurityTokenResponseCollection = RequestSecurityTokenResponseCollection;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Trust13RenewRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512", Order=0)]
        public STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken;
        
        public Trust13RenewRequest() {
        }
        
        public Trust13RenewRequest(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken) {
            this.RequestSecurityToken = RequestSecurityToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Trust13RenewResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512", Order=0)]
        public STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenResponseCollectionType RequestSecurityTokenResponseCollection;
        
        public Trust13RenewResponse() {
        }
        
        public Trust13RenewResponse(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenResponseCollectionType RequestSecurityTokenResponseCollection) {
            this.RequestSecurityTokenResponseCollection = RequestSecurityTokenResponseCollection;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Trust13ValidateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512", Order=0)]
        public STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken;
        
        public Trust13ValidateRequest() {
        }
        
        public Trust13ValidateRequest(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken) {
            this.RequestSecurityToken = RequestSecurityToken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Trust13ValidateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://docs.oasis-open.org/ws-sx/ws-trust/200512", Order=0)]
        public STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenResponseCollectionType RequestSecurityTokenResponseCollection;
        
        public Trust13ValidateResponse() {
        }
        
        public Trust13ValidateResponse(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenResponseCollectionType RequestSecurityTokenResponseCollection) {
            this.RequestSecurityTokenResponseCollection = RequestSecurityTokenResponseCollection;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSTrust13SyncChannel : STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSTrust13SyncClient : System.ServiceModel.ClientBase<STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync>, STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync {
        
        public WSTrust13SyncClient() {
        }
        
        public WSTrust13SyncClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSTrust13SyncClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSTrust13SyncClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSTrust13SyncClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        STS.RelyingPartyApp.ServiceReference1.Trust13CancelResponse STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync.Trust13Cancel(STS.RelyingPartyApp.ServiceReference1.Trust13CancelRequest request) {
            return base.Channel.Trust13Cancel(request);
        }
        
        public STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenResponseCollectionType Trust13Cancel(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken) {
            STS.RelyingPartyApp.ServiceReference1.Trust13CancelRequest inValue = new STS.RelyingPartyApp.ServiceReference1.Trust13CancelRequest();
            inValue.RequestSecurityToken = RequestSecurityToken;
            STS.RelyingPartyApp.ServiceReference1.Trust13CancelResponse retVal = ((STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync)(this)).Trust13Cancel(inValue);
            return retVal.RequestSecurityTokenResponseCollection;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<STS.RelyingPartyApp.ServiceReference1.Trust13CancelResponse> STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync.Trust13CancelAsync(STS.RelyingPartyApp.ServiceReference1.Trust13CancelRequest request) {
            return base.Channel.Trust13CancelAsync(request);
        }
        
        public System.Threading.Tasks.Task<STS.RelyingPartyApp.ServiceReference1.Trust13CancelResponse> Trust13CancelAsync(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken) {
            STS.RelyingPartyApp.ServiceReference1.Trust13CancelRequest inValue = new STS.RelyingPartyApp.ServiceReference1.Trust13CancelRequest();
            inValue.RequestSecurityToken = RequestSecurityToken;
            return ((STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync)(this)).Trust13CancelAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        STS.RelyingPartyApp.ServiceReference1.Trust13IssueResponse STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync.Trust13Issue(STS.RelyingPartyApp.ServiceReference1.Trust13IssueRequest request) {
            return base.Channel.Trust13Issue(request);
        }
        
        public STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenResponseCollectionType Trust13Issue(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken) {
            STS.RelyingPartyApp.ServiceReference1.Trust13IssueRequest inValue = new STS.RelyingPartyApp.ServiceReference1.Trust13IssueRequest();
            inValue.RequestSecurityToken = RequestSecurityToken;
            STS.RelyingPartyApp.ServiceReference1.Trust13IssueResponse retVal = ((STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync)(this)).Trust13Issue(inValue);
            return retVal.RequestSecurityTokenResponseCollection;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<STS.RelyingPartyApp.ServiceReference1.Trust13IssueResponse> STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync.Trust13IssueAsync(STS.RelyingPartyApp.ServiceReference1.Trust13IssueRequest request) {
            return base.Channel.Trust13IssueAsync(request);
        }
        
        public System.Threading.Tasks.Task<STS.RelyingPartyApp.ServiceReference1.Trust13IssueResponse> Trust13IssueAsync(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken) {
            STS.RelyingPartyApp.ServiceReference1.Trust13IssueRequest inValue = new STS.RelyingPartyApp.ServiceReference1.Trust13IssueRequest();
            inValue.RequestSecurityToken = RequestSecurityToken;
            return ((STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync)(this)).Trust13IssueAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        STS.RelyingPartyApp.ServiceReference1.Trust13RenewResponse STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync.Trust13Renew(STS.RelyingPartyApp.ServiceReference1.Trust13RenewRequest request) {
            return base.Channel.Trust13Renew(request);
        }
        
        public STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenResponseCollectionType Trust13Renew(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken) {
            STS.RelyingPartyApp.ServiceReference1.Trust13RenewRequest inValue = new STS.RelyingPartyApp.ServiceReference1.Trust13RenewRequest();
            inValue.RequestSecurityToken = RequestSecurityToken;
            STS.RelyingPartyApp.ServiceReference1.Trust13RenewResponse retVal = ((STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync)(this)).Trust13Renew(inValue);
            return retVal.RequestSecurityTokenResponseCollection;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<STS.RelyingPartyApp.ServiceReference1.Trust13RenewResponse> STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync.Trust13RenewAsync(STS.RelyingPartyApp.ServiceReference1.Trust13RenewRequest request) {
            return base.Channel.Trust13RenewAsync(request);
        }
        
        public System.Threading.Tasks.Task<STS.RelyingPartyApp.ServiceReference1.Trust13RenewResponse> Trust13RenewAsync(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken) {
            STS.RelyingPartyApp.ServiceReference1.Trust13RenewRequest inValue = new STS.RelyingPartyApp.ServiceReference1.Trust13RenewRequest();
            inValue.RequestSecurityToken = RequestSecurityToken;
            return ((STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync)(this)).Trust13RenewAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        STS.RelyingPartyApp.ServiceReference1.Trust13ValidateResponse STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync.Trust13Validate(STS.RelyingPartyApp.ServiceReference1.Trust13ValidateRequest request) {
            return base.Channel.Trust13Validate(request);
        }
        
        public STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenResponseCollectionType Trust13Validate(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken) {
            STS.RelyingPartyApp.ServiceReference1.Trust13ValidateRequest inValue = new STS.RelyingPartyApp.ServiceReference1.Trust13ValidateRequest();
            inValue.RequestSecurityToken = RequestSecurityToken;
            STS.RelyingPartyApp.ServiceReference1.Trust13ValidateResponse retVal = ((STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync)(this)).Trust13Validate(inValue);
            return retVal.RequestSecurityTokenResponseCollection;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<STS.RelyingPartyApp.ServiceReference1.Trust13ValidateResponse> STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync.Trust13ValidateAsync(STS.RelyingPartyApp.ServiceReference1.Trust13ValidateRequest request) {
            return base.Channel.Trust13ValidateAsync(request);
        }
        
        public System.Threading.Tasks.Task<STS.RelyingPartyApp.ServiceReference1.Trust13ValidateResponse> Trust13ValidateAsync(STS.RelyingPartyApp.ServiceReference1.RequestSecurityTokenType RequestSecurityToken) {
            STS.RelyingPartyApp.ServiceReference1.Trust13ValidateRequest inValue = new STS.RelyingPartyApp.ServiceReference1.Trust13ValidateRequest();
            inValue.RequestSecurityToken = RequestSecurityToken;
            return ((STS.RelyingPartyApp.ServiceReference1.IWSTrust13Sync)(this)).Trust13ValidateAsync(inValue);
        }
    }
}
