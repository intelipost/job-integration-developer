using System;
using System.Collections.Generic;
using System.Text;

namespace IntelipostMiddleware.Integrations.External
{
    public abstract class IntegrationProxyResult
    {
        public string Message { get; protected set; }
        public bool IsSuccess { get; protected set; }
    }
}
