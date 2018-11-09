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
    public partial class repContagemConferencia : Form
    {
        public repContagemConferencia()
        {
            InitializeComponent();
        }

        private void repContagemConferencia_Load(object sender, EventArgs e)
        {
            rvContagemConferencia.RefreshReport();
            rvContagemConferencia.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvContagemConferencia.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
