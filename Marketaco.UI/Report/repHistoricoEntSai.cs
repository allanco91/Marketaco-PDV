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
    public partial class repHistoricoEntSai : Form
    {
        public repHistoricoEntSai()
        {
            InitializeComponent();
        }

        private void repHistoricoEntSai_Load(object sender, EventArgs e)
        {
            rvHistoricoEntSai.RefreshReport();
            rvHistoricoEntSai.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvHistoricoEntSai.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
