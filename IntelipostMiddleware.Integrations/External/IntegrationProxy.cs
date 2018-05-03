using System;
using System.Collections.Generic;
using System.Text;

namespace IntelipostMiddleware.Integrations.External
{
    /// <summary>
    /// Entire integration context facade
    /// </summary>
    public class IntegrationProxy
    {
        private static IntegrationProxy _instance;

        public static IntegrationProxy GetInstance(IntegrationProxyArgs args)
        {
            if(_instance == null)
            {
                _instance = new IntegrationProxy(args);
            }

            return _instance;
        }


        private IntegrationProxy(IntegrationProxyArgs args)
        {
            IntegrationProxyFactory factory = new IntegrationProxyFactory();
            this.Proxy = factory.CreateProxy(args);
        }

        public IPlatformProxy Proxy { get; private set; }
    }

    public enum SuportedPlatforms
    {
        Other = 0,
        SalePlatform = 1
    }
}
