//------------------------------------------------------------------------------
// <généré automatiquement>
//     Ce code a été généré par un outil.
//     //
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </généré automatiquement>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VelibSoapContract", Namespace="http://tempuri.org/")]
    public partial class VelibSoapContract : object
    {
        
        private string NameField;
        
        private ServiceReference1.ArrayOfString CitiesField;
        
        private string CommercialNameField;
        
        private string CountryCodeField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public ServiceReference1.ArrayOfString Cities
        {
            get
            {
                return this.CitiesField;
            }
            set
            {
                this.CitiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string CommercialName
        {
            get
            {
                return this.CommercialNameField;
            }
            set
            {
                this.CommercialNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string CountryCode
        {
            get
            {
                return this.CountryCodeField;
            }
            set
            {
                this.CountryCodeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    public class ArrayOfString : System.Collections.Generic.List<string>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VelibSoapStation", Namespace="http://tempuri.org/")]
    public partial class VelibSoapStation : object
    {
        
        private int NumberField;
        
        private string NameField;
        
        private string AddressField;
        
        private string ContractNameField;
        
        private int BikeStandsField;
        
        private int AvailableBikeStandsField;
        
        private int AvailableBikesField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Number
        {
            get
            {
                return this.NumberField;
            }
            set
            {
                this.NumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ContractName
        {
            get
            {
                return this.ContractNameField;
            }
            set
            {
                this.ContractNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int BikeStands
        {
            get
            {
                return this.BikeStandsField;
            }
            set
            {
                this.BikeStandsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int AvailableBikeStands
        {
            get
            {
                return this.AvailableBikeStandsField;
            }
            set
            {
                this.AvailableBikeStandsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int AvailableBikes
        {
            get
            {
                return this.AvailableBikesField;
            }
            set
            {
                this.AvailableBikesField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IVelibSoapService")]
    public interface IVelibSoapService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibSoapService/GetContracts", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetContractsResponse> GetContractsAsync(ServiceReference1.GetContractsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibSoapService/GetStations", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetStationsResponse> GetStationsAsync(ServiceReference1.GetStationsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetContractsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetContracts", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetContractsRequestBody Body;
        
        public GetContractsRequest()
        {
        }
        
        public GetContractsRequest(ServiceReference1.GetContractsRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetContractsRequestBody
    {
        
        public GetContractsRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetContractsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetContractsResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetContractsResponseBody Body;
        
        public GetContractsResponse()
        {
        }
        
        public GetContractsResponse(ServiceReference1.GetContractsResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetContractsResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.VelibSoapContract[] GetContractsResult;
        
        public GetContractsResponseBody()
        {
        }
        
        public GetContractsResponseBody(ServiceReference1.VelibSoapContract[] GetContractsResult)
        {
            this.GetContractsResult = GetContractsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStationsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStations", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetStationsRequestBody Body;
        
        public GetStationsRequest()
        {
        }
        
        public GetStationsRequest(ServiceReference1.GetStationsRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetStationsRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.VelibSoapContract contract;
        
        public GetStationsRequestBody()
        {
        }
        
        public GetStationsRequestBody(ServiceReference1.VelibSoapContract contract)
        {
            this.contract = contract;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStationsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStationsResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetStationsResponseBody Body;
        
        public GetStationsResponse()
        {
        }
        
        public GetStationsResponse(ServiceReference1.GetStationsResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetStationsResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.VelibSoapStation[] GetStationsResult;
        
        public GetStationsResponseBody()
        {
        }
        
        public GetStationsResponseBody(ServiceReference1.VelibSoapStation[] GetStationsResult)
        {
            this.GetStationsResult = GetStationsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface IVelibSoapServiceChannel : ServiceReference1.IVelibSoapService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class VelibSoapServiceClient : System.ServiceModel.ClientBase<ServiceReference1.IVelibSoapService>, ServiceReference1.IVelibSoapService
    {
        
    /// <summary>
    /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
    /// </summary>
    /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
    /// <param name="clientCredentials">Informations d'identification du client</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public VelibSoapServiceClient() : 
                base(VelibSoapServiceClient.GetDefaultBinding(), VelibSoapServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IVelibSoapService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VelibSoapServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(VelibSoapServiceClient.GetBindingForEndpoint(endpointConfiguration), VelibSoapServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VelibSoapServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(VelibSoapServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VelibSoapServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(VelibSoapServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public VelibSoapServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetContractsResponse> ServiceReference1.IVelibSoapService.GetContractsAsync(ServiceReference1.GetContractsRequest request)
        {
            return base.Channel.GetContractsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetContractsResponse> GetContractsAsync()
        {
            ServiceReference1.GetContractsRequest inValue = new ServiceReference1.GetContractsRequest();
            inValue.Body = new ServiceReference1.GetContractsRequestBody();
            return ((ServiceReference1.IVelibSoapService)(this)).GetContractsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetStationsResponse> ServiceReference1.IVelibSoapService.GetStationsAsync(ServiceReference1.GetStationsRequest request)
        {
            return base.Channel.GetStationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetStationsResponse> GetStationsAsync(ServiceReference1.VelibSoapContract contract)
        {
            ServiceReference1.GetStationsRequest inValue = new ServiceReference1.GetStationsRequest();
            inValue.Body = new ServiceReference1.GetStationsRequestBody();
            inValue.Body.contract = contract;
            return ((ServiceReference1.IVelibSoapService)(this)).GetStationsAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IVelibSoapService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IVelibSoapService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:5050/VelibSoapService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return VelibSoapServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IVelibSoapService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return VelibSoapServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IVelibSoapService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IVelibSoapService,
        }
    }
}
