namespace Marketaco.UI.Report
{
    partial class repEstoqueMin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repEstoqueMin));
            this.rvEstoqueMin = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RelEstoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvEstoqueMin
            // 
            this.rvEstoqueMin.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsListaEstoque";
            reportDataSource1.Value = this.RelEstoqueBindingSource;
            this.rvEstoqueMin.LocalReport.DataSources.Add(reportDataSource1);
            this.rvEstoqueMin.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relListaEstoqueMínimo.rdlc";
            this.rvEstoqueMin.Location = new System.Drawing.Point(0, 0);
            this.rvEstoqueMin.Name = "rvEstoqueMin";
            this.rvEstoqueMin.Size = new System.Drawing.Size(284, 264);
            this.rvEstoqueMin.TabIndex = 0;
            // 
            // RelEstoqueBindingSource
            // 
            this.RelEstoqueBindingSource.DataSource = typeof(Marketaco.DAL.dalEstoque.RelEstoque);
            // 
            // repEstoqueMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvEstoqueMin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repEstoqueMin";
            this.Text = "Lista estoque mínimo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repEstoqueMin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelEstoqueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvEstoqueMin;
        public System.Windows.Forms.BindingSource RelEstoqueBindingSource;
    }
}