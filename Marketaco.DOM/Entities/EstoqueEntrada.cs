using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketaco.DOM.Entities
{
    public class EstoqueEntrada
    {
        public int EstoqueEntradaID { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime Data { get; set; }

        public int EstoqueID { get; set; }

        public virtual Estoque Estoque { get; set; }
    }
}
