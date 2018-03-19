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
    [System.Runtime.Serialization.DataContractAttribute(Name="VelibSoapContract", Namespace="http://schemas.datacontract.org/2004/07/VelibSoap")]
    public partial class VelibSoapContract : object
    {
        
        private string[] CitiesField;
        
        private string CommercialNameField;
        
        private string CountryCodeField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Cities
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VelibSoapStation", Namespace="http://schemas.datacontract.org/2004/07/VelibSoap")]
    public partial class VelibSoapStation : object
    {
        
        private string AddressField;
        
        private int AvailableBikeStandsField;
        
        private int AvailableBikesField;
        
        private int BikeStandsField;
        
        private string ContractNameField;
        
        private string NameField;
        
        private int NumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IVelibSoapService")]
    public interface IVelibSoapService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibSoapService/GetContracts", ReplyAction="http://tempuri.org/IVelibSoapService/GetContractsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.VelibSoapContract[]> GetContractsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibSoapService/GetStations", ReplyAction="http://tempuri.org/IVelibSoapService/GetStationsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.VelibSoapStation[]> GetStationsAsync(ServiceReference1.VelibSoapContract contract);
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
        
        public System.Threading.Tasks.Task<ServiceReference1.VelibSoapContract[]> GetContractsAsync()
        {
            return base.Channel.GetContractsAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.VelibSoapStation[]> GetStationsAsync(ServiceReference1.VelibSoapContract contract)
        {
            return base.Channel.GetStationsAsync(contract);
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
                return new System.ServiceModel.EndpointAddress("http://localhost:51460/VelibSoapService.svc");
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
