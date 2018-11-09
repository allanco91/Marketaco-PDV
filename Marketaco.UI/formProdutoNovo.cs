using System;
using System.Windows.Forms;
using Marketaco.DAL;
using Marketaco.DOM.Entities;

namespace Marketaco.UI
{
    public partial class formProdutoNovo : Form
    {
        public formProdutoNovo()
        {
            InitializeComponent();
        }

        #region Métodos
        private void populaCBUnidade()
        {
            dalUnidadeCom unidadeCom = new dalUnidadeCom();
            cbUnid.DataSource = unidadeCom.listaUnidadeCom();
            cbUnid.DisplayMember = "Nome";
            cbUnid.ValueMember = "UnidadeComID";
        }

        private void populaCBCategoria()
        {
            dalCategoria categoria = new dalCategoria();
            cbCategoria.DataSource = categoria.listaCategorias();
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "CategoriaID";
        }

        private void insereProduto()
        {
            if (!string.IsNullOrEmpty(tbNome.Text))
            {
                dalProduto produto = new dalProduto();
                dalEstoque estoque = new dalEstoque();

                Produto novo_prod = new Produto
                {
                    Codigo = tbCodigo.Text,
                    Nome = tbNome.Text,
                    PrecoC = Convert.ToDecimal(tbPrecoCusto.Text),
                    PrecoV = Convert.ToDecimal(tbPrecoVenda.Text),
                    Vendavel = rbVendavelSim.Checked,
                    ControlaEstoque = rbEstoqueSim.Checked,
                    UnidadeComID = (int)cbUnid.SelectedValue,
                    CategoriaID = (int)cbCategoria.SelectedValue
                };

                Estoque novo_est = new Estoque
                {
                    EstoqueAtu = 0,
                    EstoqueMin = Convert.ToDecimal(tbEstoqueMin.Text),
                    EstoqueIde = Convert.ToDecimal(tbEstoqueIdeal.Text)
                };

                if (produto.verificaCodigo(novo_prod))
                {

                    produto.insereProduto(novo_prod);
                    estoque.Add(novo_est);
                    dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Adicionou o produto: " + novo_prod.Nome);
                    Close();
                }
                else
                {
                    MessageBox.Show("O código não pode ser igual de outro produto", "ERRO: Salvar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCodigo.Select();
                    tbCodigo.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("O nome do produto não pode ser em branco.", "ERRO: Salvar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Select();
            }
        }
        #endregion

        #region Eventos
        private void formProdutoNovo_Load(object sender, EventArgs e)
        {
            populaCBUnidade();
            populaCBCategoria();
        }

        private void brSalvar_Click(object sender, EventArgs e)
        {
            insereProduto();
        }
        #endregion

        #region KeyDown
        private void formProdutoNovo_KeyDown(object sender, KeyEventArgs e)
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
            else
            {
                (sender as TextBox).Text = "0,00";
            }
        }
        #endregion

        private void rbEstoqueSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstoqueNao.Checked == true)
            {
                tbEstoqueIdeal.Text = "0,00";
                tbEstoqueMin.Text = "0,00";
                tbEstoqueIdeal.Enabled = false;
                tbEstoqueMin.Enabled = false;
            }
            else
            {
                tbEstoqueIdeal.Enabled = true;
                tbEstoqueMin.Enabled = true;
            }
        }
    }
}
