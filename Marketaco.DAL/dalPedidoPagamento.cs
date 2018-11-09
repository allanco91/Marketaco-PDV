using System;
using System.Collections.Generic;
using System.Linq;
using Marketaco.DOM.Entities;

namespace Marketaco.DAL
{
    public class dalPedidoPagamento
    {
        public class PPag
        {
            public int ID { get; set; }
            public int FormaPagamentoID { get; set; }
            public DateTime Data { get; set; }
            public string FormaP { get; set; }
            public decimal Valor { get; set; }
        }

        public void Add(PedidoPagamento pag)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    db.PedidoPagamentos.Add(pag);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void Remove(int PedidoPagamentoID)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    PedidoPagamento pag = db.PedidoPagamentos.Single(pp => pp.PedidoPagamentoID == PedidoPagamentoID);
                    db.PedidoPagamentos.Remove(pag);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<PPag> listaPagamentos(int PedidoID)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    return db.PedidoPagamentos.Where(pp => pp.PedidoID == PedidoID)
                        .Select(pp => new PPag
                        {
                            ID = pp.PedidoPagamentoID,
                            FormaPagamentoID = pp.FormaPagamentoID,
                            Data = pp.Data,
                            FormaP = pp.FormaPagamento.Nome,
                            Valor = pp.Valor
                        }).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public decimal PagamentoPedido(int PedidoID)
        {
            using (DataContext db = new DataContext())
            {
                decimal vl = 0;
                try
                {
                    foreach(var lala in db.PedidoPagamentos.Where(pp => pp.PedidoID == PedidoID))
                    {
                        vl += lala.Valor;
                    }

                    return vl;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
