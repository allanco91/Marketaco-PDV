using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Marketaco.DAL;
using Marketaco.DOM.Entities;
using System.Drawing;

namespace Marketaco.UI
{
    public partial class formPedidoPag : Form
    {
        public formPedidoPag()
        {
            InitializeComponent();
        }

        public int PedidoID { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Viagem { get; set; }
        public bool TaxaS { get; set; }
        public decimal VlTaxaS { get; set; }
        decimal valorPagar = 0, saldo = 0, valorPago = 0, troco = 0, pagoDinheiro = 0;

        private void populaGrid()
        {
            dalPedidoPagamento dalPPag = new dalPedidoPagamento();
            dgvPagamento.DataSource = dalPPag.listaPagamentos(PedidoID);
        }

        private void formataGrid()
        {
            dgvPagamento.Columns[0].HeaderText = "ID";
            dgvPagamento.Columns[0].Visible = false;
            dgvPagamento.Columns[1].HeaderText = "FormaPagamentoID";
            dgvPagamento.Columns[1].Visible = false;
            dgvPagamento.Columns[2].HeaderText = "Data";
            dgvPagamento.Columns[2].DefaultCellStyle.Format = "dd/MM/yy";
            dgvPagamento.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPagamento.Columns[3].HeaderText = "Tipo";
            dgvPagamento.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPagamento.Columns[4].HeaderText = "Valor";
            dgvPagamento.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPagamento.Columns[4].DefaultCellStyle.Format = "f";
        }

        private void carregaConferencia()
        {
            PrintPedido pp = new PrintPedido();
            pp.montaCupom(PedidoID, ValorTotal, Viagem, TaxaS, VlTaxaS);
            rtbConferencia.Text = pp.Visualiza().Text;
        }

        private void atualizaValores()
        {
            valorPagar = 0;
            saldo = 0;
            valorPago = 0;
            troco = 0;
            pagoDinheiro = 0;

            dalPedidoPagamento dalPPag = new dalPedidoPagamento();
            var pagamentos = dalPPag.listaPagamentos(PedidoID);

            valorPagar = ValorTotal;

            foreach (var p in pagamentos)
            {
                valorPago += p.Valor;
            }

            saldo = valorPagar - valorPago;

            tbTotalPagar.Text = valorPagar.ToString("f");
            tbSaldo.Text = (saldo > 0) ? saldo.ToString("f") : "0,00";

            //troco somente com dinheiro
            if (saldo < 0)
            {
                foreach (var p in pagamentos.Where(p => p.FormaPagamentoID == 1))
                {
                    pagoDinheiro += p.Valor;
                    troco = pagoDinheiro - (pagoDinheiro + saldo);
                    tbTroco.Text = troco.ToString("f");
                }
            }
            else
            {
                troco = 0;
                tbTroco.Text = troco.ToString("f");
            }

            calculaPessoas(nupNumPessoa.Value);
            tbReceber.Text = tbSaldo.Text;
            tbReceber.Select();
            tbSubTotal.Text = string.Format("{0:f}", SubTotal);
            tbValorPago.Text = string.Format("{0:f}", valorPago);
            tbTaxa.Text = string.Format("{0:f}", VlTaxaS);

            if (valorPago >= ValorTotal)
                cbTaxa.Enabled = false;
            else
                cbTaxa.Enabled = true;

            carregaConferencia();
        }

        private void calculaPessoas(decimal Num)
        {
            decimal vlr = Convert.ToDecimal(tbSaldo.Text);
            decimal valorPessoa = vlr / Num;
            tbPorPessoa.Text = string.Format("{0:f}", valorPessoa);
            tbReceber.Select();
        }

        //Pagamentos
        private bool verificaPagamento()
        {
            if (!tbReceber.Text.Equals("0,00") && !string.IsNullOrEmpty(tbReceber.Text))
            {
                if ((ValorTotal - valorPago) > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Não é possível fazer mais pagamentos. O saldo a pagar é de R$0,00", "ERRO");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Não é possível fazer um pagamento com o valor de R$0,00 ou em branco", "ERRO");
                return false;
            }
        }

        private void addPagamento(decimal Valor, int FormaPagamentoID)
        {
            if (FormaPagamentoID > 1 && Valor > saldo)
                MessageBox.Show("Não é possível fazer um pagamento com cartão/cheque maior que o saldo do pedido.", "ERRO: Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dalPedidoPagamento dalPPag = new dalPedidoPagamento();
                PedidoPagamento pp = new PedidoPagamento
                {
                    Data = DateTime.Now,
                    FormaPagamentoID = FormaPagamentoID,
                    Valor = Valor,
                    PedidoID = PedidoID
                };

                dalPPag.Add(pp);

                populaGrid();
                atualizaValores();
            }
        }

        private bool lancaPagamentoCaixa()
        {
            if ((dgvPagamento.RowCount > 0) && (valorPago >= ValorTotal))
            {
                if (MessageBox.Show("Confirma a baixa do pedido? \n Troco R$" + tbTroco.Text + ".", "Baixar Pedido", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    decimal pg_dinheiro = 0;

                    if (dalCaixa.verificaCaixa().Status)
                    {
                        dalLancamentosCaixa dalLCaixa = new dalLancamentosCaixa();
                        foreach (DataGridViewRow dgvPR in dgvPagamento.Rows)
                        {
                            if ((int)dgvPR.Cells[1].Value == 1)
                            {
                                pg_dinheiro += (decimal)dgvPR.Cells[4].Value;
                            }
                            else
                            {
                                dalLCaixa.lancaMovimento(new LancamentoCaixa
                                {
                                    CaixaID = dalCaixa.verificaCaixa().CaixaID,
                                    Data = DateTime.Now,
                                    Descricao = string.Format("Pedido {0}", PedidoID),
                                    Entrada = (decimal)dgvPR.Cells[4].Value,
                                    Saida = 0,
                                    FormaPagamentoID = (int)dgvPR.Cells[1].Value,
                                    Observacao = "",
                                    Excluir = false,
                                    PedidoID = PedidoID
                                });
                            }
                        }

                        if (pg_dinheiro > 0)
                        {
                            dalLCaixa.lancaMovimento(new LancamentoCaixa
                            {
                                CaixaID = dalCaixa.verificaCaixa().CaixaID,
                                Data = DateTime.Now,
                                Descricao = string.Format("Pedido {0}", PedidoID),
                                Entrada = pg_dinheiro - troco,
                                Saida = 0,
                                FormaPagamentoID = 1,
                                Observacao = "",
                                Excluir = false,
                                PedidoID = PedidoID
                            });
                        }
                        dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Lançou pagamento ref. pedido nº: " + PedidoID);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Não é possível baixar o pedido. O caixa ainda não foi aberto", "ERRO: Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else return false;
            }
            else
            {
                MessageBox.Show("Não é possível baixar o pedido.\nNão existe pagamentos ou o valor pago é inferior o do pedido", "ERRO: Baixar pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void finalizaPedido()
        {
            dalPedido dalPedido = new dalPedido();
            dalPedido.baixaPedido(PedidoID, valorPago, troco);
        }

        private void btDinheiro_Click(object sender, EventArgs e)
        {
            if (verificaPagamento())
                addPagamento(Convert.ToDecimal(tbReceber.Text), 1);
        }

        private void btDebito_Click(object sender, EventArgs e)
        {
            if (verificaPagamento())
                addPagamento(Convert.ToDecimal(tbReceber.Text), 2);
        }

        private void btCredito_Click(object sender, EventArgs e)
        {
            if (verificaPagamento())
                addPagamento(Convert.ToDecimal(tbReceber.Text), 3);
        }

        private void btCheque_Click(object sender, EventArgs e)
        {
            if (verificaPagamento())
                addPagamento(Convert.ToDecimal(tbReceber.Text), 4);
        }

        private void formPedidoPag_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F2:
                    btFinalizar.PerformClick();
                    break;
            }
        }

        private void btExcluirPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                dalPedidoPagamento dalPPag = new dalPedidoPagamento();
                dalPPag.Remove((int)dgvPagamento.CurrentRow.Cells[0].Value);
                populaGrid();
                atualizaValores();
            }
            catch(Exception)
            {
                MessageBox.Show("Erro oa tentar apagar o pagamento, clique no pagamento e tente novamente.", "ERRO: Apagar pagamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbReceber_Enter(object sender, EventArgs e)
        {
            tbReceber.SelectAll();
        }

        //Fim Pagamentos
        private void formPedidoPag_Load(object sender, EventArgs e)
        {
            cbTaxa.Checked = TaxaS;
            formatCBTAXA();
            carregaConferencia();
            populaGrid();
            formataGrid();
            atualizaValores();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            PrintPedido pp = new PrintPedido();
            pp.montaCupom(PedidoID, ValorTotal, Viagem, TaxaS, VlTaxaS);
            pp.Imprimir();
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (lancaPagamentoCaixa())
            {
                finalizaPedido();
                Close();
            }
        }

        private void tbReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDinheiro.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void atualizaPedido()
        {
            dalPedido dalPed = new dalPedido();
            dalPed.atualizaPedidoPAG(new Pedido
            {
                PedidoID = PedidoID,
                ValorTotal = Convert.ToDecimal(tbTotalPagar.Text),
                TaxaS = cbTaxa.Checked,
                VlTaxaS = Convert.ToDecimal(tbTaxa.Text)
            });

            VlTaxaS = Convert.ToDecimal(tbTaxa.Text);
            ValorTotal = Convert.ToDecimal(tbTotalPagar.Text);
        }

        private void mudaTaxa()
        {
            decimal taxa = cbTaxa.Checked ? (SubTotal * 10) / 100 : 0;
            decimal valorpedido = SubTotal + taxa;

            tbTaxa.Text = string.Format("{0:f}", taxa);
            tbTotalPagar.Text = string.Format("{0:f}", valorpedido);
        }

        private void formatCBTAXA()
        {
            if (cbTaxa.Checked)
            {
                cbTaxa.Font = new Font(cbTaxa.Font.FontFamily, cbTaxa.Font.Size, FontStyle.Bold);
                cbTaxa.Image = Image.FromFile(@"img/icons8-polegar-para-cima-24.png");
            }
            else
            {
                cbTaxa.Font = new Font(cbTaxa.Font.FontFamily, cbTaxa.Font.Size, FontStyle.Regular);
                cbTaxa.Image = Image.FromFile(@"img/icons8-polegares-para-baixo-24.png");
            }
        }

        private void cbTaxa_CheckedChanged(object sender, EventArgs e)
        {
            formatCBTAXA();
            mudaTaxa();
            atualizaPedido();
            atualizaValores();
            carregaConferencia();
        }

        private void nupNumPessoa_ValueChanged(object sender, EventArgs e)
        {
            calculaPessoas(nupNumPessoa.Value);
        }

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
                try
                {
                    decimal muda = Convert.ToDecimal((sender as TextBox).Text.Replace(".", ","));
                    (sender as TextBox).Text = string.Format("{0:f}", muda);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Valor informado inválido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    (sender as TextBox).Text = "0,00";
                }
            }
            else
            {
                (sender as TextBox).Text = "0,00";
            }
        }
        #endregion
    }
}
