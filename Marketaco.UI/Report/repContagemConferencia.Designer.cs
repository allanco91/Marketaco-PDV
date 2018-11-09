namespace Marketaco.UI.Report
{
    partial class repContagemConferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repContagemConferencia));
            this.rvContagemConferencia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RelEstoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvContagemConferencia
            // 
            this.rvContagemConferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsListaEstoque";
            reportDataSource1.Value = this.RelEstoqueBindingSource;
            this.rvContagemConferencia.LocalReport.DataSources.Add(reportDataSource1);
            this.rvContagemConferencia.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relContagemConferencia.rdlc";
            this.rvContagemConferencia.Location = new System.Drawing.Point(0, 0);
            this.rvContagemConferencia.Name = "rvContagemConferencia";
            this.rvContagemConferencia.Size = new System.Drawing.Size(284, 264);
            this.rvContagemConferencia.TabIndex = 0;
            // 
            // RelEstoqueBindingSource
            // 
            this.RelEstoqueBindingSource.DataSource = typeof(Marketaco.DAL.dalEstoque.RelEstoque);
            // 
            // repContagemConferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvContagemConferencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repContagemConferencia";
            this.Text = "Lista contagem/conferência";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repContagemConferencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelEstoqueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvContagemConferencia;
        public System.Windows.Forms.BindingSource RelEstoqueBindingSource;
    }
}