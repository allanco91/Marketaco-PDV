namespace Marketaco.UI
{
    partial class formPedidoVisualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPedidoVisualizar));
            this.rtbPedido = new System.Windows.Forms.RichTextBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbPedido
            // 
            this.rtbPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbPedido.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPedido.Location = new System.Drawing.Point(0, 0);
            this.rtbPedido.Name = "rtbPedido";
            this.rtbPedido.ReadOnly = true;
            this.rtbPedido.Size = new System.Drawing.Size(354, 404);
            this.rtbPedido.TabIndex = 0;
            this.rtbPedido.Text = "";
            // 
            // btImprimir
            // 
            this.btImprimir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btImprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btImprimir.Image")));
            this.btImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImprimir.Location = new System.Drawing.Point(0, 404);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(354, 43);
            this.btImprimir.TabIndex = 1;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // formPedidoVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 447);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.rtbPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "formPedidoVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Pedido";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formPedidoVisualizar_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbPedido;
        private System.Windows.Forms.Button btImprimir;
    }
}