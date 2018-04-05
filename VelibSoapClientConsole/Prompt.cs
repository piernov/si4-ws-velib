using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VelibSoapClientConsole.ServiceReference1;

namespace VelibSoapClientConsole
{
    public class Prompt
    {
        private VelibSoapServiceClient client;
        private ServiceReference1.Timer eventTimer;

        string Help()
        {
            return @"Available commands:
    help                                                       — display this message
    quit                                                       — close the application
    connect [url]                                              — connect to the webservice with an optional url
    list contracts                                             — list contract names
    list stations <contract name>                              — list station names for a given contract
    get contract <contract name>                               — get details about a contract
    get station <contract name> <station name>                 — get details about a station of a contract
    subscribe station <contract name> <station name> <period>  — subscribe to available bike changes
Note: name containing whitespaces should be enclosed with """".";
        }

        string Connect(string[] args)
        {

            VelibSoapServiceCallbackSink objsink = new VelibSoapServiceCallbackSink();
            InstanceContext iCntxt = new InstanceContext(objsink);

            if (args.Length > 0)
                client = new VelibSoapServiceClient(iCntxt, "", args[0]);
                //client = new VelibSoapServiceClient(VelibSoapServiceClient.EndpointConfiguration.BasicHttpBinding_IVelibSoapService, args[0], iCntxt);
            else
                client = new VelibSoapServiceClient(iCntxt);
            return "Connected to: " + client.Endpoint.Address;
        }

        bool Connected()
        {
            return client != null && (client.State == System.ServiceModel.CommunicationState.Opened || client.State == System.ServiceModel.CommunicationState.Created);
        }

        bool ValidateList(string[] args)
        {
            if (args.Length < 1) return false;
            switch(args[0])
            {
                case "contracts":
                    return args.Length == 1;
                case "stations":
                    return args.Length == 2;
                default:
                    return false;
            }
        }

        async Task<string> List(string[] args)
        {
            var command = args[0];
            switch (args[0])
            {
                case "contracts":
                    var contracts = await client.GetContractsNameAsync();
                    return string.Join("\n", contracts);
                case "stations":
                    var contract = await client.GetContractByNameAsync(args[1]);
                    if (contract == null) return "Contract " + args[1] + " not found";
                    var stations = await client.GetStationsNameAsync(contract);
                    return string.Join("\n", stations);
                default:
                    return "";
            }
        }

        bool ValidateGet(string[] args)
        {
            if (args.Length < 2) return false;
            switch (args[0])
            {
                case "contract":
                    return args.Length == 2;
                case "station":
                    return args.Length == 3;
                default:
                    return false;
            }
        }

        async Task<string> Get(string[] args)
        {
            string result = "";
            var command = args[0];
            var contractRes = await client.GetContractByNameAsync(args[1]);
            var contract = contractRes;
            if (contract == null) return "Contract " + args[1] + " not found";
            switch (args[0])
            {
                case "contract":
                    result += "Name: " + contract.Name + "\n";
                    result += "Commercial name: " + contract.CommercialName + "\n";
                    result += "Country code: " + contract.CountryCode + "\n";
                    result += "Cities: " + string.Join(" ", contract.Cities);
                    break;
                case "station":
                    var stationRes = await client.GetStationByNameAsync(contract, args[2]);
                    var station = stationRes;
                    if (station == null) return "Station " + args[1] + " not found in contract " + args[1];
                    result += "Name: " + station.Name + "\n";
                    result += "Number: " + station.Number + "\n";
                    result += "Contract name: " + station.ContractName + "\n";
                    result += "Address: " + station.Address + "\n";
                    result += "Bike stands: " + station.BikeStands + "\n";
                    result += "Available bike stands: " + station.AvailableBikeStands + "\n";
                    result += "Available bikes: " + station.AvailableBikes + "\n";
                    break;
            }
            return result;
        }

        bool ValidateSubscribe(string[] args)
        {
            if (args.Length < 2) return false;
            switch (args[0])
            {
                case "contract":
                    /*return args.Length == 2;*/
                    return false;
                case "station":
                    return args.Length == 4;
                default:
                    return false;
            }
        }

        string Subscribe(string[] args)
        {
            var command = args[0];
            var contractRes = client.GetContractByNameAsync(args[1]).Result;
            var contract = contractRes;
            if (contract == null) return "Contract " + args[1] + " not found";
            switch (args[0])
            {
                case "station":
                    eventTimer = client.SubscribeAvailableVelibUpdatedEvent(contract, args[2], Int32.Parse(args[3]));
                    break;
            }
            return "Subscribed!";
        }

        async public Task Run()
        {
            while (true)
            {
                Console.Write("> ");
                Console.Out.Flush();

                // from https://stackoverflow.com/a/14655199
                var line = Console.ReadLine().Split('"')
                     .Select((element, index) => index % 2 == 0  // If even index
                                           ? element.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)  // Split the item
                                           : new string[] { element })  // Keep the entire item
                     .SelectMany(element => element).ToArray();
                if (line.Length <= 0) continue;

                var command = line[0];
                var args = line.Skip(1).ToArray();
                string result = "";
                switch (command)
                {
                    case "quit":
                        return;
                    case "help":
                        result = Help();
                        break;
                    case "connect":
                        result = Connect(args);
                        break;
                    case "list":
                        if (!Connected()) result = "Not connected";
                        else if (!ValidateList(args)) result = Help();
                        else result = await List(args);
                        break;
                    case "get":
                        if (!Connected()) result = "Not connected";
                        else if (!ValidateGet(args)) result = Help();
                        else result = await Get(args);
                        break;
                    case "subscribe":
                        if (!Connected()) result = "Not connected";
                        else if (!ValidateSubscribe(args)) result = Help();
                        else result = Subscribe(args);
                        break;
                    default:
                        result = Help();
                        break;
                }

                Console.WriteLine(result);
            }
        }
    }
}
