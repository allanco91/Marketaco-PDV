using System;
using System.Windows.Forms;

namespace Marketaco.UI.Report
{
    public partial class repResumoCaixa : Form
    {
        public repResumoCaixa()
        {
            InitializeComponent();
        }

        private void repResumoCaixa_Load(object sender, EventArgs e)
        {

            rvResumoCaixa.RefreshReport();
            rvResumoCaixa.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvResumoCaixa.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
