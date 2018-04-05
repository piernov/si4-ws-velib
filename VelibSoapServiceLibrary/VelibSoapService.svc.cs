using JCDecauxAPILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;

namespace VelibSoapServiceLibrary
{
    public class VelibSoapService : IVelibSoapService
    {
        private JCDecauxRESTClient jCDecauxRESTClient;
        static Dictionary<string, int> availableBikesByStation = new Dictionary<string, int>();
        static List<Timer> timers = new List<Timer>();


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

        private void UpdateAvailableVelibUpdated(VelibSoapContract contract, string name, Action<VelibSoapStation, int> availableVelibUpdatedEvent)
        {
            Console.WriteLine("Event!");
            VelibSoapStation station = GetStationByName(contract, name);
            if (!availableBikesByStation.ContainsKey(name)) {
                availableBikesByStation[name] = -1;
            }
            if (availableBikesByStation[name] != station.AvailableBikes)
            {
                availableBikesByStation[name] = station.AvailableBikes;
                availableVelibUpdatedEvent(station, station.AvailableBikes);
            }
            availableVelibUpdatedEvent(station, station.AvailableBikes); //Debug: trigger event even if no change
        }

        public /*Timer*/ void SubscribeAvailableVelibUpdatedEvent(VelibSoapContract contract, string name, int period)
        {
            IVelibSoapServiceEvents subscriber = OperationContext.Current.GetCallbackChannel<IVelibSoapServiceEvents>();
            Action<VelibSoapStation, int> availableVelibUpdatedEvent = delegate { };

            availableVelibUpdatedEvent += subscriber.AvailableVelibUpdated;

            Console.WriteLine("Subscribed: " + contract.Name + ", " + name + ", " + period);

            var timer = new Timer(
                e => UpdateAvailableVelibUpdated(contract, name, availableVelibUpdatedEvent),
                null,
                TimeSpan.Zero,
                TimeSpan.FromSeconds(period));

            timers.Add(timer);
            //return timer;
        }
    }
}
