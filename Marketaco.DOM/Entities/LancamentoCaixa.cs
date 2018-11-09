using System;

namespace Marketaco.DOM.Entities
{
    public class LancamentoCaixa
    {
        public int LancamentoCaixaID { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public decimal Entrada { get; set; }
        public decimal Saida { get; set; }
        public string Observacao { get; set; }
        public bool Excluir { get; set; }

        public int CaixaID { get; set; }
        public int FormaPagamentoID { get; set; }
        public int? PedidoID { get; set; }

        public virtual Caixa Caixa { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
