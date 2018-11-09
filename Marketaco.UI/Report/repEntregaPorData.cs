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
    public partial class repEntregaPorData : Form
    {
        public repEntregaPorData()
        {
            InitializeComponent();
        }

        private void repEntregaPorData_Load(object sender, EventArgs e)
        {
            rvEntregaPorData.RefreshReport();
            rvEntregaPorData.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvEntregaPorData.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
