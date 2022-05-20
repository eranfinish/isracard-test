using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;
using System.IO;
//using System.Text.Json;
using Newtonsoft.Json;
using System.Web.Http.Cors;

namespace TestService.Controllers
{
    public class TesterController : ApiController
    {
        // GET: Tester
      
        public string Get()
        {
            List<City> res = new List<City>();
            try
            {

                using(StreamReader reader = new StreamReader(@"C:\Users\finis\source\repos\TestService\Data\jsn.json"))
                {
                    string jsn = reader.ReadToEnd();
                  res = JsonConvert.DeserializeObject<List<City>>(jsn);

                        res = res.Where(x => x.name.Contains("los")).ToList();
                }
          
             

            }
            catch (Exception ex)
            {
                return  ex.Message;
            }
            //    string json = JsonConvert.SerializeXmlNode(doc);

            //var data = ((JObject)JsonConvert.DeserializeObject(json))["RecoProfile"];
            return JsonConvert.SerializeObject(res);

        }


    }

    public class City
    {
        public string name { get; set; }
        public string country { get; set; }
        public string subcountry { get; set; }
        public int geonameid { get; set; }
    }
}