using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibSoapClientConsole.ServiceReference1;

namespace VelibSoapClientConsole
{
    class VelibSoapServiceCallbackSink : IVelibSoapServiceCallback
    {
        public void AvailableVelibUpdated(VelibSoapStation station, int newValue)
        {
            Console.WriteLine("Station: " + station.Name + ", available bikes: " + newValue);
        }
    }
}
