using System;
using System.Windows.Forms;
using Marketaco.DAL;

namespace Marketaco.UI
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void logarSistema(string Login, string Senha)
        {
            dalOperador op = new dalOperador();
            if (op.logar(Login, Senha))
            {
                Visible = false;
                Principal principal = new Principal();
                Principal.OperadorID = op.retornaOperador(Login).OperadorID;
                principal.FormClosed += Aparecer;
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos.", "ERRO: Entrar no sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbLogin.Select();
            }
        }

        private void Aparecer(object sender, EventArgs e)
        {
            Visible = true;
            tbLogin.Text = "";
            tbSenha.Text = "";
            tbLogin.Select();
        }

        private void formLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            logarSistema(tbLogin.Text, tbSenha.Text);
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbSenha.Select();
                e.SuppressKeyPress = true;
            }
        }

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
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
            toolTip.SetToolTip(btLogar, "Logar no sistema");
            toolTip.SetToolTip(btSair, "Sair do sistema");
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
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
