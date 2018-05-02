using System;
using System.Collections.Generic;
using System.Text;

namespace IntelipostMiddleware.Integrations.Intelipost.Models
{
    public enum OrderStatus
    {
        Pedido_em_transito = 1,
        Pedido_saiu_para_entrega = 2,
        Pedido_entregue = 3
    }
}
