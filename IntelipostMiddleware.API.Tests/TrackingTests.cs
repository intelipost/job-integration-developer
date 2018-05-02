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
        public async void Test1()
        {
            TrackingController controller = new TrackingController();

            // Act
            //IActionResult actionResult = await controller.Get();

            // Assert
            Assert.NotNull(actionResult);

            OkObjectResult result = actionResult as OkObjectResult;

            Assert.NotNull(result);

            List<string> messages = result.Value as List<string>;

            Assert.Equal(2, messages.Count);
            Assert.Equal("value1", messages[0]);
            Assert.Equal("value2", messages[1]);
        }

        [Fact]
        public async Task TestPost()
        {
            // Arrange
            var controller = new TrackingController();

            // Act
            IActionResult actionResult = await controller.Post("{teste invalido}");

            // Assert
            Assert.NotNull(actionResult);
            CreatedResult result = actionResult as CreatedResult;

            Assert.NotNull(result);
            Assert.Equal(201, result.StatusCode);
        }
    }
}
