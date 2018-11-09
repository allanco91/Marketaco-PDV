using System;
using System.Windows.Forms;
using Marketaco.DAL;
using Marketaco.DOM.Entities;

namespace Marketaco.UI
{
    public partial class formCategoriaNova : Form
    {
        public formCategoriaNova()
        {
            InitializeComponent();
        }

        #region Eventos
        private void btSalvar_Click(object sender, EventArgs e)
        {
            dalCategoria dalCat = new dalCategoria();
            Categoria nova_cat = new Categoria { Nome = tbNome.Text };
            dalCat.insereCategoria(nova_cat);
            dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Adicionou uma categoria");
            Close();
        }
        #endregion

        #region KeyDown
        private void formCategoriaNova_KeyDown(object sender, KeyEventArgs e)
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
