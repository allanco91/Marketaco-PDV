namespace Marketaco.UI.Report
{
    partial class repLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repLogs));
            this.rvLogs = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvLogs
            // 
            this.rvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsLogs";
            reportDataSource1.Value = this.LogsBindingSource;
            reportDataSource2.Name = "dsDatas";
            reportDataSource2.Value = this.DatasBindingSource;
            this.rvLogs.LocalReport.DataSources.Add(reportDataSource1);
            this.rvLogs.LocalReport.DataSources.Add(reportDataSource2);
            this.rvLogs.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relLogs.rdlc";
            this.rvLogs.Location = new System.Drawing.Point(0, 0);
            this.rvLogs.Name = "rvLogs";
            this.rvLogs.Size = new System.Drawing.Size(284, 264);
            this.rvLogs.TabIndex = 0;
            // 
            // LogsBindingSource
            // 
            this.LogsBindingSource.DataSource = typeof(Marketaco.DOM.Entities.Logs);
            // 
            // DatasBindingSource
            // 
            this.DatasBindingSource.DataSource = typeof(Marketaco.UI.formRelatorio.Datas);
            // 
            // repLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repLogs";
            this.Text = "Histórico de ações";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvLogs;
        public System.Windows.Forms.BindingSource LogsBindingSource;
        public System.Windows.Forms.BindingSource DatasBindingSource;
    }
}