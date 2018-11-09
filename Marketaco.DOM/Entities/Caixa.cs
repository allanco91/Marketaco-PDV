namespace Marketaco.DOM.Entities
{
    using System;
    using System.Collections.Generic;

    public class Caixa
    {
        public int CaixaID { get; set; }
        public DateTime Data_Abertura { get; set; }
        public DateTime? Data_Fechamento { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal? SaldoFinal { get; set; }
        public decimal E_Dinheiro { get; set; }
        public decimal C_Debito { get; set; }
        public decimal C_Credito { get; set; }
        public decimal E_Cheque { get; set; }
        public decimal SaldoDinheiro { get; set; }
        public decimal S_Dinheiro { get; set; }
        public decimal S_Cheque { get; set; }
        public string Observacao { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<LancamentoCaixa> LancamentoCaixa { get; set; }
    }
}
