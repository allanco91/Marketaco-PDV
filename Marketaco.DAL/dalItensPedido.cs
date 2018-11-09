using System;
using System.Collections.Generic;
using System.Linq;
using Marketaco.DOM.Entities;

namespace Marketaco.DAL
{
    public class dalItensPedido
    {
        public class ItensCupom
        {
            public string produto { get; set; }
            public decimal quantidade { get; set; }
            public decimal valorUnit { get; set; }
            public decimal desconto { get; set; }
            public decimal valorTotal { get; set; }
            public string categoria { get; set; }
        }

        public List<ItensCupom> listaItensCupom(int PedidoID)
        {
            using (DataContext db = new DataContext())
            {
                return db.ItensPedidos.Where(ip => ip.PedidoID == PedidoID)
                    .OrderBy(ip => ip.ItensPedidoID)
                    .Select(ip => new ItensCupom
                    {
                        produto = ip.Produto.Nome,
                        quantidade = ip.Quantidade,
                        valorUnit = ip.ValorUnitario,
                        desconto = ip.Desconto * ip.Quantidade,
                        valorTotal = ip.ValorTotal,
                        categoria = ip.Produto.Categoria.Nome
                    }).ToList();
            }
        }

        public List<ItensPedido> listaItensPedidoPedID(int PedidoID)
        {
            using (DataContext db = new DataContext())
            {
                return db.ItensPedidos.Where(ip => ip.PedidoID == PedidoID).ToList();
            }
        }

        public bool contaProdutosPedido(int ProdutoID)
        {
            using (DataContext db = new DataContext())
            {
                var conta = db.ItensPedidos.Where(ip => ip.ProdutoID == ProdutoID).Count();
                if (conta == 0)
                    return true;
                else
                    return false;
            }
        }

        //Relatórios
        public class GrupoProdutos
        {
            public DateTime Data { get; set; }
            public string Produto { get; set; }
            public decimal Quantidade { get; set; }
            public decimal Valor { get; set; }
        }

        public class GrupoCategorias
        {
            public DateTime Data { get; set; }
            public string Categoria { get; set; }
            public decimal Quantidade { get; set; }
            public decimal Valor { get; set; }
        }

        public List<GrupoProdutos> ProdutosPorData(DateTime Data1, DateTime Data2, string nProduto)
        {
            using (DataContext db = new DataContext())
            {
                DateTime DataFinal = new DateTime(Data2.Year, Data2.Month, Data2.Day, 23, 59, 59);
                string[] Prod = nProduto.ToUpper().Split(',');
                List<GrupoProdutos> ListaP = new List<GrupoProdutos>();

                var L1 = db.ItensPedidos.Where(p => p.Data >= Data1.Date && p.Data <= DataFinal)
                    .OrderBy(p => p.Data).ThenBy(p => p.Produto.Nome)
                    .Select(p => new GrupoProdutos
                    {
                        Data = p.Data,
                        Produto = p.Produto.Nome,
                        Quantidade = p.Quantidade,
                        Valor = p.ValorTotal
                    }).ToList();

                var L2 = L1.GroupBy(p => new
                {
                    Data = new DateTime(p.Data.Year, p.Data.Month, p.Data.Day),
                    Produto = p.Produto
                })
                .Select(g => new GrupoProdutos
                {
                    Data = g.Key.Data,
                    Produto = g.Key.Produto,
                    Quantidade = g.Sum(x => x.Quantidade),
                    Valor = g.Sum(x => x.Valor)
                }).ToList();

                if (Prod != null && Prod.Length > 0)
                {
                    foreach (string Produto in Prod)
                    {
                        ListaP.AddRange(L2.Where(p => p.Produto.ToUpper().StartsWith(Produto)));
                        L2.RemoveAll(p => p.Produto.ToUpper().StartsWith(Produto));
                    }
                }

                return ListaP;
            }
        }

