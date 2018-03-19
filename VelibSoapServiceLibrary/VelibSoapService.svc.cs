using JCDecauxAPILibrary;
using System.Collections.Generic;
using System.Linq;

namespace VelibSoapServiceLibrary
{
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class VelibSoapService : IVelibSoapService
    {
        private JCDecauxRESTClient jCDecauxRESTClient;

        VelibSoapService()
        {
            jCDecauxRESTClient = new JCDecauxRESTClient();
        }

        public List<VelibSoapContract> GetContracts()
        {
            return jCDecauxRESTClient.GetContracts().Select(c => new VelibSoapContract()
            {
                Cities = c.cities,
                Name = c.name,
                CommercialName = c.commercial_name,
                CountryCode = c.country_code
            }).ToList();
        }

        public List<VelibSoapStation> GetStations(VelibSoapContract contract)
        {
            return jCDecauxRESTClient.GetStations(new JCDecauxContract()
            {
                cities = contract.Cities,
                name = contract.Name,
                country_code = contract.CountryCode,
                commercial_name = contract.CommercialName
            }).Select(s => new VelibSoapStation()
            {
                Number = s.number,
                Name = s.name,
                Address = s.address,
                ContractName = s.contract_name,
                BikeStands = s.bike_stands,
                AvailableBikeStands = s.available_bike_stands,
                AvailableBikes = s.available_bikes
            }).ToList();
        }
    }
}
