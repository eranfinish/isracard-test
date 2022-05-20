using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;


namespace SailPointTest.Controllers
{ 
  //  [EnableCors()]
    [ApiController]   
    [Route("api/[controller]")]    
    public class TestController : ControllerBase
    {         
        [HttpGet("{xpr}")]
     
        public async Task<IActionResult> Get(string xpr)
        {
          //  var xpr = "";
            List<City> res = new List<City>();
            try
            {
                List<City> cities =  await JsonFileReader.ReadAsync<List<City>>(@"C:\Users\finis\source\repos\SailPointTest\SailPointTest\Data\jsn.json");
                res = cities.Where(x=>x.name.Contains(xpr)).ToList();

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        //    string json = JsonConvert.SerializeXmlNode(doc);

            //var data = ((JObject)JsonConvert.DeserializeObject(json))["RecoProfile"];
            return Ok(System.Text.Json.JsonSerializer.Serialize(res));
        }
        public static class JsonFileReader
        {
            public static async Task<T> ReadAsync<T>(string filePath)
            {
                using FileStream stream = System.IO.File.OpenRead(filePath);
                return await System.Text.Json.JsonSerializer.DeserializeAsync<T>(stream);
            }
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
