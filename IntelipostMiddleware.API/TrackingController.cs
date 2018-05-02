using IntelipostMiddleware.API.Models.Intelipost;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntelipostMiddleware.API
{
    [Route("api/[controller]")]
    public class TrackingController : Controller
    {
        /*
        [HttpGet]
        public IEnumerable<string> Get()
        {   
            return new string[] { "value1", "value2 of test" };
        }*/
        [HttpGet]
        public string Get()
        {            
            List<string> values = new List<string>() { "value1", "value2" };
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
            if (!value.Order_id.HasValue)
            {
                this.ModelState.AddModelError("order_id", "Invalid value.");
            }

            if (!value.Event.Status_id.HasValue)
            {
                this.ModelState.AddModelError("Status_id", "Invalid value.");
            }


            if (!value.Event.Date.HasValue)
            {
                this.ModelState.AddModelError("date", "Invalid value.");
            }

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            return this.Created("", value);
        }        
    }
}
