namespace Marketaco.UI
{
    partial class formCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCaixa));
            this.label5 = new System.Windows.Forms.Label();
            this.tbSaldoInicialCaixa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbObservacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDataHoraAbertura = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbFechado = new System.Windows.Forms.PictureBox();
            this.btFecharCaixa = new System.Windows.Forms.Button();
            this.pbAberto = new System.Windows.Forms.PictureBox();
            this.btAbrirCaixa = new System.Windows.Forms.Button();
            this.gbResumo = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSaldoFinal = new System.Windows.Forms.TextBox();
            this.tbTotalSaida = new System.Windows.Forms.TextBox();
            this.tbTotalEntrada = new System.Windows.Forms.TextBox();
            this.tbChequeE = new System.Windows.Forms.TextBox();
            this.tbSaldoDinheiro = new System.Windows.Forms.TextBox();
            this.tbCartaoCredito = new System.Windows.Forms.TextBox();
            this.tbChequeS = new System.Windows.Forms.TextBox();
            this.tbDinheiroS = new System.Windows.Forms.TextBox();
            this.tbCartaoDebito = new System.Windows.Forms.TextBox();
            this.tbDinheiroE = new System.Windows.Forms.TextBox();
            this.tbSaldoInicial = new System.Windows.Forms.TextBox();
            this.gbMovimentos = new System.Windows.Forms.GroupBox();
            this.dgvLancamentosCaixa = new System.Windows.Forms.DataGridView();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btLancar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAberto)).BeginInit();
            this.gbResumo.SuspendLayout();
            this.gbMovimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentosCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Saldo inicial (dinheiro):";
            // 
            // tbSaldoInicialCaixa
            // 
            this.tbSaldoInicialCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSaldoInicialCaixa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldoInicialCaixa.Location = new System.Drawing.Point(9, 147);
            this.tbSaldoInicialCaixa.Name = "tbSaldoInicialCaixa";
            this.tbSaldoInicialCaixa.Size = new System.Drawing.Size(165, 27);
            this.tbSaldoInicialCaixa.TabIndex = 1;
            this.tbSaldoInicialCaixa.Text = "0,00";
            this.tbSaldoInicialCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSaldoInicialCaixa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSaldoInicialCaixa_KeyDown);
            this.tbSaldoInicialCaixa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSaldoInicialCaixa_KeyPress);
            this.tbSaldoInicialCaixa.Leave += new System.EventHandler(this.tbSaldoInicialCaixa_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Observação:";
            // 
            // tbObservacao
            // 
            this.tbObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbObservacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObservacao.Location = new System.Drawing.Point(8, 210);
            this.tbObservacao.MaxLength = 150;
            this.tbObservacao.Multiline = true;
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Size = new System.Drawing.Size(165, 82);
            this.tbObservacao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data / Hora Abertura:";
            // 
            // lbDataHoraAbertura
            // 
            this.lbDataHoraAbertura.AutoSize = true;
            this.lbDataHoraAbertura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataHoraAbertura.Location = new System.Drawing.Point(5, 325);
            this.lbDataHoraAbertura.Name = "lbDataHoraAbertura";
            this.lbDataHoraAbertura.Size = new System.Drawing.Size(39, 20);
            this.lbDataHoraAbertura.TabIndex = 1;
            this.lbDataHoraAbertura.Text = "data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbFechado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btFecharCaixa);
            this.groupBox1.Controls.Add(this.pbAberto);
            this.groupBox1.Controls.Add(this.btAbrirCaixa);
            this.groupBox1.Controls.Add(this.tbSaldoInicialCaixa);
            this.groupBox1.Controls.Add(this.tbObservacao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbDataHoraAbertura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 489);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status do Caixa";
            // 
            // pbFechado
            // 
            this.pbFechado.Image = ((System.Drawing.Image)(resources.GetObject("pbFechado.Image")));
            this.pbFechado.Location = new System.Drawing.Point(35, 26);
            this.pbFechado.Name = "pbFechado";
            this.pbFechado.Size = new System.Drawing.Size(102, 86);
            this.pbFechado.TabIndex = 7;
            this.pbFechado.TabStop = false;
            // 
            // btFecharCaixa
            // 
            this.btFecharCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btFecharCaixa.FlatAppearance.BorderSize = 0;
            this.btFecharCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btFecharCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFecharCaixa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFecharCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btFecharCaixa.Image")));
            this.btFecharCaixa.Location = new System.Drawing.Point(6, 418);
            this.btFecharCaixa.Name = "btFecharCaixa";
            this.btFecharCaixa.Size = new System.Drawing.Size(167, 54);
            this.btFecharCaixa.TabIndex = 6;
            this.btFecharCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFecharCaixa.UseVisualStyleBackColor = true;
            this.btFecharCaixa.Click += new System.EventHandler(this.btFecharCaixa_Click);
            // 
            // pbAberto
            // 
            this.pbAberto.Image = ((System.Drawing.Image)(resources.GetObject("pbAberto.Image")));
            this.pbAberto.Location = new System.Drawing.Point(35, 27);
            this.pbAberto.Name = "pbAberto";
            this.pbAberto.Size = new System.Drawing.Size(102, 86);
            this.pbAberto.TabIndex = 7;
            this.pbAberto.TabStop = false;
            this.pbAberto.Visible = false;
            // 
            // btAbrirCaixa
            // 
            this.btAbrirCaixa.FlatAppearance.BorderSize = 0;
            this.btAbrirCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btAbrirCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbrirCaixa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btAbrirCaixa.Image")));
            this.btAbrirCaixa.Location = new System.Drawing.Point(6, 358);
            this.btAbrirCaixa.Name = "btAbrirCaixa";
            this.btAbrirCaixa.Size = new System.Drawing.Size(167, 54);
            this.btAbrirCaixa.TabIndex = 3;
            this.btAbrirCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAbrirCaixa.UseVisualStyleBackColor = true;
            this.btAbrirCaixa.Click += new System.EventHandler(this.btAbrirCaixa_Click);
            // 
            // gbResumo
            // 
            this.gbResumo.Controls.Add(this.label19);
            this.gbResumo.Controls.Add(this.label16);
            this.gbResumo.Controls.Add(this.label12);
            this.gbResumo.Controls.Add(this.label10);
            this.gbResumo.Controls.Add(this.label9);
            this.gbResumo.Controls.Add(this.label18);
            this.gbResumo.Controls.Add(this.label15);
            this.gbResumo.Controls.Add(this.label8);
            this.gbResumo.Controls.Add(this.label14);
            this.gbResumo.Controls.Add(this.label7);
            this.gbResumo.Controls.Add(this.label17);
            this.gbResumo.Controls.Add(this.label13);
            this.gbResumo.Controls.Add(this.label6);
            this.gbResumo.Controls.Add(this.label4);
            this.gbResumo.Controls.Add(this.tbSaldoFinal);
            this.gbResumo.Controls.Add(this.tbTotalSaida);
            this.gbResumo.Controls.Add(this.tbTotalEntrada);
            this.gbResumo.Controls.Add(this.tbChequeE);
            this.gbResumo.Controls.Add(this.tbSaldoDinheiro);
            this.gbResumo.Controls.Add(this.tbCartaoCredito);
            this.gbResumo.Controls.Add(this.tbChequeS);
            this.gbResumo.Controls.Add(this.tbDinheiroS);
            this.gbResumo.Controls.Add(this.tbCartaoDebito);
            this.gbResumo.Controls.Add(this.tbDinheiroE);
            this.gbResumo.Controls.Add(this.tbSaldoInicial);
            this.gbResumo.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbResumo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumo.Location = new System.Drawing.Point(878, 0);
            this.gbResumo.Name = "gbResumo";
            this.gbResumo.Size = new System.Drawing.Size(271, 489);
            this.gbResumo.TabIndex = 5;
            this.gbResumo.TabStop = false;
            this.gbResumo.Text = "Resumo do Caixa:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 459);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 20);
            this.label19.TabIndex = 3;
            this.label19.Text = "SALDO FINAL:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 358);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Total (Saídas):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total (Entradas):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Cheque:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cartão - Crédito:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 426);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "Saldo dinheiro:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Cheque:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cartão - Débito:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Dinheiro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Dinheiro:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(6, 392);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 20);
            this.label17.TabIndex = 3;
            this.label17.Text = "(=) Saldo Caixa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(6, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "(-) Todas as Saídas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "(+) Todas as Entradas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo Inicial:";
            // 
            // tbSaldoFinal
            // 
            this.tbSaldoFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbSaldoFinal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldoFinal.Location = new System.Drawing.Point(137, 456);
            this.tbSaldoFinal.Name = "tbSaldoFinal";
            this.tbSaldoFinal.ReadOnly = true;
            this.tbSaldoFinal.Size = new System.Drawing.Size(128, 27);
            this.tbSaldoFinal.TabIndex = 2;
            this.tbSaldoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotalSaida
            // 
            this.tbTotalSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbTotalSaida.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalSaida.Location = new System.Drawing.Point(137, 355);
            this.tbTotalSaida.Name = "tbTotalSaida";
            this.tbTotalSaida.ReadOnly = true;
            this.tbTotalSaida.Size = new System.Drawing.Size(128, 27);
            this.tbTotalSaida.TabIndex = 2;
            this.tbTotalSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbTotalEntrada
            // 
            this.tbTotalEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbTotalEntrada.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalEntrada.Location = new System.Drawing.Point(137, 224);
            this.tbTotalEntrada.Name = "tbTotalEntrada";
            this.tbTotalEntrada.ReadOnly = true;
            this.tbTotalEntrada.Size = new System.Drawing.Size(128, 27);
            this.tbTotalEntrada.TabIndex = 2;
            this.tbTotalEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbChequeE
            // 
            this.tbChequeE.Location = new System.Drawing.Point(137, 191);
            this.tbChequeE.Name = "tbChequeE";
            this.tbChequeE.ReadOnly = true;
            this.tbChequeE.Size = new System.Drawing.Size(128, 27);
            this.tbChequeE.TabIndex = 2;
            this.tbChequeE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSaldoDinheiro
            // 
            this.tbSaldoDinheiro.Location = new System.Drawing.Point(137, 423);
            this.tbSaldoDinheiro.Name = "tbSaldoDinheiro";
            this.tbSaldoDinheiro.ReadOnly = true;
            this.tbSaldoDinheiro.Size = new System.Drawing.Size(128, 27);
            this.tbSaldoDinheiro.TabIndex = 2;
            this.tbSaldoDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCartaoCredito
            // 
            this.tbCartaoCredito.Location = new System.Drawing.Point(137, 158);
            this.tbCartaoCredito.Name = "tbCartaoCredito";
            this.tbCartaoCredito.ReadOnly = true;
            this.tbCartaoCredito.Size = new System.Drawing.Size(128, 27);
            this.tbCartaoCredito.TabIndex = 2;
            this.tbCartaoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbChequeS
            // 
            this.tbChequeS.Location = new System.Drawing.Point(137, 322);
            this.tbChequeS.Name = "tbChequeS";
            this.tbChequeS.ReadOnly = true;
            this.tbChequeS.Size = new System.Drawing.Size(128, 27);
            this.tbChequeS.TabIndex = 2;
            this.tbChequeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDinheiroS
            // 
            this.tbDinheiroS.Location = new System.Drawing.Point(137, 289);
            this.tbDinheiroS.Name = "tbDinheiroS";
            this.tbDinheiroS.ReadOnly = true;
            this.tbDinheiroS.Size = new System.Drawing.Size(128, 27);
            this.tbDinheiroS.TabIndex = 2;
            this.tbDinheiroS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbCartaoDebito
            // 
            this.tbCartaoDebito.Location = new System.Drawing.Point(137, 125);
            this.tbCartaoDebito.Name = "tbCartaoDebito";
            this.tbCartaoDebito.ReadOnly = true;
            this.tbCartaoDebito.Size = new System.Drawing.Size(128, 27);
            this.tbCartaoDebito.TabIndex = 2;
            this.tbCartaoDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDinheiroE
            // 
            this.tbDinheiroE.Location = new System.Drawing.Point(137, 92);
            this.tbDinheiroE.Name = "tbDinheiroE";
            this.tbDinheiroE.ReadOnly = true;
            this.tbDinheiroE.Size = new System.Drawing.Size(128, 27);
            this.tbDinheiroE.TabIndex = 2;
            this.tbDinheiroE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSaldoInicial
            // 
            this.tbSaldoInicial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSaldoInicial.Location = new System.Drawing.Point(137, 30);
            this.tbSaldoInicial.Name = "tbSaldoInicial";
            this.tbSaldoInicial.ReadOnly = true;
            this.tbSaldoInicial.Size = new System.Drawing.Size(128, 27);
            this.tbSaldoInicial.TabIndex = 2;
            this.tbSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbMovimentos
            // 
            this.gbMovimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMovimentos.Controls.Add(this.dgvLancamentosCaixa);
            this.gbMovimentos.Controls.Add(this.btExcluir);
            this.gbMovimentos.Controls.Add(this.btLancar);
            this.gbMovimentos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovimentos.Location = new System.Drawing.Point(179, 0);
            this.gbMovimentos.Name = "gbMovimentos";
            this.gbMovimentos.Size = new System.Drawing.Size(699, 489);
            this.gbMovimentos.TabIndex = 4;
            this.gbMovimentos.TabStop = false;
            this.gbMovimentos.Text = "Movimentos do Caixa";
            // 
            // dgvLancamentosCaixa
            // 
            this.dgvLancamentosCaixa.AllowUserToAddRows = false;
            this.dgvLancamentosCaixa.AllowUserToDeleteRows = false;
            this.dgvLancamentosCaixa.AllowUserToResizeRows = false;
            this.dgvLancamentosCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLancamentosCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLancamentosCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLancamentosCaixa.Location = new System.Drawing.Point(6, 27);
            this.dgvLancamentosCaixa.MultiSelect = false;
            this.dgvLancamentosCaixa.Name = "dgvLancamentosCaixa";
            this.dgvLancamentosCaixa.ReadOnly = true;
            this.dgvLancamentosCaixa.RowHeadersVisible = false;
            this.dgvLancamentosCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLancamentosCaixa.Size = new System.Drawing.Size(687, 410);
            this.dgvLancamentosCaixa.TabIndex = 0;
            this.dgvLancamentosCaixa.SelectionChanged += new System.EventHandler(this.dgvLancamentosCaixa_SelectionChanged);
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluir.Enabled = false;
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(650, 443);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(43, 40);
            this.btExcluir.TabIndex = 6;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluirEntradaSaida_Click);
            // 
            // btLancar
            // 
            this.btLancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLancar.Image = ((System.Drawing.Image)(resources.GetObject("btLancar.Image")));
            this.btLancar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLancar.Location = new System.Drawing.Point(454, 443);
            this.btLancar.Name = "btLancar";
            this.btLancar.Size = new System.Drawing.Size(190, 40);
            this.btLancar.TabIndex = 6;
            this.btLancar.Text = "Lançar Entrada/Saída";
            this.btLancar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLancar.UseVisualStyleBackColor = true;
            this.btLancar.Click += new System.EventHandler(this.btAdicionarEntradaSaida_Click);
            // 
            // formCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 489);
            this.Controls.Add(this.gbResumo);
            this.Controls.Add(this.gbMovimentos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "formCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Activated += new System.EventHandler(this.formCaixa_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formCaixa_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAberto)).EndInit();
            this.gbResumo.ResumeLayout(false);
            this.gbResumo.PerformLayout();
            this.gbMovimentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentosCaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSaldoInicialCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbObservacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDataHoraAbertura;
        private System.Windows.Forms.Button btAbrirCaixa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbResumo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSaldoInicial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbChequeE;
        private System.Windows.Forms.TextBox tbCartaoCredito;
        private System.Windows.Forms.TextBox tbCartaoDebito;
        private System.Windows.Forms.TextBox tbDinheiroE;
        private System.Windows.Forms.TextBox tbTotalEntrada;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTotalSaida;
        private System.Windows.Forms.TextBox tbChequeS;
        private System.Windows.Forms.TextBox tbDinheiroS;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbSaldoFinal;
        private System.Windows.Forms.TextBox tbSaldoDinheiro;
        private System.Windows.Forms.Button btFecharCaixa;
        private System.Windows.Forms.GroupBox gbMovimentos;
        private System.Windows.Forms.DataGridView dgvLancamentosCaixa;
        private System.Windows.Forms.Button btLancar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.PictureBox pbFechado;
        private System.Windows.Forms.PictureBox pbAberto;
    }
}