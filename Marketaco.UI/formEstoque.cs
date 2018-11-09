using System;
using System.Windows.Forms;
using Marketaco.DAL;
using Marketaco.DOM.Entities;

namespace Marketaco.UI
{
    public partial class formEstoque : Form
    {
        public formEstoque()
        {
            InitializeComponent();
        }

        private int EstoqueID, ProdutoID;
        private char Tipo;

        private void formEstoque_Load(object sender, EventArgs e)
        {
            pesquisaEstoque(tbPesquisar.Text);
            formataGrid();
        }

        private void AtivaLancamento()
        {
            EstoqueID = (int)dgvEstoque.CurrentRow.Cells[0].Value;
            ProdutoID = (int)dgvEstoque.CurrentRow.Cells[1].Value;
            tbProduto.Text = (string)dgvEstoque.CurrentRow.Cells[3].Value;
            tbAtual.Text = string.Format("{0:N}", dgvEstoque.CurrentRow.Cells[4].Value);

            btEntrada.Enabled = false;
            btSaida.Enabled = false;

            grLancamento.Enabled = true;
            tbQuantidade.Select();
        }

        private void Entrada(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbQuantidade.Text))
            {
                Tipo = 'E';
                Lancar(EstoqueID, Convert.ToDecimal(tbQuantidade.Text));
                dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Lançou entrada no estoque prod:" + tbProduto.Text);

                tbAtual.Text = "";
                tbProduto.Text = "";
                tbQuantidade.Text = "";
                tbPesquisar.Text = "";
                pesquisaEstoque(tbPesquisar.Text);
                tbPesquisar.Select();

                btEntrada.Enabled = true;
                btSaida.Enabled = true;

                grLancamento.Enabled = false;
                grLancamento.Text = "Lançamento";
            }
            else
                MessageBox.Show("O Campo quantidade não pode ser em branco.", "ERRO: Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Saida(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbQuantidade.Text))
            {
                Tipo = 'S';
                Lancar(EstoqueID, Convert.ToDecimal(tbQuantidade.Text));
                dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Lançou saída no estoque prod:" + tbProduto.Text);

                tbAtual.Text = "";
                tbProduto.Text = "";
                tbQuantidade.Text = "";
                tbPesquisar.Text = "";
                pesquisaEstoque(tbPesquisar.Text);
                tbPesquisar.Select();

                btEntrada.Enabled = true;
                btSaida.Enabled = true;

                grLancamento.Enabled = false;
                grLancamento.Text = "Lançamento";
            }
            else
                MessageBox.Show("O Campo quantidade não pode ser em branco.", "ERRO: Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Lancar(int id, decimal qnt)
        {
            dalEstoque dalEst = new dalEstoque();

            if (Tipo == 'E')
            {
                EstoqueEntrada entrada = new EstoqueEntrada
                {
                    Data = DateTime.Now,
                    Quantidade = qnt,
                    EstoqueID = id
                };

                dalEst.entrada(entrada);
            }
            else if (Tipo == 'S')
            {
                EstoqueSaida saida = new EstoqueSaida
                {
                    Data = DateTime.Now,
                    Quantidade = qnt,
                    ValorUnitario = 0,
                    Venda = false,
                    EstoqueID = id
                };

                dalEst.saida(saida);
            }
        }

        private void pesquisaEstoque(string s)
        {
            dalEstoque dalEst = new dalEstoque();
            dgvEstoque.DataSource = dalEst.listaEstoque(s);
        }

        private void formataGrid()
        {
            dgvEstoque.Columns[0].HeaderText = "ID";
            dgvEstoque.Columns[0].Visible = false;
            dgvEstoque.Columns[1].HeaderText = "ID Produto";
            dgvEstoque.Columns[1].Visible = false;
            dgvEstoque.Columns[2].HeaderText = "Código";
            dgvEstoque.Columns[2].Width = 80;
            dgvEstoque.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvEstoque.Columns[3].HeaderText = "Nome";
            dgvEstoque.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEstoque.Columns[4].HeaderText = "Estoque Atual";
            dgvEstoque.Columns[4].DefaultCellStyle.Format = "N";
            dgvEstoque.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvEstoque.Columns[5].HeaderText = "Estoque Mín";
            dgvEstoque.Columns[5].DefaultCellStyle.Format = "N";
            dgvEstoque.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvEstoque.Columns[6].HeaderText = "Estoque Ideal";
            dgvEstoque.Columns[6].DefaultCellStyle.Format = "N";
            dgvEstoque.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }


        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisaEstoque(tbPesquisar.Text);
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            pesquisaEstoque(tbPesquisar.Text);
        }

        private void formEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    btEntrada.PerformClick();
                    break;
                case Keys.Subtract:
                    btSaida.PerformClick();
                    break;
                case Keys.Escape:
                    if (grLancamento.Enabled == true)
                        btCancelar.PerformClick();
                    else
                        Close();
                    break;
                
            }
        }

        #region Textbox Números
        public static void Alphanum(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            tbAtual.Text = "";
            tbProduto.Text = "";
            tbQuantidade.Text = "";

            btEntrada.Enabled = true;
            btSaida.Enabled = true;

            tbPesquisar.Text = "";
            tbPesquisar.Select();

            grLancamento.Enabled = false;
            grLancamento.Text = "Lançamento";
        }

        private void btEntrada_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.RowCount > 0)
            {
                AtivaLancamento();
                grLancamento.Text = "Lançamento: Entrada"; 
                btLancar.Click -= new EventHandler(Saida);
                btLancar.Click -= new EventHandler(Entrada);
                btLancar.Click += new EventHandler(Entrada);
            }
            else
                MessageBox.Show("Nenhum produto para lançar estoque.", "ERRO: Lançamento estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tbQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLancar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void tbPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Alphanum(sender, e);
        }

        private void tbPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dgvEstoque.Select();
            }
        }

        private void btSaida_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.RowCount > 0)
            {
                AtivaLancamento();
                grLancamento.Text = "Lançamento: Saída";
                btLancar.Click -= new EventHandler(Entrada);
                btLancar.Click -= new EventHandler(Saida);
                btLancar.Click += new EventHandler(Saida);
            }
            else
                MessageBox.Show("Nenhum produto para lançar estoque.", "ERRO: Lançamento estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
