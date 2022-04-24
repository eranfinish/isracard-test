using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace OrboGraphTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirstController : Controller
    {
        [HttpGet("/GetXml/{location}")]
        public async Task<IActionResult> GetXml(string location)
        {
            var xml = String.Empty;
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(location))
                {
                    // Read the stream as a string, and write the string to the console.
                    xml = sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

//           var xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
//<RecoProfile xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" Description=""Test profile""  ResultThreshold=""70"" TestMinAmount=""0"">
//<Tests>
//<RecoTest Type=""MaximumAmount"" Required=""true"" Threshold=""10000"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""AmountVerification"" Required=""true"" Threshold=""40"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""AmountDiscrepancy"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""ImageQuality"" Required="" true"" Threshold=""40"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""PayeeVerification"" Required=""true"" Threshold=""45"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""PayerVerification"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""MissingSignature"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""MissingEndorsement"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""ValidDocumentType"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""DateInRange"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""FraudDetection"" Required=""false"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""CheckOutOfState"" Required=""true"" Threshold=""50"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""AmountNotToExceed"" Required=""false"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""TwoSignatures Required"" Required=""false"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""PayableToCash"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""PayeePayerValidation"" Required=""false"" Threshold=""60"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""DepositOutofState"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""PayerBlackList"" Required=""true"" Threshold=""50"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""PayerSuspicious"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""NewAccount"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""ShortTermDuplicate"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""PADdetection"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""AccountBlackList"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""CashEquivalentDetection"" Required=""true"" Threshold=""70"" MinTestAmount=""0"" Weight=""1""/>
//<RecoTest Type=""ImageIntegrity"" Required=""true"" Threshold=""85"" MinTestAmount=""0"" Weight=""1""/>
//</Tests>
//<MetaData>
//<AllowedDocTypes>
//<DocumentType Type=""BusinessCheck"" Required=""true""/>
//<DocumentType Type=""PersonalCheck"" Required=""true""/>
//<DocumentType Type=""MoneyOrder"" Required=""true""/>
//<DocumentType Type=""Traveler'sCheck"" Required=""true""/>
//</AllowedDocTypes>
//<ValidPeriodDays Backward=""90"" DaysForward=""30""/>
//<NewAccountPeriod>30</NewAccountPeriod>
//<PayerBlackLists>
//<ListType Name=""PayerBlackList"" Required=""true""/>
//<ListType Name=""PayerWhiteList"" Required=""false""/>
//</PayerBlackLists>
//<AccountBlackLists>
//<ListType Name=""AccountBlackList"" Required=""false""/>
//<ListType Name=""AccountWhiteList"" Required=""false""/>
//</AccountBlackLists>
//</MetaData>
//</RecoProfile>";
            XmlDocument doc = new XmlDocument();
           doc.LoadXml(xml);
       
         
            string json = JsonConvert.SerializeXmlNode(doc);

            var data = ((JObject)JsonConvert.DeserializeObject(json))["RecoProfile"];
            return Ok(JsonConvert.SerializeObject(data));
        }
        [HttpPost("UpdateXml/{xml}/{location}/")]
        public async Task<IActionResult> UpdateXml(string xml, string location)
        {
            xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
<RecoProfile xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" Description=""Test profile""  ResultThreshold=""70"" TestMinAmount=""0"">
"
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(location))
                {
                    // Read the stream as a string, and write the string to the console.
                    xml = sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

                xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
            <RecoProfile xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" Description=""Test profile""  ResultThreshold=""70"" TestMinAmount=""0"">
            <Tests>
            </Tests>
            <MetaData>
            <AllowedDocTypes>
            <DocumentType Type=""BusinessCheck"" Required=""true""/>
            <DocumentType Type=""PersonalCheck"" Required=""true""/>
            <DocumentType Type=""MoneyOrder"" Required=""true""/>
            <DocumentType Type=""Traveler'sCheck"" Required=""true""/>
            </AllowedDocTypes>
            <ValidPeriodDays Backward=""90"" DaysForward=""30""/>
            <NewAccountPeriod>30</NewAccountPeriod>
            <PayerBlackLists>
            <ListType Name=""PayerBlackList"" Required=""true""/>
            <ListType Name=""PayerWhiteList"" Required=""false""/>
            </PayerBlackLists>
            <AccountBlackLists>
            <ListType Name=""AccountBlackList"" Required=""false""/>
            <ListType Name=""AccountWhiteList"" Required=""false""/>
            </AccountBlackLists>
            </MetaData>
            </RecoProfile>";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);


            string json = JsonConvert.SerializeXmlNode(doc);

            var data = ((JObject)JsonConvert.DeserializeObject(json))["RecoProfile"]["Tests"]["RecoTest"];
            return Ok(JsonConvert.SerializeObject(data));
        }


    }

    public class RecoTest
    {
        public string Type { get; set; }        
        public bool Required { get; set; }
        public int Threshhold { get; set; }
        public int  MinTestAmount { get; set; }
        public int  Weight { get; set; }

    }
}
