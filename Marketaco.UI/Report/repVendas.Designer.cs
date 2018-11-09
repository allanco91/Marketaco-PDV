namespace Marketaco.UI.Report
{
    partial class repVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repVendas));
            this.lvItensPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvVendas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.lvItensPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lvItensPedidoBindingSource
            // 
            this.lvItensPedidoBindingSource.DataMember = "lvItensPedido";
            // 
            // DatasBindingSource
            // 
            this.DatasBindingSource.DataSource = typeof(Marketaco.UI.formRelatorio.Datas);
            // 
            // rvVendas
            // 
            this.rvVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsItensPedidos";
            reportDataSource1.Value = this.lvItensPedidoBindingSource;
            reportDataSource2.Name = "dsDATAS";
            reportDataSource2.Value = this.DatasBindingSource;
            this.rvVendas.LocalReport.DataSources.Add(reportDataSource1);
            this.rvVendas.LocalReport.DataSources.Add(reportDataSource2);
            this.rvVendas.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relVendas.rdlc";
            this.rvVendas.Location = new System.Drawing.Point(0, 0);
            this.rvVendas.Name = "rvVendas";
            this.rvVendas.Size = new System.Drawing.Size(284, 261);
            this.rvVendas.TabIndex = 0;
            // 
            // repVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rvVendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repVendas";
            this.Text = "Vendas por período";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvItensPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvVendas;
        public System.Windows.Forms.BindingSource lvItensPedidoBindingSource;
        public System.Windows.Forms.BindingSource DatasBindingSource;
    }
}