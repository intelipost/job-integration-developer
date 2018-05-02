using System;
using System.Collections.Generic;
using System.Text;
using IntelipostMiddleware.Integrations.Intelipost.Models;

namespace IntelipostMiddleware.Integrations.External.SalePlatform
{
    public sealed class SalePlatformProxy : IIntegrationProxy
    {
        public bool SendTrackNotification(OrderTrackingInformation orderTrackingInformation)
        {
            return false;
        }
    }
}
