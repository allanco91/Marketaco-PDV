namespace Marketaco.UI
{
    partial class formPedidoDetalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPedidoDetalhes));
            this.label2 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.lbPesquisar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdicionarProduto = new System.Windows.Forms.Button();
            this.btImportar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btPagamento = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.cbViagem = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTaxa = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCima = new System.Windows.Forms.Button();
            this.btBaixo = new System.Windows.Forms.Button();
            this.btExcluirProduto = new System.Windows.Forms.Button();
            this.btQuantidadeMais = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btDesconto = new System.Windows.Forms.Button();
            this.btQuantidadeMenos = new System.Windows.Forms.Button();
            this.tbTaxa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.dgvPedProduto = new System.Windows.Forms.DataGridView();
            this.nupNumPessoa = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome/Mesa:";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(161, 24);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(317, 31);
            this.tbNome.TabIndex = 4;
            this.tbNome.Leave += new System.EventHandler(this.tbNome_Leave);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(6, 73);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(531, 276);
            this.dgvProduto.TabIndex = 2;
            this.dgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellDoubleClick);
            this.dgvProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProduto_KeyDown);
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPesquisa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesquisa.Location = new System.Drawing.Point(85, 34);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(404, 27);
            this.tbPesquisa.TabIndex = 1;
            this.tbPesquisa.TextChanged += new System.EventHandler(this.tbPesquisa_TextChanged);
            this.tbPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesquisa_KeyDown);
            // 
            // lbPesquisar
            // 
            this.lbPesquisar.AutoSize = true;
            this.lbPesquisar.Location = new System.Drawing.Point(6, 38);
            this.lbPesquisar.Name = "lbPesquisar";
            this.lbPesquisar.Size = new System.Drawing.Size(73, 20);
            this.lbPesquisar.TabIndex = 13;
            this.lbPesquisar.Text = "Pesquisar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tbPesquisa);
            this.groupBox1.Controls.Add(this.dgvProduto);
            this.groupBox1.Controls.Add(this.btAdicionarProduto);
            this.groupBox1.Controls.Add(this.lbPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(17, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 355);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Produto";
            // 
            // btAdicionarProduto
            // 
            this.btAdicionarProduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAdicionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btAdicionarProduto.Image")));
            this.btAdicionarProduto.Location = new System.Drawing.Point(495, 25);
            this.btAdicionarProduto.Name = "btAdicionarProduto";
            this.btAdicionarProduto.Size = new System.Drawing.Size(42, 42);
            this.btAdicionarProduto.TabIndex = 3;
            this.btAdicionarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdicionarProduto.UseVisualStyleBackColor = true;
            this.btAdicionarProduto.Click += new System.EventHandler(this.btAdicionarProduto_Click);
            // 
            // btImportar
            // 
            this.btImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImportar.Image = ((System.Drawing.Image)(resources.GetObject("btImportar.Image")));
            this.btImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImportar.Location = new System.Drawing.Point(425, 422);
            this.btImportar.Name = "btImportar";
            this.btImportar.Size = new System.Drawing.Size(135, 50);
            this.btImportar.TabIndex = 10;
            this.btImportar.Text = "Importar (F3)";
            this.btImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btImportar.UseVisualStyleBackColor = true;
            this.btImportar.Click += new System.EventHandler(this.btImportar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(17, 422);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(93, 49);
            this.btExcluir.TabIndex = 14;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btPagamento
            // 
            this.btPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btPagamento.Image")));
            this.btPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPagamento.Location = new System.Drawing.Point(266, 423);
            this.btPagamento.Name = "btPagamento";
            this.btPagamento.Size = new System.Drawing.Size(153, 49);
            this.btPagamento.TabIndex = 16;
            this.btPagamento.Text = "Pagamento (F2)";
            this.btPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPagamento.UseVisualStyleBackColor = true;
            this.btPagamento.Click += new System.EventHandler(this.btPagamento_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btImprimir.Image")));
            this.btImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImprimir.Location = new System.Drawing.Point(116, 422);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(144, 50);
            this.btImprimir.TabIndex = 15;
            this.btImprimir.Text = "Imprimir (F1)";
            this.btImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // cbViagem
            // 
            this.cbViagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbViagem.AutoSize = true;
            this.cbViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViagem.Location = new System.Drawing.Point(1178, 27);
            this.cbViagem.Name = "cbViagem";
            this.cbViagem.Size = new System.Drawing.Size(94, 28);
            this.cbViagem.TabIndex = 26;
            this.cbViagem.Text = "Viagem";
            this.cbViagem.UseVisualStyleBackColor = true;
            this.cbViagem.Click += new System.EventHandler(this.cbViagem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbProduto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btImportar);
            this.groupBox3.Controls.Add(this.cbTaxa);
            this.groupBox3.Controls.Add(this.cbViagem);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.nupNumPessoa);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.tbNome);
            this.groupBox3.Controls.Add(this.btExcluir);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btImprimir);
            this.groupBox3.Controls.Add(this.btPagamento);
            this.groupBox3.Controls.Add(this.tbTotal);
            this.groupBox3.Controls.Add(this.tbSubtotal);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1284, 477);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pedido";
            // 
            // cbProduto
            // 
            this.cbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProduto.DropDownHeight = 150;
            this.cbProduto.IntegralHeight = false;
            this.cbProduto.ItemHeight = 20;
            this.cbProduto.Location = new System.Drawing.Point(593, 24);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(233, 28);
            this.cbProduto.TabIndex = 30;
            this.cbProduto.Visible = false;
            this.cbProduto.DropDown += new System.EventHandler(this.comboBox_DropDown);
            this.cbProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbProduto_KeyDown);
            this.cbProduto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.comboBox_PreviewKeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(589, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Pessoas:";
            // 
            // cbTaxa
            // 
            this.cbTaxa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTaxa.AutoSize = true;
            this.cbTaxa.Checked = true;
            this.cbTaxa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaxa.Location = new System.Drawing.Point(1033, 27);
            this.cbTaxa.Name = "cbTaxa";
            this.cbTaxa.Size = new System.Drawing.Size(139, 28);
            this.cbTaxa.TabIndex = 26;
            this.cbTaxa.Text = "Taxa Serviço";
            this.cbTaxa.UseVisualStyleBackColor = true;
            this.cbTaxa.Visible = false;
            this.cbTaxa.CheckedChanged += new System.EventHandler(this.cbTaxa_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btCima);
            this.groupBox2.Controls.Add(this.btBaixo);
            this.groupBox2.Controls.Add(this.btExcluirProduto);
            this.groupBox2.Controls.Add(this.btQuantidadeMais);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btDesconto);
            this.groupBox2.Controls.Add(this.btQuantidadeMenos);
            this.groupBox2.Controls.Add(this.tbTaxa);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbDesconto);
            this.groupBox2.Controls.Add(this.dgvPedProduto);
            this.groupBox2.Location = new System.Drawing.Point(566, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 355);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos do pedido";
            // 
            // btCima
            // 
            this.btCima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCima.Image = ((System.Drawing.Image)(resources.GetObject("btCima.Image")));
            this.btCima.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCima.Location = new System.Drawing.Point(642, 73);
            this.btCima.Name = "btCima";
            this.btCima.Size = new System.Drawing.Size(64, 62);
            this.btCima.TabIndex = 9;
            this.btCima.Text = "Cima";
            this.btCima.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCima.UseVisualStyleBackColor = true;
            this.btCima.Click += new System.EventHandler(this.btCima_Click);
            // 
            // btBaixo
            // 
            this.btBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBaixo.Image = ((System.Drawing.Image)(resources.GetObject("btBaixo.Image")));
            this.btBaixo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btBaixo.Location = new System.Drawing.Point(642, 141);
            this.btBaixo.Name = "btBaixo";
            this.btBaixo.Size = new System.Drawing.Size(64, 62);
            this.btBaixo.TabIndex = 9;
            this.btBaixo.Text = "Baixo";
            this.btBaixo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBaixo.UseVisualStyleBackColor = true;
            this.btBaixo.Click += new System.EventHandler(this.btBaixo_Click);
            // 
            // btExcluirProduto
            // 
            this.btExcluirProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluirProduto.Image = ((System.Drawing.Image)(resources.GetObject("btExcluirProduto.Image")));
            this.btExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExcluirProduto.Location = new System.Drawing.Point(642, 287);
            this.btExcluirProduto.Name = "btExcluirProduto";
            this.btExcluirProduto.Size = new System.Drawing.Size(64, 62);
            this.btExcluirProduto.TabIndex = 9;
            this.btExcluirProduto.Text = "Excluir";
            this.btExcluirProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluirProduto.UseVisualStyleBackColor = true;
            this.btExcluirProduto.Click += new System.EventHandler(this.btExcluirProduto_Click);
            // 
            // btQuantidadeMais
            // 
            this.btQuantidadeMais.Image = ((System.Drawing.Image)(resources.GetObject("btQuantidadeMais.Image")));
            this.btQuantidadeMais.Location = new System.Drawing.Point(105, 28);
            this.btQuantidadeMais.Name = "btQuantidadeMais";
            this.btQuantidadeMais.Size = new System.Drawing.Size(40, 40);
            this.btQuantidadeMais.TabIndex = 5;
            this.btQuantidadeMais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuantidadeMais.UseVisualStyleBackColor = true;
            this.btQuantidadeMais.Click += new System.EventHandler(this.btQuantidadeMais_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantidade";
            // 
            // btDesconto
            // 
            this.btDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDesconto.Image = ((System.Drawing.Image)(resources.GetObject("btDesconto.Image")));
            this.btDesconto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDesconto.Location = new System.Drawing.Point(521, 27);
            this.btDesconto.Name = "btDesconto";
            this.btDesconto.Size = new System.Drawing.Size(115, 40);
            this.btDesconto.TabIndex = 8;
            this.btDesconto.Text = "Desconto";
            this.btDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDesconto.UseVisualStyleBackColor = true;
            this.btDesconto.Click += new System.EventHandler(this.btDesconto_Click);
            // 
            // btQuantidadeMenos
            // 
            this.btQuantidadeMenos.Image = ((System.Drawing.Image)(resources.GetObject("btQuantidadeMenos.Image")));
            this.btQuantidadeMenos.Location = new System.Drawing.Point(151, 28);
            this.btQuantidadeMenos.Name = "btQuantidadeMenos";
            this.btQuantidadeMenos.Size = new System.Drawing.Size(40, 40);
            this.btQuantidadeMenos.TabIndex = 6;
            this.btQuantidadeMenos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuantidadeMenos.UseVisualStyleBackColor = true;
            this.btQuantidadeMenos.Click += new System.EventHandler(this.btQuantidadeMenos_Click);
            // 
            // tbTaxa
            // 
            this.tbTaxa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTaxa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTaxa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaxa.Location = new System.Drawing.Point(454, 0);
            this.tbTaxa.Name = "tbTaxa";
            this.tbTaxa.ReadOnly = true;
            this.tbTaxa.Size = new System.Drawing.Size(182, 29);
            this.tbTaxa.TabIndex = 13;
            this.tbTaxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTaxa.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor";
            // 
            // tbDesconto
            // 
            this.tbDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbDesconto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesconto.Location = new System.Drawing.Point(294, 34);
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(221, 27);
            this.tbDesconto.TabIndex = 7;
            this.tbDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbValorNovo_KeyDown);
            this.tbDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxNumeros_KeyPress);
            this.tbDesconto.Leave += new System.EventHandler(this.textboxNumeros_Leave);
            // 
            // dgvPedProduto
            // 
            this.dgvPedProduto.AllowUserToAddRows = false;
            this.dgvPedProduto.AllowUserToDeleteRows = false;
            this.dgvPedProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedProduto.Location = new System.Drawing.Point(9, 73);
            this.dgvPedProduto.MultiSelect = false;
            this.dgvPedProduto.Name = "dgvPedProduto";
            this.dgvPedProduto.ReadOnly = true;
            this.dgvPedProduto.RowHeadersWidth = 50;
            this.dgvPedProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedProduto.Size = new System.Drawing.Size(627, 276);
            this.dgvPedProduto.TabIndex = 0;
            this.dgvPedProduto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPedProduto_CellMouseClick);
            this.dgvPedProduto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPedProduto_CellMouseDoubleClick);
            // 
            // nupNumPessoa
            // 
            this.nupNumPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nupNumPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNumPessoa.Location = new System.Drawing.Point(669, 434);
            this.nupNumPessoa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNumPessoa.Name = "nupNumPessoa";
            this.nupNumPessoa.Size = new System.Drawing.Size(50, 26);
            this.nupNumPessoa.TabIndex = 11;
            this.nupNumPessoa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(725, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total:";
            this.label3.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(979, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Total:";
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.BackColor = System.Drawing.Color.LightCoral;
            this.tbTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTotal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(779, 422);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(169, 46);
            this.tbTotal.TabIndex = 13;
            this.tbTotal.Text = "999.999,99";
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTotal.Visible = false;
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubtotal.BackColor = System.Drawing.Color.PaleGreen;
            this.tbSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSubtotal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubtotal.Location = new System.Drawing.Point(1033, 422);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.ReadOnly = true;
            this.tbSubtotal.Size = new System.Drawing.Size(169, 46);
            this.tbSubtotal.TabIndex = 13;
            this.tbSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // formPedidoDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 477);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "formPedidoDetalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido Detalhes";
            this.Activated += new System.EventHandler(this.formPedidoDetalhes_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formPedidoDetalhes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btPagamento;
        private System.Windows.Forms.Button btAdicionarProduto;
        public System.Windows.Forms.TextBox tbNome;
        public System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Label lbPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btImportar;
        public System.Windows.Forms.CheckBox cbViagem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCima;
        private System.Windows.Forms.Button btBaixo;
        private System.Windows.Forms.Button btExcluirProduto;
        private System.Windows.Forms.Button btQuantidadeMais;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown nupNumPessoa;
        private System.Windows.Forms.Button btDesconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btQuantidadeMenos;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbDesconto;
        public System.Windows.Forms.DataGridView dgvPedProduto;
        public System.Windows.Forms.CheckBox cbTaxa;
        private System.Windows.Forms.TextBox tbTaxa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.ComboBox cbProduto;
    }
}