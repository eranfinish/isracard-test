using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcService.DAL;
namespace CalcService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlusController : ControllerBase
    {
        [HttpGet]
        public JsonResult Get(float a, float b)
        {
            var res = new Plus(a, b);
            return { res: res.Calculate()};
        }
        // [HttpPut]
        // public float Put(int id, float a, float b)
        //{

        //}
    }
}
