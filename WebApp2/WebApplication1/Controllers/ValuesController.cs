using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] // tune to your needs
    [RoutePrefix("")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public JObject Get()
        {
            var class2 = @"{""val"":[
              {
    ""name"":""Rum 1"",
                  ""id"": ""a31d1fc8-df29-419c-8308-f8bc884b378e"",
                  ""seats"": 10,
                  ""availableFrom"": null,
                  ""availableTo"": null
  },
                {
                    ""name"": ""Rum 2"",
                    ""id"": ""7defd34d-222d-4980-b28f-e616e8b9003c"",
                    ""seats"": 5,
                    ""availableFrom"": null,
                    ""availableTo"": null
                },
                {
                    ""name"": ""Skrubben"",
                    ""id"": ""b20390ff-703b-4d80-8c2f-32c0f27158bc"",
                    ""seats"": 5,
                    ""availableFrom"": 10,
                    ""availableTo"": 11
                },
                {
                    ""name"": ""Hangaren"",
                    ""id"": ""b89cbacd-c738-477f-aff2-7f22c2b2cd5c"",
                    ""seats"": 100,
                    ""availableFrom"": null,
                    ""availableTo"": null
                },
                {
                    ""name"": ""Tv-rummet"",
                    ""id"": ""ea6a290f-209b-4ccb-91a4-65d82a674bad"",
                    ""seats"": 10,
                    ""availableFrom"": null,
                    ""availableTo"": null
                },
                {
                    ""name"": ""Projektor-rummet"",
                    ""id"": ""3136a56a-4a28-4939-aca8-806534c808f7"",
                    ""seats"": 12,
                    ""availableFrom"": null,
                    ""availableTo"": null
                },
                {
                    ""name"": ""Skolsalen"",
                    ""id"": ""05f73582-3734-453f-aeb3-36daf8884912"",
                    ""seats"": 30,
                    ""availableFrom"": null,
                    ""availableTo"": null
                }
]
  
}";

            return JObject.Parse(class2);
        }          
        

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class Class2
    {
        public string name { get; set; }
        public string id { get; set; }
        public int seats { get; set; }
        public int? availableFrom { get; set; }
        public int? availableTo { get; set; }
    }
}
