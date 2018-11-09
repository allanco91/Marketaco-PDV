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
    public partial class formOperadorEditar : Form
    {
        public formOperadorEditar()
        {
            InitializeComponent();
        }

        public int OperadorID { get; set; }

        private void carregaDados()
        {
            Operador edit_op = dalOperador.retornaOperador(OperadorID);

            tbNome.Text = edit_op.Nome;
            tbLogin.Text = edit_op.Login;
            tbSenha.Text = edit_op.Senha;
            rbSim.Checked = edit_op.Adm ? true : false;
            rbNao.Checked = !edit_op.Adm ? true : false;
        }

        private void formOperadorEditar_Load(object sender, EventArgs e)
        {
            carregaDados();
        }

        private void atualizaOperador(string Nome, string Login, string Senha, bool Adm)
        {
            dalOperador op = new dalOperador();
            Operador operador = new Operador
            {
                OperadorID = OperadorID,
                Nome = Nome,
                Login = Login,
                Senha = Senha,
                Adm = Adm
            };

            op.updOperador(operador);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNome.Text) && !string.IsNullOrEmpty(tbLogin.Text))
            {
                atualizaOperador(tbNome.Text, tbLogin.Text, tbSenha.Text, rbSim.Checked);
                dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Editou o operador " + tbNome.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Para atualizar o operador somente o campo senha pode ser em branco.", "ERRO: Atualizar operador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNome.Select();
            }
        }

        private void formOperadorEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
