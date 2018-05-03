using IntelipostMiddleware.Integrations.Intelipost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntelipostMiddleware.Integrations.External.SalePlatform.Adapters
{
    public class OrderStatusAdapter : IAdapter<string, int>
    {
        /*
         * Poderia ser feito uma consulta no BD e buscar um mapeamento definido pelo usuário
         * Para fins de teste e simplificacao do processo, sera um swtich:
         */ 
        public string Adapt(int target)
        {
            switch ((OrderStatus)target)
            {
                case OrderStatus.Pedido_em_transito:
                    return "in_transit";

                case OrderStatus.Pedido_saiu_para_entrega:
                    return "to_be_delivered";

                case OrderStatus.Pedido_entregue:
                    return "delivered";
            }

            return "";
        }
    }
}
