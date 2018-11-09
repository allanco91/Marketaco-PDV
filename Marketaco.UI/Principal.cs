using System;
using System.Windows.Forms;
using Marketaco.DAL;
using System.Drawing;

namespace Marketaco.UI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            _instance = this;

            SetStyle(
ControlStyles.AllPaintingInWmPaint |
ControlStyles.DoubleBuffer,
true);
        }
        public static int OperadorID { get; set; }
        public static Principal _instance { get; private set; }

        private formCategoria categoria = null;
        private formProduto produto = null;
        private formOperador operador = null;
        private formCaixa caixa = null;
        private formCaixaHistorico caixaHistorico = null;
        private formRelatorio relatorio = null;
        private formSobre sobre = null;
        private formPedidoGerenciar gerenciarPedido = null;
        private formEstoque estoque = null;
        private formEmpresa empresa = null;
        private formLogs logs = null;
        private formConfig config = null;
        private formPDV pdv = null;

        public static void atualizaAvisoS()
        {
            _instance.atualizaAviso();
        }

        #region Abrir Forms
        private void btPDV_Click(object sender, EventArgs e)
        {
            if (pdv == null)
            {
                pdv = new formPDV();
                pdv.Show();
                pdv.FormClosed += new FormClosedEventHandler(fecharPDV);
            }
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            if (config == null)
            {
                config = new formConfig();
                config.MdiParent = this;
                config.Show();
                config.FormClosed += new FormClosedEventHandler(fecharConfig);
            }
        }

        private void btLogs_Click(object sender, EventArgs e)
        {
            if (logs == null)
            {
                logs = new formLogs();
                logs.MdiParent = this;
                logs.Show();
                logs.FormClosed += new FormClosedEventHandler(fecharLogs);
            }
        }

        private void btEmpresa_Click(object sender, EventArgs e)
        {
            if (empresa == null)
            {
                empresa = new formEmpresa();
                empresa.MdiParent = this;
                empresa.Show();
                empresa.FormClosed += new FormClosedEventHandler(fecharEmpresa);
            }
        }

        private void btCaixa_Click(object sender, EventArgs e)
        {
            if (caixa == null)
            {
                caixa = new formCaixa();
                caixa.MdiParent = this;
                caixa.Show();
                caixa.FormClosed += new FormClosedEventHandler(fecharCaixa);
            }
        }

        private void btProduto_Click(object sender, EventArgs e)
        {
            if (produto == null)
            {
                produto = new formProduto();
                produto.MdiParent = this;
                produto.Show();
                produto.FormClosed += new FormClosedEventHandler(fecharProduto);
            }
        }

        private void btOperadores_Click(object sender, EventArgs e)
        {
            if (operador == null)
            {
                operador = new formOperador();
                operador.MdiParent = this;
                operador.Show();
                operador.FormClosed += new FormClosedEventHandler(fecharOperador);
            }

        }

        private void btPedidoBalcao_Click(object sender, EventArgs e)
        {
            if (dalCaixa.verificaCaixa().Status)
            {

            }
            else
            {
                MessageBox.Show("É preciso abrir o caixa antes de fazer pedidos.", "Novo pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btHistoricoCaixa_Click(object sender, EventArgs e)
        {
            if (caixaHistorico == null)
            {
                caixaHistorico = new formCaixaHistorico();
                caixaHistorico.MdiParent = this;
                caixaHistorico.Show();
                caixaHistorico.FormClosed += new FormClosedEventHandler(fecharCaixaHistorico);
            }
        }

        private void btSobre_Click(object sender, EventArgs e)
        {
            if (sobre == null)
            {
                sobre = new formSobre();
                sobre.MdiParent = this;
                sobre.Show();
                sobre.FormClosed += new FormClosedEventHandler(fecharSobre);
            }
        }

        private void btCategoria_Click(object sender, EventArgs e)
        {
            if (categoria == null)
            {
                categoria = new formCategoria();
                categoria.MdiParent = this;
                categoria.Show();
                categoria.FormClosed += new FormClosedEventHandler(fecharCategoria);
            }
        }

        private void btGerenciarPedido_Click(object sender, EventArgs e)
        {
            if (dalCaixa.verificaCaixa().Status)
            {
                if (gerenciarPedido == null)
                {
                    dalConfig conf = new dalConfig();

                    gerenciarPedido = new formPedidoGerenciar();
                    gerenciarPedido.MdiParent = this;
                    gerenciarPedido.Show();
                    gerenciarPedido.FormClosed += new FormClosedEventHandler(fecharGerenciarPedido);
                }
                else
                    gerenciarPedido.Activate();
            }
            else
            {
                MessageBox.Show("É preciso abrir o caixa antes de fazer pedidos.", "Novo pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btEstoque_Click(object sender, EventArgs e)
        {
            if (estoque == null)
            {
                estoque = new formEstoque();
                estoque.MdiParent = this;
                estoque.Show();
                estoque.FormClosed += new FormClosedEventHandler(fecharEstoque);
            }
        }

        private void btRelTotalPorMes_Click(object sender, EventArgs e)
        {
            if (relatorio == null)
            {
                relatorio = new formRelatorio();
                relatorio.TRel = 1;
                relatorio.MdiParent = this;
                relatorio.Show();
                relatorio.FormClosed += new FormClosedEventHandler(fecharRelVendas);
            }
        }

        private void btRelData_Click(object sender, EventArgs e)
        {
            if (relatorio == null)
            {
                relatorio = new formRelatorio();
                relatorio.TRel = 2;
                relatorio.MdiParent = this;
                relatorio.Show();
                relatorio.FormClosed += new FormClosedEventHandler(fecharRelVendas);
            }
        }

        private void btRelEstoque_Click(object sender, EventArgs e)
        {
            if (relatorio == null)
            {
                relatorio = new formRelatorio();
                relatorio.TRel = 3;
                relatorio.MdiParent = this;
                relatorio.Show();
                relatorio.FormClosed += new FormClosedEventHandler(fecharRelVendas);
            }
        }

        private void btRelLista_Click(object sender, EventArgs e)
        {
            if (relatorio == null)
            {
                relatorio = new formRelatorio();
                relatorio.TRel = 4;
                relatorio.MdiParent = this;
                relatorio.Show();
                relatorio.FormClosed += new FormClosedEventHandler(fecharRelVendas);
            }
        }
        #endregion

        #region Setar Null
        private void fecharPDV(object sender, EventArgs e)
        {
            pdv = null;
        }

        private void fecharConfig(object sender, EventArgs e)
        {
            config = null;
        }

        private void fecharLogs(object sender, EventArgs e)
        {
            logs = null;
        }

        private void fecharEmpresa(object sender, EventArgs e)
        {
            empresa = null;
            atualizaEmpresa();
        }

        private void fecharEstoque(object sender, EventArgs e)
        {
            estoque = null;
            atualizaAviso();
        }

        private void fecharGerenciarPedido(object sender, EventArgs e)
        {
            gerenciarPedido = null;
        }

        private void fecharCategoria(object sender, EventArgs e)
        {
            categoria = null;
        }

        private void fecharProduto(object sender, EventArgs e)
        {
            produto = null;
            atualizaAviso();
        }

        private void fecharOperador(object sender, EventArgs e)
        {
            operador = null;
        }

        private void fecharPedido(object sender, EventArgs e)
        {
            atualizaAviso();
        }

        private void fecharCaixa(object sender, EventArgs e)
        {
            caixa = null;
        }

        private void fecharCaixaHistorico(object sender, EventArgs e)
        {
            caixaHistorico = null;
        }

        private void fecharRelVendas(object sender, EventArgs e)
        {
            relatorio = null;
        }

        private void fecharSobre(object sender, EventArgs e)
        {
            sobre = null;
        }
        #endregion

        private void btSomaVendas_Click(object sender, EventArgs e)
        {
            dalPedido dalped = new dalPedido();
            decimal VendasDia = dalped.pedidosDia();
            MessageBox.Show(string.Format("Total de vendas do dia: R$ {0:N}.", VendasDia), "Vendas do dia");
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls)
                if (ctrl is MdiClient)
                    ctrl.BackColor = Color.SlateGray;

            atualizaAviso();
            atualizaEmpresa();
            atualizaOperador();
            statusLB1.Text = "Marketaco " + DateTime.Now.Year;
        }

        private void atualizaEmpresa()
        {
            dalEmpresa emp = new dalEmpresa();
            statusEmpresa.Text = "Empresa: " + emp.retornaEmpresa().RazaoSocial;
            
        }

        private void atualizaOperador()
        {
            statusOperador.Text = "Operador: " + dalOperador.retornaOperador(OperadorID).Nome;
            if (!dalOperador.retornaOperador(OperadorID).Adm)
            {
                tabGeral.Controls.Remove(tabConfig);
                tabGeral.Controls.Remove(tabRelatorio);
                btCaixa.Visible = false;
                btHistoricoCaixa.Visible = false;
            }     
        }

        private void atualizaAviso()
        {
            PrintPedido vis = new PrintPedido();
            if (vis.montaEstoqueMin() > 0)
                btAviso.BackColor = Color.Orange;
            else
                btAviso.BackColor = Color.SlateGray;

            rtbAviso.Text = vis.Visualiza().Text;
        }

        private void imprimirAviso()
        {
            PrintPedido vis = new PrintPedido();
            vis.montaEstoqueMin();
            vis.Imprimir();
        }

        private void btAviso_Click(object sender, EventArgs e)
        {
            if (panelAviso.Width == 25)
            {
                panelAviso.Width = 340;
                btAviso.Image = Image.FromFile(@"img\icons8-close-pane-24.png");
            }
            else
            {
                panelAviso.Width = 25;
                btAviso.Image = Image.FromFile(@"img\icons8-open-pane-24.png");
            }
        }

        private void btAtualizarAviso_Click(object sender, EventArgs e)
        {
            atualizaAviso();
        }

        private void btImprimirAviso_Click(object sender, EventArgs e)
        {
            imprimirAviso();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btTrocarOperador_Click(object sender, EventArgs e)
        {
            FormClosed -= Principal_FormClosed;
            Close();
        }

        private void btSaldoDia_Click(object sender, EventArgs e)
        {
            dalPedido dalped = new dalPedido();
            decimal VendasDia = dalped.pedidosDiaSemIngresso();
            MessageBox.Show(string.Format("Total de vendas do dia: R$ {0:N}.", VendasDia), "Vendas do dia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
