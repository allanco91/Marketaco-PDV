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
    public partial class repListaCategoria : Form
    {
        public repListaCategoria()
        {
            InitializeComponent();
        }

        private void repListaCategoria_Load(object sender, EventArgs e)
        {
            rvListaCategoria.RefreshReport();
            rvListaCategoria.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvListaCategoria.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
