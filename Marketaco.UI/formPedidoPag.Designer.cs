namespace Marketaco.UI
{
    partial class formPedidoPag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPedidoPag));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.rtbConferencia = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTaxa = new System.Windows.Forms.CheckBox();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btExcluirPagamento = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbReceber = new System.Windows.Forms.TextBox();
            this.btDinheiro = new System.Windows.Forms.Button();
            this.btDebito = new System.Windows.Forms.Button();
            this.btCredito = new System.Windows.Forms.Button();
            this.btCheque = new System.Windows.Forms.Button();
            this.dgvPagamento = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTroco = new System.Windows.Forms.TextBox();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.tbValorPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nupNumPessoa = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPorPessoa = new System.Windows.Forms.TextBox();
            this.tbTaxa = new System.Windows.Forms.TextBox();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotalPagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btImprimir);
            this.groupBox1.Controls.Add(this.rtbConferencia);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conferencia";
            // 
            // btImprimir
            // 
            this.btImprimir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btImprimir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btImprimir.Image")));
            this.btImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImprimir.Location = new System.Drawing.Point(3, 433);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(354, 43);
            this.btImprimir.TabIndex = 7;
            this.btImprimir.Text = "Imprimir conferência";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // rtbConferencia
            // 
            this.rtbConferencia.BackColor = System.Drawing.Color.Beige;
            this.rtbConferencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbConferencia.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConferencia.Location = new System.Drawing.Point(3, 23);
            this.rtbConferencia.Name = "rtbConferencia";
            this.rtbConferencia.ReadOnly = true;
            this.rtbConferencia.Size = new System.Drawing.Size(354, 404);
            this.rtbConferencia.TabIndex = 0;
            this.rtbConferencia.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTaxa);
            this.groupBox2.Controls.Add(this.btFinalizar);
            this.groupBox2.Controls.Add(this.btExcluirPagamento);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbReceber);
            this.groupBox2.Controls.Add(this.btDinheiro);
            this.groupBox2.Controls.Add(this.btDebito);
            this.groupBox2.Controls.Add(this.btCredito);
            this.groupBox2.Controls.Add(this.btCheque);
            this.groupBox2.Controls.Add(this.dgvPagamento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbTroco);
            this.groupBox2.Controls.Add(this.tbSaldo);
            this.groupBox2.Controls.Add(this.tbValorPago);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nupNumPessoa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbPorPessoa);
            this.groupBox2.Controls.Add(this.tbTaxa);
            this.groupBox2.Controls.Add(this.tbSubTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbTotalPagar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(360, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 479);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagamentos";
            // 
            // cbTaxa
            // 
            this.cbTaxa.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbTaxa.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Highlight;
            this.cbTaxa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTaxa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaxa.Image = ((System.Drawing.Image)(resources.GetObject("cbTaxa.Image")));
            this.cbTaxa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTaxa.Location = new System.Drawing.Point(7, 67);
            this.cbTaxa.Name = "cbTaxa";
            this.cbTaxa.Size = new System.Drawing.Size(102, 27);
            this.cbTaxa.TabIndex = 42;
            this.cbTaxa.Text = "Serviço";
            this.cbTaxa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbTaxa.UseVisualStyleBackColor = true;
            this.cbTaxa.CheckedChanged += new System.EventHandler(this.cbTaxa_CheckedChanged);
            // 
            // btFinalizar
            // 
            this.btFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btFinalizar.Image")));
            this.btFinalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btFinalizar.Location = new System.Drawing.Point(3, 405);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(179, 68);
            this.btFinalizar.TabIndex = 6;
            this.btFinalizar.Text = "Finaliza Pedido (F2)";
            this.btFinalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btExcluirPagamento
            // 
            this.btExcluirPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btExcluirPagamento.Image")));
            this.btExcluirPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluirPagamento.Location = new System.Drawing.Point(527, 249);
            this.btExcluirPagamento.Name = "btExcluirPagamento";
            this.btExcluirPagamento.Size = new System.Drawing.Size(42, 150);
            this.btExcluirPagamento.TabIndex = 8;
            this.btExcluirPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluirPagamento.UseVisualStyleBackColor = true;
            this.btExcluirPagamento.Click += new System.EventHandler(this.btExcluirPagamento_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Receber:";
            // 
            // tbReceber
            // 
            this.tbReceber.BackColor = System.Drawing.Color.PaleGreen;
            this.tbReceber.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReceber.Location = new System.Drawing.Point(3, 120);
            this.tbReceber.Name = "tbReceber";
            this.tbReceber.Size = new System.Drawing.Size(330, 57);
            this.tbReceber.TabIndex = 1;
            this.tbReceber.Text = "0,00";
            this.tbReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbReceber.Click += new System.EventHandler(this.tbReceber_Enter);
            this.tbReceber.Enter += new System.EventHandler(this.tbReceber_Enter);
            this.tbReceber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbReceber_KeyDown);
            this.tbReceber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNumeros_KeyPress);
            this.tbReceber.Leave += new System.EventHandler(this.textboxNumeros_Leave);
            // 
            // btDinheiro
            // 
            this.btDinheiro.Image = ((System.Drawing.Image)(resources.GetObject("btDinheiro.Image")));
            this.btDinheiro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDinheiro.Location = new System.Drawing.Point(3, 183);
            this.btDinheiro.Name = "btDinheiro";
            this.btDinheiro.Size = new System.Drawing.Size(78, 60);
            this.btDinheiro.TabIndex = 2;
            this.btDinheiro.Text = "Dinheiro";
            this.btDinheiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDinheiro.UseVisualStyleBackColor = true;
            this.btDinheiro.Click += new System.EventHandler(this.btDinheiro_Click);
            // 
            // btDebito
            // 
            this.btDebito.Image = ((System.Drawing.Image)(resources.GetObject("btDebito.Image")));
            this.btDebito.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDebito.Location = new System.Drawing.Point(87, 183);
            this.btDebito.Name = "btDebito";
            this.btDebito.Size = new System.Drawing.Size(78, 60);
            this.btDebito.TabIndex = 3;
            this.btDebito.Text = "Débito";
            this.btDebito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDebito.UseVisualStyleBackColor = true;
            this.btDebito.Click += new System.EventHandler(this.btDebito_Click);
            // 
            // btCredito
            // 
            this.btCredito.Image = ((System.Drawing.Image)(resources.GetObject("btCredito.Image")));
            this.btCredito.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCredito.Location = new System.Drawing.Point(171, 183);
            this.btCredito.Name = "btCredito";
            this.btCredito.Size = new System.Drawing.Size(78, 60);
            this.btCredito.TabIndex = 4;
            this.btCredito.Text = "Crédito";
            this.btCredito.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCredito.UseVisualStyleBackColor = true;
            this.btCredito.Click += new System.EventHandler(this.btCredito_Click);
            // 
            // btCheque
            // 
            this.btCheque.Image = ((System.Drawing.Image)(resources.GetObject("btCheque.Image")));
            this.btCheque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCheque.Location = new System.Drawing.Point(255, 183);
            this.btCheque.Name = "btCheque";
            this.btCheque.Size = new System.Drawing.Size(78, 60);
            this.btCheque.TabIndex = 5;
            this.btCheque.Text = "Cheque";
            this.btCheque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCheque.UseVisualStyleBackColor = true;
            this.btCheque.Click += new System.EventHandler(this.btCheque_Click);
            // 
            // dgvPagamento
            // 
            this.dgvPagamento.AllowUserToAddRows = false;
            this.dgvPagamento.AllowUserToDeleteRows = false;
            this.dgvPagamento.AllowUserToResizeRows = false;
            this.dgvPagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamento.Location = new System.Drawing.Point(3, 249);
            this.dgvPagamento.MultiSelect = false;
            this.dgvPagamento.Name = "dgvPagamento";
            this.dgvPagamento.ReadOnly = true;
            this.dgvPagamento.RowHeadersVisible = false;
            this.dgvPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagamento.Size = new System.Drawing.Size(519, 150);
            this.dgvPagamento.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Troco:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Saldo a pagar:";
            // 
            // tbTroco
            // 
            this.tbTroco.BackColor = System.Drawing.Color.Khaki;
            this.tbTroco.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTroco.Location = new System.Drawing.Point(372, 427);
            this.tbTroco.Name = "tbTroco";
            this.tbTroco.ReadOnly = true;
            this.tbTroco.Size = new System.Drawing.Size(150, 46);
            this.tbTroco.TabIndex = 10;
            this.tbTroco.Text = "0,00";
            this.tbTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSaldo
            // 
            this.tbSaldo.BackColor = System.Drawing.Color.LightCoral;
            this.tbSaldo.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldo.Location = new System.Drawing.Point(339, 120);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.ReadOnly = true;
            this.tbSaldo.Size = new System.Drawing.Size(230, 57);
            this.tbSaldo.TabIndex = 28;
            this.tbSaldo.Text = "0,00";
            this.tbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbValorPago
            // 
            this.tbValorPago.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbValorPago.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorPago.Location = new System.Drawing.Point(188, 427);
            this.tbValorPago.Name = "tbValorPago";
            this.tbValorPago.ReadOnly = true;
            this.tbValorPago.Size = new System.Drawing.Size(178, 46);
            this.tbValorPago.TabIndex = 9;
            this.tbValorPago.Text = "0,00";
            this.tbValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Valor pago:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Nº Pessoas:";
            // 
            // nupNumPessoa
            // 
            this.nupNumPessoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNumPessoa.Location = new System.Drawing.Point(428, 216);
            this.nupNumPessoa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNumPessoa.Name = "nupNumPessoa";
            this.nupNumPessoa.Size = new System.Drawing.Size(50, 27);
            this.nupNumPessoa.TabIndex = 12;
            this.nupNumPessoa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNumPessoa.ValueChanged += new System.EventHandler(this.nupNumPessoa_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Valor:";
            // 
            // tbPorPessoa
            // 
            this.tbPorPessoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPorPessoa.Location = new System.Drawing.Point(449, 183);
            this.tbPorPessoa.Name = "tbPorPessoa";
            this.tbPorPessoa.ReadOnly = true;
            this.tbPorPessoa.Size = new System.Drawing.Size(117, 27);
            this.tbPorPessoa.TabIndex = 13;
            this.tbPorPessoa.Text = "0,00";
            this.tbPorPessoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTaxa
            // 
            this.tbTaxa.BackColor = System.Drawing.SystemColors.Window;
            this.tbTaxa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaxa.Location = new System.Drawing.Point(115, 67);
            this.tbTaxa.Name = "tbTaxa";
            this.tbTaxa.ReadOnly = true;
            this.tbTaxa.Size = new System.Drawing.Size(218, 27);
            this.tbTaxa.TabIndex = 11;
            this.tbTaxa.Text = "0,00";
            this.tbTaxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.BackColor = System.Drawing.SystemColors.Window;
            this.tbSubTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubTotal.Location = new System.Drawing.Point(115, 34);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(218, 27);
            this.tbSubTotal.TabIndex = 11;
            this.tbSubTotal.Text = "0,00";
            this.tbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total pedido:";
            // 
            // tbTotalPagar
            // 
            this.tbTotalPagar.BackColor = System.Drawing.Color.DarkSalmon;
            this.tbTotalPagar.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.tbTotalPagar.Location = new System.Drawing.Point(339, 37);
            this.tbTotalPagar.Name = "tbTotalPagar";
            this.tbTotalPagar.ReadOnly = true;
            this.tbTotalPagar.Size = new System.Drawing.Size(230, 57);
            this.tbTotalPagar.TabIndex = 11;
            this.tbTotalPagar.Text = "0,00";
            this.tbTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total a pagar:";
            // 
            // formPedidoPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "formPedidoPag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos do pedido";
            this.Load += new System.EventHandler(this.formPedidoPag_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formPedidoPag_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbConferencia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btImprimir;
        public System.Windows.Forms.TextBox tbTotalPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown nupNumPessoa;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbPorPessoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbTroco;
        public System.Windows.Forms.TextBox tbSaldo;
        public System.Windows.Forms.TextBox tbValorPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPagamento;
        private System.Windows.Forms.Button btDinheiro;
        private System.Windows.Forms.Button btDebito;
        private System.Windows.Forms.Button btCredito;
        private System.Windows.Forms.Button btCheque;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbReceber;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Button btExcluirPagamento;
        public System.Windows.Forms.CheckBox cbTaxa;
        public System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbTaxa;
    }
}