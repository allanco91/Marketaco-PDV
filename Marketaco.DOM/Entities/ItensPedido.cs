using System;

namespace Marketaco.DOM.Entities
{
    public class ItensPedido
    {
        public int ItensPedidoID { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public int Ordem { get; set; }

        public int PedidoID { get; set; }
        public int ProdutoID { get; set; }

        public virtual Pedido Pedido { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
