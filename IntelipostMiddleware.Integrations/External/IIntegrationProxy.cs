using IntelipostMiddleware.Integrations.External.SalePlatform.Responses;
using IntelipostMiddleware.Integrations.Intelipost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntelipostMiddleware.Integrations.External
{
    public interface IIntegrationProxy
    {
        SendTrackNotificationResult SendTrackNotification(OrderTrackingInformation orderTrackingInformation);

        /** Adicionar outras operações  que forem necessárias **/ 
    }
}
