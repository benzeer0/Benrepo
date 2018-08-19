using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTGatewayEntity
{
    public class DataFromDevice
    {
        public string DeviceID { get; set; }
        public string Data { get; set; }
        public Response response { get; set; }
    }
}
