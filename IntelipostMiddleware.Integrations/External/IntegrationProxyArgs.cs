using System;
using System.Collections.Generic;
using System.Text;

namespace IntelipostMiddleware.Integrations.External
{
    public sealed class IntegrationProxyArgs
    {
        private IntegrationProxyArgs(IntegrationProxyArgsBuilder buidlder)
        {
            this.Platform = buidlder.Platform;
            this.BaseURI = buidlder.BaseURI;
        }

        public SuportedPlatforms Platform { get; private set; }

        public string BaseURI { get; private set; }



        public class IntegrationProxyArgsBuilder
        {
            protected IntegrationProxyArgs args { get; set; }

            public IntegrationProxyArgsBuilder()
            {
                this.args = new IntegrationProxyArgs(this);
            }

            public IntegrationProxyArgsBuilder SetPlatformType(SuportedPlatforms suportedPlatform)
            {
                this.args.Platform = suportedPlatform;
                return this;
            }

            public IntegrationProxyArgsBuilder SetBaseURI(string uri)
            {
                this.args.BaseURI = uri;
                return this;
            }

            public IntegrationProxyArgs Build()
            {
                return this.args;
            }

            /// <summary>
            /// roposito de testes
            /// </summary>
            /// <returns></returns>
            public IntegrationProxyArgs BuildDefault()
            {
                this.args.Platform = SuportedPlatforms.SalePlatform;
                return this.args;
            }

            public SuportedPlatforms Platform { get; private set; }

            public string BaseURI { get; private set; }

        }
    }
}
