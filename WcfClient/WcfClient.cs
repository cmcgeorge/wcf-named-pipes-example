﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://WcfService", ClrNamespace="wcfservice")]

namespace wcfservice
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NullFault", Namespace="http://WcfService")]
    public partial class NullFault : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string MessageField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://WcfService", ConfigurationName="IService")]
public interface IService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://WcfService/IService/ToUpperCase", ReplyAction="http://WcfService/IService/ToUpperCaseResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(wcfservice.NullFault), Action="http://WcfService/IService/ToUpperCaseNullFaultFault", Name="NullFault")]
    string ToUpperCase(string text);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://WcfService/IService/ToUpperCase", ReplyAction="http://WcfService/IService/ToUpperCaseResponse")]
    System.Threading.Tasks.Task<string> ToUpperCaseAsync(string text);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServiceChannel : IService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ServiceClient : System.ServiceModel.ClientBase<IService>, IService
{
    
    public ServiceClient()
    {
    }
    
    public ServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string ToUpperCase(string text)
    {
        return base.Channel.ToUpperCase(text);
    }
    
    public System.Threading.Tasks.Task<string> ToUpperCaseAsync(string text)
    {
        return base.Channel.ToUpperCaseAsync(text);
    }
}
