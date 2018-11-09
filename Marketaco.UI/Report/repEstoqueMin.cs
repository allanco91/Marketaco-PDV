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
    public partial class repEstoqueMin : Form
    {
        public repEstoqueMin()
        {
            InitializeComponent();
        }

        private void repEstoqueMin_Load(object sender, EventArgs e)
        {
            rvEstoqueMin.RefreshReport();
            rvEstoqueMin.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvEstoqueMin.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
