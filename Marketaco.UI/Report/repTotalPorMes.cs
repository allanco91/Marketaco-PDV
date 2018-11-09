using System;
using System.Windows.Forms;

namespace Marketaco.UI.Report
{
    public partial class repTotalPorMes : Form
    {
        public repTotalPorMes()
        {
            InitializeComponent();
        }

        private void repTotalPorMes_Load(object sender, EventArgs e)
        {
            rvTotalPorMes.RefreshReport();
            rvTotalPorMes.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvTotalPorMes.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
