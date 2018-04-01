using JCDecauxAPILibrary;
using System.Collections.Generic;
using System.Linq;

namespace VelibSoapServiceLibrary
{
    public class VelibSoapService : IVelibSoapService
    {
        private JCDecauxRESTClient jCDecauxRESTClient;

        public VelibSoapService()
        {
            jCDecauxRESTClient = new JCDecauxRESTClient();
        }

        public VelibSoapContract GetContractByName(string name)
        {
            return jCDecauxRESTClient.GetContracts().Where(c => c.name == name).Select(c => new VelibSoapContract()
            {
                Cities = c.cities.ToArray(),
                Name = c.name,
                CommercialName = c.commercial_name,
                CountryCode = c.country_code
            }).FirstOrDefault();
        }

        public VelibSoapContract[]  GetContracts()
        {
            return jCDecauxRESTClient.GetContracts().Select(c => new VelibSoapContract()
            {
                Cities = c.cities.ToArray(),
                Name = c.name,
                CommercialName = c.commercial_name,
                CountryCode = c.country_code
            })
            .ToArray();
        }

        public string[] GetContractsName()
        {
            return jCDecauxRESTClient.GetContracts().Select(c => c.name)
            .ToArray();
        }

        public VelibSoapStation GetStationByName(VelibSoapContract contract, string name)
        {
            return jCDecauxRESTClient.GetStations(new JCDecauxContract()
            {
                cities = contract.Cities.ToList(),
                name = contract.Name,
                country_code = contract.CountryCode,
                commercial_name = contract.CommercialName
            }).Where(c => c.name == name)
            .Select(s => new VelibSoapStation()
            {
                Number = s.number,
                Name = s.name,
                Address = s.address,
                ContractName = s.contract_name,
                BikeStands = s.bike_stands,
                AvailableBikeStands = s.available_bike_stands,
                AvailableBikes = s.available_bikes
            })
            .FirstOrDefault();
        }

        public VelibSoapStation[] GetStations(VelibSoapContract contract)
        {
            return jCDecauxRESTClient.GetStations(new JCDecauxContract()
            {
                cities = contract.Cities.ToList(),
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
            })
            .ToArray();
        }

        public string[] GetStationsName(VelibSoapContract contract)
        {
            return jCDecauxRESTClient.GetStations(new JCDecauxContract()
            {
                cities = contract.Cities.ToList(),
                name = contract.Name,
                country_code = contract.CountryCode,
                commercial_name = contract.CommercialName
            }).Select(s => s.name)
            .ToArray();
        }
    }
}
