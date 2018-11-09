namespace Marketaco.UI
{
    partial class formProdutoNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProdutoNovo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbEstoqueIdeal = new System.Windows.Forms.TextBox();
            this.brSalvar = new System.Windows.Forms.Button();
            this.tbEstoqueMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbEstoqueNao = new System.Windows.Forms.RadioButton();
            this.rbEstoqueSim = new System.Windows.Forms.RadioButton();
            this.rbVendavelNao = new System.Windows.Forms.RadioButton();
            this.rbVendavelSim = new System.Windows.Forms.RadioButton();
            this.tbPrecoCusto = new System.Windows.Forms.TextBox();
            this.tbPrecoVenda = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.cbUnid = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rbVendavelNao);
            this.groupBox1.Controls.Add(this.rbVendavelSim);
            this.groupBox1.Controls.Add(this.tbPrecoCusto);
            this.groupBox1.Controls.Add(this.tbPrecoVenda);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.tbCodigo);
            this.groupBox1.Controls.Add(this.cbUnid);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 432);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Produto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbEstoqueIdeal);
            this.groupBox2.Controls.Add(this.brSalvar);
            this.groupBox2.Controls.Add(this.tbEstoqueMin);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rbEstoqueNao);
            this.groupBox2.Controls.Add(this.rbEstoqueSim);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 173);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estoque";
            // 
            // tbEstoqueIdeal
            // 
            this.tbEstoqueIdeal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEstoqueIdeal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEstoqueIdeal.Location = new System.Drawing.Point(171, 108);
            this.tbEstoqueIdeal.Name = "tbEstoqueIdeal";
            this.tbEstoqueIdeal.Size = new System.Drawing.Size(160, 27);
            this.tbEstoqueIdeal.TabIndex = 11;
            this.tbEstoqueIdeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbEstoqueIdeal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNumeros_KeyPress);
            this.tbEstoqueIdeal.Leave += new System.EventHandler(this.textboxNumeros_Leave);
            // 
            // brSalvar
            // 
            this.brSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.brSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.brSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.brSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.brSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brSalvar.Image = ((System.Drawing.Image)(resources.GetObject("brSalvar.Image")));
            this.brSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brSalvar.Location = new System.Drawing.Point(418, 124);
            this.brSalvar.Name = "brSalvar";
            this.brSalvar.Size = new System.Drawing.Size(94, 40);
            this.brSalvar.TabIndex = 12;
            this.brSalvar.Text = "Salvar";
            this.brSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brSalvar.UseVisualStyleBackColor = false;
            this.brSalvar.Click += new System.EventHandler(this.brSalvar_Click);
            // 
            // tbEstoqueMin
            // 
            this.tbEstoqueMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEstoqueMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbEstoqueMin.Location = new System.Drawing.Point(171, 75);
            this.tbEstoqueMin.Name = "tbEstoqueMin";
            this.tbEstoqueMin.Size = new System.Drawing.Size(160, 27);
            this.tbEstoqueMin.TabIndex = 10;
            this.tbEstoqueMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbEstoqueMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNumeros_KeyPress);
            this.tbEstoqueMin.Leave += new System.EventHandler(this.textboxNumeros_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Estoque Ideal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Controla Estoque:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Estoque Mínimo:";
            // 
            // rbEstoqueNao
            // 
            this.rbEstoqueNao.AutoSize = true;
            this.rbEstoqueNao.Location = new System.Drawing.Point(229, 34);
            this.rbEstoqueNao.Name = "rbEstoqueNao";
            this.rbEstoqueNao.Size = new System.Drawing.Size(55, 24);
            this.rbEstoqueNao.TabIndex = 9;
            this.rbEstoqueNao.Text = "Não";
            this.rbEstoqueNao.UseVisualStyleBackColor = true;
            // 
            // rbEstoqueSim
            // 
            this.rbEstoqueSim.AutoSize = true;
            this.rbEstoqueSim.Checked = true;
            this.rbEstoqueSim.Location = new System.Drawing.Point(171, 34);
            this.rbEstoqueSim.Name = "rbEstoqueSim";
            this.rbEstoqueSim.Size = new System.Drawing.Size(52, 24);
            this.rbEstoqueSim.TabIndex = 8;
            this.rbEstoqueSim.TabStop = true;
            this.rbEstoqueSim.Text = "Sim";
            this.rbEstoqueSim.UseVisualStyleBackColor = true;
            this.rbEstoqueSim.CheckedChanged += new System.EventHandler(this.rbEstoqueSim_CheckedChanged);
            // 
            // rbVendavelNao
            // 
            this.rbVendavelNao.AutoSize = true;
            this.rbVendavelNao.Location = new System.Drawing.Point(232, 226);
            this.rbVendavelNao.Name = "rbVendavelNao";
            this.rbVendavelNao.Size = new System.Drawing.Size(55, 24);
            this.rbVendavelNao.TabIndex = 7;
            this.rbVendavelNao.Text = "Não";
            this.rbVendavelNao.UseVisualStyleBackColor = true;
            // 
            // rbVendavelSim
            // 
            this.rbVendavelSim.AutoSize = true;
            this.rbVendavelSim.Checked = true;
            this.rbVendavelSim.Location = new System.Drawing.Point(174, 226);
            this.rbVendavelSim.Name = "rbVendavelSim";
            this.rbVendavelSim.Size = new System.Drawing.Size(52, 24);
            this.rbVendavelSim.TabIndex = 6;
            this.rbVendavelSim.TabStop = true;
            this.rbVendavelSim.Text = "Sim";
            this.rbVendavelSim.UseVisualStyleBackColor = true;
            // 
            // tbPrecoCusto
            // 
            this.tbPrecoCusto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrecoCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPrecoCusto.Location = new System.Drawing.Point(174, 160);
            this.tbPrecoCusto.Name = "tbPrecoCusto";
            this.tbPrecoCusto.Size = new System.Drawing.Size(160, 27);
            this.tbPrecoCusto.TabIndex = 5;
            this.tbPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNumeros_KeyPress);
            this.tbPrecoCusto.Leave += new System.EventHandler(this.textboxNumeros_Leave);
            // 
            // tbPrecoVenda
            // 
            this.tbPrecoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrecoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPrecoVenda.Location = new System.Drawing.Point(174, 193);
            this.tbPrecoVenda.Name = "tbPrecoVenda";
            this.tbPrecoVenda.Size = new System.Drawing.Size(160, 27);
            this.tbPrecoVenda.TabIndex = 5;
            this.tbPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPrecoVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNumeros_KeyPress);
            this.tbPrecoVenda.Leave += new System.EventHandler(this.textboxNumeros_Leave);
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNome.Location = new System.Drawing.Point(174, 59);
            this.tbNome.MaxLength = 41;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(325, 27);
            this.tbNome.TabIndex = 2;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCodigo.Location = new System.Drawing.Point(174, 26);
            this.tbCodigo.MaxLength = 13;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(160, 27);
            this.tbCodigo.TabIndex = 1;
            // 
            // cbUnid
            // 
            this.cbUnid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUnid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnid.FormattingEnabled = true;
            this.cbUnid.Location = new System.Drawing.Point(174, 92);
            this.cbUnid.Name = "cbUnid";
            this.cbUnid.Size = new System.Drawing.Size(160, 28);
            this.cbUnid.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Preço custo:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(174, 126);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(226, 28);
            this.cbCategoria.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Preço venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Produto vendável:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Unid. Com.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // formProdutoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 432);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "formProdutoNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo produto";
            this.Load += new System.EventHandler(this.formProdutoNovo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formProdutoNovo_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox tbPrecoVenda;
        private System.Windows.Forms.ComboBox cbUnid;
        private System.Windows.Forms.RadioButton rbVendavelNao;
        private System.Windows.Forms.RadioButton rbVendavelSim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button brSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbEstoqueMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbEstoqueNao;
        private System.Windows.Forms.RadioButton rbEstoqueSim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEstoqueIdeal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPrecoCusto;
        private System.Windows.Forms.Label label10;
    }
}