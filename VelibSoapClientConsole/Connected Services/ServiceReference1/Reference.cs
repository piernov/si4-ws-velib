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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibSoapService/GetContractsName", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetContractsNameResponse> GetContractsNameAsync(ServiceReference1.GetContractsNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibSoapService/GetContractByName", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetContractByNameResponse> GetContractByNameAsync(ServiceReference1.GetContractByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibSoapService/GetStations", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetStationsResponse> GetStationsAsync(ServiceReference1.GetStationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibSoapService/GetStationsName", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetStationsNameResponse> GetStationsNameAsync(ServiceReference1.GetStationsNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibSoapService/GetStationByName", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.GetStationByNameResponse> GetStationByNameAsync(ServiceReference1.GetStationByNameRequest request);
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
    public partial class GetContractsNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetContractsName", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetContractsNameRequestBody Body;
        
        public GetContractsNameRequest()
        {
        }
        
        public GetContractsNameRequest(ServiceReference1.GetContractsNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetContractsNameRequestBody
    {
        
        public GetContractsNameRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetContractsNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetContractsNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetContractsNameResponseBody Body;
        
        public GetContractsNameResponse()
        {
        }
        
        public GetContractsNameResponse(ServiceReference1.GetContractsNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetContractsNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.ArrayOfString GetContractsNameResult;
        
        public GetContractsNameResponseBody()
        {
        }
        
        public GetContractsNameResponseBody(ServiceReference1.ArrayOfString GetContractsNameResult)
        {
            this.GetContractsNameResult = GetContractsNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetContractByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetContractByName", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetContractByNameRequestBody Body;
        
        public GetContractByNameRequest()
        {
        }
        
        public GetContractByNameRequest(ServiceReference1.GetContractByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetContractByNameRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public GetContractByNameRequestBody()
        {
        }
        
        public GetContractByNameRequestBody(string name)
        {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetContractByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetContractByNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetContractByNameResponseBody Body;
        
        public GetContractByNameResponse()
        {
        }
        
        public GetContractByNameResponse(ServiceReference1.GetContractByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetContractByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.VelibSoapContract GetContractByNameResult;
        
        public GetContractByNameResponseBody()
        {
        }
        
        public GetContractByNameResponseBody(ServiceReference1.VelibSoapContract GetContractByNameResult)
        {
            this.GetContractByNameResult = GetContractByNameResult;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStationsNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStationsName", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetStationsNameRequestBody Body;
        
        public GetStationsNameRequest()
        {
        }
        
        public GetStationsNameRequest(ServiceReference1.GetStationsNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetStationsNameRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.VelibSoapContract contract;
        
        public GetStationsNameRequestBody()
        {
        }
        
        public GetStationsNameRequestBody(ServiceReference1.VelibSoapContract contract)
        {
            this.contract = contract;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStationsNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStationsNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetStationsNameResponseBody Body;
        
        public GetStationsNameResponse()
        {
        }
        
        public GetStationsNameResponse(ServiceReference1.GetStationsNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetStationsNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.ArrayOfString GetStationsNameResult;
        
        public GetStationsNameResponseBody()
        {
        }
        
        public GetStationsNameResponseBody(ServiceReference1.ArrayOfString GetStationsNameResult)
        {
            this.GetStationsNameResult = GetStationsNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStationByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStationByName", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetStationByNameRequestBody Body;
        
        public GetStationByNameRequest()
        {
        }
        
        public GetStationByNameRequest(ServiceReference1.GetStationByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetStationByNameRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.VelibSoapContract contract;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        public GetStationByNameRequestBody()
        {
        }
        
        public GetStationByNameRequestBody(ServiceReference1.VelibSoapContract contract, string name)
        {
            this.contract = contract;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStationByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStationByNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.GetStationByNameResponseBody Body;
        
        public GetStationByNameResponse()
        {
        }
        
        public GetStationByNameResponse(ServiceReference1.GetStationByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetStationByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.VelibSoapStation GetStationByNameResult;
        
        public GetStationByNameResponseBody()
        {
        }
        
        public GetStationByNameResponseBody(ServiceReference1.VelibSoapStation GetStationByNameResult)
        {
            this.GetStationByNameResult = GetStationByNameResult;
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
        System.Threading.Tasks.Task<ServiceReference1.GetContractsNameResponse> ServiceReference1.IVelibSoapService.GetContractsNameAsync(ServiceReference1.GetContractsNameRequest request)
        {
            return base.Channel.GetContractsNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetContractsNameResponse> GetContractsNameAsync()
        {
            ServiceReference1.GetContractsNameRequest inValue = new ServiceReference1.GetContractsNameRequest();
            inValue.Body = new ServiceReference1.GetContractsNameRequestBody();
            return ((ServiceReference1.IVelibSoapService)(this)).GetContractsNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetContractByNameResponse> ServiceReference1.IVelibSoapService.GetContractByNameAsync(ServiceReference1.GetContractByNameRequest request)
        {
            return base.Channel.GetContractByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetContractByNameResponse> GetContractByNameAsync(string name)
        {
            ServiceReference1.GetContractByNameRequest inValue = new ServiceReference1.GetContractByNameRequest();
            inValue.Body = new ServiceReference1.GetContractByNameRequestBody();
            inValue.Body.name = name;
            return ((ServiceReference1.IVelibSoapService)(this)).GetContractByNameAsync(inValue);
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
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetStationsNameResponse> ServiceReference1.IVelibSoapService.GetStationsNameAsync(ServiceReference1.GetStationsNameRequest request)
        {
            return base.Channel.GetStationsNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetStationsNameResponse> GetStationsNameAsync(ServiceReference1.VelibSoapContract contract)
        {
            ServiceReference1.GetStationsNameRequest inValue = new ServiceReference1.GetStationsNameRequest();
            inValue.Body = new ServiceReference1.GetStationsNameRequestBody();
            inValue.Body.contract = contract;
            return ((ServiceReference1.IVelibSoapService)(this)).GetStationsNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.GetStationByNameResponse> ServiceReference1.IVelibSoapService.GetStationByNameAsync(ServiceReference1.GetStationByNameRequest request)
        {
            return base.Channel.GetStationByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.GetStationByNameResponse> GetStationByNameAsync(ServiceReference1.VelibSoapContract contract, string name)
        {
            ServiceReference1.GetStationByNameRequest inValue = new ServiceReference1.GetStationByNameRequest();
            inValue.Body = new ServiceReference1.GetStationByNameRequestBody();
            inValue.Body.contract = contract;
            inValue.Body.name = name;
            return ((ServiceReference1.IVelibSoapService)(this)).GetStationByNameAsync(inValue);
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
