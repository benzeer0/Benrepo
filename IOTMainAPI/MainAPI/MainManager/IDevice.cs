using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainDBEntity;

namespace MainManager
{
    public interface IDevice
    {
        DeviceInformation RegisterDevice(DeviceInformation device);
        Response SendConfiguration(Configuration config);
        Response GetDataFromDevice(DataFromDevice data);
        string GetSASToken(string token);
    }
}
