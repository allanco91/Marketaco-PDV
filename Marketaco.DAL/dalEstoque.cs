using System;
using System.Collections.Generic;
using System.Linq;
using Marketaco.DOM.Entities;
using System.Data.Entity;

namespace Marketaco.DAL
{
    public class dalEstoque
    {
        public void Add(Estoque estoque)
        {
            using (DataContext db = new DataContext())
            {
                estoque.ProdutoID = db.Produtos.Max(p => p.ProdutoID);
                db.Estoques.Add(estoque);

                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void entrada(EstoqueEntrada e_estoque)
        {
            using (DataContext db = new DataContext())
            {
                db.EstoqueEntradas.Add(e_estoque);

               try
                {
                    db.SaveChanges();
                    atualiza(e_estoque.EstoqueID, e_estoque.Quantidade);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void saida(EstoqueSaida s_estoque)
        {
            using (DataContext db = new DataContext())
            {
                db.EstoqueSaidas.Add(s_estoque);

                try
                {
                    db.SaveChanges();
                    atualiza(s_estoque.EstoqueID, -s_estoque.Quantidade);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void atualiza(int EstoqueID, decimal Quantidade)
        {
            using (DataContext db = new DataContext())
            {
                Estoque estoque = db.Estoques.SingleOrDefault(e => e.EstoqueID == EstoqueID);

                try
                {
                    estoque.EstoqueAtu = estoque.EstoqueAtu + Quantidade;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool apagaEstoque(int ProdutoID)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    Estoque estoque = db.Estoques.SingleOrDefault(e => e.ProdutoID == ProdutoID);
                    var EE = db.EstoqueEntradas.Where(e => e.EstoqueID == estoque.EstoqueID);
                    var ES = db.EstoqueSaidas.Where(e => e.EstoqueID == estoque.EstoqueID);

                    db.EstoqueEntradas.RemoveRange(EE);
                    db.EstoqueSaidas.RemoveRange(ES);
                    db.Estoques.Remove(estoque);

                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void atualizaEstoque(Estoque obj_estoque)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    Estoque estoque = db.Estoques.SingleOrDefault(e => e.EstoqueID == obj_estoque.EstoqueID);
                    estoque.EstoqueMin = obj_estoque.EstoqueMin;
                    estoque.EstoqueIde = obj_estoque.EstoqueIde;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public Estoque Estoque(int ProdutoID)
        {
            using (DataContext db = new DataContext())
            {
                return db.Estoques.Where(e => e.ProdutoID == ProdutoID).SingleOrDefault();
            }
        }

        public List<GridEstoque> listaEstoque(string texto)
        {
            using (DataContext db = new DataContext())
            {
                return db.Estoques.Where(e => (e.Produto.Nome.ToUpper().StartsWith(texto.ToUpper()) || e.Produto.Codigo.ToUpper().StartsWith(texto.ToUpper())) && e.Produto.ControlaEstoque == true)
                    .OrderBy(e => e.EstoqueAtu).ThenBy(e => e.Produto.Nome)
                    .Select(e => new GridEstoque
                    {
                        EstoqueID = e.EstoqueID,
                        ProdutoID = e.ProdutoID,
                        Codigo = e.Produto.Codigo,
                        Nome = e.Produto.Nome,
                        EstoqueAtu = e.EstoqueAtu,
                        EstoqueMin = e.EstoqueMin,
                        EstoqueIde = e.EstoqueIde
                    }).ToList();
            }
        }

        public List<VEstoque> verificaEstoqueMin()
        {
            using (DataContext db = new DataContext())
            {
                return db.Estoques.Where(e => e.EstoqueAtu <= e.EstoqueMin && e.Produto.ControlaEstoque == true)
                    .Select(e => new VEstoque
                    {
                        Produto = e.Produto.Nome,
                        QtdM = e.EstoqueIde,
                        QtdA = e.EstoqueAtu
                    }).ToList();
            }
        }

        public class VEstoque
        {
            public string Produto { get; set; }
            public decimal QtdM { get; set; }
            public decimal QtdA { get; set; }
        }

        public class GridEstoque
        {
            public int EstoqueID { get; set; }
            public int ProdutoID { get; set; }
            public string Codigo { get; set; }
            public string Nome { get; set; }
            public decimal EstoqueAtu { get; set; }
            public decimal EstoqueMin { get; set; }
            public decimal EstoqueIde { get; set; }
        }

        //Relatórios
        public class RelEstoque
        {
            public string Categoria { get; set; }
            public string Produto { get; set; }
            public decimal MinIde { get; set; }
            public decimal Quantidade { get; set; }            
        }

        public class RelHistEstoque
        {
            public DateTime Data { get; set; }
            public string Produto { get; set; }
            public decimal Entrada { get; set; }
            public decimal Saida { get; set; }
        }

        public List<RelEstoque> relEstoqueConfCont(string nCategoria, bool Vendavel)
        {
            using (DataContext db = new DataContext())
            {
                string[] Cat = nCategoria.ToUpper().Split(',');
                List<RelEstoque> ListaE = new List<RelEstoque>();

                var L1 = db.Estoques.Where(e => e.Produto.Vendavel == Vendavel)
                    .Select(e => new RelEstoque
                {
                    Categoria = e.Produto.Categoria.Nome,
                    Produto = e.Produto.Nome,
                    Quantidade = e.EstoqueAtu
                }).ToList();

                if (Cat != null && Cat.Length > 0)
                {
                    foreach (string Categoria in Cat)
                    {
                        ListaE.AddRange(L1.Where(e => e.Categoria.StartsWith(Categoria)));
                        L1.RemoveAll(e => e.Categoria.StartsWith(Categoria));
                    }
                }

                return ListaE;
            }
        }

        public List<RelEstoque> relEstoqueProducao(string nCategoria, bool Vendavel)
        {
            using (DataContext db = new DataContext())
            {
                string[] Cat = nCategoria.ToUpper().Split(',');
                List<RelEstoque> ListaE = new List<RelEstoque>();

                var L1 = db.Estoques.Where(e => e.EstoqueAtu <= e.EstoqueIde && e.Produto.Vendavel == Vendavel)
                    .Select(e => new RelEstoque
                    {
                        Categoria = e.Produto.Categoria.Nome,
                        Produto = e.Produto.Nome,
                        MinIde = e.EstoqueIde,
                        Quantidade = e.EstoqueAtu
                    }).ToList();

                if (Cat != null && Cat.Length > 0)
                {
                    foreach (string Categoria in Cat)
                    {
                        ListaE.AddRange(L1.Where(e => e.Categoria.StartsWith(Categoria)));
                        L1.RemoveAll(e => e.Categoria.StartsWith(Categoria));
                    }
                }

                return ListaE;
            }
        }

        public List<RelEstoque> relEstoqueMin(string nCategoria, bool Vendavel)
        {
            using (DataContext db = new DataContext())
            {
                string[] Cat = nCategoria.ToUpper().Split(',');
                List<RelEstoque> ListaE = new List<RelEstoque>();

                var L1 = db.Estoques.Where(e => e.EstoqueAtu <= e.EstoqueMin && e.Produto.Vendavel == Vendavel)
                    .Select(e => new RelEstoque
                    {
                        Categoria = e.Produto.Categoria.Nome,
                        Produto = e.Produto.Nome,
                        MinIde = e.EstoqueMin,
                        Quantidade = e.EstoqueAtu,
                    }).ToList();

                if (Cat != null && Cat.Length > 0)
                {
                    foreach (string Categoria in Cat)
                    {
                        ListaE.AddRange(L1.Where(e => e.Categoria.StartsWith(Categoria)));
                        L1.RemoveAll(e => e.Categoria.StartsWith(Categoria));
                    }
                }

                return ListaE;
            }
        }

        public List<RelEstoque> relEstoqueIde(string nCategoria, bool Vendavel)
        {
            using (DataContext db = new DataContext())
            {
                string[] Cat = nCategoria.ToUpper().Split(',');
                List<RelEstoque> ListaE = new List<RelEstoque>();

                var L1 = db.Estoques.Where(e => e.EstoqueAtu >= e.EstoqueIde && e.Produto.Vendavel == Vendavel)
                    .Select(e => new RelEstoque
                    {
                        Categoria = e.Produto.Categoria.Nome,
                        Produto = e.Produto.Nome,
                        MinIde = e.EstoqueIde,
                        Quantidade = e.EstoqueAtu,
                    }).ToList();

                if (Cat != null && Cat.Length > 0)
                {
                    foreach (string Categoria in Cat)
                    {
                        ListaE.AddRange(L1.Where(e => e.Categoria.StartsWith(Categoria)));
                        L1.RemoveAll(e => e.Categoria.StartsWith(Categoria));
                    }
                }

                return ListaE;
            }
        }

        public List<RelHistEstoque> relHistoricoEntSai(DateTime Data1, DateTime Data2, string nProduto, bool Vendavel)
        {
            using (DataContext db = new DataContext())
            {
                DateTime DataFinal = new DateTime(Data2.Year, Data2.Month, Data2.Day, 23, 59, 59);
                string[] Prod = nProduto.ToUpper().Split(',');
                List<RelHistEstoque> ListaH = new List<RelHistEstoque>();

                var L1 = (from h in db.Estoques
                          join e in db.EstoqueEntradas on h.EstoqueID equals e.EstoqueID
                          where e.Data >= Data1.Date && e.Data <= DataFinal && h.Produto.Vendavel == Vendavel
                          select new RelHistEstoque
                          {
                              Data = e.Data,
                              Produto = h.Produto.Nome,
                              Entrada = e.Quantidade
                          }).ToList();

                var L2 = (from h in db.Estoques
                         join s in db.EstoqueSaidas on h.EstoqueID equals s.EstoqueID
                         where s.Data >= Data1.Date && s.Data <= DataFinal && h.Produto.Vendavel == Vendavel
                          select new RelHistEstoque
                         {
                             Data = s.Data,
                             Produto = h.Produto.Nome,
                             Saida = s.Quantidade
                         }).ToList();

                if (Prod != null && Prod.Length > 0)
                {
                    foreach (string Produto in Prod)
                    {
                        ListaH.AddRange(L1.Where(e => e.Produto.ToUpper().StartsWith(Produto)));
                        ListaH.AddRange(L2.Where(s => s.Produto.ToUpper().StartsWith(Produto)));

                        L1.RemoveAll(e => e.Produto.ToUpper().StartsWith(Produto));
                        L2.RemoveAll(s => s.Produto.ToUpper().StartsWith(Produto));
                    }
                }

                var Final = ListaH.GroupBy(l => new
                {
                    Data = new DateTime(l.Data.Year, l.Data.Month, l.Data.Day),
                    Produto = l.Produto
                })
                .OrderBy(g => g.Key.Data)
                .Select(g => new RelHistEstoque
                {
                    Data = g.Key.Data,
                    Produto = g.Key.Produto,
                    Entrada = g.Sum(x => x.Entrada),
                    Saida = g.Sum(x => x.Saida)
                }).ToList();

                return Final;
            }
        }
    }
}
