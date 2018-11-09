namespace Marketaco.UI.Report
{
    partial class repTotalPorMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repTotalPorMes));
            this.rvTotalPorMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GrupoMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrupoMesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvTotalPorMes
            // 
            this.rvTotalPorMes.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsGrupoMes";
            reportDataSource1.Value = this.GrupoMesBindingSource;
            reportDataSource2.Name = "dsDatas";
            reportDataSource2.Value = this.DatasBindingSource;
            this.rvTotalPorMes.LocalReport.DataSources.Add(reportDataSource1);
            this.rvTotalPorMes.LocalReport.DataSources.Add(reportDataSource2);
            this.rvTotalPorMes.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relTotalPorMes.rdlc";
            this.rvTotalPorMes.Location = new System.Drawing.Point(0, 0);
            this.rvTotalPorMes.Name = "rvTotalPorMes";
            this.rvTotalPorMes.Size = new System.Drawing.Size(284, 264);
            this.rvTotalPorMes.TabIndex = 0;
            // 
            // GrupoMesBindingSource
            // 
            this.GrupoMesBindingSource.DataSource = typeof(Marketaco.DAL.dalPedido.GrupoMes);
            // 
            // DatasBindingSource
            // 
            this.DatasBindingSource.DataSource = typeof(Marketaco.UI.formRelatorio.Datas);
            // 
            // repTotalPorMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvTotalPorMes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repTotalPorMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório: Total por Mês";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repTotalPorMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupoMesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvTotalPorMes;
        public System.Windows.Forms.BindingSource DatasBindingSource;
        public System.Windows.Forms.BindingSource GrupoMesBindingSource;
    }
}