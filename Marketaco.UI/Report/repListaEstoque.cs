using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marketaco.UI.Report
{
    public partial class repListaEstoque : Form
    {
        public repListaEstoque()
        {
            InitializeComponent();
        }

        private void repListaEstoque_Load(object sender, EventArgs e)
        {
            rvListaEstoque.RefreshReport();
            rvListaEstoque.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvListaEstoque.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
