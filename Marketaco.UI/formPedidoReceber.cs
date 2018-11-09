using System;
using System.Windows.Forms;
using Marketaco.DAL;
using Marketaco.DOM.Entities;

namespace Marketaco.UI
{
    public partial class formPedidoReceber : Form
    {
        public formPedidoReceber(int PedidoID, string Cliente)
        {
            InitializeComponent();

            carregaPagamentos(PedidoID);
            mostraDados(PedidoID, Cliente);
            formataGrid();
            calculaValores();
        }

        private void mostraDados(int PedidoID, string Cliente)
        {
            dalPedido dalPed = new dalPedido();
            Pedido pedido = dalPed.selecionaPedido(PedidoID);

            tbNumPedido.Text = pedido.PedidoID.ToString();
            tbCliente.Text = Cliente;

            tbValorTotal.Text = string.Format("{0:f}", pedido.ValorTotal);
            tbDesconto.Text = string.Format("{0:f}", pedido.Desconto);
            tbValorFinal.Text = string.Format("{0:f}", pedido.ValorFinal); 
        }

        private void carregaPagamentos(int PedidoID)
        {
            dalLancamentosCaixa dalLanc = new dalLancamentosCaixa();
            dgvPagamento.DataSource = dalLanc.listaPagamentos(PedidoID);
        }

        private void calculaValores()
        {
            decimal vlrTotal = Convert.ToDecimal(tbValorTotal.Text);
            decimal vlrFinal = 0, vlrPago = 0;
            decimal desconto = !string.IsNullOrEmpty(tbDesconto.Text) ? Convert.ToDecimal(tbDesconto.Text) : 0;

            vlrFinal = vlrTotal - desconto;

            //Calcula troco somente com dinheiro
            foreach (DataGridViewRow row in dgvPagamento.Rows)
            {
                vlrPago += (decimal)row.Cells[4].Value;
            }

            decimal saldo = vlrFinal - vlrPago;
            decimal troco = 0;
            decimal pagoDinheiro = 0;
            if (saldo < 0)
            {
                foreach (DataGridViewRow row in dgvPagamento.Rows)
                {
                    if ((int)row.Cells[1].Value == 1)
                    {
                        pagoDinheiro += (decimal)row.Cells[4].Value;
                        troco = pagoDinheiro - (pagoDinheiro + saldo);
                    }
                }
            }

            //valor para o textbox
            tbValorPago.Text = string.Format("{0:f}", vlrPago);
            tbSaldo.Text = saldo < 0 ? "0,00" : string.Format("{0:f}", saldo);
            tbDesconto.Text = string.Format("{0:f}", desconto);
            tbValorFinal.Text = string.Format("{0:f}", vlrFinal);
            tbTroco.Text = string.Format("{0:f}", troco);
        }

