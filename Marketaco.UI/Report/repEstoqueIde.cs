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
    public partial class repEstoqueIde : Form
    {
        public repEstoqueIde()
        {
            InitializeComponent();
        }

        private void repEstoqueIde_Load(object sender, EventArgs e)
        {
            rvEstoqueIde.RefreshReport();
            rvEstoqueIde.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvEstoqueIde.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
