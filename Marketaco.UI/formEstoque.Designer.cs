namespace Marketaco.UI
{
    partial class formEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEstoque));
            this.grEstoque = new System.Windows.Forms.GroupBox();
            this.grLancamento = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btLancar = new System.Windows.Forms.Button();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.tbAtual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSaida = new System.Windows.Forms.Button();
            this.btEntrada = new System.Windows.Forms.Button();
            this.grEstoque.SuspendLayout();
            this.grLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // grEstoque
            // 
            this.grEstoque.Controls.Add(this.grLancamento);
            this.grEstoque.Controls.Add(this.dgvEstoque);
            this.grEstoque.Controls.Add(this.tbPesquisar);
            this.grEstoque.Controls.Add(this.label1);
            this.grEstoque.Controls.Add(this.btSaida);
            this.grEstoque.Controls.Add(this.btEntrada);
            this.grEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grEstoque.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grEstoque.Location = new System.Drawing.Point(0, 0);
            this.grEstoque.Name = "grEstoque";
            this.grEstoque.Size = new System.Drawing.Size(766, 400);
            this.grEstoque.TabIndex = 20;
            this.grEstoque.TabStop = false;
            this.grEstoque.Text = "Estoque";
            // 
            // grLancamento
            // 
            this.grLancamento.Controls.Add(this.btCancelar);
            this.grLancamento.Controls.Add(this.btLancar);
            this.grLancamento.Controls.Add(this.tbQuantidade);
            this.grLancamento.Controls.Add(this.tbAtual);
            this.grLancamento.Controls.Add(this.label8);
            this.grLancamento.Controls.Add(this.label2);
            this.grLancamento.Controls.Add(this.tbProduto);
            this.grLancamento.Controls.Add(this.label3);
            this.grLancamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grLancamento.Enabled = false;
            this.grLancamento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grLancamento.Location = new System.Drawing.Point(3, 297);
            this.grLancamento.Name = "grLancamento";
            this.grLancamento.Size = new System.Drawing.Size(760, 100);
            this.grLancamento.TabIndex = 23;
            this.grLancamento.TabStop = false;
            this.grLancamento.Text = "Lançamento";
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(710, 42);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(43, 46);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btLancar
            // 
            this.btLancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLancar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLancar.Image = ((System.Drawing.Image)(resources.GetObject("btLancar.Image")));
            this.btLancar.Location = new System.Drawing.Point(661, 42);
            this.btLancar.Name = "btLancar";
            this.btLancar.Size = new System.Drawing.Size(43, 46);
            this.btLancar.TabIndex = 5;
            this.btLancar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLancar.UseVisualStyleBackColor = true;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbQuantidade.Location = new System.Drawing.Point(466, 52);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(189, 27);
            this.tbQuantidade.TabIndex = 1;
            this.tbQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQuantidade_KeyDown);
            this.tbQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNumeros_KeyPress);
            this.tbQuantidade.Leave += new System.EventHandler(this.textboxNumeros_Leave);
            // 
            // tbAtual
            // 
            this.tbAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAtual.Location = new System.Drawing.Point(271, 52);
            this.tbAtual.Name = "tbAtual";
            this.tbAtual.ReadOnly = true;
            this.tbAtual.Size = new System.Drawing.Size(189, 27);
            this.tbAtual.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Estoque Atual:";
            // 
            // tbProduto
            // 
            this.tbProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbProduto.Location = new System.Drawing.Point(14, 52);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.ReadOnly = true;
            this.tbProduto.Size = new System.Drawing.Size(251, 27);
            this.tbProduto.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Produto:";
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.AllowUserToResizeRows = false;
            this.dgvEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(17, 59);
            this.dgvEstoque.MultiSelect = false;
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.Size = new System.Drawing.Size(690, 232);
            this.dgvEstoque.TabIndex = 20;
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPesquisar.Location = new System.Drawing.Point(92, 26);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(615, 27);
            this.tbPesquisar.TabIndex = 1;
            this.tbPesquisar.TextChanged += new System.EventHandler(this.tbPesquisar_TextChanged);
            this.tbPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesquisar_KeyDown);
            this.tbPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPesquisar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pesquisar:";
            // 
            // btSaida
            // 
            this.btSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSaida.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaida.Image = ((System.Drawing.Image)(resources.GetObject("btSaida.Image")));
            this.btSaida.Location = new System.Drawing.Point(713, 178);
            this.btSaida.Name = "btSaida";
            this.btSaida.Size = new System.Drawing.Size(43, 113);
            this.btSaida.TabIndex = 8;
            this.btSaida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSaida.UseVisualStyleBackColor = true;
            this.btSaida.Click += new System.EventHandler(this.btSaida_Click);
            // 
            // btEntrada
            // 
            this.btEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEntrada.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btEntrada.Image")));
            this.btEntrada.Location = new System.Drawing.Point(713, 59);
            this.btEntrada.Name = "btEntrada";
            this.btEntrada.Size = new System.Drawing.Size(43, 113);
            this.btEntrada.TabIndex = 7;
            this.btEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEntrada.UseVisualStyleBackColor = true;
            this.btEntrada.Click += new System.EventHandler(this.btEntrada_Click);
            // 
            // formEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 400);
            this.Controls.Add(this.grEstoque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "formEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.formEstoque_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formEstoque_KeyDown);
            this.grEstoque.ResumeLayout(false);
            this.grEstoque.PerformLayout();
            this.grLancamento.ResumeLayout(false);
            this.grLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grEstoque;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSaida;
        private System.Windows.Forms.Button btEntrada;
        private System.Windows.Forms.GroupBox grLancamento;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btLancar;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.TextBox tbAtual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.Label label3;
    }
}