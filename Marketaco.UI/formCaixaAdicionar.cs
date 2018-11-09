using System;
using System.Windows.Forms;
using Marketaco.DAL;
using Marketaco.DOM.Entities;

namespace Marketaco.UI
{
    public partial class formCaixaAdicionar : Form
    {
        public formCaixaAdicionar()
        {
            InitializeComponent();
        }

        #region Métodos
        private void lancaMovCaixa(string descricao, decimal entrada, decimal saida, int forma_pagamento, string observacao)
        {
            dalLancamentosCaixa dalLCaixa = new dalLancamentosCaixa();
            dalLCaixa.lancaMovimento(new LancamentoCaixa
            {
                CaixaID = dalCaixa.verificaCaixa().CaixaID,
                Data = DateTime.Now,
                Descricao = descricao,
                Entrada = entrada,
                Saida = saida,
                FormaPagamentoID = forma_pagamento,
                Observacao = observacao,
                Excluir = true
            });
        }
        #endregion

        #region Eventos
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbValor.Text))
            {
                string descricao, observacao = tbObservacao.Text;
                decimal entrada = 0, saida = 0;
                int forma_pagamento = rbDinheiro.Checked ? 1 : 4;
                string acao;

                if (rbSaidaSangria.Checked)
                {
                    descricao = "Saída - Sangria";
                    saida = Convert.ToDecimal(tbValor.Text);
                    acao = "Lançou uma Retirada/Sangria Valor de R$" + tbValor.Text;
                }
                else if (rbSaidaPag.Checked)
                {
                    descricao = "Saída - Pagamentos";
                    saida = Convert.ToDecimal(tbValor.Text);
                    acao = "Lançou uma Retirada p/ pagamentos Valor de R$" + tbValor.Text;
                }
                else
                {
                    descricao = "Entrada - Acréscimo";
                    entrada = Convert.ToDecimal(tbValor.Text);
                    acao = "Lançou um Depósito Valor de R$" + tbValor.Text;
                }

                lancaMovCaixa(descricao, entrada, saida, forma_pagamento, observacao);
                dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, acao);
                Close();
            }
        }
        #endregion

        #region Textbox Números
        public static void AllowNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1) ||
                (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf('.') > -1) ||
                (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf(',') > -1) ||
                (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textboxNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(sender, e);
        }

        private void textboxNumeros_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as TextBox).Text))
            {
                string muda = (sender as TextBox).Text.Replace('.', ',');
                (sender as TextBox).Text = string.Format("{0:N}", Convert.ToDecimal(muda));
            }
        }
        #endregion

        #region KeyDown
        private void formCaixaAdicionar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        #endregion

        private void tbValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSalvar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void tbObservacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSalvar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
