namespace Marketaco.UI.Report
{
    partial class repTotalProdutoPorMes
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
            this.GrupoProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvTotalProdutoMes = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoProdutosBindingSource
            // 
            this.GrupoProdutosBindingSource.DataSource = typeof(Marketaco.DAL.dalItensPedido.GrupoProdutos);
            // 
            // DatasBindingSource
            // 
            this.DatasBindingSource.DataSource = typeof(Marketaco.UI.formRelatorio.Datas);
            // 
            // rvTotalProdutoMes
            // 
            this.rvTotalProdutoMes.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsGrupoProdutos";
            reportDataSource1.Value = this.GrupoProdutosBindingSource;
            reportDataSource2.Name = "dsData";
            reportDataSource2.Value = this.DatasBindingSource;
            this.rvTotalProdutoMes.LocalReport.DataSources.Add(reportDataSource1);
            this.rvTotalProdutoMes.LocalReport.DataSources.Add(reportDataSource2);
            this.rvTotalProdutoMes.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relTotalProdutoPorMes.rdlc";
            this.rvTotalProdutoMes.Location = new System.Drawing.Point(0, 0);
            this.rvTotalProdutoMes.Name = "rvTotalProdutoMes";
            this.rvTotalProdutoMes.Size = new System.Drawing.Size(284, 264);
            this.rvTotalProdutoMes.TabIndex = 0;
            // 
            // repTotalProdutoPorMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvTotalProdutoMes);
            this.Name = "repTotalProdutoPorMes";
            this.Text = "Total produtos por mês";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repTotalProdutoPorMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupoProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvTotalProdutoMes;
        public System.Windows.Forms.BindingSource GrupoProdutosBindingSource;
        public System.Windows.Forms.BindingSource DatasBindingSource;
    }
}