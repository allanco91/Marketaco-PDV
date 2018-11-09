using System;
using System.Collections.Generic;
using System.Linq;
using Marketaco.DOM.Entities;

namespace Marketaco.DAL
{
    public class dalPedido
    {
        public class PedidoSimples
        {
            public int PedidoID { get; set; }
            public string Nome { get; set; }
            public decimal Valor { get; set; }
            public decimal? ValorPago { get; set; }
            public decimal? Troco { get; set; }
            public bool Viagem { get; set; }
            public string Status { get; set; }
            public bool TaxaS { get; set; }
            public decimal VlTaxaS { get; set; }
            public decimal SubTotal { get; set; }
        }

        public class PedidoCupom
        {
            public string Nome { get; set; }
            public int NumPessoas { get; set; }
            public decimal SubTotal { get; set; }
            public decimal ValorTotal { get; set; }
            public decimal? VlPago { get; set; }
            public decimal? Troco { get; set; }
            public string FormaPagamento { get; set; }
            public bool Status { get; set; }
            public DateTime Data { get; set; }
            public bool Viagem { get; set; }
            public bool TaxaS { get; set; }
            public decimal VlTaxaS { get; set; }
        }

        public PedidoCupom PedidoImprimir(int PedidoID)
        {
            using (DataContext db = new DataContext())
            {
                dalLancamentosCaixa pagped = new dalLancamentosCaixa();
                string Formp = string.Join(", ", pagped.PagamentoCupom(PedidoID));

                PedidoCupom pcupom = db.Pedidos.Where(p => p.PedidoID == PedidoID)
                    .Select(p => new PedidoCupom
                    {
                        Nome = p.Nome,
                        NumPessoas = p.NumPessoas,
                        SubTotal = p.SubTotal,
                        ValorTotal = p.ValorTotal,
                        VlPago = p.ValorPago,
                        Troco = p.Troco,
                        Status = p.Status,
                        Data = p.Data,
                        Viagem = p.Viagem,
                        TaxaS = p.TaxaS,
                        VlTaxaS = p.VlTaxaS
                    }).SingleOrDefault();

                pcupom.FormaPagamento = Formp;

                return pcupom;
            }
        }

        public List<PedidoSimples> listaPedido_StatusPedidoID(bool StatusPedido)
        {
            using (DataContext db = new DataContext())
            {
                if (StatusPedido)
                {
                    return db.Pedidos.Where(p => p.Status == StatusPedido)
                        .OrderBy(p => p.PedidoID)
                        .Select(p => new PedidoSimples
                        {
                            PedidoID = p.PedidoID,
                            Nome = p.Nome,
                            Valor = p.ValorTotal,
                            ValorPago = p.ValorPago,
                            Troco = p.Troco,
                            Viagem = p.Viagem,
                            Status = p.Status ? "Aberto" : "Finalizado",
                            TaxaS = p.TaxaS,
                            VlTaxaS = p.VlTaxaS,
                            SubTotal = p.SubTotal
                        }).ToList();
                }
                else
                {
                    return db.Pedidos.Where(p => p.Status == StatusPedido)
                        .OrderByDescending(p => p.Data)
                        .Take(50)
                        .Select(p => new PedidoSimples
                        {
                            PedidoID = p.PedidoID,
                            Nome = p.Nome,
                            Valor = p.ValorTotal,
                            ValorPago = p.ValorPago,
                            Troco = p.Troco,
                            Viagem = p.Viagem,
                            Status = p.Status ? "Aberto" : "Finalizado",
                            TaxaS = p.TaxaS,
                            VlTaxaS = p.VlTaxaS,
                            SubTotal = p.SubTotal
                        }).ToList();
                }
            }
        }

        public void inserePedido(Pedido obj_pedido)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    db.Pedidos.Add(obj_pedido);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void atualizaStatus(int PedidoID, bool StatusPedido)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    Pedido pedido = db.Pedidos.SingleOrDefault(p => p.PedidoID == PedidoID);
                    pedido.Status = StatusPedido;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void deletaPedido(int PedidoID)
        {
            using (DataContext db = new DataContext())
            {
                //retorna em objeto ou entidade enumeravel os itens da consulta
                //var achaItens = db.ItensPedidos.Where(ip => ip.PedidoID == codigo).AsEnumerable();
                try
                {
                    //apaga os itens
                    var itens = db.ItensPedidos.Where(ip => ip.PedidoID == PedidoID);
                    db.ItensPedidos.RemoveRange(itens);
                    //apaga da tabela pedidopagamento
                    var pag = db.PedidoPagamentos.Where(pp => pp.PedidoID == PedidoID);
                    db.PedidoPagamentos.RemoveRange(pag);
                    //apaga os pagamentos
                    var pags = db.LancamentoCaixa.Where(p => p.PedidoID == PedidoID);
                    db.LancamentoCaixa.RemoveRange(pags);
                    //apaga o pedido
                    var ped = db.Pedidos.Where(p => p.PedidoID == PedidoID).SingleOrDefault();
                    db.Pedidos.Remove(ped);
                    //salva as alterações
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public decimal pedidosDia()
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    var somar = db.Pedidos.Where(p => p.Data >= DateTime.Today);
                    return somar.Sum(p => p.ValorTotal);
                }
                catch
                {
                    return 0;
                }
            }
        }

