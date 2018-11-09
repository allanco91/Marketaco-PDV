namespace Marketaco.DOM.Entities
{
    using System.Collections.Generic;

    public partial class UnidadeCom
    {
        public int UnidadeComID { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
