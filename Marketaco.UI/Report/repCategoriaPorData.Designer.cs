namespace Marketaco.UI.Report
{
    partial class repCategoriaPorData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repCategoriaPorData));
            this.rvCategoriaPorData = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GrupoCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoCategoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvCategoriaPorData
            // 
            this.rvCategoriaPorData.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsData";
            reportDataSource1.Value = this.DatasBindingSource;
            reportDataSource2.Name = "dsGrupoCategorias";
            reportDataSource2.Value = this.GrupoCategoriasBindingSource;
            this.rvCategoriaPorData.LocalReport.DataSources.Add(reportDataSource1);
            this.rvCategoriaPorData.LocalReport.DataSources.Add(reportDataSource2);
            this.rvCategoriaPorData.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relCategoriaPorData.rdlc";
            this.rvCategoriaPorData.Location = new System.Drawing.Point(0, 0);
            this.rvCategoriaPorData.Name = "rvCategoriaPorData";
            this.rvCategoriaPorData.Size = new System.Drawing.Size(284, 264);
            this.rvCategoriaPorData.TabIndex = 0;
            // 
            // DatasBindingSource
            // 
            this.DatasBindingSource.DataMember = "Datas";
            // 
            // GrupoCategoriasBindingSource
            // 
            this.GrupoCategoriasBindingSource.DataSource = typeof(Marketaco.DAL.dalItensPedido.GrupoCategorias);
            // 
            // repCategoriaPorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvCategoriaPorData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repCategoriaPorData";
            this.Text = "Categoria por data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repCategoriaPorData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoCategoriasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCategoriaPorData;
        public System.Windows.Forms.BindingSource DatasBindingSource;
        public System.Windows.Forms.BindingSource GrupoCategoriasBindingSource;
    }
}