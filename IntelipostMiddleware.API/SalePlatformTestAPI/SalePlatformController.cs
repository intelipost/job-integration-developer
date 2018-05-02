using IntelipostMiddleware.Integrations.External.SalePlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IntelipostMiddleware.API.SalePlatformTestAPI
{
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
