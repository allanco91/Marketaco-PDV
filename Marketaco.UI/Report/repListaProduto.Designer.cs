namespace Marketaco.UI.Report
{
    partial class repListaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repListaProduto));
            this.rvListaProduto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RelProdutosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvListaProduto
            // 
            this.rvListaProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsListaProduto";
            reportDataSource1.Value = this.RelProdutosBindingSource;
            this.rvListaProduto.LocalReport.DataSources.Add(reportDataSource1);
            this.rvListaProduto.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relListaProduto.rdlc";
            this.rvListaProduto.Location = new System.Drawing.Point(0, 0);
            this.rvListaProduto.Name = "rvListaProduto";
            this.rvListaProduto.Size = new System.Drawing.Size(284, 264);
            this.rvListaProduto.TabIndex = 0;
            // 
            // RelProdutosBindingSource
            // 
            this.RelProdutosBindingSource.DataSource = typeof(Marketaco.DAL.dalProduto.RelProdutos);
            // 
            // repListaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvListaProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repListaProduto";
            this.Text = "Lista de produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repListaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelProdutosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvListaProduto;
        public System.Windows.Forms.BindingSource RelProdutosBindingSource;
    }
}