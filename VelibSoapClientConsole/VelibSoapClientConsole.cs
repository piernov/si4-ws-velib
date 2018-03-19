using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace VelibSoapClientConsole
{
    class VelibSoapClientConsole
    {
        public async void run()
        {
            var client = new VelibSoapServiceClient();
            var contracts = client.GetContractsAsync().Result;
            foreach (var contract in contracts.Body.GetContractsResult)
            {
                Console.WriteLine("miaou: " + contract.Name);

                foreach (var city in contract.Cities)
                {
                    Console.WriteLine("    nyan: " + city);
                }
            }
        }
    }
}
