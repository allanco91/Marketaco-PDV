namespace Marketaco.UI.Report
{
    partial class repHistoricoEntSai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repHistoricoEntSai));
            this.rvHistoricoEntSai = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelHistEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RelHistEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvHistoricoEntSai
            // 
            this.rvHistoricoEntSai.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsHistoricoEntSai";
            reportDataSource1.Value = this.RelHistEstoqueBindingSource;
            reportDataSource2.Name = "dsDatas";
            reportDataSource2.Value = this.DatasBindingSource;
            this.rvHistoricoEntSai.LocalReport.DataSources.Add(reportDataSource1);
            this.rvHistoricoEntSai.LocalReport.DataSources.Add(reportDataSource2);
            this.rvHistoricoEntSai.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relHistoricoEntSai.rdlc";
            this.rvHistoricoEntSai.Location = new System.Drawing.Point(0, 0);
            this.rvHistoricoEntSai.Name = "rvHistoricoEntSai";
            this.rvHistoricoEntSai.Size = new System.Drawing.Size(284, 264);
            this.rvHistoricoEntSai.TabIndex = 0;
            // 
            // RelHistEstoqueBindingSource
            // 
            this.RelHistEstoqueBindingSource.DataSource = typeof(Marketaco.DAL.dalEstoque.RelHistEstoque);
            // 
            // DatasBindingSource
            // 
            this.DatasBindingSource.DataSource = typeof(Marketaco.UI.formRelatorio.Datas);
            // 
            // repHistoricoEntSai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvHistoricoEntSai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repHistoricoEntSai";
            this.Text = "Histórico entrada e saída";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repHistoricoEntSai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelHistEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvHistoricoEntSai;
        public System.Windows.Forms.BindingSource DatasBindingSource;
        public System.Windows.Forms.BindingSource RelHistEstoqueBindingSource;
    }
}