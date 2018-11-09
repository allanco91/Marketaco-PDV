using System;
using System.Windows.Forms;

namespace Marketaco.UI.Report
{
    public partial class repMovimentoCaixa : Form
    {
        public repMovimentoCaixa()
        {
            InitializeComponent();
        }

        private void repMovimentoCaixa_Load(object sender, EventArgs e)
        {

            rvMovimentoCaixa.RefreshReport();
            rvMovimentoCaixa.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvMovimentoCaixa.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
