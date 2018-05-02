﻿using IntelipostMiddleware.API.Models.Intelipost;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntelipostMiddleware.API
{
    [Route("api/[controller]")]
    public class TrackingController : Controller
    {
        [HttpGet]
        public string Get()
        {            
            List<string> values = new List<string>() { "Teste rapido", "Ando sem tempo" };
            return Ok(values).ToString();
        }

        [ProducesResponseType(400)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("key", "value");
            return this.NotFound(dic) ;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]OrderTrackingInformation value)
        {
            TrackingValidationManager validator = new TrackingValidationManager(this, value);
            if (!validator.Validate(this.ModelState))
            {
                return this.BadRequest(this.ModelState);
            }

            return this.Ok();
        }        
    }
}
