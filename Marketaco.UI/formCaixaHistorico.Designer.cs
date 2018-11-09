namespace Marketaco.UI
{
    partial class formCaixaHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCaixaHistorico));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dgvHistoricoCaixa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btImprimirResumo = new System.Windows.Forms.Button();
            this.btImprimirMovimento = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.rbPeriodo = new System.Windows.Forms.RadioButton();
            this.rbRecentes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btProcurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoCaixa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Data final:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Data inicial:";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataFinal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(584, 49);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(105, 27);
            this.dtpDataFinal.TabIndex = 16;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataInicial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(392, 49);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(103, 27);
            this.dtpDataInicial.TabIndex = 17;
            // 
            // dgvHistoricoCaixa
            // 
            this.dgvHistoricoCaixa.AllowUserToAddRows = false;
            this.dgvHistoricoCaixa.AllowUserToDeleteRows = false;
            this.dgvHistoricoCaixa.AllowUserToResizeRows = false;
            this.dgvHistoricoCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoricoCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoricoCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoricoCaixa.Location = new System.Drawing.Point(6, 26);
            this.dgvHistoricoCaixa.MultiSelect = false;
            this.dgvHistoricoCaixa.Name = "dgvHistoricoCaixa";
            this.dgvHistoricoCaixa.ReadOnly = true;
            this.dgvHistoricoCaixa.RowHeadersVisible = false;
            this.dgvHistoricoCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoricoCaixa.Size = new System.Drawing.Size(853, 290);
            this.dgvHistoricoCaixa.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btImprimirResumo);
            this.groupBox1.Controls.Add(this.btImprimirMovimento);
            this.groupBox1.Controls.Add(this.dgvHistoricoCaixa);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 374);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histórico";
            // 
            // btImprimirResumo
            // 
            this.btImprimirResumo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btImprimirResumo.Image = ((System.Drawing.Image)(resources.GetObject("btImprimirResumo.Image")));
            this.btImprimirResumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImprimirResumo.Location = new System.Drawing.Point(6, 322);
            this.btImprimirResumo.Name = "btImprimirResumo";
            this.btImprimirResumo.Size = new System.Drawing.Size(111, 46);
            this.btImprimirResumo.TabIndex = 22;
            this.btImprimirResumo.Text = "Resumo";
            this.btImprimirResumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btImprimirResumo.UseVisualStyleBackColor = true;
            this.btImprimirResumo.Click += new System.EventHandler(this.btImprimirResumo_Click);
            // 
            // btImprimirMovimento
            // 
            this.btImprimirMovimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btImprimirMovimento.Image = ((System.Drawing.Image)(resources.GetObject("btImprimirMovimento.Image")));
            this.btImprimirMovimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImprimirMovimento.Location = new System.Drawing.Point(123, 322);
            this.btImprimirMovimento.Name = "btImprimirMovimento";
            this.btImprimirMovimento.Size = new System.Drawing.Size(129, 46);
            this.btImprimirMovimento.TabIndex = 21;
            this.btImprimirMovimento.Text = "Movimento";
            this.btImprimirMovimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btImprimirMovimento.UseVisualStyleBackColor = true;
            this.btImprimirMovimento.Click += new System.EventHandler(this.btImprimirMovimento_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudNumero);
            this.groupBox2.Controls.Add(this.rbPeriodo);
            this.groupBox2.Controls.Add(this.rbRecentes);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btProcurar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpDataInicial);
            this.groupBox2.Controls.Add(this.dtpDataFinal);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(865, 85);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // nudNumero
            // 
            this.nudNumero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumero.Location = new System.Drawing.Point(12, 49);
            this.nudNumero.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(52, 27);
            this.nudNumero.TabIndex = 21;
            this.nudNumero.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // rbPeriodo
            // 
            this.rbPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPeriodo.AutoSize = true;
            this.rbPeriodo.Location = new System.Drawing.Point(303, 19);
            this.rbPeriodo.Name = "rbPeriodo";
            this.rbPeriodo.Size = new System.Drawing.Size(105, 24);
            this.rbPeriodo.TabIndex = 20;
            this.rbPeriodo.Text = "Por período";
            this.rbPeriodo.UseVisualStyleBackColor = true;
            // 
            // rbRecentes
            // 
            this.rbRecentes.AutoSize = true;
            this.rbRecentes.Checked = true;
            this.rbRecentes.Location = new System.Drawing.Point(12, 19);
            this.rbRecentes.Name = "rbRecentes";
            this.rbRecentes.Size = new System.Drawing.Size(117, 24);
            this.rbRecentes.TabIndex = 20;
            this.rbRecentes.TabStop = true;
            this.rbRecentes.Text = "Mais recentes";
            this.rbRecentes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Últimos";
            // 
            // btProcurar
            // 
            this.btProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btProcurar.Image")));
            this.btProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btProcurar.Location = new System.Drawing.Point(737, 31);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(106, 40);
            this.btProcurar.TabIndex = 15;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // formCaixaHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "formCaixaHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico do caixa";
            this.Activated += new System.EventHandler(this.formCaixaHistorico_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formCaixaHistorico_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoricoCaixa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.DataGridView dgvHistoricoCaixa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.RadioButton rbPeriodo;
        private System.Windows.Forms.RadioButton rbRecentes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btImprimirMovimento;
        private System.Windows.Forms.Button btImprimirResumo;
    }
}