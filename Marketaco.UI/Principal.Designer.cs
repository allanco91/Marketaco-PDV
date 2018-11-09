namespace Marketaco.UI
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.tabGeral = new System.Windows.Forms.TabControl();
            this.tabVendas = new System.Windows.Forms.TabPage();
            this.btTrocarOperador = new System.Windows.Forms.Button();
            this.btPDV = new System.Windows.Forms.Button();
            this.btSaldoDia = new System.Windows.Forms.Button();
            this.btGerenciarPedido = new System.Windows.Forms.Button();
            this.btCaixa = new System.Windows.Forms.Button();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.btCategoria = new System.Windows.Forms.Button();
            this.btEstoque = new System.Windows.Forms.Button();
            this.btProduto = new System.Windows.Forms.Button();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.btSobre = new System.Windows.Forms.Button();
            this.btHistoricoCaixa = new System.Windows.Forms.Button();
            this.btRelEstoque = new System.Windows.Forms.Button();
            this.btRelLista = new System.Windows.Forms.Button();
            this.btRelData = new System.Windows.Forms.Button();
            this.btRelTotalPorMes = new System.Windows.Forms.Button();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.btConfig = new System.Windows.Forms.Button();
            this.btLogs = new System.Windows.Forms.Button();
            this.btOperadores = new System.Windows.Forms.Button();
            this.btEmpresa = new System.Windows.Forms.Button();
            this.statusBarra = new System.Windows.Forms.StatusStrip();
            this.statusLB1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusOperador = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbAviso = new System.Windows.Forms.RichTextBox();
            this.btAtualizarAviso = new System.Windows.Forms.Button();
            this.panelAviso = new System.Windows.Forms.Panel();
            this.btAviso = new System.Windows.Forms.Button();
            this.tabGeral.SuspendLayout();
            this.tabVendas.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.tabRelatorio.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.statusBarra.SuspendLayout();
            this.panelAviso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGeral
            // 
            this.tabGeral.Controls.Add(this.tabVendas);
            this.tabGeral.Controls.Add(this.tabCadastro);
            this.tabGeral.Controls.Add(this.tabRelatorio);
            this.tabGeral.Controls.Add(this.tabConfig);
            this.tabGeral.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabGeral.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tabGeral.Location = new System.Drawing.Point(0, 0);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.SelectedIndex = 0;
            this.tabGeral.Size = new System.Drawing.Size(1008, 128);
            this.tabGeral.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabGeral.TabIndex = 0;
            // 
            // tabVendas
            // 
            this.tabVendas.Controls.Add(this.btTrocarOperador);
            this.tabVendas.Controls.Add(this.btPDV);
            this.tabVendas.Controls.Add(this.btSaldoDia);
            this.tabVendas.Controls.Add(this.btGerenciarPedido);
            this.tabVendas.Controls.Add(this.btCaixa);
            this.tabVendas.Location = new System.Drawing.Point(4, 24);
            this.tabVendas.Name = "tabVendas";
            this.tabVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendas.Size = new System.Drawing.Size(1000, 100);
            this.tabVendas.TabIndex = 0;
            this.tabVendas.Text = "VENDAS";
            this.tabVendas.UseVisualStyleBackColor = true;
            // 
            // btTrocarOperador
            // 
            this.btTrocarOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTrocarOperador.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btTrocarOperador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btTrocarOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTrocarOperador.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btTrocarOperador.Image = ((System.Drawing.Image)(resources.GetObject("btTrocarOperador.Image")));
            this.btTrocarOperador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btTrocarOperador.Location = new System.Drawing.Point(883, 6);
            this.btTrocarOperador.Name = "btTrocarOperador";
            this.btTrocarOperador.Size = new System.Drawing.Size(109, 90);
            this.btTrocarOperador.TabIndex = 1;
            this.btTrocarOperador.Text = "Trocar operador";
            this.btTrocarOperador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTrocarOperador.UseVisualStyleBackColor = true;
            this.btTrocarOperador.Click += new System.EventHandler(this.btTrocarOperador_Click);
            // 
            // btPDV
            // 
            this.btPDV.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btPDV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btPDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPDV.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btPDV.Image = ((System.Drawing.Image)(resources.GetObject("btPDV.Image")));
            this.btPDV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPDV.Location = new System.Drawing.Point(266, 6);
            this.btPDV.Name = "btPDV";
            this.btPDV.Size = new System.Drawing.Size(91, 90);
            this.btPDV.TabIndex = 1;
            this.btPDV.Text = "PDV";
            this.btPDV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPDV.UseVisualStyleBackColor = true;
            this.btPDV.Visible = false;
            this.btPDV.Click += new System.EventHandler(this.btPDV_Click);
            // 
            // btSaldoDia
            // 
            this.btSaldoDia.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btSaldoDia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btSaldoDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaldoDia.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btSaldoDia.Image = ((System.Drawing.Image)(resources.GetObject("btSaldoDia.Image")));
            this.btSaldoDia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSaldoDia.Location = new System.Drawing.Point(399, 6);
            this.btSaldoDia.Name = "btSaldoDia";
            this.btSaldoDia.Size = new System.Drawing.Size(97, 90);
            this.btSaldoDia.TabIndex = 1;
            this.btSaldoDia.Text = "Vendas do dia";
            this.btSaldoDia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSaldoDia.UseVisualStyleBackColor = true;
            this.btSaldoDia.Click += new System.EventHandler(this.btSaldoDia_Click);
            // 
            // btGerenciarPedido
            // 
            this.btGerenciarPedido.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btGerenciarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btGerenciarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGerenciarPedido.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btGerenciarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btGerenciarPedido.Image")));
            this.btGerenciarPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btGerenciarPedido.Location = new System.Drawing.Point(169, 6);
            this.btGerenciarPedido.Name = "btGerenciarPedido";
            this.btGerenciarPedido.Size = new System.Drawing.Size(91, 90);
            this.btGerenciarPedido.TabIndex = 1;
            this.btGerenciarPedido.Text = "Mesas";
            this.btGerenciarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGerenciarPedido.UseVisualStyleBackColor = true;
            this.btGerenciarPedido.Click += new System.EventHandler(this.btGerenciarPedido_Click);
            // 
            // btCaixa
            // 
            this.btCaixa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCaixa.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btCaixa.Image")));
            this.btCaixa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCaixa.Location = new System.Drawing.Point(6, 6);
            this.btCaixa.Name = "btCaixa";
            this.btCaixa.Size = new System.Drawing.Size(82, 90);
            this.btCaixa.TabIndex = 1;
            this.btCaixa.Text = "Meu Caixa";
            this.btCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCaixa.UseVisualStyleBackColor = true;
            this.btCaixa.Click += new System.EventHandler(this.btCaixa_Click);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.btCategoria);
            this.tabCadastro.Controls.Add(this.btEstoque);
            this.tabCadastro.Controls.Add(this.btProduto);
            this.tabCadastro.Location = new System.Drawing.Point(4, 24);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(1000, 100);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "CADASTROS";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // btCategoria
            // 
            this.btCategoria.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btCategoria.Image")));
            this.btCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCategoria.Location = new System.Drawing.Point(8, 4);
            this.btCategoria.Name = "btCategoria";
            this.btCategoria.Size = new System.Drawing.Size(82, 90);
            this.btCategoria.TabIndex = 0;
            this.btCategoria.Text = "Categorias";
            this.btCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCategoria.UseVisualStyleBackColor = true;
            this.btCategoria.Click += new System.EventHandler(this.btCategoria_Click);
            // 
            // btEstoque
            // 
            this.btEstoque.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstoque.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btEstoque.Image")));
            this.btEstoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEstoque.Location = new System.Drawing.Point(248, 4);
            this.btEstoque.Name = "btEstoque";
            this.btEstoque.Size = new System.Drawing.Size(82, 90);
            this.btEstoque.TabIndex = 0;
            this.btEstoque.Text = "Estoque";
            this.btEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEstoque.UseVisualStyleBackColor = true;
            this.btEstoque.Click += new System.EventHandler(this.btEstoque_Click);
            // 
            // btProduto
            // 
            this.btProduto.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduto.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btProduto.Image = ((System.Drawing.Image)(resources.GetObject("btProduto.Image")));
            this.btProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btProduto.Location = new System.Drawing.Point(128, 4);
            this.btProduto.Name = "btProduto";
            this.btProduto.Size = new System.Drawing.Size(82, 90);
            this.btProduto.TabIndex = 0;
            this.btProduto.Text = "Produtos";
            this.btProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Click += new System.EventHandler(this.btProduto_Click);
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Controls.Add(this.btSobre);
            this.tabRelatorio.Controls.Add(this.btHistoricoCaixa);
            this.tabRelatorio.Controls.Add(this.btRelEstoque);
            this.tabRelatorio.Controls.Add(this.btRelLista);
            this.tabRelatorio.Controls.Add(this.btRelData);
            this.tabRelatorio.Controls.Add(this.btRelTotalPorMes);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 24);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorio.Size = new System.Drawing.Size(1000, 100);
            this.tabRelatorio.TabIndex = 2;
            this.tabRelatorio.Text = "RELATÓRIOS";
            this.tabRelatorio.UseVisualStyleBackColor = true;
            // 
            // btSobre
            // 
            this.btSobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSobre.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btSobre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSobre.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btSobre.Image = ((System.Drawing.Image)(resources.GetObject("btSobre.Image")));
            this.btSobre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSobre.Location = new System.Drawing.Point(912, 6);
            this.btSobre.Name = "btSobre";
            this.btSobre.Size = new System.Drawing.Size(82, 90);
            this.btSobre.TabIndex = 3;
            this.btSobre.Text = "Sobre";
            this.btSobre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSobre.UseVisualStyleBackColor = true;
            this.btSobre.Click += new System.EventHandler(this.btSobre_Click);
            // 
            // btHistoricoCaixa
            // 
            this.btHistoricoCaixa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btHistoricoCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btHistoricoCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHistoricoCaixa.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btHistoricoCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btHistoricoCaixa.Image")));
            this.btHistoricoCaixa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btHistoricoCaixa.Location = new System.Drawing.Point(471, 6);
            this.btHistoricoCaixa.Name = "btHistoricoCaixa";
            this.btHistoricoCaixa.Size = new System.Drawing.Size(105, 90);
            this.btHistoricoCaixa.TabIndex = 2;
            this.btHistoricoCaixa.Text = "Histórico Caixa";
            this.btHistoricoCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHistoricoCaixa.UseVisualStyleBackColor = true;
            this.btHistoricoCaixa.Click += new System.EventHandler(this.btHistoricoCaixa_Click);
            // 
            // btRelEstoque
            // 
            this.btRelEstoque.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btRelEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btRelEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelEstoque.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btRelEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btRelEstoque.Image")));
            this.btRelEstoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRelEstoque.Location = new System.Drawing.Point(251, 6);
            this.btRelEstoque.Name = "btRelEstoque";
            this.btRelEstoque.Size = new System.Drawing.Size(82, 90);
            this.btRelEstoque.TabIndex = 1;
            this.btRelEstoque.Text = "Estoque";
            this.btRelEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRelEstoque.UseVisualStyleBackColor = true;
            this.btRelEstoque.Click += new System.EventHandler(this.btRelEstoque_Click);
            // 
            // btRelLista
            // 
            this.btRelLista.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btRelLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btRelLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelLista.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btRelLista.Image = ((System.Drawing.Image)(resources.GetObject("btRelLista.Image")));
            this.btRelLista.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRelLista.Location = new System.Drawing.Point(339, 6);
            this.btRelLista.Name = "btRelLista";
            this.btRelLista.Size = new System.Drawing.Size(82, 90);
            this.btRelLista.TabIndex = 1;
            this.btRelLista.Text = "Listas";
            this.btRelLista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRelLista.UseVisualStyleBackColor = true;
            this.btRelLista.Click += new System.EventHandler(this.btRelLista_Click);
            // 
            // btRelData
            // 
            this.btRelData.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btRelData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btRelData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelData.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btRelData.Image = ((System.Drawing.Image)(resources.GetObject("btRelData.Image")));
            this.btRelData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRelData.Location = new System.Drawing.Point(108, 6);
            this.btRelData.Name = "btRelData";
            this.btRelData.Size = new System.Drawing.Size(86, 90);
            this.btRelData.TabIndex = 1;
            this.btRelData.Text = "Data";
            this.btRelData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRelData.UseVisualStyleBackColor = true;
            this.btRelData.Click += new System.EventHandler(this.btRelData_Click);
            // 
            // btRelTotalPorMes
            // 
            this.btRelTotalPorMes.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btRelTotalPorMes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btRelTotalPorMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelTotalPorMes.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btRelTotalPorMes.Image = ((System.Drawing.Image)(resources.GetObject("btRelTotalPorMes.Image")));
            this.btRelTotalPorMes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRelTotalPorMes.Location = new System.Drawing.Point(8, 6);
            this.btRelTotalPorMes.Name = "btRelTotalPorMes";
            this.btRelTotalPorMes.Size = new System.Drawing.Size(94, 90);
            this.btRelTotalPorMes.TabIndex = 1;
            this.btRelTotalPorMes.Text = "Total por mês";
            this.btRelTotalPorMes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRelTotalPorMes.UseVisualStyleBackColor = true;
            this.btRelTotalPorMes.Click += new System.EventHandler(this.btRelTotalPorMes_Click);
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.btConfig);
            this.tabConfig.Controls.Add(this.btLogs);
            this.tabConfig.Controls.Add(this.btOperadores);
            this.tabConfig.Controls.Add(this.btEmpresa);
            this.tabConfig.Location = new System.Drawing.Point(4, 24);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(1000, 100);
            this.tabConfig.TabIndex = 3;
            this.tabConfig.Text = "CONFIGURAÇÕES";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // btConfig
            // 
            this.btConfig.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfig.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btConfig.Image = ((System.Drawing.Image)(resources.GetObject("btConfig.Image")));
            this.btConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btConfig.Location = new System.Drawing.Point(429, 5);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(98, 90);
            this.btConfig.TabIndex = 4;
            this.btConfig.Text = "Configurações";
            this.btConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // btLogs
            // 
            this.btLogs.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btLogs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogs.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btLogs.Image = ((System.Drawing.Image)(resources.GetObject("btLogs.Image")));
            this.btLogs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLogs.Location = new System.Drawing.Point(265, 5);
            this.btLogs.Name = "btLogs";
            this.btLogs.Size = new System.Drawing.Size(94, 90);
            this.btLogs.TabIndex = 4;
            this.btLogs.Text = "Hist. de ações";
            this.btLogs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLogs.UseVisualStyleBackColor = true;
            this.btLogs.Click += new System.EventHandler(this.btLogs_Click);
            // 
            // btOperadores
            // 
            this.btOperadores.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btOperadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btOperadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOperadores.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btOperadores.Image = ((System.Drawing.Image)(resources.GetObject("btOperadores.Image")));
            this.btOperadores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btOperadores.Location = new System.Drawing.Point(8, 5);
            this.btOperadores.Name = "btOperadores";
            this.btOperadores.Size = new System.Drawing.Size(82, 90);
            this.btOperadores.TabIndex = 4;
            this.btOperadores.Text = "Operadores";
            this.btOperadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btOperadores.UseVisualStyleBackColor = true;
            this.btOperadores.Click += new System.EventHandler(this.btOperadores_Click);
            // 
            // btEmpresa
            // 
            this.btEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmpresa.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btEmpresa.Image")));
            this.btEmpresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEmpresa.Location = new System.Drawing.Point(96, 5);
            this.btEmpresa.Name = "btEmpresa";
            this.btEmpresa.Size = new System.Drawing.Size(82, 90);
            this.btEmpresa.TabIndex = 3;
            this.btEmpresa.Text = "Empresa";
            this.btEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEmpresa.UseVisualStyleBackColor = true;
            this.btEmpresa.Click += new System.EventHandler(this.btEmpresa_Click);
            // 
            // statusBarra
            // 
            this.statusBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLB1,
            this.toolStripStatusLabel1,
            this.statusEmpresa,
            this.toolStripStatusLabel3,
            this.statusOperador});
            this.statusBarra.Location = new System.Drawing.Point(0, 639);
            this.statusBarra.Name = "statusBarra";
            this.statusBarra.Size = new System.Drawing.Size(1008, 22);
            this.statusBarra.TabIndex = 2;
            this.statusBarra.Text = "statusStrip1";
            // 
            // statusLB1
            // 
            this.statusLB1.Name = "statusLB1";
            this.statusLB1.Size = new System.Drawing.Size(90, 17);
            this.statusLB1.Text = "Marketaco 2017";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // statusEmpresa
            // 
            this.statusEmpresa.Name = "statusEmpresa";
            this.statusEmpresa.Size = new System.Drawing.Size(103, 17);
            this.statusEmpresa.Text = "Empresa: Empresa";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel3.Text = "-";
            // 
            // statusOperador
            // 
            this.statusOperador.Name = "statusOperador";
            this.statusOperador.Size = new System.Drawing.Size(90, 17);
            this.statusOperador.Text = "Operador: Allan";
            // 
            // rtbAviso
            // 
            this.rtbAviso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAviso.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAviso.Location = new System.Drawing.Point(25, 0);
            this.rtbAviso.Name = "rtbAviso";
            this.rtbAviso.Size = new System.Drawing.Size(0, 468);
            this.rtbAviso.TabIndex = 19;
            this.rtbAviso.Text = "36";
            // 
            // btAtualizarAviso
            // 
            this.btAtualizarAviso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btAtualizarAviso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarAviso.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizarAviso.Image")));
            this.btAtualizarAviso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtualizarAviso.Location = new System.Drawing.Point(25, 468);
            this.btAtualizarAviso.Name = "btAtualizarAviso";
            this.btAtualizarAviso.Size = new System.Drawing.Size(0, 43);
            this.btAtualizarAviso.TabIndex = 17;
            this.btAtualizarAviso.Text = "Atualizar";
            this.btAtualizarAviso.UseVisualStyleBackColor = true;
            this.btAtualizarAviso.Click += new System.EventHandler(this.btAtualizarAviso_Click);
            // 
            // panelAviso
            // 
            this.panelAviso.Controls.Add(this.rtbAviso);
            this.panelAviso.Controls.Add(this.btAtualizarAviso);
            this.panelAviso.Controls.Add(this.btAviso);
            this.panelAviso.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAviso.Location = new System.Drawing.Point(983, 128);
            this.panelAviso.Name = "panelAviso";
            this.panelAviso.Size = new System.Drawing.Size(25, 511);
            this.panelAviso.TabIndex = 12;
            // 
            // btAviso
            // 
            this.btAviso.BackColor = System.Drawing.Color.SlateGray;
            this.btAviso.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAviso.FlatAppearance.BorderSize = 0;
            this.btAviso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btAviso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAviso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAviso.Image = ((System.Drawing.Image)(resources.GetObject("btAviso.Image")));
            this.btAviso.Location = new System.Drawing.Point(0, 0);
            this.btAviso.Name = "btAviso";
            this.btAviso.Size = new System.Drawing.Size(25, 511);
            this.btAviso.TabIndex = 14;
            this.btAviso.UseVisualStyleBackColor = false;
            this.btAviso.Click += new System.EventHandler(this.btAviso_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panelAviso);
            this.Controls.Add(this.statusBarra);
            this.Controls.Add(this.tabGeral);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marketaco - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabGeral.ResumeLayout(false);
            this.tabVendas.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabRelatorio.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.statusBarra.ResumeLayout(false);
            this.statusBarra.PerformLayout();
            this.panelAviso.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeral;
        private System.Windows.Forms.TabPage tabVendas;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.Button btCategoria;
        private System.Windows.Forms.Button btCaixa;
        private System.Windows.Forms.StatusStrip statusBarra;
        private System.Windows.Forms.ToolStripStatusLabel statusLB1;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.Button btRelTotalPorMes;
        private System.Windows.Forms.Button btGerenciarPedido;
        private System.Windows.Forms.Button btEstoque;
        private System.Windows.Forms.Button btRelData;
        private System.Windows.Forms.Button btRelLista;
        private System.Windows.Forms.Button btRelEstoque;
        private System.Windows.Forms.Button btHistoricoCaixa;
        private System.Windows.Forms.RichTextBox rtbAviso;
        private System.Windows.Forms.Button btAtualizarAviso;
        private System.Windows.Forms.Panel panelAviso;
        private System.Windows.Forms.Button btAviso;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusEmpresa;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button btEmpresa;
        private System.Windows.Forms.Button btOperadores;
        private System.Windows.Forms.Button btSobre;
        private System.Windows.Forms.Button btLogs;
        private System.Windows.Forms.ToolStripStatusLabel statusOperador;
        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.Button btTrocarOperador;
        private System.Windows.Forms.Button btPDV;
        private System.Windows.Forms.Button btSaldoDia;
    }
}