        private void formataGrid()
        {
            dgvPagamento.Columns[0].HeaderText = "Pagamento ID";
            dgvPagamento.Columns[0].Visible = false;
            dgvPagamento.Columns[1].HeaderText = "Forma Pagamento ID";
            dgvPagamento.Columns[1].Visible = false;
            dgvPagamento.Columns[2].HeaderText = "Data";
            dgvPagamento.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPagamento.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvPagamento.Columns[3].HeaderText = "Forma de Pagamento";
            dgvPagamento.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPagamento.Columns[4].HeaderText = "Valor";
            dgvPagamento.Columns[4].DefaultCellStyle.Format = "f";
            dgvPagamento.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void adicionaPagamento(string PedID, int FormaPagamentoID, string Vlr)
        {
            try
            {
                decimal Valor = Convert.ToDecimal(Vlr);
                decimal Saldo = Convert.ToDecimal(tbSaldo.Text) - Valor;
                int PedidoID = Convert.ToInt32(PedID);

                if (FormaPagamentoID > 1 && Saldo < 0)
                {
                    MessageBox.Show("O valor do pagamento com cartão/cheque não pode ser maior que o saldo em aberto do pedido", "ERRO: Valor do pagamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbValorPagamento.Select();
                    tbValorPagamento.SelectAll();
                }
                else
                {
                    dalLancamentosCaixa dalLanc = new dalLancamentosCaixa();
                    LancamentoCaixa novo_lanc = new LancamentoCaixa
                    {
                        Data = DateTime.Now,
                        Descricao = string.Format("Pedido nº: {0}", PedidoID),
                        Entrada = Valor,
                        Saida = 0,
                        Observacao = Saldo <= 0 ? "Pago" : "Pg Parcial - Ped nº: " + PedidoID,
                        Excluir = false,
                        CaixaID = dalCaixa.verificaCaixa().CaixaID,
                        FormaPagamentoID = FormaPagamentoID,
                        PedidoID = PedidoID
                    };

                    dalLanc.lancaMovimento(novo_lanc);
                    carregaPagamentos(PedidoID);
                    calculaValores();

                    bool Pago = Saldo <= 0 ? true : false;
                    atualizaPedido(Convert.ToInt32(tbNumPedido.Text), Saldo, Pago);
                    dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Lançou um pagamento do pedido nº " + PedidoID);

                    tbValorPagamento.Text = "";
                    tbValorPagamento.Select();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("O valor do pagamento está incorreto ou em branco", "ERRO: Valor do pagamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridPagamentoDEL(int PagamentoID)
        {
            dalLancamentosCaixa dalLanc = new dalLancamentosCaixa();
            dalLanc.excluirMovimento(PagamentoID);
        }

        private void atualizaPedido(int PedidoID, decimal Saldo, bool Pago)
        {
            dalPedido ped = new dalPedido();
            ped.atualizarReceber(PedidoID, Saldo, Pago);
        }

        private void tbDesconto_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal muda = Convert.ToDecimal((sender as TextBox).Text.Replace(".", ","));
                (sender as TextBox).Text = string.Format("{0:f}", muda);
                if (Convert.ToDecimal(tbValorTotal.Text) > muda)
                {
                    tbValorFinal.Text = string.Format("{0:f}", Convert.ToDecimal(tbValorTotal.Text) - muda);
                    calculaValores();
                }
                else
                {
                    MessageBox.Show("Desconto não pode ser o mesmo valor ou maior que o valor final do pedido.", "ERRO: Desconto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    (sender as TextBox).Text = "0,00";
                    calculaValores();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor informado inválido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                (sender as TextBox).Text = "0,00";
            }
        }

        private void formReceberPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (e.KeyCode == Keys.F4)
                btConcluir_Click(sender, e);
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

        public static void JustNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textboxSomenteNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            JustNumber(sender, e);
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
                    (sender as TextBox).Text = "";
                }
            }
        }
        #endregion

        private void btDinheiro_Click(object sender, EventArgs e)
        {
            adicionaPagamento(tbNumPedido.Text, 1, tbValorPagamento.Text);
        }

        private void btDebito_Click(object sender, EventArgs e)
        {
            adicionaPagamento(tbNumPedido.Text, 2, tbValorPagamento.Text);
        }

        private void btCredito_Click(object sender, EventArgs e)
        {
            adicionaPagamento(tbNumPedido.Text, 3, tbValorPagamento.Text);
        }

        private void btCheque_Click(object sender, EventArgs e)
        {
            adicionaPagamento(tbNumPedido.Text, 4, tbValorPagamento.Text);
        }

        private void btExcluirPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                gridPagamentoDEL((int)dgvPagamento.CurrentRow.Cells[0].Value);
                carregaPagamentos(Convert.ToInt32(tbNumPedido.Text));
                calculaValores();
            }
            catch (Exception)
            {
                MessageBox.Show("Não há nenhum pagamento para apagar.", "ERRO: Apagar pagamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelarPedido_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConcluir_Click(object sender, EventArgs e)
        {
            /*decimal Saldo = Convert.ToDecimal(tbSaldo.Text);
            bool Pago = Saldo == 0 ? true : false;
            concluirPedido(Convert.ToInt32(tbNumPedido.Text), Saldo, Pago);*/
            Close();
        }

        private void tbValorPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btDinheiro_Click(sender, e);
        }

        private void formPedidoReceber_Load(object sender, EventArgs e)
        {
            // Cria ToolTip.
            ToolTip toolTip = new ToolTip();

            // Delay para mostrar o tooltip.
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            // Forçar para mostrar mesmo com o form ativo ou nao.
            toolTip.ShowAlways = true;

            // Tooltips.
            toolTip.SetToolTip(btExcluirPagamento, "Apagar pagamento");
        }
    }
}
