namespace Marketaco.UI
{
    partial class formPedidoGerenciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPedidoGerenciar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomePedido = new System.Windows.Forms.TextBox();
            this.btNovoPedido = new System.Windows.Forms.Button();
            this.rbFinalizados = new System.Windows.Forms.RadioButton();
            this.rbAberto = new System.Windows.Forms.RadioButton();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome/Mesa:";
            // 
            // tbNomePedido
            // 
            this.tbNomePedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNomePedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomePedido.Location = new System.Drawing.Point(16, 30);
            this.tbNomePedido.MaxLength = 30;
            this.tbNomePedido.Name = "tbNomePedido";
            this.tbNomePedido.Size = new System.Drawing.Size(392, 27);
            this.tbNomePedido.TabIndex = 1;
            this.tbNomePedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNomePedido_KeyDown);
            // 
            // btNovoPedido
            // 
            this.btNovoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovoPedido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoPedido.Image = ((System.Drawing.Image)(resources.GetObject("btNovoPedido.Image")));
            this.btNovoPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNovoPedido.Location = new System.Drawing.Point(414, 22);
            this.btNovoPedido.Name = "btNovoPedido";
            this.btNovoPedido.Size = new System.Drawing.Size(137, 43);
            this.btNovoPedido.TabIndex = 2;
            this.btNovoPedido.Text = "Novo Pedido";
            this.btNovoPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNovoPedido.UseVisualStyleBackColor = true;
            this.btNovoPedido.Click += new System.EventHandler(this.btNovoPedido_Click);
            // 
            // rbFinalizados
            // 
            this.rbFinalizados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFinalizados.AutoSize = true;
            this.rbFinalizados.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.rbFinalizados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbFinalizados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFinalizados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbFinalizados.Location = new System.Drawing.Point(700, 31);
            this.rbFinalizados.Name = "rbFinalizados";
            this.rbFinalizados.Size = new System.Drawing.Size(100, 24);
            this.rbFinalizados.TabIndex = 4;
            this.rbFinalizados.Text = "Finalizados";
            this.rbFinalizados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbFinalizados.UseVisualStyleBackColor = true;
            this.rbFinalizados.Click += new System.EventHandler(this.botoes_Alterar);
            // 
            // rbAberto
            // 
            this.rbAberto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAberto.AutoSize = true;
            this.rbAberto.Checked = true;
            this.rbAberto.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.rbAberto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbAberto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAberto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbAberto.Location = new System.Drawing.Point(597, 31);
            this.rbAberto.Name = "rbAberto";
            this.rbAberto.Size = new System.Drawing.Size(97, 24);
            this.rbAberto.TabIndex = 3;
            this.rbAberto.TabStop = true;
            this.rbAberto.Text = "Em Aberto";
            this.rbAberto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbAberto.UseVisualStyleBackColor = true;
            this.rbAberto.Click += new System.EventHandler(this.botoes_Alterar);
            // 
            // dgvPedido
            // 
            this.dgvPedido.AllowUserToAddRows = false;
            this.dgvPedido.AllowUserToDeleteRows = false;
            this.dgvPedido.AllowUserToResizeRows = false;
            this.dgvPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPedido.Location = new System.Drawing.Point(0, 71);
            this.dgvPedido.MultiSelect = false;
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedido.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPedido.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedido.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPedido.Size = new System.Drawing.Size(812, 406);
            this.dgvPedido.TabIndex = 5;
            this.dgvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick_Aberto);
            // 
            // formPedidoGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNomePedido);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.btNovoPedido);
            this.Controls.Add(this.rbAberto);
            this.Controls.Add(this.rbFinalizados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "formPedidoGerenciar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar pedidos";
            this.Activated += new System.EventHandler(this.formPedidoGerenciar_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formPedidoGerenciar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.RadioButton rbAberto;
        private System.Windows.Forms.RadioButton rbFinalizados;
        private System.Windows.Forms.Button btNovoPedido;
        private System.Windows.Forms.TextBox tbNomePedido;
        private System.Windows.Forms.Label label1;
    }
}