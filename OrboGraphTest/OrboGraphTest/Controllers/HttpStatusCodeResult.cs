using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace OrboGraphTest.Controllers
{
    internal class HttpStatusCodeResult : IActionResult
    {
        public Task ExecuteResultAsync(ActionContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}