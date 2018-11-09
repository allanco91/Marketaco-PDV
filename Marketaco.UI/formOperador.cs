using System;
using System.Windows.Forms;
using Marketaco.DAL;

namespace Marketaco.UI
{
    public partial class formOperador : Form
    {
        public formOperador()
        {
            InitializeComponent();
        }

        formOperadorNovo novoOperador = null;
        formOperadorEditar editarOperador = null;

        private void formOperador_Activated(object sender, EventArgs e)
        {
            populaGrid();
            formataGrid();
        }

        private void populaGrid()
        {
            dalOperador op = new dalOperador();
            dgvOperador.DataSource = op.listaOperador(tbPesquisar.Text);
        }

        private void formataGrid()
        {
            dgvOperador.Columns[0].HeaderText = "ID";
            dgvOperador.Columns[0].Visible = false;
            dgvOperador.Columns[1].HeaderText = "Nome";
            dgvOperador.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOperador.Columns[2].HeaderText = "Login";
            dgvOperador.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvOperador.Columns[3].HeaderText = "Senha";
            dgvOperador.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvOperador.Columns[4].HeaderText = "Admin";
            dgvOperador.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void excluiOperador(int OperadorID)
        {
            try
            {
                string Operador = dalOperador.retornaOperador(Principal.OperadorID).Nome;
                string OperadorE = dalOperador.retornaOperador(OperadorID).Nome;

                if (Operador != OperadorE)
                {
                    dalOperador op = new dalOperador();
                    op.remOperador(OperadorID);

                    dalLogs.addLog(Operador, "Excluiu um operador o " + OperadorE);
                    MessageBox.Show("Operador excluído com sucesso!", "Excluir operador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populaGrid();
                }
                else
                    MessageBox.Show("Não foi possível excluir o operador! O operador não pode ser o mesmo que está logado.", "ERRO: Excluir operador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Não foi possível excluir o operador!", "ERRO: Excluir operador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formOperador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (novoOperador == null)
            {
                novoOperador = new formOperadorNovo();
                novoOperador.MdiParent = ActiveForm;
                novoOperador.FormClosed += fecharNovoOperador;
                novoOperador.Show();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (editarOperador == null)
            {
                try
                {
                    editarOperador = new formOperadorEditar();
                    editarOperador.OperadorID = (int)dgvOperador.CurrentRow.Cells[0].Value;
                    editarOperador.MdiParent = ActiveForm;
                    editarOperador.FormClosed += fecharEditarOperador;
                    editarOperador.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao tentar editar o operador, clique no operador e tente novamente.", "ERRO: Editar operador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o operador?", "Excluir operador", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    excluiOperador((int)dgvOperador.CurrentRow.Cells[0].Value);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao tentar excluir o operador, clique no operador e tente novamente.", "ERRO: excluir operador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fecharNovoOperador(object sender, EventArgs e)
        {
            novoOperador = null;
        }

        private void fecharEditarOperador(object sender, EventArgs e)
        {
            editarOperador = null;
        }

        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            populaGrid();
        }
    }
}
