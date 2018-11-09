namespace Marketaco.UI.Report
{
    partial class repVendasPorData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repVendasPorData));
            this.rvVendasPorData = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GrupoMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoMesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvVendasPorData
            // 
            this.rvVendasPorData.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsDatas";
            reportDataSource1.Value = this.DatasBindingSource;
            reportDataSource2.Name = "dsVendaPorData";
            reportDataSource2.Value = this.GrupoMesBindingSource;
            this.rvVendasPorData.LocalReport.DataSources.Add(reportDataSource1);
            this.rvVendasPorData.LocalReport.DataSources.Add(reportDataSource2);
            this.rvVendasPorData.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relVendasPorData.rdlc";
            this.rvVendasPorData.Location = new System.Drawing.Point(0, 0);
            this.rvVendasPorData.Name = "rvVendasPorData";
            this.rvVendasPorData.Size = new System.Drawing.Size(284, 264);
            this.rvVendasPorData.TabIndex = 0;
            // 
            // DatasBindingSource
            // 
            this.DatasBindingSource.DataMember = "Datas";
            // 
            // GrupoMesBindingSource
            // 
            this.GrupoMesBindingSource.DataSource = typeof(Marketaco.DAL.dalPedido.GrupoMes);
            // 
            // repVendasPorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvVendasPorData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repVendasPorData";
            this.Text = "Vendas por data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repVendasPorData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoMesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvVendasPorData;
        public System.Windows.Forms.BindingSource DatasBindingSource;
        public System.Windows.Forms.BindingSource GrupoMesBindingSource;
    }
}