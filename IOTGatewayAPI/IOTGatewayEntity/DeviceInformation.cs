using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTGatewayEntity
{
    public class DeviceInformation
    {
        public string DeviceID { get; set; }
        public string IMEI { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public Response response { get; set; }
    }
}
