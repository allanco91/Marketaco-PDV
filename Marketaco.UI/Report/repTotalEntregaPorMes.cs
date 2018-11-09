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
    public partial class repTotalEntregaPorMes : Form
    {
        public repTotalEntregaPorMes()
        {
            InitializeComponent();
        }

        private void repTotalEntregaPorMes_Load(object sender, EventArgs e)
        {
            rvGrupoEntrega.RefreshReport();
            rvGrupoEntrega.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvGrupoEntrega.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
