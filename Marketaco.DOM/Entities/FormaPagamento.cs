namespace Marketaco.DOM.Entities
{
    using System.Collections.Generic;

    public class FormaPagamento
    {
        public int FormaPagamentoID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<LancamentoCaixa> LancamentoCaixa { get; set; }
        public virtual ICollection<PedidoPagamento> PedidoPagamento { get; set; }
    }
}
