using MainDBEntity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace MainAPI.Controllers
{
    public class GatewayDeviceController : ApiController
    {
        string BaseURL = null;
        public GatewayDeviceController()
        {
            BaseURL = System.Configuration.ConfigurationManager.AppSettings["MainAPIURL"];
        }
        [HttpPost]

        public IHttpActionResult RegisterDevice(DeviceInformation oData)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseURL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            StringContent content = new StringContent(JsonConvert.SerializeObject(oData), Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync("api/Device/RegisterDevice", content).Result;

            //      HttpResponseMessage response = client.GetAsync("api/Device/RegisterDevice").Result;
            DeviceInformation data = null;
            if (response.IsSuccessStatusCode)
            {
                data = response.Content.ReadAsAsync<DeviceInformation>().Result;

            }
            return Ok(data);

        }
        [HttpGet]
        public IHttpActionResult GetSASToken(string Token)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseURL);
            client.DefaultRequestHeaders.Add("oData", Token);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HttpResponseMessage response = client.PostAsJsonAsync("api/Device/GetSASToken",Token).Result;
            HttpResponseMessage response = client.GetAsync("api/Device/Token?oData=" + Token).Result;
            string data = "";
            if (response.IsSuccessStatusCode)
            {
                data = response.Content.ReadAsAsync<String>().Result;

            }
            return Ok(data);

        }
    }
}
