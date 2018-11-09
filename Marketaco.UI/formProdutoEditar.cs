using System;
using System.Windows.Forms;
using Marketaco.DAL;
using Marketaco.DOM.Entities;

namespace Marketaco.UI
{
    public partial class formProdutoEditar : Form
    {
        public int ProdutoID { get; set; }

        public formProdutoEditar(string Codigo, string Nome, decimal? PrecoC, decimal? PrecoV, bool Vendavel, int UnidadeComID, int CategoriaID, bool ControlaEstoque)
        {
            InitializeComponent();

            populaCBUnidade();
            populaCBCategoria();
            
            tbCodigo.Text = Codigo;
            tbNome.Text = Nome;
            cbUnidade.SelectedValue = UnidadeComID;
            cbCategoria.SelectedValue = CategoriaID;
            tbPrecoCusto.Text = string.Format("{0:f}", PrecoC);
            tbPrecoVenda.Text = string.Format("{0:f}", PrecoV);
            if (Vendavel == true)
                rbVendavelSim.Checked = true;
            else
                rbVendavelNao.Checked = true;
            if (ControlaEstoque == true)
                rbEstoqueSim.Checked = true;
            else
                rbEstoqueNao.Checked = true;

        }

        #region Métodos
        private void populaCBUnidade()
        {
            dalUnidadeCom unidadeCom = new dalUnidadeCom();
            cbUnidade.DataSource = unidadeCom.listaUnidadeCom();
            cbUnidade.DisplayMember = "Nome";
            cbUnidade.ValueMember = "UnidadeComID";
        }

        private void populaCBCategoria()
        {
            dalCategoria categoria = new dalCategoria();
            cbCategoria.DataSource = categoria.listaCategorias();
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "CategoriaID";
        }

        private void atualizaProduto(int id)
        {
            if (!string.IsNullOrEmpty(tbNome.Text))
            {
                dalProduto produto = new dalProduto();
                dalEstoque estoque = new dalEstoque();

                Produto att_prod = new Produto
                {
                    ProdutoID = id,
                    Codigo = tbCodigo.Text,
                    Nome = tbNome.Text,
                    UnidadeComID = (int)cbUnidade.SelectedValue,
                    CategoriaID = (int)cbCategoria.SelectedValue,
                    PrecoC = Convert.ToDecimal(tbPrecoCusto.Text),
                    PrecoV = Convert.ToDecimal(tbPrecoVenda.Text),
                    Vendavel = rbVendavelSim.Checked,
                    ControlaEstoque = rbEstoqueSim.Checked
                };

                Estoque att_est = new Estoque
                {
                    EstoqueID = estoque.Estoque(id).EstoqueID,
                    EstoqueMin = Convert.ToDecimal(tbEstoqueMin.Text),
                    EstoqueIde = Convert.ToDecimal(tbEstoqueIdeal.Text),
                    ProdutoID = id
                };

                if (produto.verificaCodigo(att_prod))
                {

                    produto.atualizaProduto(att_prod);
                    estoque.atualizaEstoque(att_est);
                    dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Editou o produto: " + tbNome.Text);
                    Close();
                }
                else
                {
                    MessageBox.Show("O código não pode ser igual de outro produto", "ERRO: Editar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbCodigo.Select();
                    tbCodigo.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("O nome do produto não pode ser em branco.", "ERRO: Editar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Select();
            }
        }
        #endregion

        #region Eventos
        private void btSalvar_Click(object sender, EventArgs e)
        {
            atualizaProduto(ProdutoID);
        }
        #endregion

        #region KeyDown
        private void formProdutoEditar_KeyDown(object sender, KeyEventArgs e)
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
                    (sender as TextBox).Text = "0,00";
                }
            }
            else
            {
                (sender as TextBox).Text = "0,00";
            }
        }
        #endregion

        private void formProdutoEditar_Load(object sender, EventArgs e)
        {
            dalEstoque dalEst = new dalEstoque();
            Estoque estoque = dalEst.Estoque(ProdutoID);

            tbEstoqueMin.Text = string.Format("{0:f}", estoque.EstoqueMin);
            tbEstoqueIdeal.Text = string.Format("{0:f}", estoque.EstoqueIde);

            rbEstoqueSim_CheckedChanged(sender, e);
        }

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
