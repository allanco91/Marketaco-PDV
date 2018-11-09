namespace Marketaco.DOM.Entities
{
    using System.Collections.Generic;

    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal PrecoC { get; set; }
        public decimal PrecoV { get; set; }
        public bool Vendavel { get; set; }
        public bool ControlaEstoque { get; set; }

        public int UnidadeComID { get; set; }
        public int CategoriaID { get; set; }

        public virtual UnidadeCom UnidadeCom { get; set; }
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<ItensPedido> ItensPedido { get; set; }
        public virtual ICollection<Estoque> Estoque { get; set; }
    }
}
