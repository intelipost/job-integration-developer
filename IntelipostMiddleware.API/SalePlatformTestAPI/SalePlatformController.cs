using IntelipostMiddleware.Integrations.External.SalePlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IntelipostMiddleware.API.SalePlatformTestAPI
{
    /// <summary>
    /// Serviço Mock apenas, sem auth
    /// </summary>
    [Route("api/[controller]")]
    public class SalePlatformController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]SalePlatformTrackInfo value)
        {
            return this.Ok(value);
        }
    }
}
