using IntelipostMiddleware.Integrations.External.SalePlatform.Models;
using IntelipostMiddleware.Integrations.Intelipost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntelipostMiddleware.Integrations.External.SalePlatform.Adapters
{
    public class OrderTrackingInfoAdapter : IAdapter<SalePlatformTrackInfo, OrderTrackingInformation>
    {
        public SalePlatformTrackInfo Adapt(OrderTrackingInformation target)
        {
            SalePlatformTrackInfo infor = new SalePlatformTrackInfo();
            infor.Date = target.Event.Date.Value;
            infor.OrderId = target.Order_id.Value;
            infor.Status = new OrderStatusAdapter().Adapt(target.Event.Status_id.Value);

            return infor;
        }
    }
}
