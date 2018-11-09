using System;
using System.Windows.Forms;
using Marketaco.DAL;
using Marketaco.UI.Report;
using System.Collections.Generic;
using System.Drawing;

namespace Marketaco.UI
{
    public partial class formRelatorio : Form
    {
        public formRelatorio()
        {
            InitializeComponent();
        }

        #region Classes
        private int TTipo = 0;
        public int TRel { get; set; }
        public class Datas
        {
            public DateTime data_inicial { get; set; }
            public DateTime data_final { get; set; }
        }
        #endregion

        #region Métodos
        private Dictionary<int, string> ComboBoxTipos()
        {
            Dictionary<int, string> Tipos = new Dictionary<int, string>();

            switch (TRel)
            {
                //Relatórios Total por mês
                case 1:
                    Tipos.Add(0, "Selecione um tipo de relatório");
                    Tipos.Add(1, "Total de vendas por mês");
                    Tipos.Add(3, "Total Vendas x Produtos por mês");
                    Tipos.Add(4, "Total Vendas x Categorias por mês");
                    break;
                //Relatórios por data
                case 2:
                    Tipos.Add(0, "Selecione um tipo de relatório");
                    Tipos.Add(5, "Vendas por data");
                    Tipos.Add(7, "Vendas x Produtos por data");
                    Tipos.Add(8, "Vendas x Categorias por data");
                    break;
                //Relatórios Estoque
                case 3:
                    Tipos.Add(0, "Selecione um tipo de relatório");
                    Tipos.Add(9, "Lista para contagem/conferência");
                    Tipos.Add(10, "Lista estoque");
                    Tipos.Add(11, "Lista para reposição");
                    Tipos.Add(12, "Lista estoque mínimo");
                    Tipos.Add(13, "Lista estoque ideal");
                    Tipos.Add(14, "Histórico de Entrada/Saída");
                    
                    break;
                //Relatórios Listas
                case 4:
                    Tipos.Add(0, "Selecione um tipo de relatório");
                    Tipos.Add(16, "Lista de Produtos");
                    Tipos.Add(17, "Lista de Categorias");
                    break;
                default:
                    Tipos.Add(0, "Selecione um tipo de relatório");
                    break;
            }
            
            return Tipos;
        }