        public List<GrupoProdutos> TotalProdutosPorMes(DateTime Data1, DateTime Data2, string nProduto)
        {
            using (DataContext db = new DataContext())
            {
                DateTime DataInicial = new DateTime(Data1.Year, Data1.Month, 1);
                DateTime DataFinal = new DateTime(Data2.Year, Data2.Month, DateTime.DaysInMonth(Data2.Year, Data2.Month), 23, 59, 59);
                string[] Prod = nProduto.ToUpper().Split(',');
                List<GrupoProdutos> ListaP = new List<GrupoProdutos>();

                var L1 = db.ItensPedidos.Where(p => p.Data >= DataInicial && p.Data <= DataFinal)
                    .OrderBy(p => p.Data).ThenBy(p => p.Produto.Nome)
                    .Select(p => new GrupoProdutos
                    {
                        Data = p.Data,
                        Produto = p.Produto.Nome,
                        Quantidade = p.Quantidade,
                        Valor = p.ValorTotal
                    }).ToList();

                List<GrupoProdutos> L2 = L1.GroupBy(l => new { Data = new DateTime(l.Data.Year, l.Data.Month, 1), Produto = l.Produto })
                    .Select(g => new GrupoProdutos
                    {
                        Data = g.Key.Data,
                        Produto = g.Key.Produto,
                        Quantidade = g.Sum(x => x.Quantidade),
                        Valor = g.Sum(x => x.Valor)
                    }).ToList();
                    

                if (Prod != null && Prod.Length > 0)
                {
                    foreach (string Produto in Prod)
                    {
                        ListaP.AddRange(L2.Where(p => p.Produto.ToUpper().StartsWith(Produto)));
                        L2.RemoveAll(p => p.Produto.ToUpper().StartsWith(Produto));
                    }
                }

                return ListaP;
            }
        }

        public List<GrupoCategorias> CategoriasPorData(DateTime Data1, DateTime Data2, string nCategoria)
        {
            using (DataContext db = new DataContext())
            {
                DateTime DataFinal = new DateTime(Data2.Year, Data2.Month, DateTime.DaysInMonth(Data2.Year, Data2.Month), 23, 59, 59);
                string[] Cat = nCategoria.ToUpper().Split(',');
                List<GrupoCategorias> ListaC = new List<GrupoCategorias>();

                var L1 = db.ItensPedidos.Where(c => c.Data >= Data1.Date && c.Data <= DataFinal)
                    .OrderBy(c => c.Data).ThenBy(c => c.Produto.Categoria.Nome)
                    .Select(c => new GrupoCategorias
                    {
                        Data = c.Data,
                        Categoria = c.Produto.Categoria.Nome,
                        Quantidade = c.Quantidade,
                        Valor = c.ValorTotal
                    }).ToList();

                var L2 = L1.GroupBy(l => new
                {
                    Data = new DateTime(l.Data.Year, l.Data.Month, l.Data.Day),
                    Categoria = l.Categoria
                })
                .Select(g => new GrupoCategorias
                {
                    Data = g.Key.Data,
                    Categoria = g.Key.Categoria,
                    Quantidade = g.Sum(x => x.Quantidade),
                    Valor = g.Sum(x => x.Valor)
                }).ToList();

                if (Cat != null && Cat.Length > 0)
                {
                    foreach (string Categoria in Cat)
                    {
                        ListaC.AddRange(L2.Where(c => c.Categoria.ToUpper().StartsWith(Categoria)));
                        L2.RemoveAll(c => c.Categoria.ToUpper().StartsWith(Categoria));
                    }
                }

                return ListaC;
            }
        }

