using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
namespace TrainTest.Controllers
{
 [RoutePrefix("api/main")]
    public class MainController : WebApiControllerBase
    {
        [Route("costs/{source?}/{destination?}")]
        [HttpGet]
        public string Costs(string source="",string destination = "")
        {
            var res = new JObject();
            res["telaviv"] = new JObject();
            res["telaviv"]["lod"] = 18.5;
            res["lod"] = new JObject();
            res["lod"]["telaviv"] = res["telaviv"]["lod"];
            return res[source][destination].ToString();
        }
    }
}
