using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Marketaco.DOM.Entities;

namespace Marketaco.DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Caixa> Caixas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<ItensPedido> ItensPedidos { get; set; }
        public DbSet<LancamentoCaixa> LancamentoCaixa { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<UnidadeCom> UnidadeComs { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<EstoqueEntrada> EstoqueEntradas { get; set; }
        public DbSet<EstoqueSaida> EstoqueSaidas { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Operador> Operadores { get; set; }
        public DbSet<Logs> Log { get; set; }
        public DbSet<PedidoPagamento> PedidoPagamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Caixa>().ToTable("Caixa", "public");
            modelBuilder.Entity<Categoria>().ToTable("Categoria", "public");
            modelBuilder.Entity<FormaPagamento>().ToTable("FormaPagamento", "public");
            modelBuilder.Entity<ItensPedido>().ToTable("ItensPedido", "public");
            modelBuilder.Entity<LancamentoCaixa>().ToTable("LancamentoCaixa", "public");
            modelBuilder.Entity<Pedido>().ToTable("Pedido", "public");
            modelBuilder.Entity<Produto>().ToTable("Produto", "public");
            modelBuilder.Entity<UnidadeCom>().ToTable("UnidadeCom", "public");
            modelBuilder.Entity<Estoque>().ToTable("Estoque", "public");
            modelBuilder.Entity<EstoqueEntrada>().ToTable("EstoqueEntrada", "public");
            modelBuilder.Entity<EstoqueSaida>().ToTable("EstoqueSaida", "public");
            modelBuilder.Entity<Empresa>().ToTable("Empresa", "public");
            modelBuilder.Entity<Operador>().ToTable("Operador", "public");
            modelBuilder.Entity<Logs>().ToTable("Logs", "public");
            modelBuilder.Entity<PedidoPagamento>().ToTable("PedidoPagamento", "public");

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
