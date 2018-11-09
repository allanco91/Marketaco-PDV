namespace Marketaco.UI.Report
{
    partial class repListaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repListaEstoque));
            this.rvListaEstoque = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RelEstoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvListaEstoque
            // 
            this.rvListaEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsListaEstoque";
            reportDataSource1.Value = this.RelEstoqueBindingSource;
            this.rvListaEstoque.LocalReport.DataSources.Add(reportDataSource1);
            this.rvListaEstoque.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relListaEstoque .rdlc";
            this.rvListaEstoque.Location = new System.Drawing.Point(0, 0);
            this.rvListaEstoque.Name = "rvListaEstoque";
            this.rvListaEstoque.Size = new System.Drawing.Size(284, 264);
            this.rvListaEstoque.TabIndex = 0;
            // 
            // RelEstoqueBindingSource
            // 
            this.RelEstoqueBindingSource.DataSource = typeof(Marketaco.DAL.dalEstoque.RelEstoque);
            // 
            // repListaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvListaEstoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repListaEstoque";
            this.Text = "Lista de estoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repListaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelEstoqueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvListaEstoque;
        public System.Windows.Forms.BindingSource RelEstoqueBindingSource;
    }
}