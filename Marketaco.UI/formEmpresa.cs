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
    public partial class formEmpresa : Form
    {
        public formEmpresa()
        {
            InitializeComponent();
        }

        private void formEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void carregaDados()
        {
            dalEmpresa emp = new dalEmpresa();
            Empresa dados = emp.retornaEmpresa();

            tbNomeFantasia.Text = dados.NomeFantasia;
            tbRazaoSocial.Text = dados.RazaoSocial;
            tbEndereco.Text = dados.Endereco;
            tbNumero.Text = dados.Numero;
            tbCidade.Text = dados.Cidade;
            tbUF.Text = dados.UF;
            mtbTelefone1.Text = dados.Telefone1;
            mtbTelefone2.Text = dados.Telefone2;
            mtbCNPJ.Text = dados.CNPJ;
            tbIE.Text = dados.IE;
        }

        private void atualizaEmpresa(string NomeFantasia, string RazaoSocial, string Endereco, string Numero, string Cidade, string UF, string Telefone1, string Telefone2, string CNPJ, string IE)
        {
            dalEmpresa emp = new dalEmpresa();
            Empresa dados = new Empresa
            {
                EmpresaID = 1,
                NomeFantasia = NomeFantasia,
                RazaoSocial = RazaoSocial,
                Endereco = Endereco,
                Numero = Numero,
                Cidade = Cidade,
                UF = UF,
                Telefone1 = Telefone1,
                Telefone2 = Telefone2,
                CNPJ = CNPJ,
                IE = IE
            };

            emp.atualizaEmpresa(dados);
        }

        private void formEmpresa_Load(object sender, EventArgs e)
        {
            carregaDados();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNomeFantasia.Text)
                && !string.IsNullOrEmpty(tbRazaoSocial.Text)
                && !string.IsNullOrEmpty(tbEndereco.Text)
                && !string.IsNullOrEmpty(tbNumero.Text)
                && !string.IsNullOrEmpty(tbCidade.Text)
                && !string.IsNullOrEmpty(tbUF.Text)
                && !string.IsNullOrEmpty(mtbTelefone1.Text)
                && !string.IsNullOrEmpty(mtbCNPJ.Text)
                && !string.IsNullOrEmpty(tbIE.Text))
            {
                atualizaEmpresa(tbNomeFantasia.Text, tbRazaoSocial.Text, tbEndereco.Text, tbNumero.Text, tbCidade.Text, tbUF.Text, mtbTelefone1.Text, mtbTelefone2.Text, mtbCNPJ.Text, tbIE.Text);
                dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Atualizou os dados da empresa");
                MessageBox.Show("Dados da empresa atualizados com sucesso.", "Dados da empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show("Erro ao atualizar os dados da empresa, somente o campo Telefone 2 pode ser em branco.", "ERRO: Dados da empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
