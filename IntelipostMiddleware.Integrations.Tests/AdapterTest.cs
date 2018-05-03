using IntelipostMiddleware.Integrations.External.SalePlatform.Adapters;
using IntelipostMiddleware.Integrations.External.SalePlatform.Models;
using IntelipostMiddleware.Integrations.Intelipost.Models;
using System;
using Xunit;

namespace IntelipostMiddleware.Integrations.Tests
{
    public class AdapterTest
    {
        [Fact]
        public void OrderStatusConvertingIsWorking()
        {
            OrderStatusAdapter adapter = new OrderStatusAdapter();

            Assert.Equal("in_transit", adapter.Adapt(1));
            Assert.Equal("to_be_delivered", adapter.Adapt(2));
            Assert.Equal("delivered", adapter.Adapt(3));
        }

        [Fact]
        public void TrackingInfoIsConvertingRightToSalePlatformInfo()
        {
            DateTime date = DateTime.Now;
            OrderTrackingInformation info = new OrderTrackingInformation()
            {
                Order_id = 123,
                Event = new OrderTrackingEvent()
                {
                    Date = date,
                    Status_id = 1,
                }
            };

            SalePlatformTrackInfo expected = new SalePlatformTrackInfo()
            {
                Date = date,
                OrderId = 123,
                Status = "in_transit"
            };

            OrderTrackingInfoAdapter adapter = new OrderTrackingInfoAdapter();
            var dest = adapter.Adapt(info);
            Assert.Equal(expected.Date, dest.Date);
            Assert.Equal(expected.OrderId, dest.OrderId);
            Assert.Equal(expected.Status, dest.Status);
        }
    }
}
