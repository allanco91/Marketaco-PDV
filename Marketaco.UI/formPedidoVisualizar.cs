using System.Windows.Forms;

namespace Marketaco.UI
{
    public partial class formPedidoVisualizar : Form
    {
        public formPedidoVisualizar()
        {
            InitializeComponent();
        }

        public int PedidoID { get; set; }
        public decimal valorTotal { get; set; }
        public bool viagem { get; set; }
        public bool taxa { get; set; }
        public decimal vltaxa { get; set; }

        private void formPedidoVisualizar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void pedidoImprimir()
        {
            //Imprime pedido
            PrintPedido pp = new PrintPedido();
            pp.montaCupom(PedidoID, valorTotal, viagem, taxa, vltaxa);
            pp.Imprimir();
        }

        private void btImprimir_Click(object sender, System.EventArgs e)
        {
            pedidoImprimir();
        }
    }
}
