using System;
using System.Collections.Generic;
using System.Text;

namespace IntelipostMiddleware.Integrations.External.SalePlatform.Adapters
{
    public interface IAdapter<T, O>
    {
        T Adapt(O target);
    }
}
