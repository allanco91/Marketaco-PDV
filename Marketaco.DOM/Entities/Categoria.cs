namespace Marketaco.DOM.Entities
{
    using System.Collections.Generic;

    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
