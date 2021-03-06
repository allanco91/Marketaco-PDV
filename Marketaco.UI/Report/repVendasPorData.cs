﻿using System;
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
    public partial class repVendasPorData : Form
    {
        public repVendasPorData()
        {
            InitializeComponent();
        }

        private void repVendasPorData_Load(object sender, EventArgs e)
        {
            rvVendasPorData.RefreshReport();
            rvVendasPorData.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rvVendasPorData.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
    }
}
