﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace MyNet.Atmcs.Uscmcp.Bll.OtherQueryService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="OtherQueryInfoHttpBinding", Namespace="http://query")]
    public partial class OtherQueryInfo : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback QueryUntreatedLlegalInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback QueryLlegalScoreCountOperationCompleted;
        
        private System.Threading.SendOrPostCallback QueryLlegalCountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFeatureImageSearchOperationCompleted;
        
        private System.Threading.SendOrPostCallback QueryObjectOutOperationCompleted;
        
        private System.Threading.SendOrPostCallback WriteObjectOutOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetImageSearchOperationCompleted;
        
        private System.Threading.SendOrPostCallback QueryPersonRelationAnalysisOperationCompleted;
        
        private System.Threading.SendOrPostCallback QueryHandleLlegalPersonsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public OtherQueryInfo() {
            this.Url = global::MyNet.Atmcs.Uscmcp.Bll.Properties.Settings.Default.MyNet_Atmcs_Uscmcp_Bll_OtherQueryService_OtherQueryInfo;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event QueryUntreatedLlegalInfoCompletedEventHandler QueryUntreatedLlegalInfoCompleted;
        
        /// <remarks/>
        public event QueryLlegalScoreCountCompletedEventHandler QueryLlegalScoreCountCompleted;
        
        /// <remarks/>
        public event QueryLlegalCountCompletedEventHandler QueryLlegalCountCompleted;
        
        /// <remarks/>
        public event GetFeatureImageSearchCompletedEventHandler GetFeatureImageSearchCompleted;
        
        /// <remarks/>
        public event QueryObjectOutCompletedEventHandler QueryObjectOutCompleted;
        
        /// <remarks/>
        public event WriteObjectOutCompletedEventHandler WriteObjectOutCompleted;
        
        /// <remarks/>
        public event GetImageSearchCompletedEventHandler GetImageSearchCompleted;
        
        /// <remarks/>
        public event QueryPersonRelationAnalysisCompletedEventHandler QueryPersonRelationAnalysisCompleted;
        
        /// <remarks/>
        public event QueryHandleLlegalPersonsCompletedEventHandler QueryHandleLlegalPersonsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://query", ResponseNamespace="http://query", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("out", IsNullable=true)]
        public string QueryUntreatedLlegalInfo([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in1) {
            object[] results = this.Invoke("QueryUntreatedLlegalInfo", new object[] {
                        in0,
                        in1});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void QueryUntreatedLlegalInfoAsync(string in0, string in1) {
            this.QueryUntreatedLlegalInfoAsync(in0, in1, null);
        }
        
        /// <remarks/>
        public void QueryUntreatedLlegalInfoAsync(string in0, string in1, object userState) {
            if ((this.QueryUntreatedLlegalInfoOperationCompleted == null)) {
                this.QueryUntreatedLlegalInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryUntreatedLlegalInfoOperationCompleted);
            }
            this.InvokeAsync("QueryUntreatedLlegalInfo", new object[] {
                        in0,
                        in1}, this.QueryUntreatedLlegalInfoOperationCompleted, userState);
        }
        
        private void OnQueryUntreatedLlegalInfoOperationCompleted(object arg) {
            if ((this.QueryUntreatedLlegalInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryUntreatedLlegalInfoCompleted(this, new QueryUntreatedLlegalInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://query", ResponseNamespace="http://query", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("out")]
        public int QueryLlegalScoreCount([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in1) {
            object[] results = this.Invoke("QueryLlegalScoreCount", new object[] {
                        in0,
                        in1});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void QueryLlegalScoreCountAsync(string in0, string in1) {
            this.QueryLlegalScoreCountAsync(in0, in1, null);
        }
        
        /// <remarks/>
        public void QueryLlegalScoreCountAsync(string in0, string in1, object userState) {
            if ((this.QueryLlegalScoreCountOperationCompleted == null)) {
                this.QueryLlegalScoreCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryLlegalScoreCountOperationCompleted);
            }
            this.InvokeAsync("QueryLlegalScoreCount", new object[] {
                        in0,
                        in1}, this.QueryLlegalScoreCountOperationCompleted, userState);
        }
        
        private void OnQueryLlegalScoreCountOperationCompleted(object arg) {
            if ((this.QueryLlegalScoreCountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryLlegalScoreCountCompleted(this, new QueryLlegalScoreCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://query", ResponseNamespace="http://query", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("out")]
        public int QueryLlegalCount([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in1) {
            object[] results = this.Invoke("QueryLlegalCount", new object[] {
                        in0,
                        in1});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void QueryLlegalCountAsync(string in0, string in1) {
            this.QueryLlegalCountAsync(in0, in1, null);
        }
        
        /// <remarks/>
        public void QueryLlegalCountAsync(string in0, string in1, object userState) {
            if ((this.QueryLlegalCountOperationCompleted == null)) {
                this.QueryLlegalCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryLlegalCountOperationCompleted);
            }
            this.InvokeAsync("QueryLlegalCount", new object[] {
                        in0,
                        in1}, this.QueryLlegalCountOperationCompleted, userState);
        }
        
        private void OnQueryLlegalCountOperationCompleted(object arg) {
            if ((this.QueryLlegalCountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryLlegalCountCompleted(this, new QueryLlegalCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://query", ResponseNamespace="http://query", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("out", IsNullable=true)]
        public string GetFeatureImageSearch([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0) {
            object[] results = this.Invoke("GetFeatureImageSearch", new object[] {
                        in0});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetFeatureImageSearchAsync(string in0) {
            this.GetFeatureImageSearchAsync(in0, null);
        }
        
        /// <remarks/>
        public void GetFeatureImageSearchAsync(string in0, object userState) {
            if ((this.GetFeatureImageSearchOperationCompleted == null)) {
                this.GetFeatureImageSearchOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFeatureImageSearchOperationCompleted);
            }
            this.InvokeAsync("GetFeatureImageSearch", new object[] {
                        in0}, this.GetFeatureImageSearchOperationCompleted, userState);
        }
        
        private void OnGetFeatureImageSearchOperationCompleted(object arg) {
            if ((this.GetFeatureImageSearchCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFeatureImageSearchCompleted(this, new GetFeatureImageSearchCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://query", ResponseNamespace="http://query", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("out", IsNullable=true)]
        public string QueryObjectOut([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in1) {
            object[] results = this.Invoke("QueryObjectOut", new object[] {
                        in0,
                        in1});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void QueryObjectOutAsync(string in0, string in1) {
            this.QueryObjectOutAsync(in0, in1, null);
        }
        
        /// <remarks/>
        public void QueryObjectOutAsync(string in0, string in1, object userState) {
            if ((this.QueryObjectOutOperationCompleted == null)) {
                this.QueryObjectOutOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryObjectOutOperationCompleted);
            }
            this.InvokeAsync("QueryObjectOut", new object[] {
                        in0,
                        in1}, this.QueryObjectOutOperationCompleted, userState);
        }
        
        private void OnQueryObjectOutOperationCompleted(object arg) {
            if ((this.QueryObjectOutCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryObjectOutCompleted(this, new QueryObjectOutCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://query", ResponseNamespace="http://query", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("out", IsNullable=true)]
        public string WriteObjectOut([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in1) {
            object[] results = this.Invoke("WriteObjectOut", new object[] {
                        in0,
                        in1});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WriteObjectOutAsync(string in0, string in1) {
            this.WriteObjectOutAsync(in0, in1, null);
        }
        
        /// <remarks/>
        public void WriteObjectOutAsync(string in0, string in1, object userState) {
            if ((this.WriteObjectOutOperationCompleted == null)) {
                this.WriteObjectOutOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWriteObjectOutOperationCompleted);
            }
            this.InvokeAsync("WriteObjectOut", new object[] {
                        in0,
                        in1}, this.WriteObjectOutOperationCompleted, userState);
        }
        
        private void OnWriteObjectOutOperationCompleted(object arg) {
            if ((this.WriteObjectOutCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WriteObjectOutCompleted(this, new WriteObjectOutCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://query", ResponseNamespace="http://query", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("out", IsNullable=true)]
        public string GetImageSearch([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0) {
            object[] results = this.Invoke("GetImageSearch", new object[] {
                        in0});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetImageSearchAsync(string in0) {
            this.GetImageSearchAsync(in0, null);
        }
        
        /// <remarks/>
        public void GetImageSearchAsync(string in0, object userState) {
            if ((this.GetImageSearchOperationCompleted == null)) {
                this.GetImageSearchOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetImageSearchOperationCompleted);
            }
            this.InvokeAsync("GetImageSearch", new object[] {
                        in0}, this.GetImageSearchOperationCompleted, userState);
        }
        
        private void OnGetImageSearchOperationCompleted(object arg) {
            if ((this.GetImageSearchCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetImageSearchCompleted(this, new GetImageSearchCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://query", ResponseNamespace="http://query", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("out", IsNullable=true)]
        public string QueryPersonRelationAnalysis([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0) {
            object[] results = this.Invoke("QueryPersonRelationAnalysis", new object[] {
                        in0});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void QueryPersonRelationAnalysisAsync(string in0) {
            this.QueryPersonRelationAnalysisAsync(in0, null);
        }
        
        /// <remarks/>
        public void QueryPersonRelationAnalysisAsync(string in0, object userState) {
            if ((this.QueryPersonRelationAnalysisOperationCompleted == null)) {
                this.QueryPersonRelationAnalysisOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryPersonRelationAnalysisOperationCompleted);
            }
            this.InvokeAsync("QueryPersonRelationAnalysis", new object[] {
                        in0}, this.QueryPersonRelationAnalysisOperationCompleted, userState);
        }
        
        private void OnQueryPersonRelationAnalysisOperationCompleted(object arg) {
            if ((this.QueryPersonRelationAnalysisCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryPersonRelationAnalysisCompleted(this, new QueryPersonRelationAnalysisCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://query", ResponseNamespace="http://query", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("out", IsNullable=true)]
        public string QueryHandleLlegalPersons([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in0, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string in1) {
            object[] results = this.Invoke("QueryHandleLlegalPersons", new object[] {
                        in0,
                        in1});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void QueryHandleLlegalPersonsAsync(string in0, string in1) {
            this.QueryHandleLlegalPersonsAsync(in0, in1, null);
        }
        
        /// <remarks/>
        public void QueryHandleLlegalPersonsAsync(string in0, string in1, object userState) {
            if ((this.QueryHandleLlegalPersonsOperationCompleted == null)) {
                this.QueryHandleLlegalPersonsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryHandleLlegalPersonsOperationCompleted);
            }
            this.InvokeAsync("QueryHandleLlegalPersons", new object[] {
                        in0,
                        in1}, this.QueryHandleLlegalPersonsOperationCompleted, userState);
        }
        
        private void OnQueryHandleLlegalPersonsOperationCompleted(object arg) {
            if ((this.QueryHandleLlegalPersonsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryHandleLlegalPersonsCompleted(this, new QueryHandleLlegalPersonsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void QueryUntreatedLlegalInfoCompletedEventHandler(object sender, QueryUntreatedLlegalInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryUntreatedLlegalInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal QueryUntreatedLlegalInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void QueryLlegalScoreCountCompletedEventHandler(object sender, QueryLlegalScoreCountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryLlegalScoreCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal QueryLlegalScoreCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void QueryLlegalCountCompletedEventHandler(object sender, QueryLlegalCountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryLlegalCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal QueryLlegalCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetFeatureImageSearchCompletedEventHandler(object sender, GetFeatureImageSearchCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFeatureImageSearchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFeatureImageSearchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void QueryObjectOutCompletedEventHandler(object sender, QueryObjectOutCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryObjectOutCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal QueryObjectOutCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void WriteObjectOutCompletedEventHandler(object sender, WriteObjectOutCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WriteObjectOutCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WriteObjectOutCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetImageSearchCompletedEventHandler(object sender, GetImageSearchCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetImageSearchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetImageSearchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void QueryPersonRelationAnalysisCompletedEventHandler(object sender, QueryPersonRelationAnalysisCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryPersonRelationAnalysisCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal QueryPersonRelationAnalysisCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void QueryHandleLlegalPersonsCompletedEventHandler(object sender, QueryHandleLlegalPersonsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryHandleLlegalPersonsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal QueryHandleLlegalPersonsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591