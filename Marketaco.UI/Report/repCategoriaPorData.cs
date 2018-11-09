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
    public partial class repCategoriaPorData : Form
    {
        public repCategoriaPorData()
        {
            InitializeComponent();
        }

        private void repCategoriaPorData_Load(object sender, EventArgs e)
        {
            rvCategoriaPorData.RefreshReport();
            rvCategoriaPorData.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvCategoriaPorData.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
