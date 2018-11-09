using System;
using System.Collections.Generic;
using System.Linq;
using Marketaco.DOM.Entities;

namespace Marketaco.DAL
{
    public class dalLancamentosCaixa
    {
        public class LCaixa
        {
            public int id { get; set; }
            public DateTime data_hora { get; set; }
            public string descricao { get; set; }
            public decimal entrada { get; set; }
            public decimal saida { get; set; }
            public string forma_pagamento { get; set; }
            public string observacao { get; set; }
            public bool excluir { get; set; }
        }

        public class Pagamentos
        {
            public int PagamentoID { get; set; }
            public int FormaPagamentoID { get; set; }
            public DateTime Data { get; set; }
            public string FormaPagamento { get; set; }
            public decimal Valor { get; set; }
        }

        //Lista do Grid do form PedidoReceber
        public List<Pagamentos> listaPagamentos(int PedidoID)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    return db.LancamentoCaixa.Where(p => p.PedidoID == PedidoID)
                        .Select(p => new Pagamentos
                        {
                            PagamentoID = p.LancamentoCaixaID,
                            FormaPagamentoID = p.FormaPagamentoID,
                            Data = p.Data,
                            FormaPagamento = p.FormaPagamento.Nome,
                            Valor = p.Entrada
                        }).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<string> PagamentoCupom(int PedidoID)
        {
            using (DataContext db = new DataContext())
            {
                return db.LancamentoCaixa.Where(p => p.PedidoID == PedidoID).Select(p => p.FormaPagamento.Nome).ToList();
            }
        }

        public List<LCaixa> listaMovimento(int id_caixa)
        {
            DataContext db = new DataContext();

            return db.LancamentoCaixa.Where(lc => lc.CaixaID == id_caixa)
                .OrderBy(lc => lc.LancamentoCaixaID)
                .Select(lc =>
                new LCaixa
                {
                    id = lc.LancamentoCaixaID,
                    data_hora = lc.Data,
                    descricao = lc.Descricao,
                    entrada = lc.Entrada,
                    saida = lc.Saida,
                    forma_pagamento = lc.FormaPagamento.Nome,
                    observacao = lc.Observacao,
                    excluir = lc.Excluir
                }).ToList();
        }

        public void lancaMovimento(LancamentoCaixa obj_lcaixa)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    db.LancamentoCaixa.Add(obj_lcaixa);
                    db.SaveChanges();

                    dalCaixa dalCa = new dalCaixa();
                    dalCa.atualizaCaixa(obj_lcaixa.CaixaID);
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }

        public void excluirMovimento(int id)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    LancamentoCaixa del = db.LancamentoCaixa.SingleOrDefault(p => p.LancamentoCaixaID == id);

                    db.LancamentoCaixa.Remove(del);
                    db.SaveChanges();

                    dalCaixa dalCa = new dalCaixa();
                    dalCa.atualizaCaixa(del.CaixaID);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool excluirAtivarPedido(int PedidoID)
        {
            DateTime DataInicial = DateTime.Now.Date;
            DateTime DataFinal = DateTime.Now.Date.AddMinutes(1439.99);

            try
            {
                DataContext db = new DataContext();

                var achaIdLanc = db.LancamentoCaixa.Where(lc => lc.PedidoID == PedidoID).ToList();

                if (achaIdLanc.FirstOrDefault().Data >= DataInicial && achaIdLanc.FirstOrDefault().Data <= DataFinal)
                {
                    if (dalCaixa.verificaCaixa().Status == true)
                    {
                        db.LancamentoCaixa.RemoveRange(achaIdLanc);
                        db.SaveChanges();

                        dalCaixa dalCa = new dalCaixa();
                        dalCa.atualizaCaixa(dalCaixa.verificaCaixa().CaixaID);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}