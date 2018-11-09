using System;
using System.Windows.Forms;
using Marketaco.DAL;

namespace Marketaco.UI
{
    public partial class formCategoria : Form
    {
        public formCategoria()
        {
            InitializeComponent();
        }

        formCategoriaNova novaCategoria;
        formCategoriaEditar editarCategoria;

        #region Métodos
        private void populaGridCategoria()
        {
            dalCategoria dalCat = new dalCategoria();
            dgvCategoria.DataSource = dalCat.listaCategorias();
        }

        private void formataGridCategoria()
        {
            dgvCategoria.Columns[0].HeaderText = "Código";
            dgvCategoria.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCategoria.Columns[1].HeaderText = "Nome";
            dgvCategoria.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCategoria.Columns[2].Visible = false;
        }

        private void pesquisaCategoria_nome(string nome)
        {
            dalCategoria dalCat = new dalCategoria();
            dgvCategoria.DataSource = dalCat.listaCategorias_nome(nome);
        }

        private void deletarCategoria(int codigo)
        {
            dalCategoria dalCat = new dalCategoria();
            if (dalCat.deletaCategoria(codigo))
            {
                MessageBox.Show("Categoria apagada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                populaGridCategoria();
            }
            else
                MessageBox.Show("Erro ao apagar a categoria, um ou mais produtos possui essa categoria cadastrada", "ERRO: Apagar categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Eventos
        private void btNovo_Click(object sender, EventArgs e)
        {
            if (novaCategoria == null)
            {
                novaCategoria = new formCategoriaNova();
                novaCategoria.MdiParent = ActiveForm;
                novaCategoria.Show();
                novaCategoria.FormClosed += new FormClosedEventHandler(novaCategoriaNull);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.RowCount > 0)
            {
                if (editarCategoria == null)
                {
                    editarCategoria = new formCategoriaEditar((int)dgvCategoria.CurrentRow.Cells[0].Value, dgvCategoria.CurrentRow.Cells[1].Value.ToString());

                    editarCategoria.MdiParent = ActiveForm;
                    editarCategoria.Show();
                    editarCategoria.FormClosed += new FormClosedEventHandler(editarCategoriaNull);
                }
            }
            else
                MessageBox.Show("Erro ao editar a categoria, clique na categoria e tenta novamente", "ERRO: Editar categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void editarCategoriaNull(object sender, EventArgs e)
        {
            editarCategoria = null;
        }
        private void novaCategoriaNull(object sender, EventArgs e)
        {
            novaCategoria = null;
        }

        private void formCategoria_Activated(object sender, EventArgs e)
        {
            populaGridCategoria();
            formataGridCategoria();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisaCategoria_nome(tbPesquisar.Text);
        }
        #endregion

        #region KeyDown
        private void formCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        #endregion

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                deletarCategoria((int)dgvCategoria.CurrentRow.Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao apagar a categoria, clique na categoria e tente novamente", "ERRO: Apagar categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dgvCategoria.Select();
            }
        }
    }
}
    