        public Pedido selecionaPedido(int PedidoID)
        {
            using (DataContext db = new DataContext())
            {
                return db.Pedidos.SingleOrDefault(p => p.PedidoID == PedidoID);
            }
        }

        public Pedido selecionaUltimoPedido()
        {
            using (DataContext db = new DataContext())
            {
                return db.Pedidos.OrderByDescending(p => p.PedidoID).Take(1).SingleOrDefault();
            }
        }

        //Relatórios

        //Total por mês
        public class GrupoMes
        {
            public DateTime Data { get; set; }
            public decimal Valor { get; set; }
        }

        public class GrupoEntrega
        {
            public DateTime Data { get; set; }
            public int Entregas { get; set; }
            public decimal Valor { get; set; }
        }

        public List<GrupoMes> VendaPorData(DateTime Data1, DateTime Data2)
        {
            using (DataContext db = new DataContext())
            {
                //Data2.Date.AddMinutes(1439.99);
                DateTime DataFinal = new DateTime(Data2.Year, Data2.Month, Data2.Day, 23, 59, 59);
                return db.Pedidos.Where(p => p.Data >= Data1.Date && p.Data <= DataFinal)
                    .ToList()
                    .GroupBy(p => new { Data = new DateTime(p.Data.Year, p.Data.Month, p.Data.Day) })
                    .OrderBy(p => p.Key.Data)
                    .Select(g => new GrupoMes
                    {
                        Data = g.Key.Data,
                        Valor = g.Sum(x => x.ValorTotal)
                    }).ToList();
            }
        }

        public List<GrupoMes> TotalPorMes(DateTime Data1, DateTime Data2)
        {
            using (DataContext db = new DataContext())
            {
                DateTime DataInicial = new DateTime(Data1.Year, Data1.Month, 1);
                DateTime DataFinal = new DateTime(Data2.Year, Data2.Month, DateTime.DaysInMonth(Data2.Year, Data2.Month), 23, 59, 59);
                return db.Pedidos.Where(p => p.Data >= DataInicial && p.Data <= DataFinal)
                    .ToList()
                    .GroupBy(p => new { Data = new DateTime(p.Data.Year, p.Data.Month, 1) })
                    .OrderBy(p => p.Key.Data)
                    .Select(g => new GrupoMes
                    {
                        Data = g.Key.Data,
                        Valor = g.Sum(x => x.ValorTotal)
                    }).ToList();
            }
        }


        ///dalpedido old

        public class listPedido
        {
            public int num_pedido { get; set; }
            public string nome { get; set; }
            public decimal valor_pedido { get; set; }
            public bool viagem { get; set; }
            public bool status { get; set; }
            public DateTime data { get; set; }
            public string forma_pag { get; set; }
            public decimal? valor_pago { get; set; }
            public decimal? troco { get; set; }
        }

        public class listPedidoSimple
        {
            public int num_pedido { get; set; }
            public string nome { get; set; }
            public decimal valor_pedido { get; set; }
        }

