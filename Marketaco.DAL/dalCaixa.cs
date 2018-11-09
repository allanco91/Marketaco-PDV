using System;
using System.Collections.Generic;
using System.Linq;
using Marketaco.DOM.Entities;

namespace Marketaco.DAL
{
    public class dalCaixa
    {
        public void abreCaixa(Caixa obj_caixa)
        {
            using (DataContext db = new DataContext())
            {
                try
                {
                    db.Caixas.Add(obj_caixa);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void fechaCaixa(Caixa obj_caixa)
        {
            DataContext db = new DataContext();

            var achaIdCai = db.Caixas.Where(c => c.Status == true).OrderByDescending(c => c.CaixaID).First();

            try
            {
                if (achaIdCai.Status == true)
                {
                    achaIdCai.Data_Fechamento = obj_caixa.Data_Fechamento;
                    achaIdCai.Status = obj_caixa.Status;

                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Caixa verificaCaixa()
        {
            using (DataContext db = new DataContext())
            {
                var i = db.Caixas.Where(c => c.Status == true).Count();

                if (i != 0)
                {
                    return db.Caixas.Where(c => c.Status == true).OrderByDescending(c => c.CaixaID).Take(1).SingleOrDefault();
                }
                return new Caixa { Status = false };
            }
        }

        public void atualizaCaixa(int id)
        {
            DataContext db = new DataContext();

            var achaCaixa = db.Caixas.SingleOrDefault(c => c.CaixaID == id);

            decimal e_dinhei = db.LancamentoCaixa.Where(lc => lc.FormaPagamentoID == 1 && lc.CaixaID == id).Count() > 0 ? db.LancamentoCaixa.Where(lc => lc.FormaPagamentoID == 1 && lc.CaixaID == id).Sum(lc => lc.Entrada) : 0;
            decimal c_debito = db.LancamentoCaixa.Where(lc => lc.FormaPagamentoID == 2 && lc.CaixaID == id).Count() > 0 ? db.LancamentoCaixa.Where(lc => lc.FormaPagamentoID == 2 && lc.CaixaID == id).Sum(lc => lc.Entrada) : 0;
            decimal c_credit = db.LancamentoCaixa.Where(lc => lc.FormaPagamentoID == 3 && lc.CaixaID == id).Count() > 0 ? db.LancamentoCaixa.Where(lc => lc.FormaPagamentoID == 3 && lc.CaixaID == id).Sum(lc => lc.Entrada) : 0;
            decimal e_cheque = db.LancamentoCaixa.Where(lc => lc.FormaPagamentoID == 4 && lc.CaixaID == id).Count() > 0 ? db.LancamentoCaixa.Where(lc => lc.FormaPagamentoID == 4 && lc.CaixaID == id).Sum(lc => lc.Entrada) : 0;

            decimal s_dinhei = db.LancamentoCaixa.Where(lc => lc.FormaPagamentoID == 1 && lc.CaixaID == id).Count() > 0 ? db.LancamentoCaixa.Where(lc => lc.FormaPagamentoID == 1 && lc.CaixaID == id).Sum(lc => lc.Saida) : 0;
            decimal s_cheque = db.LancamentoCaixa.Where(lc => lc.FormaPagamentoID == 4 && lc.CaixaID == id).Count() > 0 ? db.LancamentoCaixa.Where(lc => lc.FormaPagamentoID == 4 && lc.CaixaID == id).Sum(lc => lc.Saida) : 0;

            decimal saldo_dinhe = (achaCaixa.SaldoInicial + e_dinhei) - s_dinhei;
            decimal saldo_final = (saldo_dinhe + c_debito + c_credit + e_cheque) - s_cheque;

            if (achaCaixa != null)
            {
                try
                {
                    achaCaixa.E_Dinheiro = e_dinhei;
                    achaCaixa.C_Debito = c_debito;
                    achaCaixa.C_Credito = c_credit;
                    achaCaixa.E_Cheque = e_cheque;
                    achaCaixa.S_Dinheiro = s_dinhei;
                    achaCaixa.S_Cheque = s_cheque;
                    achaCaixa.SaldoDinheiro = saldo_dinhe;
                    achaCaixa.SaldoFinal = saldo_final;

                    db.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            
        }

        public class LCaixa
        {
            public int CaixaID { get; set; }
            public DateTime Data_Abertura { get; set; }
            public DateTime? Data_Fechamento { get; set; }
            public decimal SaldoInicial { get; set; }
            public decimal? SaldoFinal { get; set; }
            public decimal E_Dinheiro { get; set; }
            public decimal C_Debito { get; set; }
            public decimal C_Credito { get; set; }
            public decimal E_Cheque { get; set; }
            public decimal S_Dinheiro { get; set; }
            public decimal S_Cheque { get; set; }
            public decimal SaldoDinheiro { get; set; }
            public string Observacao { get; set; }
            public string Status { get; set; }
            public decimal TaxaC { get; set; }
            public decimal TaxaD { get; set; }
        }

        public List<LCaixa> listaCaixa(int numero)
        {
            using (DataContext db = new DataContext())
            {
                return db.Caixas.OrderByDescending(c => c.CaixaID)
                    .Take(numero)
                    .Select(c =>
                    new LCaixa
                    {
                        CaixaID = c.CaixaID,
                        Data_Abertura = c.Data_Abertura,
                        Data_Fechamento = c.Data_Fechamento,
                        SaldoInicial = c.SaldoInicial,
                        SaldoFinal = c.SaldoFinal,
                        E_Dinheiro = c.E_Dinheiro,
                        C_Debito = c.C_Debito,
                        C_Credito = c.C_Credito,
                        E_Cheque = c.E_Cheque,
                        S_Dinheiro = c.S_Dinheiro,
                        S_Cheque = c.S_Cheque,
                        SaldoDinheiro = c.SaldoDinheiro,
                        Observacao = c.Observacao,
                        Status = c.Status ? "Aberto" : "Fechado"
                    }).ToList();
            }
        }

        public List<LCaixa> listaCaixa(DateTime data1, DateTime data2)
        {
            DataContext db = new DataContext();

            DateTime DataFinal = data2.AddMinutes(1439.99);

            return db.Caixas.Where(c => c.Data_Abertura >= data1.Date && c.Data_Abertura <= DataFinal)
                .OrderByDescending(c => c.CaixaID)
                .Select(c =>
                new LCaixa
                {
                    CaixaID = c.CaixaID,
                    Data_Abertura = c.Data_Abertura,
                    Data_Fechamento = c.Data_Fechamento,
                    SaldoInicial = c.SaldoInicial,
                    SaldoFinal = c.SaldoFinal,
                    E_Dinheiro = c.E_Dinheiro,
                    C_Debito = c.C_Debito,
                    C_Credito = c.C_Credito,
                    E_Cheque = c.E_Cheque,
                    S_Dinheiro = c.S_Dinheiro,
                    S_Cheque = c.S_Cheque,
                    SaldoDinheiro = c.SaldoDinheiro,
                    Observacao = c.Observacao,
                    Status = c.Status ? "Aberto" : "Fechado"
                }).ToList();
        }

        public List<LCaixa> achaCaixa(int id)
        {
            using (DataContext db = new DataContext())
            {
                dalConfig conf = new dalConfig();
                decimal tc = Convert.ToDecimal(conf.retornaConfig("TaxaC"));
                decimal td = Convert.ToDecimal(conf.retornaConfig("TaxaD"));

                return db.Caixas.Where(c => c.CaixaID == id)
                    .Select(c =>
                    new LCaixa
                    {
                        CaixaID = c.CaixaID,
                        Data_Abertura = c.Data_Abertura,
                        Data_Fechamento = c.Data_Fechamento,
                        SaldoInicial = c.SaldoInicial,
                        SaldoFinal = c.SaldoFinal,
                        E_Dinheiro = c.E_Dinheiro,
                        C_Debito = c.C_Debito,
                        C_Credito = c.C_Credito,
                        E_Cheque = c.E_Cheque,
                        S_Dinheiro = c.S_Dinheiro,
                        S_Cheque = c.S_Cheque,
                        SaldoDinheiro = c.SaldoDinheiro,
                        Observacao = c.Observacao,
                        Status = c.Status ? "Aberto" : "Fechado",
                        TaxaC = tc,
                        TaxaD = td
                    }).ToList();
            }
        }

        /*return (from c in caixa
                    select c).Take(numero).OrderByDescending(ca => ca.Id).ToList();*/
        //return caixa.OrderByDescending(c => c.Id).Take(numero).ToList();
    }
}
