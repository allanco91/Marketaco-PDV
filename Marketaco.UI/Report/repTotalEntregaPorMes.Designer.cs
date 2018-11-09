namespace Marketaco.UI.Report
{
    partial class repTotalEntregaPorMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repTotalEntregaPorMes));
            this.GrupoEntregaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvGrupoEntrega = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoEntregaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoEntregaBindingSource
            // 
            this.GrupoEntregaBindingSource.DataSource = typeof(Marketaco.DAL.dalPedido.GrupoEntrega);
            // 
            // DatasBindingSource
            // 
            this.DatasBindingSource.DataSource = typeof(Marketaco.UI.formRelatorio.Datas);
            // 
            // rvGrupoEntrega
            // 
            this.rvGrupoEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsGrupoEntrega";
            reportDataSource1.Value = this.GrupoEntregaBindingSource;
            reportDataSource2.Name = "dsData";
            reportDataSource2.Value = this.DatasBindingSource;
            this.rvGrupoEntrega.LocalReport.DataSources.Add(reportDataSource1);
            this.rvGrupoEntrega.LocalReport.DataSources.Add(reportDataSource2);
            this.rvGrupoEntrega.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relTotalEntregaPorMes.rdlc";
            this.rvGrupoEntrega.Location = new System.Drawing.Point(0, 0);
            this.rvGrupoEntrega.Name = "rvGrupoEntrega";
            this.rvGrupoEntrega.Size = new System.Drawing.Size(284, 264);
            this.rvGrupoEntrega.TabIndex = 0;
            // 
            // repTotalEntregaPorMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvGrupoEntrega);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repTotalEntregaPorMes";
            this.Text = "Relatório: Total entrega por mês";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repTotalEntregaPorMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupoEntregaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvGrupoEntrega;
        public System.Windows.Forms.BindingSource GrupoEntregaBindingSource;
        public System.Windows.Forms.BindingSource DatasBindingSource;
    }
}