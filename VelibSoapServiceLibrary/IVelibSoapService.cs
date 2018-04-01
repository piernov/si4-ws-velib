using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace VelibSoapServiceLibrary
{
    [ServiceContract]
    public interface IVelibSoapService
    {
        [OperationContract]
        VelibSoapContract[] GetContracts();

        [OperationContract]
        string[] GetContractsName();

        [OperationContract]
        VelibSoapContract GetContractByName(string name);

        [OperationContract]
        VelibSoapStation[] GetStations(VelibSoapContract contract);

        [OperationContract]
        string[] GetStationsName(VelibSoapContract contract);

        [OperationContract]
        VelibSoapStation GetStationByName(VelibSoapContract contract, string name);
    }

    [DataContract]
    public class VelibSoapContract
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string[] Cities { get; set; } // array because SoapCore won't serialize List properly

        [DataMember]
        public string CommercialName { get; set; }

        [DataMember]
        public string CountryCode { get; set; }
    }

    [DataContract]
    public class VelibSoapStation
    {
        [DataMember]
        public int Number { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string ContractName { get; set; }

        [DataMember]
        public int BikeStands { get; set; }

        [DataMember]
        public int AvailableBikeStands { get; set; }

        [DataMember]
        public int AvailableBikes { get; set; }
    }
}