        public List<GrupoCategorias> TotalCategoriasPorMes(DateTime Data1, DateTime Data2, string nCategoria)
        {
            using (DataContext db = new DataContext())
            {
                DateTime DataInicial = new DateTime(Data1.Year, Data1.Month, 1);
                DateTime DataFinal = new DateTime(Data2.Year, Data2.Month, DateTime.DaysInMonth(Data2.Year, Data2.Month), 23, 59, 59);
                string[] Cat = nCategoria.ToUpper().Split(',');
                List<GrupoCategorias> ListaC = new List<GrupoCategorias>();

                var L1 = db.ItensPedidos.Where(c => c.Data >= DataInicial && c.Data <= DataFinal)
                    .OrderBy(c => c.Data).ThenBy(c => c.Produto.Categoria.Nome)
                    .Select(c => new GrupoCategorias
                    {
                        Data = c.Data,
                        Categoria = c.Produto.Categoria.Nome,
                        Quantidade = c.Quantidade,
                        Valor = c.ValorTotal
                    }).ToList();

                List<GrupoCategorias> L2 = L1.GroupBy(l => new { Data = new DateTime(l.Data.Year, l.Data.Month, 1), Categoria = l.Categoria })
                    .Select(g => new GrupoCategorias
                    {
                        Data = g.Key.Data,
                        Categoria = g.Key.Categoria,
                        Quantidade = g.Sum(x => x.Quantidade),
                        Valor = g.Sum(x => x.Valor)
                    }).ToList();

                if (Cat != null && Cat.Length > 0)
                {
                    foreach (string Categoria in Cat)
                    {
                        ListaC.AddRange(L2.Where(c => c.Categoria.ToUpper().StartsWith(Categoria)));
                        L2.RemoveAll(c => c.Categoria.ToUpper().StartsWith(Categoria));
                    }
                }

                return ListaC;
            }
        }




        //dalItenspedido old
        public class lvItensPedido
        {
            public int id { get; set; }
            public int id_produto { get; set; }
            public string nome { get; set; }
            public string categoria { get; set; }
            public decimal quantidade { get; set; }
            public decimal valor_unitario { get; set; }
            public decimal desconto { get; set; }
            public decimal subtotal { get; set; }
            public DateTime data { get; set; }
            public int ordem { get; set; }
        }

        public List<lvItensPedido> listaItensPedido(int id_pedido)
        {
            DataContext db = new DataContext();

            return db.ItensPedidos.Where(ip => ip.PedidoID == id_pedido)
                .OrderBy(ip => ip.Ordem)
                .Select(ip => new lvItensPedido
                {
                    id = ip.ItensPedidoID,
                    id_produto = ip.ProdutoID,
                    nome = ip.Produto.Nome,
                    categoria = ip.Produto.Categoria.Nome,
                    quantidade = ip.Quantidade,
                    valor_unitario = ip.ValorUnitario,
                    desconto = ip.Desconto,
                    subtotal = ip.ValorTotal,
                    data = ip.Data,
                    ordem = ip.Ordem
                }).ToList();
        }

        public List<lvItensPedido> listaItensPedidoDataProd(DateTime data1, DateTime data2, string produto)
        {
            DataContext db = new DataContext();

            DateTime DataFinal = data2.AddMinutes(1439.99);

            return db.ItensPedidos.Where(ip => ip.Data >= data1.Date && ip.Data <= DataFinal && ip.Produto.Nome.ToUpper().Contains(produto.ToUpper()))
                .OrderBy(ip => ip.Produto.Nome)
                .Select(ip => new lvItensPedido
                {
                    id = ip.ItensPedidoID,
                    id_produto = ip.ProdutoID,
                    nome = ip.Produto.Nome,
                    categoria = ip.Produto.Categoria.Nome,
                    quantidade = ip.Quantidade,
                    valor_unitario = ip.ValorUnitario,
                    desconto = ip.Desconto,
                    subtotal = ip.ValorTotal,
                    data = ip.Data,
                    ordem = ip.Ordem
                }).ToList();
        }

