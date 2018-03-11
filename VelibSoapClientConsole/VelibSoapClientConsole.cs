using System;
using System.Collections.Generic;
using System.Text;
using VelibSoapServiceReference;

namespace VelibSoapClientConsole
{
    class VelibSoapClientConsole
    {
        public async void run()
        {
            var client = new VelibSoapServiceClient();
            var contracts = await client.GetContractsAsync();
            foreach (var contract in contracts)
            {
                Console.WriteLine("miaou: " + contract.Name);
            }
            
        }
    }
}
