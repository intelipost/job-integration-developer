using IntelipostMiddleware.Integrations.External;
using IntelipostMiddleware.Integrations.Intelipost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntelipostMiddleware.Integrations.Tests
{
    public class PlatformProxyTest
    {
        [Fact]
        public void SendTrackInformationIsBeingSent()
        {
            IPlatformProxy proxy = IntegrationProxy.GetInstance(new IntegrationProxyArgs.IntegrationProxyArgsBuilder().BuildDefault()).Proxy;

            var input = new OrderTrackingInformation()
            {
                Order_id = 12,
                Event = new OrderTrackingEvent()
                {
                    Date = DateTime.Now,
                    Status_id = 1
                }
            };

            Assert.True(proxy.SendTrackNotification(input).IsSuccess);
        }
    }
}
