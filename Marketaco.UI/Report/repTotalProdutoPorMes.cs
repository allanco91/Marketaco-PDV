using System;
using System.Windows.Forms;

namespace Marketaco.UI.Report
{
    public partial class repTotalProdutoPorMes : Form
    {
        public repTotalProdutoPorMes()
        {
            InitializeComponent();
        }

        private void repTotalProdutoPorMes_Load(object sender, EventArgs e)
        {
            rvTotalProdutoMes.RefreshReport();
            rvTotalProdutoMes.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvTotalProdutoMes.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
