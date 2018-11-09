using System;
using System.Windows.Forms;
using Marketaco.DAL;

namespace Marketaco.UI
{
    public partial class formPedidoImportar : Form
    {
        public formPedidoImportar()
        {
            InitializeComponent();
        }

        public int id_pedido;

        #region Métodos
        private void populaGrid()
        {
            dalPedido dalPed = new dalPedido();
            dgvPedido.DataSource = dalPed.listaPedidosSimples(id_pedido, tbPesquisa.Text);
            dgvPedido.Columns[0].HeaderText = "Núm. Pedido";
            dgvPedido.Columns[0].Width = 100;
            dgvPedido.Columns[1].HeaderText = "Nome";
            dgvPedido.Columns[2].HeaderText = "Valor";
            dgvPedido.Columns[2].DefaultCellStyle.Format = "N";
            dgvPedido.Columns[2].Width = 120;
        }

        private void importarPedido(int id_pedido_importar)
        {
            dalPedido dalPed = new dalPedido();
            dalItensPedido dalIPed = new dalItensPedido();

            try
            {
                if (dalIPed.importaPedido(id_pedido, id_pedido_importar))
                {
                    dalPed.deletaPedido(id_pedido_importar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Eventos
        private void formPedidoImportar_Activated(object sender, EventArgs e)
        {
            populaGrid();
        }

        private void btImportar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja importar o pedido?", "Confirmar importação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                importarPedido((int)dgvPedido.CurrentRow.Cells[0].Value);
                Close();
            }
        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            populaGrid();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region KeyDown
        private void formPedidoImportar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btImportar_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        #endregion
    }
}
