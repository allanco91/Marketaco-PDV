using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Marketaco.DAL;

namespace Marketaco.UI
{
    public partial class formPedidoReativar : Form
    {
        public formPedidoReativar()
        {
            InitializeComponent();
        }

        public int PedidoID { get; set; }

        private void reativarPedido()
        {
            try
            {
                dalLancamentosCaixa dalLC = new dalLancamentosCaixa();

                if (dalLC.excluirAtivarPedido(PedidoID))
                {
                    dalPedido dalPed = new dalPedido();
                    dalPed.ativaPedido(PedidoID);
                    dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Reativou o pedido nº: " + PedidoID);
                    Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível reativar o pedido. Somente os pedidos com a data de hoje podem ser reativados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("É necessário selecionar um pedido para reativar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btReativar_Click(object sender, EventArgs e)
        {
            dalOperador op = new dalOperador();
            if (op.logar(tbLogin.Text, tbSenha.Text))
            {
                reativarPedido();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha de administrator incorretos", "ERRO: Reativar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbLogin.Text = "";
                tbSenha.Text = "";
                tbLogin.Select();
            }
        }

        private void formPedidoReativar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btReativar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void tbLogin_Enter(object sender, EventArgs e)
        {
            tbLogin.SelectAll();
        }

        private void tbSenha_Enter(object sender, EventArgs e)
        {
            tbSenha.SelectAll();
        }
    }
}
