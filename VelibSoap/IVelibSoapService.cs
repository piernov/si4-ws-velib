using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VelibSoap
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IVelibSoapService
    {
        [OperationContract]
        List<VelibSoapContract> GetContracts();

        [OperationContract]
        List<VelibSoapStation> GetStations(VelibSoapContract contract);
    }

    [DataContract]
    public class VelibSoapContract
    {
        [DataMember]
        public string Name;

        [DataMember]
        public List<string> Cities;

        [DataMember]
        public string CommercialName;

        [DataMember]
        public string CountryCode;
    }

    [DataContract]
    public class VelibSoapStation
    {
        [DataMember]
        public int Number;

        [DataMember]
        public string Name;

        [DataMember]
        public string Address;

        [DataMember]
        public string ContractName;

        [DataMember]
        public int BikeStands;

        [DataMember]
        public int AvailableBikeStands;

        [DataMember]
        public int AvailableBikes;
    }
}