        private void procurarVendas(int Tipo, DateTime Data1, DateTime Data2, string Produto, string Categoria)
        {
            try
            {
                dalPedido ped = new dalPedido();
                dalItensPedido iped = new dalItensPedido();
                dalEstoque est = new dalEstoque();
                dalProduto prod = new dalProduto();
                dalCategoria cat = new dalCategoria();

                switch (Tipo)
                {
                    case 1:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = ped.TotalPorMes(Data1, Data2);
                        dgvRelatorio.Columns[0].HeaderText = "Mês";
                        dgvRelatorio.Columns[0].DefaultCellStyle.Format = "MM/yyyy";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Valor";
                        dgvRelatorio.Columns[1].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        TTipo = Tipo;
                        break;
                    case 3:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = iped.TotalProdutosPorMes(Data1, Data2, Produto);
                        dgvRelatorio.Columns[0].HeaderText = "Mês";
                        dgvRelatorio.Columns[0].DefaultCellStyle.Format = "MM/yyyy";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Produto";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvRelatorio.Columns[2].HeaderText = "Quantidade";
                        dgvRelatorio.Columns[2].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[3].HeaderText = "Valor";
                        dgvRelatorio.Columns[3].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        TTipo = Tipo;
                        break;
                    case 4:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = iped.TotalCategoriasPorMes(Data1, Data2, Categoria);
                        dgvRelatorio.Columns[0].HeaderText = "Mês";
                        dgvRelatorio.Columns[0].DefaultCellStyle.Format = "MM/yyyy";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Categoria";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvRelatorio.Columns[2].HeaderText = "Quantidade";
                        dgvRelatorio.Columns[2].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[3].HeaderText = "Valor";
                        dgvRelatorio.Columns[3].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        TTipo = Tipo;
                        break;
                    case 5:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = ped.VendaPorData(Data1, Data2);
                        dgvRelatorio.Columns[0].HeaderText = "Data";
                        dgvRelatorio.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Valor";
                        dgvRelatorio.Columns[1].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        TTipo = Tipo;
                        break;
                    case 7:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = iped.ProdutosPorData(Data1, Data2, Produto);
                        dgvRelatorio.Columns[0].HeaderText = "Data";
                        dgvRelatorio.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Produto";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvRelatorio.Columns[2].HeaderText = "Quantidade";
                        dgvRelatorio.Columns[2].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[3].HeaderText = "Valor";
                        dgvRelatorio.Columns[3].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        TTipo = Tipo;
                        break;
                    case 8:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = iped.CategoriasPorData(Data1, Data2, Categoria);
                        dgvRelatorio.Columns[0].HeaderText = "Data";
                        dgvRelatorio.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Categoria";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvRelatorio.Columns[2].HeaderText = "Quantidade";
                        dgvRelatorio.Columns[2].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[3].HeaderText = "Valor";
                        dgvRelatorio.Columns[3].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        TTipo = Tipo;
                        break;
                    case 9:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = est.relEstoqueConfCont(Categoria, cbVendavel.Checked);
                        dgvRelatorio.Columns[0].HeaderText = "Categoria";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Produto";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvRelatorio.Columns[2].HeaderText = "Quantidade";
                        dgvRelatorio.Columns[2].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        TTipo = Tipo;
                        break;
                    case 10:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = est.relEstoqueConfCont(Categoria, cbVendavel.Checked);
                        dgvRelatorio.Columns[0].HeaderText = "Categoria";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Produto";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvRelatorio.Columns[2].Visible = false;
                        dgvRelatorio.Columns[3].HeaderText = "Quantidade";
                        dgvRelatorio.Columns[3].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        TTipo = Tipo;
                        break;
                    case 11:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = est.relEstoqueProducao(Categoria, cbVendavel.Checked);
                        dgvRelatorio.Columns[0].HeaderText = "Categoria";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Produto";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvRelatorio.Columns[2].HeaderText = "Ideal";
                        dgvRelatorio.Columns[2].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[3].HeaderText = "Quantidade";
                        dgvRelatorio.Columns[3].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        TTipo = Tipo;
                        break;
                    case 12:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = est.relEstoqueMin(Categoria, cbVendavel.Checked);
                        dgvRelatorio.Columns[0].HeaderText = "Categoria";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Produto";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvRelatorio.Columns[2].HeaderText = "Mínimo";
                        dgvRelatorio.Columns[2].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[3].HeaderText = "Quantidade";
                        dgvRelatorio.Columns[3].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        TTipo = Tipo;
                        break;
                    case 13:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = est.relEstoqueIde(Categoria, cbVendavel.Checked);
                        dgvRelatorio.Columns[0].HeaderText = "Categoria";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Produto";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvRelatorio.Columns[2].HeaderText = "Ideal";
                        dgvRelatorio.Columns[2].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[3].HeaderText = "Quantidade";
                        dgvRelatorio.Columns[3].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        TTipo = Tipo;
                        break;
                    case 14:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = est.relHistoricoEntSai(Data1, Data2, Produto, cbVendavel.Checked);
                        dgvRelatorio.Columns[0].HeaderText = "Data";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvRelatorio.Columns[1].HeaderText = "Produto";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvRelatorio.Columns[2].HeaderText = "Entrada";
                        dgvRelatorio.Columns[2].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[3].HeaderText = "Saida";
                        dgvRelatorio.Columns[3].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        TTipo = Tipo;
                        break;
                    case 16:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = prod.listaProdutos(Categoria, cbVendavel.Checked);
                        dgvRelatorio.Columns[0].HeaderText = "Categoria";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Código";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[2].HeaderText = "Produto";
                        dgvRelatorio.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvRelatorio.Columns[3].HeaderText = "Custo";
                        dgvRelatorio.Columns[3].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[4].HeaderText = "Preço";
                        dgvRelatorio.Columns[4].DefaultCellStyle.Format = "f";
                        dgvRelatorio.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[5].HeaderText = "% Lucro";
                        dgvRelatorio.Columns[5].DefaultCellStyle.Format = "P2";
                        dgvRelatorio.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        TTipo = Tipo;
                        break;
                    case 17:
                        dgvRelatorio.DataSource = null;
                        dgvRelatorio.DataSource = cat.listaCategorias();
                        dgvRelatorio.Columns[0].HeaderText = "Código";
                        dgvRelatorio.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvRelatorio.Columns[1].HeaderText = "Categoria";
                        dgvRelatorio.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgvRelatorio.Columns[2].Visible = false;
                        TTipo = Tipo;
                        break;
                    default:
                        MessageBox.Show("Selecione um tipo de relatório.", "Tipo de relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }
        }

        private void imprimirRelatorio(int Tipo)
        {
            try
            {
                if (TTipo == Tipo)
                {
                    switch (Tipo)
                    {
                        case 1:
                            repTotalPorMes rel1 = new repTotalPorMes();
                            rel1.GrupoMesBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel1.DatasBindingSource.DataSource = new Datas { data_inicial = dtpDataInicial.Value.Date, data_final = dtpDataFinal.Value.Date };
                            rel1.Show();
                            break;
                        case 2:
                            repTotalEntregaPorMes rel2 = new repTotalEntregaPorMes();
                            rel2.GrupoEntregaBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel2.DatasBindingSource.DataSource = new Datas { data_inicial = dtpDataInicial.Value.Date, data_final = dtpDataFinal.Value.Date };
                            rel2.Show();
                            break;
                        case 3:
                            repTotalProdutoPorMes rel3 = new repTotalProdutoPorMes();
                            rel3.GrupoProdutosBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel3.DatasBindingSource.DataSource = new Datas { data_inicial = dtpDataInicial.Value.Date, data_final = dtpDataFinal.Value.Date };
                            rel3.Show();
                            break;
                        case 4:
                            repTotalCategoriaPorMes rel4 = new repTotalCategoriaPorMes();
                            rel4.GrupoCategoriasBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel4.DatasBindingSource.DataSource = new Datas { data_inicial = dtpDataInicial.Value.Date, data_final = dtpDataFinal.Value.Date };
                            rel4.Show();
                            break;
                        case 5:
                            repVendasPorData rel5 = new repVendasPorData();
                            rel5.GrupoMesBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel5.DatasBindingSource.DataSource = new Datas { data_inicial = dtpDataInicial.Value.Date, data_final = dtpDataFinal.Value.Date };
                            rel5.Show();
                            break;
                        case 6:
                            repEntregaPorData rel6 = new repEntregaPorData();
                            rel6.GrupoEntregaBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel6.DatasBindingSource.DataSource = new Datas { data_inicial = dtpDataInicial.Value.Date, data_final = dtpDataFinal.Value.Date };
                            rel6.Show();
                            break;
                        case 7:
                            repProdutoPorData rel7 = new repProdutoPorData();
                            rel7.GrupoProdutosBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel7.DatasBindingSource.DataSource = new Datas { data_inicial = dtpDataInicial.Value.Date, data_final = dtpDataFinal.Value.Date };
                            rel7.Show();
                            break;
                        case 8:
                            repCategoriaPorData rel8 = new repCategoriaPorData();
                            rel8.GrupoCategoriasBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel8.DatasBindingSource.DataSource = new Datas { data_inicial = dtpDataInicial.Value.Date, data_final = dtpDataFinal.Value.Date };
                            rel8.Show();
                            break;
                        case 9:
                            repContagemConferencia rel9 = new repContagemConferencia();
                            rel9.RelEstoqueBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel9.Show();
                            break;
                        case 10:
                            repListaEstoque rel10 = new repListaEstoque();
                            rel10.RelEstoqueBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel10.Show();
                            break;
                        case 11:
                            repEstoqueProducao rel11 = new repEstoqueProducao();
                            rel11.RelEstoqueBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel11.Show();
                            break;
                        case 12:
                            repEstoqueMin rel12 = new repEstoqueMin();
                            rel12.RelEstoqueBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel12.Show();
                            break;
                        case 13:
                            repEstoqueIde rel13 = new repEstoqueIde();
                            rel13.RelEstoqueBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel13.Show();
                            break;
                        case 14:
                            repHistoricoEntSai rel14 = new repHistoricoEntSai();
                            rel14.RelHistEstoqueBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel14.DatasBindingSource.DataSource = new Datas { data_inicial = dtpDataInicial.Value.Date, data_final = dtpDataFinal.Value.Date };
                            rel14.Show();
                            break;
                        case 16:
                            repListaProduto rel16 = new repListaProduto();
                            rel16.RelProdutosBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel16.Show();
                            break;
                        case 17:
                            repListaCategoria rel17 = new repListaCategoria();
                            rel17.CategoriaBindingSource.DataSource = dgvRelatorio.DataSource;
                            rel17.Show();
                            break;
                        default:
                            MessageBox.Show("Selecione um tipo de relatório.", "Tipo de relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
                else
                    MessageBox.Show("É preciso carregar os dados novamente para imprimir o relatório", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO");
            }
        }
        #endregion

        #region Eventos
        private void btProcurar_Click(object sender, EventArgs e)
        {
            procurarVendas((int)cbTipos.SelectedValue, dtpDataInicial.Value.Date, dtpDataFinal.Value.Date, tbProduto.Text, tbCategoria.Text);
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            imprimirRelatorio((int)cbTipos.SelectedValue);
        }
        #endregion

        #region KeyDown
        private void formRelVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void presquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btProcurar_Click(sender, e);
            }
        }
        #endregion

        private void formRelVendas_Load(object sender, EventArgs e)
        {
            cbTipos.DataSource = new BindingSource(ComboBoxTipos(), null);
            cbTipos.DisplayMember = "Value";
            cbTipos.ValueMember = "Key";
            cbTipos.SelectedIndexChanged += cbTipos_SelectedIndexChanged;

            // Cria ToolTip.
            ToolTip toolTip = new ToolTip();

            // Delay para mostrar o tooltip.
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            // Forçar para mostrar mesmo com o form ativo ou nao.
            toolTip.ShowAlways = true;

            // Tooltips.
            toolTip.SetToolTip(btImprimir, "Imprimir");
            toolTip.SetToolTip(cbVendavel, "Vendável?");
        }

        private void mudaRelatorio(int Tipo)
        {
            switch (Tipo)
            {
                case 1:
                case 2:
                    dtpDataInicial.Format = DateTimePickerFormat.Custom;
                    dtpDataFinal.Format = DateTimePickerFormat.Custom;
                    dtpDataInicial.Enabled = true;
                    dtpDataFinal.Enabled = true;
                    tbProduto.Enabled = false;
                    tbCategoria.Enabled = false;
                    tbProduto.Text = "";
                    tbCategoria.Text = "";
                    cbVendavel.Enabled = false;
                    cbVendavel.Checked = false;
                    break;
                case 3:
                    dtpDataInicial.Format = DateTimePickerFormat.Custom;
                    dtpDataFinal.Format = DateTimePickerFormat.Custom;
                    dtpDataInicial.Enabled = true;
                    dtpDataFinal.Enabled = true;
                    tbProduto.Enabled = true;
                    tbCategoria.Enabled = false;
                    tbProduto.Text = "";
                    tbCategoria.Text = "";
                    cbVendavel.Enabled = false;
                    cbVendavel.Checked = false;
                    break;
                case 4:
                    dtpDataInicial.Format = DateTimePickerFormat.Custom;
                    dtpDataFinal.Format = DateTimePickerFormat.Custom;
                    dtpDataInicial.Enabled = true;
                    dtpDataFinal.Enabled = true;
                    tbProduto.Enabled = false;
                    tbCategoria.Enabled = true;
                    tbProduto.Text = "";
                    tbCategoria.Text = "";
                    cbVendavel.Enabled = false;
                    cbVendavel.Checked = false;
                    break;
                case 5:
                case 6:
                    dtpDataInicial.Format = DateTimePickerFormat.Short;
                    dtpDataFinal.Format = DateTimePickerFormat.Short;
                    dtpDataInicial.Enabled = true;
                    dtpDataFinal.Enabled = true;
                    tbProduto.Enabled = false;
                    tbCategoria.Enabled = false;
                    tbProduto.Text = "";
                    tbCategoria.Text = "";
                    cbVendavel.Enabled = false;
                    cbVendavel.Checked = false;
                    break;
                case 7:
                    dtpDataInicial.Format = DateTimePickerFormat.Short;
                    dtpDataFinal.Format = DateTimePickerFormat.Short;
                    dtpDataInicial.Enabled = true;
                    dtpDataFinal.Enabled = true;
                    tbProduto.Enabled = true;
                    tbCategoria.Enabled = false;
                    tbProduto.Text = "";
                    tbCategoria.Text = "";
                    break;
                case 14:
                    dtpDataInicial.Format = DateTimePickerFormat.Short;
                    dtpDataFinal.Format = DateTimePickerFormat.Short;
                    dtpDataInicial.Enabled = true;
                    dtpDataFinal.Enabled = true;
                    tbProduto.Enabled = true;
                    tbCategoria.Enabled = false;
                    tbProduto.Text = "";
                    tbCategoria.Text = "";
                    cbVendavel.Enabled = true;
                    cbVendavel.Checked = true;
                    break;
                case 8:
                    dtpDataInicial.Format = DateTimePickerFormat.Short;
                    dtpDataFinal.Format = DateTimePickerFormat.Short;
                    dtpDataInicial.Enabled = true;
                    dtpDataFinal.Enabled = true;
                    tbProduto.Enabled = false;
                    tbCategoria.Enabled = true;
                    tbProduto.Text = "";
                    tbCategoria.Text = "";
                    cbVendavel.Enabled = false;
                    cbVendavel.Checked = false;
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    dtpDataInicial.Enabled = false;
                    dtpDataFinal.Enabled = false;
                    tbProduto.Enabled = false;
                    tbCategoria.Enabled = true;
                    tbProduto.Text = "";
                    tbCategoria.Text = "";
                    cbVendavel.Enabled = true;
                    cbVendavel.Checked = true;
                    break;
                case 15:
                case 17:
                default:
                    dtpDataInicial.Enabled = false;
                    dtpDataFinal.Enabled = false;
                    tbProduto.Enabled = false;
                    tbCategoria.Enabled = false;
                    tbProduto.Text = "";
                    tbCategoria.Text = "";
                    cbVendavel.Enabled = false;
                    cbVendavel.Checked = false;
                    break;
                case 16:
                    dtpDataInicial.Enabled = false;
                    dtpDataFinal.Enabled = false;
                    tbProduto.Enabled = false;
                    tbCategoria.Enabled = true;
                    tbProduto.Text = "";
                    tbCategoria.Text = "";
                    cbVendavel.Enabled = true;
                    cbVendavel.Checked = true;
                    break;
            }
        }

        private void cbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            mudaRelatorio((int)cbTipos.SelectedValue);
        }

        private void cbVendavel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVendavel.Checked)
                cbVendavel.Font = new Font(cbVendavel.Font.FontFamily, cbVendavel.Font.Size, FontStyle.Bold);
            else
                cbVendavel.Font = new Font(cbVendavel.Font.FontFamily, cbVendavel.Font.Size, FontStyle.Regular);
        }
    }
}
