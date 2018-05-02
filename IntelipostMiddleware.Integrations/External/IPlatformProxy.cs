using IntelipostMiddleware.Integrations.External.SalePlatform.Responses;
using IntelipostMiddleware.Integrations.Intelipost.Models;

namespace IntelipostMiddleware.Integrations.External
{
    public interface IPlatformProxy
    {
        SendTrackNotificationResult SendTrackNotification(OrderTrackingInformation orderTrackingInformation);

        /** Adicionar outras operações  que forem necessárias **/ 
    }
}
