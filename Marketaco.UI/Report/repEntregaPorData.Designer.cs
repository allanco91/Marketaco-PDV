namespace Marketaco.UI.Report
{
    partial class repEntregaPorData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repEntregaPorData));
            this.rvEntregaPorData = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GrupoEntregaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrupoEntregaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvEntregaPorData
            // 
            this.rvEntregaPorData.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsGrupoEntrega";
            reportDataSource1.Value = this.GrupoEntregaBindingSource;
            reportDataSource2.Name = "dsData";
            reportDataSource2.Value = this.DatasBindingSource;
            this.rvEntregaPorData.LocalReport.DataSources.Add(reportDataSource1);
            this.rvEntregaPorData.LocalReport.DataSources.Add(reportDataSource2);
            this.rvEntregaPorData.LocalReport.ReportEmbeddedResource = "Marketaco.UI.Report.relEntregaPorData.rdlc";
            this.rvEntregaPorData.Location = new System.Drawing.Point(0, 0);
            this.rvEntregaPorData.Name = "rvEntregaPorData";
            this.rvEntregaPorData.Size = new System.Drawing.Size(284, 264);
            this.rvEntregaPorData.TabIndex = 0;
            // 
            // GrupoEntregaBindingSource
            // 
            this.GrupoEntregaBindingSource.DataSource = typeof(Marketaco.DAL.dalPedido.GrupoEntrega);
            // 
            // DatasBindingSource
            // 
            this.DatasBindingSource.DataMember = "Datas";
            // 
            // repEntregaPorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.rvEntregaPorData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repEntregaPorData";
            this.Text = "Entrega por data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.repEntregaPorData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupoEntregaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvEntregaPorData;
        public System.Windows.Forms.BindingSource GrupoEntregaBindingSource;
        public System.Windows.Forms.BindingSource DatasBindingSource;
    }
}