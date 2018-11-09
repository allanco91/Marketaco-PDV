namespace Marketaco.UI.Report
{
    partial class repListaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repListaCategoria));
            this.rvListaCategoria = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvListaCategoria
            // 
            this.rvListaCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsCategoria";
            reportDataSource1.Value = this.CategoriaBindingSource;
            this.rvListaCategoria.LocalReport.DataSources.Add(reportDataSource1);
            this.rvListaCategoria.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relListaCategoria.rdlc";
            this.rvListaCategoria.Location = new System.Drawing.Point(0, 0);
            this.rvListaCategoria.Name = "rvListaCategoria";
            this.rvListaCategoria.Size = new System.Drawing.Size(284, 264);
            this.rvListaCategoria.TabIndex = 0;
            // 
            // CategoriaBindingSource
            // 
            this.CategoriaBindingSource.DataSource = typeof(Marketaco.DOM.Entities.Categoria);
            // 
            // repListaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvListaCategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repListaCategoria";
            this.Text = "Lista de categorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repListaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvListaCategoria;
        public System.Windows.Forms.BindingSource CategoriaBindingSource;
    }
}