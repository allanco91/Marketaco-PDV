namespace Marketaco.DOM.Entities
{
    using System;
    using System.Collections.Generic;

    public class Pedido
    {
        public int PedidoID { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorTotal { get; set; }
        public int NumPessoas { get; set; }
        public bool Viagem { get; set; }
        public bool Status { get; set; }
        public decimal? Troco { get; set; }
        public decimal? ValorPago { get; set; }
        public bool TaxaS { get; set; }
        public decimal VlTaxaS { get; set; }

        public virtual ICollection<ItensPedido> ItensPedido { get; set; }
        public virtual ICollection<LancamentoCaixa> LancamentoCaixa { get; set; }
        public virtual ICollection<PedidoPagamento> PedidoPagamento { get; set; }
    }
}
