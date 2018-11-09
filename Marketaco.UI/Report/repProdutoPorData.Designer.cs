namespace Marketaco.UI.Report
{
    partial class repProdutoPorData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repProdutoPorData));
            this.rvProdutoPorData = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GrupoProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrupoProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvProdutoPorData
            // 
            this.rvProdutoPorData.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsGrupoProdutos";
            reportDataSource1.Value = this.GrupoProdutosBindingSource;
            reportDataSource2.Name = "dsData";
            reportDataSource2.Value = this.DatasBindingSource;
            this.rvProdutoPorData.LocalReport.DataSources.Add(reportDataSource1);
            this.rvProdutoPorData.LocalReport.DataSources.Add(reportDataSource2);
            this.rvProdutoPorData.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relProdutoPorData .rdlc";
            this.rvProdutoPorData.Location = new System.Drawing.Point(0, 0);
            this.rvProdutoPorData.Name = "rvProdutoPorData";
            this.rvProdutoPorData.Size = new System.Drawing.Size(284, 264);
            this.rvProdutoPorData.TabIndex = 0;
            // 
            // GrupoProdutosBindingSource
            // 
            this.GrupoProdutosBindingSource.DataSource = typeof(Marketaco.DAL.dalItensPedido.GrupoProdutos);
            // 
            // DatasBindingSource
            // 
            this.DatasBindingSource.DataMember = "Datas";
            // 
            // repProdutoPorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvProdutoPorData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repProdutoPorData";
            this.Text = "Produto por data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repProdutoPorData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupoProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvProdutoPorData;
        public System.Windows.Forms.BindingSource GrupoProdutosBindingSource;
        public System.Windows.Forms.BindingSource DatasBindingSource;
    }
}