using System;
using System.Text;
using System.ServiceModel;
namespace VelibSoapServiceLibrary
{
    public interface IVelibSoapServiceEvents
    {
        [OperationContract(IsOneWay = true)]
        void AvailableVelibUpdated(VelibSoapStation station, int newValue);
    }
}