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
    public partial class formConfig : Form
    {
        public formConfig()
        {
            InitializeComponent();
        }

        private void carregaForm()
        {
            dalConfig conf = new dalConfig();

            //Desconto Especial
            listaCategoriaESP05.Items.Clear();
            foreach (string t in conf.ListaAppConfig("ESP05"))
            {
                listaCategoriaESP05.Items.Add(t);
            }

            cbCategoriaESP05.DataSource = conf.listaCategoriaAdd("ESP05");
            cbCategoriaESP05.DisplayMember = "Nome";
            cbCategoriaESP05.ValueMember = "Nome";

            listaCategoriaESP10.Items.Clear();
            foreach (string t in conf.ListaAppConfig("ESP10"))
            {
                listaCategoriaESP10.Items.Add(t);
            }

            cbCategoriaESP10.DataSource = conf.listaCategoriaAdd("ESP10");
            cbCategoriaESP10.DisplayMember = "Nome";
            cbCategoriaESP10.ValueMember = "Nome";

            //Desconto Diário
            listaCategoriaDIA.Items.Clear();
            foreach (string t in conf.ListaAppConfig("DIA"))
            {
                listaCategoriaDIA.Items.Add(t);
            }

            cbCategoriaDIA.DataSource = conf.listaCategoriaAdd("DIA");
            cbCategoriaDIA.DisplayMember = "Nome";
            cbCategoriaDIA.ValueMember = "Nome";

            //Pula linha
            listaCategoria.Items.Clear();
            foreach (string t in conf.ListaAppConfig("pula"))
            {
                listaCategoria.Items.Add(t);
            }

            cbCategoria.DataSource = conf.listaCategoriaAdd("pula");
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "Nome";
        }

        private void adicionaConfig(string id, string nome)
        {
            try
            {
                dalConfig conf = new dalConfig();
                conf.addConfig(id, nome);
                carregaForm();
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO", "Não foi possível adicionar a categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void apagarConfig(string id)
        {
            try
            {
                dalConfig conf = new dalConfig();
                conf.delConfig(id);
                carregaForm();
            }
            catch (Exception)
            {
                MessageBox.Show("ERRO", "Não foi possível apagar a categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formConfig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void formConfig_Load(object sender, EventArgs e)
        {
            carregaForm();

            dalConfig conf = new dalConfig();
            tbTaxaC.Text = conf.retornaConfig("TaxaC");
            tbTaxaD.Text = conf.retornaConfig("TaxaD");

            tbDomingo.Text = conf.retornaConfig("Sunday");
            tbSegunda.Text = conf.retornaConfig("Monday");
            tbTerca.Text = conf.retornaConfig("Tuesday");
            tbQuarta.Text = conf.retornaConfig("Wednesday");
            tbQuinta.Text = conf.retornaConfig("Thursday");
            tbSexta.Text = conf.retornaConfig("Friday");
            tbSabado.Text = conf.retornaConfig("Saturday");

            if (conf.retornaConfig("SERV") == "S")
                rbSimSERV.Checked = true;
            else
                rbNaoSERV.Checked = true;
        }

        #region Textbox Números
        public static void AllowNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1) ||
                (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf('.') > -1) ||
                (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf(',') > -1) ||
                (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textboxNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(sender, e);
        }

        private void textboxNumeros_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as TextBox).Text))
            {
                try
                {
                    decimal muda = Convert.ToDecimal((sender as TextBox).Text.Replace(".", ","));
                    (sender as TextBox).Text = string.Format("{0:f}", muda);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Valor informado inválido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    (sender as TextBox).Text = "0,00";
                }
            }
            else
            {
                (sender as TextBox).Text = "0,00";
            }
        }
        #endregion

        #region Tab Taxa
        private void atualizaTaxas(string TaxaC, string TaxaD)
        {
            try
            {
                dalConfig conf = new dalConfig();
                conf.atuConfig("TaxaC", TaxaC);
                conf.atuConfig("TaxaD", TaxaD);
                MessageBox.Show("Taxas atualizadas com sucesso", "Atualizar taxas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            atualizaTaxas(tbTaxaC.Text, tbTaxaD.Text);
        }
        #endregion

        #region Tab Pula linha
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            adicionaConfig("pula" + (string)cbCategoria.SelectedValue, (string)cbCategoria.SelectedValue);
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            apagarConfig("pula" + (string)listaCategoria.SelectedItem);
        }
        #endregion

        #region ESP05
        private void btAdicionarESP05_Click(object sender, EventArgs e)
        {
            adicionaConfig("ESP05" + (string)cbCategoriaESP05.SelectedValue, (string)cbCategoriaESP05.SelectedValue);
        }

        private void btApagarESP05_Click(object sender, EventArgs e)
        {
            apagarConfig("ESP05" + (string)listaCategoriaESP05.SelectedItem);
        }
        #endregion

        #region ESP10
        private void btAdicionarESP10_Click(object sender, EventArgs e)
        {
            adicionaConfig("ESP10" + (string)cbCategoriaESP10.SelectedValue, (string)cbCategoriaESP10.SelectedValue);
        }
        
        private void btApagarESP10_Click(object sender, EventArgs e)
        {
            apagarConfig("ESP10" + (string)listaCategoriaESP10.SelectedItem);
        }
        #endregion

        #region Desconto diário
        private void atualizaDescDiario(string Domingo, string Segunda, string Terca, string Quarta, string Quinta, string Sexta, string Sabado)
        {
            try
            {
                dalConfig conf = new dalConfig();
                conf.atuConfig("Sunday", Domingo);
                conf.atuConfig("Monday", Segunda);
                conf.atuConfig("Tuesday", Terca);
                conf.atuConfig("Wednesday", Quarta);
                conf.atuConfig("Thursday", Quinta);
                conf.atuConfig("Friday", Sexta);
                conf.atuConfig("Saturday", Sabado);
                MessageBox.Show("Descontos diários atualizados com sucesso", "Atualizar descontos diários", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btSalvarDescDiario_Click(object sender, EventArgs e)
        {
            atualizaDescDiario(tbDomingo.Text, tbSegunda.Text, tbTerca.Text, tbQuarta.Text, tbQuinta.Text, tbSexta.Text, tbSabado.Text);
        }
        #endregion

        private void btAdicionarDIA_Click(object sender, EventArgs e)
        {
            adicionaConfig("DIA" + (string)cbCategoriaDIA.SelectedValue, (string)cbCategoriaDIA.SelectedValue);
        }

        private void btApagarDIA_Click(object sender, EventArgs e)
        {
            apagarConfig("DIA" + (string)listaCategoriaDIA.SelectedItem);
        }

        private void rbSimSERV_CheckedChanged(object sender, EventArgs e)
        {
            dalConfig conf = new dalConfig();
            if (rbSimSERV.Checked)
                conf.atuConfig("SERV", "S");
            else
                conf.atuConfig("SERV", "N");
        }
    }
}
