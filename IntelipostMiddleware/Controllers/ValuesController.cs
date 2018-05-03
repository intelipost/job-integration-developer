using Microsoft.AspNetCore.Mvc;

namespace IntelipostMiddleware.Controllers
{
    [Route("")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Service is running";
        }        
    }
}
