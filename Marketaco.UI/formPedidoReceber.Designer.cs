namespace Marketaco.UI
{
    partial class formPedidoReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPedidoReceber));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvPagamento = new System.Windows.Forms.DataGridView();
            this.btExcluirPagamento = new System.Windows.Forms.Button();
            this.btCheque = new System.Windows.Forms.Button();
            this.btCredito = new System.Windows.Forms.Button();
            this.btDebito = new System.Windows.Forms.Button();
            this.btDinheiro = new System.Windows.Forms.Button();
            this.btCancelarPedido = new System.Windows.Forms.Button();
            this.btConcluir = new System.Windows.Forms.Button();
            this.tbTroco = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbValorPagamento = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbValorPago = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbValorFinal = new System.Windows.Forms.TextBox();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNumPedido = new System.Windows.Forms.TextBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbSaldo);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.dgvPagamento);
            this.groupBox5.Controls.Add(this.btExcluirPagamento);
            this.groupBox5.Controls.Add(this.btCheque);
            this.groupBox5.Controls.Add(this.btCredito);
            this.groupBox5.Controls.Add(this.btDebito);
            this.groupBox5.Controls.Add(this.btDinheiro);
            this.groupBox5.Controls.Add(this.btCancelarPedido);
            this.groupBox5.Controls.Add(this.btConcluir);
            this.groupBox5.Controls.Add(this.tbTroco);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.tbValorPagamento);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.tbValorPago);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.tbValorFinal);
            this.groupBox5.Controls.Add(this.tbDesconto);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.tbNumPedido);
            this.groupBox5.Controls.Add(this.tbCliente);
            this.groupBox5.Controls.Add(this.tbValorTotal);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(586, 485);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receber pedido";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSaldo.Location = new System.Drawing.Point(387, 414);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.ReadOnly = true;
            this.tbSaldo.Size = new System.Drawing.Size(183, 27);
            this.tbSaldo.TabIndex = 10;
            this.tbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(331, 417);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 20);
            this.label17.TabIndex = 12;
            this.label17.Text = "Saldo:";
            // 
            // dgvPagamento
            // 
            this.dgvPagamento.AllowUserToAddRows = false;
            this.dgvPagamento.AllowUserToDeleteRows = false;
            this.dgvPagamento.AllowUserToResizeRows = false;
            this.dgvPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamento.Location = new System.Drawing.Point(10, 223);
            this.dgvPagamento.Name = "dgvPagamento";
            this.dgvPagamento.ReadOnly = true;
            this.dgvPagamento.RowHeadersVisible = false;
            this.dgvPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagamento.Size = new System.Drawing.Size(510, 152);
            this.dgvPagamento.TabIndex = 10;
            // 
            // btExcluirPagamento
            // 
            this.btExcluirPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluirPagamento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btExcluirPagamento.Image")));
            this.btExcluirPagamento.Location = new System.Drawing.Point(526, 223);
            this.btExcluirPagamento.Name = "btExcluirPagamento";
            this.btExcluirPagamento.Size = new System.Drawing.Size(44, 152);
            this.btExcluirPagamento.TabIndex = 16;
            this.btExcluirPagamento.UseVisualStyleBackColor = true;
            this.btExcluirPagamento.Click += new System.EventHandler(this.btExcluirPagamento_Click);
            // 
            // btCheque
            // 
            this.btCheque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCheque.Image = ((System.Drawing.Image)(resources.GetObject("btCheque.Image")));
            this.btCheque.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCheque.Location = new System.Drawing.Point(495, 141);
            this.btCheque.Name = "btCheque";
            this.btCheque.Size = new System.Drawing.Size(75, 76);
            this.btCheque.TabIndex = 6;
            this.btCheque.Text = "Ch&eque";
            this.btCheque.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCheque.UseVisualStyleBackColor = true;
            this.btCheque.Click += new System.EventHandler(this.btCheque_Click);
            // 
            // btCredito
            // 
            this.btCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCredito.Image = ((System.Drawing.Image)(resources.GetObject("btCredito.Image")));
            this.btCredito.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCredito.Location = new System.Drawing.Point(414, 141);
            this.btCredito.Name = "btCredito";
            this.btCredito.Size = new System.Drawing.Size(75, 76);
            this.btCredito.TabIndex = 5;
            this.btCredito.Text = "&Crédito";
            this.btCredito.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCredito.UseVisualStyleBackColor = true;
            this.btCredito.Click += new System.EventHandler(this.btCredito_Click);
            // 
            // btDebito
            // 
            this.btDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDebito.Image = ((System.Drawing.Image)(resources.GetObject("btDebito.Image")));
            this.btDebito.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDebito.Location = new System.Drawing.Point(333, 141);
            this.btDebito.Name = "btDebito";
            this.btDebito.Size = new System.Drawing.Size(75, 76);
            this.btDebito.TabIndex = 4;
            this.btDebito.Text = "&Débito";
            this.btDebito.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDebito.UseVisualStyleBackColor = true;
            this.btDebito.Click += new System.EventHandler(this.btDebito_Click);
            // 
            // btDinheiro
            // 
            this.btDinheiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDinheiro.Image = ((System.Drawing.Image)(resources.GetObject("btDinheiro.Image")));
            this.btDinheiro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDinheiro.Location = new System.Drawing.Point(252, 141);
            this.btDinheiro.Name = "btDinheiro";
            this.btDinheiro.Size = new System.Drawing.Size(75, 76);
            this.btDinheiro.TabIndex = 3;
            this.btDinheiro.Text = "Dinheiro";
            this.btDinheiro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDinheiro.UseVisualStyleBackColor = true;
            this.btDinheiro.Click += new System.EventHandler(this.btDinheiro_Click);
            // 
            // btCancelarPedido
            // 
            this.btCancelarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCancelarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btCancelarPedido.Image")));
            this.btCancelarPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancelarPedido.Location = new System.Drawing.Point(122, 393);
            this.btCancelarPedido.Name = "btCancelarPedido";
            this.btCancelarPedido.Size = new System.Drawing.Size(75, 77);
            this.btCancelarPedido.TabIndex = 8;
            this.btCancelarPedido.Text = "Cancelar";
            this.btCancelarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelarPedido.UseVisualStyleBackColor = true;
            this.btCancelarPedido.Click += new System.EventHandler(this.btCancelarPedido_Click);
            // 
            // btConcluir
            // 
            this.btConcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btConcluir.Image = ((System.Drawing.Image)(resources.GetObject("btConcluir.Image")));
            this.btConcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btConcluir.Location = new System.Drawing.Point(10, 393);
            this.btConcluir.Name = "btConcluir";
            this.btConcluir.Size = new System.Drawing.Size(106, 77);
            this.btConcluir.TabIndex = 7;
            this.btConcluir.Text = "Concluir (F4)";
            this.btConcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConcluir.UseVisualStyleBackColor = true;
            this.btConcluir.Click += new System.EventHandler(this.btConcluir_Click);
            // 
            // tbTroco
            // 
            this.tbTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTroco.Location = new System.Drawing.Point(387, 447);
            this.tbTroco.Name = "tbTroco";
            this.tbTroco.ReadOnly = true;
            this.tbTroco.Size = new System.Drawing.Size(183, 27);
            this.tbTroco.TabIndex = 11;
            this.tbTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 450);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Troco:";
            // 
            // tbValorPagamento
            // 
            this.tbValorPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorPagamento.Location = new System.Drawing.Point(10, 167);
            this.tbValorPagamento.Name = "tbValorPagamento";
            this.tbValorPagamento.Size = new System.Drawing.Size(183, 27);
            this.tbValorPagamento.TabIndex = 1;
            this.tbValorPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbValorPagamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbValorPagamento_KeyDown);
            this.tbValorPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNumeros_KeyPress);
            this.tbValorPagamento.Leave += new System.EventHandler(this.textboxNumeros_Leave);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(204, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor pagamento:";
            // 
            // tbValorPago
            // 
            this.tbValorPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorPago.Location = new System.Drawing.Point(387, 381);
            this.tbValorPago.Name = "tbValorPago";
            this.tbValorPago.ReadOnly = true;
            this.tbValorPago.Size = new System.Drawing.Size(183, 27);
            this.tbValorPago.TabIndex = 9;
            this.tbValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(296, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Valor pago:";
            // 
            // tbValorFinal
            // 
            this.tbValorFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValorFinal.Location = new System.Drawing.Point(388, 108);
            this.tbValorFinal.Name = "tbValorFinal";
            this.tbValorFinal.ReadOnly = true;
            this.tbValorFinal.Size = new System.Drawing.Size(183, 27);
            this.tbValorFinal.TabIndex = 13;
            this.tbValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDesconto
            // 
            this.tbDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDesconto.Location = new System.Drawing.Point(199, 108);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(183, 27);
            this.tbDesconto.TabIndex = 2;
            this.tbDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNumeros_KeyPress);
            this.tbDesconto.Leave += new System.EventHandler(this.tbDesconto_Leave);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Valor Final:";
            // 
            // tbNumPedido
            // 
            this.tbNumPedido.Location = new System.Drawing.Point(6, 54);
            this.tbNumPedido.Name = "tbNumPedido";
            this.tbNumPedido.ReadOnly = true;
            this.tbNumPedido.Size = new System.Drawing.Size(187, 27);
            this.tbNumPedido.TabIndex = 14;
            this.tbNumPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCliente
            // 
            this.tbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCliente.Location = new System.Drawing.Point(199, 54);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ReadOnly = true;
            this.tbCliente.Size = new System.Drawing.Size(371, 27);
            this.tbCliente.TabIndex = 15;
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Location = new System.Drawing.Point(10, 108);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.ReadOnly = true;
            this.tbValorTotal.Size = new System.Drawing.Size(183, 27);
            this.tbValorTotal.TabIndex = 12;
            this.tbValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nº Pedido:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Desconto:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor total:";
            // 
            // formPedidoReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 485);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "formPedidoReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receber pedido";
            this.Load += new System.EventHandler(this.formPedidoReceber_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formReceberPedido_KeyDown);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvPagamento;
        private System.Windows.Forms.Button btExcluirPagamento;
        private System.Windows.Forms.Button btCheque;
        private System.Windows.Forms.Button btCredito;
        private System.Windows.Forms.Button btDebito;
        private System.Windows.Forms.Button btDinheiro;
        private System.Windows.Forms.Button btCancelarPedido;
        private System.Windows.Forms.Button btConcluir;
        private System.Windows.Forms.TextBox tbTroco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbValorPagamento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbValorPago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbValorFinal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label label17;
    }
}