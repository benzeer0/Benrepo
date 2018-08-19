using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mgr = MainManager;
using imp = MainImplementation;

namespace MainFactory
{
    public class Facade
    {
        public static mgr.IDevice GetDeviceInstance()
        {
            return new imp.Device();
        }
    }
}
