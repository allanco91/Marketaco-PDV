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
using Marketaco.UI.Report;

namespace Marketaco.UI
{
    public partial class formLogs : Form
    {
        public formLogs()
        {
            InitializeComponent();
        }

        public class Datas
        {
            public DateTime data_inicial { get; set; }
            public DateTime data_final { get; set; }
        }

        private void carregaGrid(DateTime Data1, DateTime Data2, string Operador)
        {
            dalLogs log = new dalLogs();
            dgvLogs.DataSource = log.listaLog(Data1, Data2, Operador);
        }

        private void formataGrid()
        {
            dgvLogs.Columns[0].HeaderText = "ID";
            dgvLogs.Columns[0].Visible = false;
            dgvLogs.Columns[1].HeaderText = "Data";
            dgvLogs.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvLogs.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvLogs.Columns[2].HeaderText = "Operador";
            dgvLogs.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvLogs.Columns[3].HeaderText = "Ação";
            dgvLogs.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void formLogs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            carregaGrid(dtpData1.Value, dtpData2.Value, tbOperador.Text);
            formataGrid();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            repLogs rel = new repLogs();
            rel.LogsBindingSource.DataSource = dgvLogs.DataSource;
            rel.DatasBindingSource.DataSource = new Datas { data_inicial = dtpData1.Value.Date, data_final = dtpData2.Value.Date };
            rel.Show();
        }

        private void formLogs_Load(object sender, EventArgs e)
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
            toolTip.SetToolTip(btImprimir, "Imprimir");
        }
    }
}
