using System;
using System.Collections.Generic;
using System.Linq;
using Marketaco.DOM.Entities;
using System.Data.Entity;

namespace Marketaco.DAL
{
    public class dalProduto
    {
        public void insereProduto(Produto obj_produto)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    db.Produtos.Add(obj_produto);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void atualizaProduto(Produto obj_produto)
        {
            using (DataContext db = new DataContext())
            {
                db.Produtos.Attach(obj_produto);
                db.Entry(obj_produto).State = EntityState.Modified;

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

        public bool deletaProduto(int id)
        {
            using (DataContext db = new DataContext())
            {
                dalItensPedido iped = new dalItensPedido();
                dalEstoque est = new dalEstoque();

                if (iped.contaProdutosPedido(id))
                {
                    if (est.apagaEstoque(id))
                    {
                        try
                        {
                            Produto del_prod = db.Produtos.Single(p => p.ProdutoID == id);
                            db.Produtos.Remove(del_prod);

                            db.SaveChanges();
                            return true;
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
        }

        public bool verificaCodigo(Produto obj_produto)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    if (!string.IsNullOrEmpty(obj_produto.Codigo))
                    {
                        int verif = db.Produtos.Count(p => p.Codigo == obj_produto.Codigo && p.ProdutoID != obj_produto.ProdutoID);

                        if (verif > 0)
                            return false;
                        else
                            return true;
                    }
                    else
                        return true;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }

        public class consultaProduto
        {
            public int id { get; set; }
            public string codigo { get; set; }
            public string nome { get; set; }
            public string categoria { get; set; }
            public decimal? preco { get; set; }
        }

        public class GridProdutoADD
        {
            public int ProdutoID { get; set; }
            public string Codigo { get; set; }
            public string Nome { get; set; }
            public decimal? Preco { get; set; }
            public int CategoriaID { get; set; }
        }

        public List<GridProdutoADD> listaProdutoGridADD_Nome(string nome)
        {
            using (DataContext db = new DataContext())
            {
                return db.Produtos.Where(p => p.Nome.ToUpper().Contains(nome.ToUpper()) && p.Vendavel == true)
                .OrderBy(p => p.Nome)
                .Select(p => new GridProdutoADD
                {
                    ProdutoID = p.ProdutoID,
                    Codigo = p.Codigo,
                    Nome = p.Nome,
                    Preco = p.PrecoV,
                    CategoriaID = p.CategoriaID
                }).ToList();
            }
        }

        public List<GridProdutoADD> listaProdutoGridADD_Codigo(string codigo)
        {
            using (DataContext db = new DataContext())
            {
                return db.Produtos.Where(p => p.Codigo.ToUpper().Contains(codigo.ToUpper()) && p.Vendavel == true)
                .OrderBy(p => p.Codigo)
                .Select(p => new GridProdutoADD
                {
                    ProdutoID = p.ProdutoID,
                    Codigo = p.Codigo,
                    Nome = p.Nome,
                    Preco = p.PrecoV,
                    CategoriaID = p.CategoriaID
                }).ToList();
            }
        }

        public Produto listaProdutoID(int codigo)
        {
            using (DataContext db = new DataContext())
            {

                return (from p in db.Produtos
                        where p.ProdutoID == codigo
                        select p).SingleOrDefault();
            }
        }

        public List<consultaProduto> listaProdutosGeral(string texto, bool vendavel)
        {
            using (DataContext db = new DataContext())
            {
                return db.Produtos.Where(p => (p.Codigo.ToUpper().Contains(texto.ToUpper()) || p.Nome.ToUpper().Contains(texto.ToUpper())) && p.Vendavel == vendavel)
                .OrderBy(p => p.Codigo)
                .Select(p => new consultaProduto
                {
                    id = p.ProdutoID,
                    codigo = p.Codigo,
                    nome = p.Nome,
                    categoria = p.Categoria.Nome,
                    preco = p.PrecoV
                }).ToList();
            }
        }

        public List<consultaProduto> listaProdutosCodigo(string codigo, bool estoque, bool vendavel)
        {
            using (DataContext db = new DataContext())
            {

                return db.Produtos.Where(p => p.Codigo.ToUpper().Contains(codigo.ToUpper()) && p.ControlaEstoque == estoque && p.Vendavel == vendavel)
                .OrderBy(p => p.Codigo)
                .Select(p => new consultaProduto
                {
                    id = p.ProdutoID,
                    codigo = p.Codigo,
                    nome = p.Nome,
                    categoria = p.Categoria.Nome,
                    preco = p.PrecoV
                }).ToList();
            }
        }

        public List<consultaProduto> listaProdutosNome(string nome, bool estoque, bool vendavel)
        {
            DataContext db = new DataContext();

            return db.Produtos.Where(p => p.Nome.ToUpper().Contains(nome.ToUpper()) && p.ControlaEstoque == estoque && p.Vendavel == vendavel)
                .OrderBy(p => p.Nome)
                .Select(p => new consultaProduto
                {
                    id = p.ProdutoID,
                    codigo = p.Codigo,
                    nome = p.Nome,
                    categoria = p.Categoria.Nome,
                    preco = p.PrecoV
                }).ToList();
        }

        public Produto selecionaProduto(int ProdutoID)
        {
            using (DataContext db = new DataContext())
            {
                return db.Produtos.Single(p => p.ProdutoID == ProdutoID);
            }
        }

        //Relatórios
        public class RelProdutos
        {
            public string Categoria { get; set; }
            public string Codigo { get; set; }
            public string Produto { get; set; }
            public decimal ValorC { get; set; }
            public decimal ValorV { get; set; }
            public decimal Plucro { get; set; }
            
        }

        public List<RelProdutos> listaProdutos(string nCategoria, bool Vendavel)
        {
            using (DataContext db = new DataContext())
            {
                string[] Cat = nCategoria.ToUpper().Split(',');
                List<RelProdutos> ListaP = new List<RelProdutos>();

                var L1 = db.Produtos.Where(p => p.Vendavel == Vendavel)
                    .OrderBy(p => p.Categoria.Nome).ThenBy(p => p.Nome)
                    .Select(p => new RelProdutos
                    {
                        Categoria = p.Categoria.Nome,
                        Codigo = p.Codigo,
                        Produto = p.Nome,
                        ValorC = p.PrecoC,
                        ValorV = p.PrecoV,
                        Plucro = p.PrecoV - p.PrecoC
                    }).ToList();

                var L2 = L1.Select(p => new RelProdutos
                {
                    Categoria = p.Categoria,
                    Codigo = p.Codigo,
                    Produto = p.Produto,
                    ValorC = p.ValorC,
                    ValorV = p.ValorV,
                    Plucro = p.ValorC == 0 ? 0 : p.Plucro / p.ValorC
                }).ToList();

                if (Cat != null && Cat.Length > 0)
                {
                    foreach (string Categoria in Cat)
                    {
                        ListaP.AddRange(L2.Where(p => p.Categoria.StartsWith(Categoria)));
                        L2.RemoveAll(p => p.Categoria.StartsWith(Categoria));
                    }
                }

                return ListaP;
            }
        }

        //dalproduto old

        /*public void insereProduto(Produto obj_produto)
        {
            try
            {
                DataContext db = new DataContext();
                Produto prod = new Produto();

                prod.Codigo = obj_produto.Codigo;
                prod.Nome = obj_produto.Nome;
                prod.PrecoCusto = obj_produto.PrecoCusto;
                prod.PrecoVenda = obj_produto.PrecoVenda;
                prod.Estoque = obj_produto.Estoque;
                prod.EstoqueMinimo = obj_produto.EstoqueMinimo;
                prod.EstoqueAtual = obj_produto.EstoqueAtual;

                prod.UnidadeComID = obj_produto.UnidadeComID;
                prod.CategoriaID = obj_produto.CategoriaID;

                db.Produtos.Add(prod);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void atualizaProduto(Produto obj_produto)
        {
            DataContext db = new DataContext();

            var achaIdProd = (from p in db.Produtos
                              where p.ProdutoID == obj_produto.ProdutoID
                              select p).SingleOrDefault();
            try
            {
                if (achaIdProd != null)
                {
                    achaIdProd.Codigo = obj_produto.Codigo;
                    achaIdProd.Nome = obj_produto.Nome;
                    achaIdProd.PrecoCusto = obj_produto.PrecoCusto;
                    achaIdProd.PrecoVenda = obj_produto.PrecoVenda;
                    achaIdProd.Estoque = obj_produto.Estoque;
                    achaIdProd.EstoqueMinimo = obj_produto.EstoqueMinimo;
                    achaIdProd.EstoqueAtual = obj_produto.EstoqueAtual;

                    achaIdProd.UnidadeComID = obj_produto.UnidadeComID;
                    achaIdProd.CategoriaID = obj_produto.CategoriaID;

                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool deletaProduto(int codigo)
        {
            DataContext db = new DataContext();

            int i = (from ip in db.ItensPedidos
                     where ip.ProdutoID == codigo
                     select ip).Count();

            if (i == 0)
            {
                var achaIdPro = (from p in db.Produtos
                                 where p.ProdutoID == codigo
                                 select p).SingleOrDefault();
                try
                {
                    db.Produtos.Remove(achaIdPro);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return false;
            }
        }*/

        /*public class consultaProduto
        {
            public int id { get; set; }
            public string codigo { get; set; }
            public string nome { get; set; }
            public string categoria { get; set; }
            public decimal? preco_venda { get; set; }
            public decimal? estoque_min { get; set; }
            public decimal? estoque_atual { get; set; }
        }*/

        public class consultaProduto2
        {
            public int id { get; set; }
            public string codigo { get; set; }
            public string nome { get; set; }
            public decimal? preco_venda { get; set; }
        }


        public List<Produto> listaProdutos()
        {
            DataContext db = new DataContext();

            return (from prod in db.Produtos
                    select prod).ToList();
        }

        /*public List<consultaProduto> listaProdutosC()
        {
            DataContext db = new DataContext();

            return (from p in db.Produtos
                    select new consultaProduto
                    {
                        id = p.ProdutoID,
                        codigo = p.Codigo,
                        nome = p.Nome,
                        categoria = p.Categoria.Nome,
                        preco_venda = p.PrecoVenda,
                        estoque_min = p.EstoqueMinimo,
                        estoque_atual = p.EstoqueAtual,
                    }).ToList();
        }

        public List<consultaProduto> listaProdutosNome(string nome)
        {
            DataContext db = new DataContext();

            return db.Produtos.Where(p => p.Nome.ToUpper().Contains(nome.ToUpper()))
                .Select(p => new consultaProduto
                {
                    id = p.ProdutoID,
                    codigo = p.Codigo,
                    nome = p.Nome,
                    categoria = p.Categoria.Nome,
                    preco_venda = p.PrecoVenda,
                    estoque_min = p.EstoqueMinimo,
                    estoque_atual = p.EstoqueAtual,
                }).ToList();
        }*/

        public List<consultaProduto2> listaProdutosAddProd(string nome)
        {
            using (DataContext db = new DataContext())
            {
                return db.Produtos.Where(p => p.Nome.ToUpper().Contains(nome.ToUpper()) && p.Vendavel == true || p.Codigo.ToUpper().Contains(nome.ToUpper()) && p.Vendavel == true)
                    .OrderBy(p => p.ProdutoID)
                    .Select(p => new consultaProduto2
                    {
                        id = p.ProdutoID,
                        codigo = p.Codigo,
                        nome = p.Nome,
                        preco_venda = p.PrecoV,
                    }).ToList();
            }
        }

        public List<Produto> listaProdutosAddProd2()
        {
            using (DataContext db = new DataContext())
            {
                return db.Produtos.Where(p => p.Vendavel == true).OrderBy(p => p.Nome).ToList();
            }
        }
    }
}