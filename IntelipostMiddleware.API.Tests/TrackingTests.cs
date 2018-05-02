using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace IntelipostMiddleware.API.Tests
{
    public class TrackingTests
    {
        [Fact]
        public async void MissingFieldShouldReturn400()
        {
            TrackingController controller = new TrackingController();

            var input = new IntelipostMiddleware.API.Models.Intelipost.OrderTrackingInformation()
            {
                Order_id = null,
                Event = new Models.Intelipost.OrderTrackingEvent()
                {
                    Date = DateTime.Now,
                    Status_id = 1
                }
            };

            var result = await controller.Post(input);
            BadRequestObjectResult viewResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal<int>(400, viewResult.StatusCode.Value);
        }

        [Fact]
        public async Task RegularPostShoudReturn200()
        {
            TrackingController controller = new TrackingController();

            var input = new IntelipostMiddleware.API.Models.Intelipost.OrderTrackingInformation()
            {
                Order_id = 12,
                Event = new Models.Intelipost.OrderTrackingEvent()
                {
                    Date = DateTime.Now,
                    Status_id = 1
                }
            };

            var resultapi = await controller.Post(input);
            OkResult result = Assert.IsType<OkResult>(resultapi);
            Assert.Equal<int>(200, result.StatusCode);
        }
    }
}
