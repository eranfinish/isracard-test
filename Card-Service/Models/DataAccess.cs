using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Card_Service.Models
{
    public class DataAccess
    {
        private static DataAccess _instance;
        private DataAccess()
        {

        }
        public static DataAccess Instance
        {
            get
            {
                if (Instance is null)
                {
                    _instance = new DataAccess();

                }
                return _instance;
            }
        }

        public JObject GetUserDetails(string userName)
        {
            var json = new JObject();
            json["full_name"] = "Eran Finish";

            return json;

        }
        

    } 
}
