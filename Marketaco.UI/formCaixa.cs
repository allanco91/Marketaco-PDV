using System;
using System.Windows.Forms;
using Marketaco.DAL;
using Marketaco.UI.Report;
using Marketaco.DOM.Entities;

namespace Marketaco.UI
{
    public partial class formCaixa : Form
    {
        public formCaixa()
        {
            InitializeComponent();
        }

        formCaixaAdicionar caixaAdicionar;

        #region Métodos
        private void montaCaixa()
        {
            if (dalCaixa.verificaCaixa().Status == false)
            {
                gbMovimentos.Visible = false;
                gbResumo.Visible = false;
                btFecharCaixa.Enabled = false;
                pbFechado.Visible = true;
                pbAberto.Visible = false;
            }
            else
            {
                dalLancamentosCaixa dalLanC = new dalLancamentosCaixa();
                dgvLancamentosCaixa.DataSource = dalLanC.listaMovimento(dalCaixa.verificaCaixa().CaixaID);
                formataGrid();

                tbSaldoInicialCaixa.Text = dalCaixa.verificaCaixa().SaldoInicial.ToString("f");
                tbSaldoInicialCaixa.Enabled = false;
                tbObservacao.Text = dalCaixa.verificaCaixa().Observacao;
                tbObservacao.Enabled = false;
                lbDataHoraAbertura.Text = dalCaixa.verificaCaixa().Data_Abertura.ToString();

                gbMovimentos.Visible = true;
                gbResumo.Visible = true;
                btFecharCaixa.Enabled = true;
                btAbrirCaixa.Enabled = false;
                pbAberto.Visible = true;
                pbFechado.Visible = false;
                calculaValores();
            }
        }

        private void formataGrid()
        {
            dgvLancamentosCaixa.Columns[0].HeaderText = "ID";
            dgvLancamentosCaixa.Columns[0].Visible = false;
            dgvLancamentosCaixa.Columns[1].HeaderText = "Data";
            dgvLancamentosCaixa.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvLancamentosCaixa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvLancamentosCaixa.Columns[2].HeaderText = "Descrição";
            dgvLancamentosCaixa.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvLancamentosCaixa.Columns[3].HeaderText = "Entrada";
            dgvLancamentosCaixa.Columns[3].DefaultCellStyle.Format = "f";
            dgvLancamentosCaixa.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvLancamentosCaixa.Columns[4].HeaderText = "Saída";
            dgvLancamentosCaixa.Columns[4].DefaultCellStyle.Format = "f";
            dgvLancamentosCaixa.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvLancamentosCaixa.Columns[5].HeaderText = "Forma-Pag.";
            dgvLancamentosCaixa.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvLancamentosCaixa.Columns[6].HeaderText = "Observação";
            dgvLancamentosCaixa.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLancamentosCaixa.Columns[7].HeaderText = "Excluir";
            dgvLancamentosCaixa.Columns[7].Visible = false;
        }

        private void abreCaixa()
        {
            if (!string.IsNullOrEmpty(tbSaldoInicialCaixa.Text))
            {
                dalCaixa dalCa = new dalCaixa();
                dalLancamentosCaixa dalLanC = new dalLancamentosCaixa();

                //abre o caixa
                Caixa ca = new Caixa
                {
                    Data_Abertura = DateTime.Now,
                    SaldoInicial = Convert.ToDecimal(tbSaldoInicialCaixa.Text),
                    E_Dinheiro = 0,
                    C_Debito = 0,
                    C_Credito = 0,
                    E_Cheque = 0,
                    S_Dinheiro = 0,
                    S_Cheque = 0,
                    SaldoDinheiro = 0,
                    Observacao = tbObservacao.Text,
                    Status = true,
                };

                dalCa.abreCaixa(ca);

                LancamentoCaixa lca = new LancamentoCaixa
                {
                    CaixaID = dalCaixa.verificaCaixa().CaixaID,
                    Data = DateTime.Now,
                    Descricao = "Saldo Inicial",
                    Entrada = Convert.ToDecimal(tbSaldoInicialCaixa.Text),
                    Saida = 0,
                    FormaPagamentoID = 5,
                    Observacao = tbObservacao.Text,
                    Excluir = false,
                    PedidoID = null
                };

                dalLanC.lancaMovimento(lca);
                dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Abriu o caixa, Valor inicial R$" + tbSaldoInicialCaixa.Text);
                montaCaixa();
            }
            else MessageBox.Show("Para abrir o caixa o saldo inicial não pode ser em branco. Utilize 0,00.", "ERRO");
        }

        private void fechaCaixa()
        {
            try
            {
                calculaValores();
                Caixa ca = new Caixa
                {
                    Data_Fechamento = DateTime.Now,
                    Status = false
                };

                dalCaixa dalCa = new dalCaixa();
                dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Fechou o caixa");
                dalCa.fechaCaixa(ca);
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO");
            }
        }