        public void insereItensPedido(ItensPedido obj_itenspedidos)
        {
            using (DataContext db = new DataContext())
            {
                var achaPed = db.Pedidos.Where(p => p.PedidoID == obj_itenspedidos.PedidoID && p.Status == true).Count();

                int numOrdem = 1;
                var Ordem = db.ItensPedidos.Where(ip => ip.PedidoID == obj_itenspedidos.PedidoID);

                if (Ordem.Count() > 0)
                {
                    numOrdem = Ordem.Max(o => o.Ordem) + 1;
                }

                if (achaPed > 0)
                {
                    try
                    {
                        ItensPedido iPed = new ItensPedido();
                        obj_itenspedidos.Ordem = numOrdem;

                        db.ItensPedidos.Add(obj_itenspedidos);
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public bool importaPedido(int id_pedido1, int id_pedido2)
        {
            try
            {
                DataContext db = new DataContext();
                var achaItens = db.ItensPedidos.Where(ip => ip.PedidoID == id_pedido2).OrderBy(ip => ip.Ordem).ToList();

                foreach (var importa in achaItens)
                {
                    var numOrdem = db.ItensPedidos.Where(ip => ip.PedidoID == id_pedido1).Count() + 1;
                    insereItensPedido(new ItensPedido
                    {
                        PedidoID = id_pedido1,
                        ProdutoID = importa.ProdutoID,
                        Quantidade = importa.Quantidade,
                        ValorUnitario = importa.ValorUnitario,
                        Desconto = importa.Desconto,
                        ValorTotal = importa.ValorTotal,
                        Data = importa.Data,
                        Ordem = numOrdem
                    });
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //atualiza a quantidade, valor unitario e valor total apenas
        public void atualizaItensPedido(ItensPedido obj_itenspedidos)
        {
            DataContext db = new DataContext();
            var achaPed = db.Pedidos.Where(p => p.PedidoID == obj_itenspedidos.PedidoID && p.Status == true).Count();

            if (achaPed > 0)
            {
                var achaIdItensPedido = db.ItensPedidos.Where(ip => ip.ItensPedidoID == obj_itenspedidos.ItensPedidoID && ip.PedidoID == obj_itenspedidos.PedidoID).SingleOrDefault();

                try
                {
                    if (achaIdItensPedido != null)
                    {
                        achaIdItensPedido.Quantidade = obj_itenspedidos.Quantidade;
                        achaIdItensPedido.ValorUnitario = obj_itenspedidos.ValorUnitario;
                        achaIdItensPedido.Desconto = obj_itenspedidos.Desconto;
                        achaIdItensPedido.ValorTotal = obj_itenspedidos.ValorTotal;

                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void deletaItensPedido(int codigo)
        {
            DataContext db = new DataContext();
            var achaIdIPed = db.ItensPedidos.Where(ip => ip.ItensPedidoID == codigo).SingleOrDefault();

            var achaPed = db.Pedidos.Where(p => p.PedidoID == achaIdIPed.PedidoID && p.Status == true).Count();

            if (achaPed > 0)
            {

                try
                {
                    db.ItensPedidos.Remove(achaIdIPed);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public decimal contadorBarcas()
        {
            try
            {
                decimal quantidade = 0;
                DataContext db = new DataContext();
                var barcas = db.ItensPedidos.Where(ip => ip.Produto.CategoriaID == 3);

                foreach (var ba in barcas)
                {
                    quantidade += ba.Quantidade;
                }

                return quantidade;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void mudaOrdem(int PedidoID, int ItensPedidoID1, int ItensPedidoID2)
        {
            try
            {
                DataContext db = new DataContext();
                var IP1 = db.ItensPedidos.Where(ip => ip.PedidoID == PedidoID && ip.ItensPedidoID == ItensPedidoID1).SingleOrDefault();
                var IP2 = db.ItensPedidos.Where(ip => ip.PedidoID == PedidoID && ip.ItensPedidoID == ItensPedidoID2).SingleOrDefault();

                int ID1 = IP1.Ordem;
                int ID2 = IP2.Ordem;

                IP1.Ordem = ID2;
                IP2.Ordem = ID1;

                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void atualizaOrdem(int PedidoID)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    int numOrdem = 1;
                    var listaItens = db.ItensPedidos.Where(ip => ip.PedidoID == PedidoID).OrderBy(ip => ip.ItensPedidoID).ToList();

                    foreach (ItensPedido item in listaItens)
                    {
                        item.Ordem = numOrdem;
                        numOrdem++;
                    }

                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
