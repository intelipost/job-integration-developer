using IntelipostMiddleware.Integrations.External.SalePlatform;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntelipostMiddleware.Integrations.External
{
    class IntegrationProxyFactory
    {
        public IPlatformProxy CreateProxy(IntegrationProxyArgs args)
        {
            if(args.Platform == SuportedPlatforms.SalePlatform)
            {
                return new SalePlatformProxy();
            }

            throw new PlatformNotSupportedException("Not supported platform");
        }
    }
}
