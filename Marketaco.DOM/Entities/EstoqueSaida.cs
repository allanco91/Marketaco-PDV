using System;

namespace Marketaco.DOM.Entities
{
    public class EstoqueSaida
    {
        public int EstoqueSaidaID { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime Data { get; set; }
        public decimal? ValorUnitario { get; set; }
        public bool Venda { get; set; }

        public int EstoqueID { get; set; }

        public virtual Estoque Estoque { get; set; }
    }
}
