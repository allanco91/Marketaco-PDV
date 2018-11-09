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
    public partial class repTotalCategoriaPorMes : Form
    {
        public repTotalCategoriaPorMes()
        {
            InitializeComponent();
        }

        private void repTotalCategoriaPorMes_Load(object sender, EventArgs e)
        {
            rvGrupoCategoria.RefreshReport();
            rvGrupoCategoria.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvGrupoCategoria.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
