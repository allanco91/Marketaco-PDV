using System.Collections.Generic;

namespace Marketaco.DOM.Entities
{
    public class Estoque
    {
        public int EstoqueID { get; set; }
        public decimal EstoqueAtu { get; set; }
        public decimal EstoqueMin { get; set; }
        public decimal EstoqueIde { get; set; }

        public int ProdutoID { get; set; }

        public virtual Produto Produto { get; set; }

        public virtual ICollection<EstoqueEntrada> EstoqueEntrada { get; set; }
        public virtual ICollection<EstoqueSaida> EstoqueSaida { get; set; }
    }
}
