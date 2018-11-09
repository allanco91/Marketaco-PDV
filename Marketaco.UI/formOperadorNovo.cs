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
using Marketaco.DOM.Entities;

namespace Marketaco.UI
{
    public partial class formOperadorNovo : Form
    {
        public formOperadorNovo()
        {
            InitializeComponent();
        }

        private void formOperadorNovo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        
        private void cadastraOperador(string Nome, string Login, string Senha, bool Adm)
        {
            dalOperador op = new dalOperador();
            Operador operador = new Operador
            {
                Nome = Nome,
                Login = Login,
                Senha = Senha,
                Adm = Adm
            };

            op.addOperador(operador);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNome.Text) && !string.IsNullOrEmpty(tbLogin.Text))
            {
                cadastraOperador(tbNome.Text, tbLogin.Text, tbSenha.Text, rbSim.Checked);
                dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Adicionou o operador " + tbNome.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Para cadastrar um novo operador somente o campo senha pode ser em branco.", "ERRO: Novo operador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Select();
            }
        }
    }
}
