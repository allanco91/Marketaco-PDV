using System;
using System.Windows.Forms;

namespace Marketaco.UI.Report
{
    public partial class repVendas : Form
    {
        public repVendas()
        {
            InitializeComponent();
        }

        private void repVendas_Load(object sender, EventArgs e)
        {

            rvVendas.RefreshReport();
            rvVendas.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvVendas.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
