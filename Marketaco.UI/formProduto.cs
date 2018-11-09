using System;
using System.Windows.Forms;
using Marketaco.DAL;
using System.Drawing;

namespace Marketaco.UI
{
    public partial class formProduto : Form
    {
        public formProduto()
        {
            InitializeComponent();
        }

        formProdutoNovo novoProduto;
        formProdutoEditar editarProduto;

        #region Métodos
        private void populaGridProduto()
        {
            dalProduto dalProd = new dalProduto();
            pesquisaProduto(tbPesquisa.Text, cbVendavel.Checked);
            dgvProduto.Columns[0].HeaderText = "ID";
            dgvProduto.Columns[0].Visible = false;
            dgvProduto.Columns[1].HeaderText = "Código";
            dgvProduto.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvProduto.Columns[2].HeaderText = "Nome";
            dgvProduto.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduto.Columns[3].HeaderText = "Categoria";
            dgvProduto.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvProduto.Columns[4].HeaderText = "Preço de venda";
            dgvProduto.Columns[4].DefaultCellStyle.Format = "f";
            dgvProduto.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void pesquisaProduto(string nome, bool vendavel)
        {
            dalProduto produto = new dalProduto();
            dgvProduto.DataSource = produto.listaProdutosGeral(nome, vendavel);
        }

        private void deletaProduto(int id)
        {
            dalProduto produto = new dalProduto();

            if (produto.deletaProduto(id))
            {
                MessageBox.Show("Produto apagado com sucesso!", "Apagar produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pesquisaProduto(tbPesquisa.Text, cbVendavel.Checked);
            }
            else
                MessageBox.Show("Não foi possível apagar o produto, há um ou mais pedidos lançados com esse produto!", "ERRO: Apagar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Eventos
        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            pesquisaProduto(tbPesquisa.Text, cbVendavel.Checked);
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (novoProduto == null)
            {
                novoProduto = new formProdutoNovo();
                novoProduto.MdiParent = ActiveForm;
                novoProduto.Show();
                novoProduto.FormClosed += NovoProduto_FormClosed;
            }
        }

        private void NovoProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            novoProduto = null;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (editarProduto == null)
                {
                    dalProduto produto = new dalProduto();

                    var p = produto.listaProdutoID(Convert.ToInt32(dgvProduto.CurrentRow.Cells[0].Value));
                    editarProduto = new formProdutoEditar(p.Codigo, p.Nome, p.PrecoC, p.PrecoV, p.Vendavel, p.UnidadeComID, p.CategoriaID, p.ControlaEstoque);
                    editarProduto.ProdutoID = p.ProdutoID;

                    editarProduto.MdiParent = ActiveForm;
                    editarProduto.Show();
                    editarProduto.FormClosed += EditarProduto_FormClosed;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar editar o produto, clique no produto e tente novamente.", "ERRO: Editar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            editarProduto = null;
        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            pesquisaProduto(tbPesquisa.Text, cbVendavel.Checked);
        }

        private void formProduto_Activated(object sender, EventArgs e)
        {
            populaGridProduto();
        }
        #endregion

        #region KeyDown
        private void formProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        #endregion

        private void formProduto_Load(object sender, EventArgs e)
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
            toolTip.SetToolTip(cbVendavel, "Vendável?");
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                deletaProduto((int)dgvProduto.CurrentRow.Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar apagar o produto, clique em um produto e tente novamente", "ERRO: Apagar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dgvProduto.Select();
            }
        }

        private void cbVendavel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVendavel.Checked)
                cbVendavel.Font = new Font(cbVendavel.Font.FontFamily, cbVendavel.Font.Size, FontStyle.Bold);
            else
                cbVendavel.Font = new Font(cbVendavel.Font.FontFamily, cbVendavel.Font.Size, FontStyle.Regular);
        }
    }
}
