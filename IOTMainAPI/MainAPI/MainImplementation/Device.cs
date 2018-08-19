using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainDBEntity;
using MainManager;

namespace MainImplementation
{
    public class Device : IDevice
    {
        public Response GetDataFromDevice(DataFromDevice data)
        {
            Response res = new Response();
            res.ResponseMessage = "Success";
            res.ResponseStatus = "S";
            return res;
        }

        public DeviceInformation RegisterDevice(DeviceInformation device)
        {
            DeviceInformation di = new DeviceInformation();
            di.DeviceID = "D1";
            di.IMEI = "AA";
            di.Name = "Device1";
            return di;
        }

        public Response SendConfiguration(Configuration config)
        {
            Response res = new Response();
            res.ResponseMessage = "Success";
            res.ResponseStatus = "S";
            return res;
        }
        public string GetSASToken(string Token)
        {
            return "SASToken";
        }
    }
}
