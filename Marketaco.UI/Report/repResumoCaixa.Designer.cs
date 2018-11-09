namespace Marketaco.UI.Report
{
    partial class repResumoCaixa
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
            this.LCaixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvResumoCaixa = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.LCaixaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LCaixaBindingSource
            // 
            this.LCaixaBindingSource.DataSource = typeof(Marketaco.DAL.dalCaixa.LCaixa);
            // 
            // rvResumoCaixa
            // 
            this.rvResumoCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsLCAIXA";
            reportDataSource1.Value = this.LCaixaBindingSource;
            this.rvResumoCaixa.LocalReport.DataSources.Add(reportDataSource1);
            this.rvResumoCaixa.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relResumoCaixa.rdlc";
            this.rvResumoCaixa.Location = new System.Drawing.Point(0, 0);
            this.rvResumoCaixa.Name = "rvResumoCaixa";
            this.rvResumoCaixa.Size = new System.Drawing.Size(284, 261);
            this.rvResumoCaixa.TabIndex = 0;
            // 
            // repResumoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rvResumoCaixa);
            this.Name = "repResumoCaixa";
            this.ShowIcon = false;
            this.Text = "Resumo do Caixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repResumoCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LCaixaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvResumoCaixa;
        public System.Windows.Forms.BindingSource LCaixaBindingSource;
    }
}