        private void calculaValores()
        {
            dalCaixa dalCa = new dalCaixa();

            var e_dinhei = dalCaixa.verificaCaixa().E_Dinheiro;
            var s_dinhei = dalCaixa.verificaCaixa().S_Dinheiro;
            var c_debito = dalCaixa.verificaCaixa().C_Debito;
            var c_credit = dalCaixa.verificaCaixa().C_Credito;
            var e_cheque = dalCaixa.verificaCaixa().E_Cheque;
            var s_cheque = dalCaixa.verificaCaixa().S_Cheque;
            var saldo_in = dalCaixa.verificaCaixa().SaldoInicial;

            decimal? total_entrada = e_dinhei + c_debito + c_credit + e_cheque + saldo_in;
            decimal? total_saida = s_dinhei + s_cheque;
            decimal? saldo_dinheiro = dalCaixa.verificaCaixa().SaldoDinheiro;
            decimal? saldo_final = dalCaixa.verificaCaixa().SaldoFinal;

            tbDinheiroE.Text = string.Format("{0:f}", e_dinhei);
            tbCartaoDebito.Text = string.Format("{0:f}", c_debito);
            tbCartaoCredito.Text = string.Format("{0:f}", c_credit);
            tbChequeE.Text = string.Format("{0:f}", e_cheque);
            tbSaldoInicial.Text = string.Format("{0:f}", saldo_in);
            tbTotalEntrada.Text = string.Format("{0:f}", total_entrada);

            tbDinheiroS.Text = string.Format("{0:f}", s_dinhei);
            tbChequeS.Text = string.Format("{0:f}", s_cheque);
            tbTotalSaida.Text = string.Format("{0:f}", total_saida);

            tbSaldoDinheiro.Text = string.Format("{0:f}", saldo_dinheiro);
            tbSaldoFinal.Text = string.Format("{0:f}", saldo_final);
        }

        private void excluirLancamento()
        {
            dalLancamentosCaixa dalLCaixa = new dalLancamentosCaixa();
            dalLCaixa.excluirMovimento((int)dgvLancamentosCaixa.CurrentRow.Cells[0].Value);
            dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Excluiu um lançamento do caixa");
        }

        private void btExcluirEntradaSaida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o lançamento?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                excluirLancamento();
                montaCaixa();
            }
        }

        private void imprimirResumo(int id)
        {
            try
            {
                repResumoCaixa relatorio = new repResumoCaixa();
                dalCaixa dalC = new dalCaixa();
                relatorio.LCaixaBindingSource.DataSource = dalC.achaCaixa(id);
                relatorio.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO");
            }
        }

        private void imprimirMovimento(int id)
        {
            try
            {
                repMovimentoCaixa relatorio = new repMovimentoCaixa();
                dalLancamentosCaixa dalLanc = new dalLancamentosCaixa();
                relatorio.LCaixaBindingSource.DataSource = dalLanc.listaMovimento(id);
                relatorio.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO");
            }
        }
        #endregion

        #region Eventos
        private void formCaixa_Activated(object sender, EventArgs e)
        {
            montaCaixa();
        }

        private void btAbrirCaixa_Click(object sender, EventArgs e)
        {
            abreCaixa();
        }

        private void btFecharCaixa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar o caixa?", "Fechamento de Caixa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                fechaCaixa();
            }
        }

        private void caixaAdicionarNull(object sender, EventArgs e)
        {
            caixaAdicionar = null;
        }

        private void btAdicionarEntradaSaida_Click(object sender, EventArgs e)
        {
            if (caixaAdicionar == null)
            {
                caixaAdicionar = new formCaixaAdicionar();
                caixaAdicionar.MdiParent = ActiveForm;
                caixaAdicionar.Show();
                caixaAdicionar.FormClosed += new FormClosedEventHandler(caixaAdicionarNull);
            }
        }

        private void btImprimirResumo_Click(object sender, EventArgs e)
        {
            try
            {
                imprimirResumo(dalCaixa.verificaCaixa().CaixaID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO");
            }
        }

        private void btImprimirMovimento_Click(object sender, EventArgs e)
        {
            try
            {
                imprimirMovimento(dalCaixa.verificaCaixa().CaixaID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO");
            }
        }

        private void dgvLancamentosCaixa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLancamentosCaixa.RowCount > 0)
            {
                if ((bool)dgvLancamentosCaixa.CurrentRow.Cells[7].Value) btExcluir.Enabled = true;
                else btExcluir.Enabled = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region KeyDown
        private void formCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
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

        private void tbSaldoInicialCaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(sender, e);
        }

        private void tbSaldoInicialCaixa_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSaldoInicialCaixa.Text))
            {
                string muda = tbSaldoInicialCaixa.Text.Replace('.', ',');
                tbSaldoInicialCaixa.Text = string.Format("{0:f}", Convert.ToDecimal(muda));
            }
        }
        #endregion

        private void tbSaldoInicialCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btAbrirCaixa.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
