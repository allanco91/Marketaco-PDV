namespace Marketaco.UI.Report
{
    partial class repMovimentoCaixa
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
            this.rvMovimentoCaixa = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.LCaixaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LCaixaBindingSource
            // 
            this.LCaixaBindingSource.DataMember = "LCaixa";
            // 
            // rvMovimentoCaixa
            // 
            this.rvMovimentoCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsLCAIXA";
            reportDataSource1.Value = this.LCaixaBindingSource;
            this.rvMovimentoCaixa.LocalReport.DataSources.Add(reportDataSource1);
            this.rvMovimentoCaixa.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relMovimentoCaixa.rdlc";
            this.rvMovimentoCaixa.Location = new System.Drawing.Point(0, 0);
            this.rvMovimentoCaixa.Name = "rvMovimentoCaixa";
            this.rvMovimentoCaixa.Size = new System.Drawing.Size(284, 261);
            this.rvMovimentoCaixa.TabIndex = 0;
            // 
            // repMovimentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rvMovimentoCaixa);
            this.Name = "repMovimentoCaixa";
            this.ShowIcon = false;
            this.Text = "Movimento do Caixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repMovimentoCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LCaixaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvMovimentoCaixa;
        public System.Windows.Forms.BindingSource LCaixaBindingSource;
    }
}