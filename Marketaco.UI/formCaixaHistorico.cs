using System;
using System.Windows.Forms;
using Marketaco.DAL;
using Marketaco.UI.Report;

namespace Marketaco.UI
{
    public partial class formCaixaHistorico : Form
    {
        public formCaixaHistorico()
        {
            InitializeComponent();
        }

        #region Classes
        public class Taxas
        {
            public decimal TaxaC { get; set; }
            public decimal TaxaD { get; set; }
        }
        #endregion

        #region Métodos
        private void populaGrid()
        {
            dalCaixa dalCa = new dalCaixa();
            dgvHistoricoCaixa.DataSource = rbRecentes.Checked ? dalCa.listaCaixa(Convert.ToInt32(nudNumero.Value)) : dalCa.listaCaixa(dtpDataInicial.Value.Date, dtpDataFinal.Value.Date);
            formataGrid();
        }

        private void formataGrid()
        {
            dgvHistoricoCaixa.Columns[0].HeaderText = "ID";
            dgvHistoricoCaixa.Columns[0].Visible = false;
            dgvHistoricoCaixa.Columns[1].HeaderText = "Abertura";
            dgvHistoricoCaixa.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHistoricoCaixa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHistoricoCaixa.Columns[2].HeaderText = "Fechamento";
            dgvHistoricoCaixa.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHistoricoCaixa.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHistoricoCaixa.Columns[3].HeaderText = "Saldo-Inicial";
            dgvHistoricoCaixa.Columns[3].DefaultCellStyle.Format = "f";
            dgvHistoricoCaixa.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHistoricoCaixa.Columns[4].HeaderText = "Saldo-Final";
            dgvHistoricoCaixa.Columns[4].DefaultCellStyle.Format = "f";
            dgvHistoricoCaixa.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHistoricoCaixa.Columns[5].HeaderText = "e_dinheiro";
            dgvHistoricoCaixa.Columns[5].Visible = false;
            dgvHistoricoCaixa.Columns[6].HeaderText = "c_debito";
            dgvHistoricoCaixa.Columns[6].Visible = false;
            dgvHistoricoCaixa.Columns[7].HeaderText = "c_credito";
            dgvHistoricoCaixa.Columns[7].Visible = false;
            dgvHistoricoCaixa.Columns[8].HeaderText = "e_cheque";
            dgvHistoricoCaixa.Columns[8].Visible = false;
            dgvHistoricoCaixa.Columns[9].HeaderText = "s_dinheiro";
            dgvHistoricoCaixa.Columns[9].Visible = false;
            dgvHistoricoCaixa.Columns[10].HeaderText = "s_cheque";
            dgvHistoricoCaixa.Columns[10].Visible = false;
            dgvHistoricoCaixa.Columns[11].HeaderText = "saldo_dinheiro";
            dgvHistoricoCaixa.Columns[11].Visible = false;
            dgvHistoricoCaixa.Columns[12].HeaderText = "Observação";
            dgvHistoricoCaixa.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHistoricoCaixa.Columns[13].HeaderText = "Status";
            dgvHistoricoCaixa.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvHistoricoCaixa.Columns[14].HeaderText = "TaxaC";
            dgvHistoricoCaixa.Columns[14].Visible = false;
            dgvHistoricoCaixa.Columns[15].HeaderText = "TaxaD";
            dgvHistoricoCaixa.Columns[15].Visible = false;
        }

        private void imprimirResumo(int id)
        {
            try
            {
                repResumoCaixa relatorio = new repResumoCaixa();
                dalCaixa dalC = new dalCaixa();
                relatorio.LCaixaBindingSource.DataSource = dalC.achaCaixa(id);
                relatorio.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO");
            }
        }

        private void imprimirMovimento(int id)
        {
            try
            {
                repMovimentoCaixa relatorio = new repMovimentoCaixa();
                dalLancamentosCaixa dalLanc = new dalLancamentosCaixa();
                relatorio.LCaixaBindingSource.DataSource = dalLanc.listaMovimento(id);
                relatorio.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO");
            }
        }
        #endregion

        #region Eventos
        private void formCaixaHistorico_Activated(object sender, EventArgs e)
        {
            populaGrid();
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            populaGrid();
        }

        private void btImprimirResumo_Click(object sender, EventArgs e)
        {
            try
            {
                imprimirResumo((int)dgvHistoricoCaixa.CurrentRow.Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("É preciso selecionar um item para exibir o resumo do caixa", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btImprimirMovimento_Click(object sender, EventArgs e)
        {
            try
            {
                imprimirMovimento((int)dgvHistoricoCaixa.CurrentRow.Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("É preciso selecionar um item para exibir o movimento do caixa", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region KeyDown
        private void formCaixaHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        #endregion
    }
}
