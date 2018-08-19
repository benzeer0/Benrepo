using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using IOTGatewayEntity;
using Newtonsoft.Json;

namespace IOTGatewayAPI.Controllers
{
    public class DeviceController : ApiController
    {
        [HttpPost]

        public IHttpActionResult RegisterDevice(DeviceInformation oData)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50564/");
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
            client.BaseAddress = new Uri("http://localhost:50564");
            client.DefaultRequestHeaders.Add("oData", Token);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HttpResponseMessage response = client.PostAsJsonAsync("api/Device/GetSASToken",Token).Result;
            HttpResponseMessage response = client.GetAsync("api/Device/GetSASToken?oData="+Token).Result;
            string data = "";
            if (response.IsSuccessStatusCode)
            {
                data = response.Content.ReadAsAsync<String>().Result;

            }
            return Ok(data);

        }
    }
}
