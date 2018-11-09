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
    public partial class repLogs : Form
    {
        public repLogs()
        {
            InitializeComponent();
        }

        private void repLogs_Load(object sender, EventArgs e)
        {
            rvLogs.RefreshReport();
            rvLogs.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvLogs.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
