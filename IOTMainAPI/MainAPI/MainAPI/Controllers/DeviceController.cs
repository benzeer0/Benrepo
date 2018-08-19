using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MainDBEntity;
using mgr = MainManager;
using fty = MainFactory;


namespace MainAPI.Controllers
{
    [RoutePrefix("api/Device")]
    public class DeviceController : ApiController
    {
        mgr.IDevice dev = null;
        public DeviceController()
        {
            dev = fty.Facade.GetDeviceInstance();
        }

        [HttpPost]
        [Route("Register")]
        public IHttpActionResult RegisterDevice(DeviceInformation oData)
        {

            return Ok(dev.RegisterDevice(oData));

        }

        [HttpPost]
        [Route("Config")]
        public IHttpActionResult SendConfiguration(Configuration oData)
        {

            return Ok(dev.SendConfiguration(oData));

        }

        [HttpPost]
        public IHttpActionResult GetDataFromDevice(DataFromDevice oData)
        {

            return Ok(dev.GetDataFromDevice(oData));

        }

        [HttpGet]
        [Route("Token")]
        public IHttpActionResult GetSASToken(string oData)
        {

            return Ok(dev.GetSASToken(oData));

        }
    }
}