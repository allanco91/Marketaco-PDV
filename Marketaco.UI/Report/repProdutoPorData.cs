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
    public partial class repProdutoPorData : Form
    {
        public repProdutoPorData()
        {
            InitializeComponent();
        }

        private void repProdutoPorData_Load(object sender, EventArgs e)
        {
            rvProdutoPorData.RefreshReport();
            rvProdutoPorData.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvProdutoPorData.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