        public void atualizaPedido(Pedido obj_pedido)
        {
            DataContext db = new DataContext();

            var achaIdPed = db.Pedidos.Where(p => p.PedidoID == obj_pedido.PedidoID).SingleOrDefault();
            if (achaIdPed != null && achaIdPed.Status == true)
            {
                try
                {
                    achaIdPed.Nome = obj_pedido.Nome;
                    achaIdPed.Data = obj_pedido.Data;
                    achaIdPed.SubTotal = obj_pedido.SubTotal;
                    achaIdPed.ValorTotal = obj_pedido.ValorTotal;
                    achaIdPed.NumPessoas = obj_pedido.NumPessoas;
                    achaIdPed.Viagem = obj_pedido.Viagem;
                    achaIdPed.TaxaS = obj_pedido.TaxaS;
                    achaIdPed.VlTaxaS = obj_pedido.VlTaxaS;

                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void atualizaPedidoPAG(Pedido obj_pedido)
        {
            DataContext db = new DataContext();

            var achaIdPed = db.Pedidos.Where(p => p.PedidoID == obj_pedido.PedidoID).SingleOrDefault();
            if (achaIdPed != null && achaIdPed.Status == true)
            {
                try
                {
                    achaIdPed.ValorTotal = obj_pedido.ValorTotal;
                    achaIdPed.TaxaS = obj_pedido.TaxaS;
                    achaIdPed.VlTaxaS = obj_pedido.VlTaxaS;

                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void baixaPedido(int PedidoID, decimal valor_pago, decimal troco)
        {
            using (DataContext db = new DataContext())
            {
                dalItensPedido iped = new dalItensPedido();
                dalEstoque dalEst = new dalEstoque();
                dalProduto prod = new dalProduto();

                var itens = iped.listaItensPedidoPedID(PedidoID);

                var achaIdPed = db.Pedidos.Where(p => p.PedidoID == PedidoID).SingleOrDefault();
                if (achaIdPed != null)
                {
                    try
                    {
                        foreach (var item in itens)
                        {
                            if (prod.selecionaProduto(item.ProdutoID).ControlaEstoque == true)
                            {
                                EstoqueSaida saida = new EstoqueSaida
                                {
                                    Data = DateTime.Now,
                                    Quantidade = item.Quantidade,
                                    ValorUnitario = item.ValorUnitario,
                                    Venda = true,
                                    EstoqueID = dalEst.Estoque(item.ProdutoID).EstoqueID
                                };

                                dalEst.saida(saida);
                            }
                        }

                        achaIdPed.Status = false;
                        achaIdPed.ValorPago = valor_pago;
                        achaIdPed.Troco = troco;
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public void ativaPedido(int PedidoID)
        {
            using (DataContext db = new DataContext())
            {
                dalItensPedido iped = new dalItensPedido();
                dalEstoque dalEst = new dalEstoque();

                var itens = iped.listaItensPedidoPedID(PedidoID);


                var achaIdPed = db.Pedidos.Where(p => p.PedidoID == PedidoID).SingleOrDefault();
                if (achaIdPed != null && achaIdPed.Status == false)
                {
                    try
                    {
                        foreach (var item in itens)
                        {
                            EstoqueEntrada entrada = new EstoqueEntrada
                            {
                                Data = DateTime.Now,
                                Quantidade = item.Quantidade,
                                EstoqueID = dalEst.Estoque(item.ProdutoID).EstoqueID
                            };

                            dalEst.entrada(entrada);
                        }

                        achaIdPed.Status = true;
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        /*public void deletaPedido(int codigo)
        {
            DataContext db = new DataContext();

            //retorna em objeto ou entidade enumeravel os itens da consulta
            var achaItens = db.ItensPedidos.Where(ip => ip.PedidoID == codigo).AsEnumerable();
            var achaPed = db.Pedidos.Where(p => p.PedidoID == codigo).SingleOrDefault();

            if (achaPed.Status == true)
            {
                if (achaItens.Count() > 0)
                {
                    try
                    {
                        //apaga os itens
                        db.ItensPedidos.RemoveRange(achaItens);

                        //apaga o pedido
                        db.Pedidos.Remove(achaPed);
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    try
                    {
                        //somente apaga o pedido
                        db.Pedidos.Remove(achaPed);
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        public decimal pedidosDia()
        {
            DataContext db = new DataContext();
            var somar = db.Pedidos.Where(p => p.Data >= DateTime.Today).ToList();

            if (somar.Count > 0)
            {
                return somar.Sum(p => p.ValorTotal);
            }
            else
            {
                return 0;
            }
        }

        public Pedido selecionaUltimoPedido()
        {
            DataContext db = new DataContext();
            return db.Pedidos.OrderByDescending(p => p.PedidoID).First();
        }*/

        public decimal pedidosDiaSemIngresso()
        {
            using (DataContext db = new DataContext())
            {
                var somar = db.ItensPedidos.Where(p => p.Data >= DateTime.Today && p.Produto.CategoriaID != 10).ToList();

                if (somar.Count > 0)
                {
                    return somar.Sum(p => p.ValorTotal);
                }
                else
                {
                    return 0;
                }
            }
        }

        public List<listPedido> listaPedidos(bool status)
        {
            DataContext db = new DataContext();

            return db.Pedidos.Where(p => p.Status == status)
                .OrderByDescending(p => p.PedidoID)
                .Take(100)
                .Select(p =>
                new listPedido
                {
                    num_pedido = p.PedidoID,
                    nome = p.Nome,
                    valor_pedido = p.ValorTotal,
                    viagem = p.Viagem,
                    status = p.Status,
                    data = p.Data,
                    forma_pag = p.LancamentoCaixa.Where(f => f.PedidoID == p.PedidoID).FirstOrDefault().FormaPagamento.Nome,
                    troco = p.Troco,
                    valor_pago = p.ValorPago
                }).ToList();
        }

        public List<listPedidoSimple> listaPedidosSimples(int id, string nome)
        {
            DataContext db = new DataContext();

            return db.Pedidos.Where(p => p.Status == true && p.Nome.ToUpper().Contains(nome.ToUpper()) && p.PedidoID != id)
                .OrderByDescending(p => p.PedidoID)
                .Select(p =>
                new listPedidoSimple
                {
                    num_pedido = p.PedidoID,
                    nome = p.Nome,
                    valor_pedido = p.ValorTotal
                }).ToList();
        }
    }
}