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
    public partial class repEstoqueProducao : Form
    {
        public repEstoqueProducao()
        {
            InitializeComponent();
        }

        private void repEstoqueProducao_Load(object sender, EventArgs e)
        {
            rvEstoqueProducao.RefreshReport();
            rvEstoqueProducao.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvEstoqueProducao.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
