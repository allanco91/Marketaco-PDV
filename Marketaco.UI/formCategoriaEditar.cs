using System;
using System.Windows.Forms;
using Marketaco.DAL;
using Marketaco.DOM.Entities;

namespace Marketaco.UI
{
    public partial class formCategoriaEditar : Form
    {
        public formCategoriaEditar(int CategoriaID, string Nome)
        {
            InitializeComponent();

            tbCodigo.Text = CategoriaID.ToString();
            tbNome.Text = Nome;
        }

        #region Métodos
        private void atualizarCategoria(int codigo)
        {
            dalCategoria dalCat = new dalCategoria();
            Categoria att_cat = new Categoria { CategoriaID = codigo, Nome = tbNome.Text };

            dalCat.atualizaCategoria(att_cat);
        }
        #endregion

        #region Eventos
        private void btSalvar_Click(object sender, EventArgs e)
        {
            atualizarCategoria(Convert.ToInt32(tbCodigo.Text));
            dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Editou uma categoria");
            Close();
        }
        #endregion

        #region KeyDown
        private void formCategoriaEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        #endregion

        private void tbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSalvar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
