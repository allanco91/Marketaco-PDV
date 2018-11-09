using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketaco.DOM.Entities
{
    public class PedidoPagamento
    {
        public int PedidoPagamentoID { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

        public int FormaPagamentoID { get; set; }
        public int PedidoID { get; set; }

        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
