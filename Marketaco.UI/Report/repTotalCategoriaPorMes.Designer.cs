namespace Marketaco.UI.Report
{
    partial class repTotalCategoriaPorMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repTotalCategoriaPorMes));
            this.rvGrupoCategoria = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GrupoCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoCategoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvGrupoCategoria
            // 
            this.rvGrupoCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsData";
            reportDataSource1.Value = this.DatasBindingSource;
            reportDataSource2.Name = "dsGrupoCategorias";
            reportDataSource2.Value = this.GrupoCategoriasBindingSource;
            this.rvGrupoCategoria.LocalReport.DataSources.Add(reportDataSource1);
            this.rvGrupoCategoria.LocalReport.DataSources.Add(reportDataSource2);
            this.rvGrupoCategoria.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relTotalCategoriaPorMes.rdlc";
            this.rvGrupoCategoria.Location = new System.Drawing.Point(0, 0);
            this.rvGrupoCategoria.Name = "rvGrupoCategoria";
            this.rvGrupoCategoria.Size = new System.Drawing.Size(284, 264);
            this.rvGrupoCategoria.TabIndex = 0;
            // 
            // DatasBindingSource
            // 
            this.DatasBindingSource.DataSource = typeof(Marketaco.UI.formRelatorio.Datas);
            // 
            // GrupoCategoriasBindingSource
            // 
            this.GrupoCategoriasBindingSource.DataSource = typeof(Marketaco.DAL.dalItensPedido.GrupoCategorias);
            // 
            // repTotalCategoriaPorMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvGrupoCategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repTotalCategoriaPorMes";
            this.Text = "Total Categoria por Mês";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repTotalCategoriaPorMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoCategoriasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvGrupoCategoria;
        public System.Windows.Forms.BindingSource DatasBindingSource;
        public System.Windows.Forms.BindingSource GrupoCategoriasBindingSource;
    }
}