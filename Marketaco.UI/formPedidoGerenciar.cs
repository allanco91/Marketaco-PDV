using System;
using System.Drawing;
using System.Windows.Forms;
using Marketaco.DAL;
using Marketaco.DOM.Entities;

namespace Marketaco.UI
{
    public partial class formPedidoGerenciar : Form
    {
        public formPedidoGerenciar()
        {
            InitializeComponent();

            carregaGrid(true);
        }

        formPedidoDetalhes pedidoDetalhes = null;
        formPedidoPag pedidoPagamento = null;
        formPedidoVisualizar visualizarPedido = null;
        formPedidoReativar reativarPedido = null;

        private void botoes_Alterar(object sender, EventArgs e)
        {
            if (rbAberto.Checked)
            {
                rbAberto.Font = new Font(rbAberto.Font.FontFamily, rbAberto.Font.Size, FontStyle.Bold);
                carregaGrid(true);
                adicionarColunas_Aberto();
                dgvPedido.CellClick -= grid_CellClick_Aberto;
                dgvPedido.CellClick += grid_CellClick_Aberto;
            }
            else
            {
                rbAberto.Font = new Font(rbAberto.Font.FontFamily, rbAberto.Font.Size, FontStyle.Regular);
                dgvPedido.CellClick -= grid_CellClick_Aberto;
            }


            if (rbFinalizados.Checked)
            {
                rbFinalizados.Font = new Font(rbFinalizados.Font.FontFamily, rbFinalizados.Font.Size, FontStyle.Bold);
                carregaGrid(false);
                adicionarColunas_Finalizado();
                dgvPedido.CellClick -= grid_CellClick_Finalizado;
                dgvPedido.CellClick += grid_CellClick_Finalizado;
            }
            else
            {
                rbFinalizados.Font = new Font(rbFinalizados.Font.FontFamily, rbFinalizados.Font.Size, FontStyle.Regular);
                dgvPedido.CellClick -= grid_CellClick_Finalizado;
            }
        }

        private void carregaGrid(bool StatusPedido)
        {
            dgvPedido.Columns.Clear();
            dalPedido dalPed = new dalPedido();
            dgvPedido.DataSource = dalPed.listaPedido_StatusPedidoID(StatusPedido);
            formataGrid(StatusPedido);
        }

        private void adicionarColunas_Aberto()
        {
            dgvPedido.Columns.Add(new ColunaVisualizar());
            dgvPedido.Columns.Add(new ColunaEditar());
            dgvPedido.Columns.Add(new ColunaReceber());
            dgvPedido.Columns.Add(new ColunaApagar());

            dgvPedido.Columns[10].HeaderText = "Visualizar";
            dgvPedido.Columns[10].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); //visualizar
            dgvPedido.Columns[11].HeaderText = "Editar";
            dgvPedido.Columns[11].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); //editar
            dgvPedido.Columns[12].HeaderText = "Receber";
            dgvPedido.Columns[12].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); //apagar
            dgvPedido.Columns[13].HeaderText = "Apagar";
            dgvPedido.Columns[13].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); //apagar
        }

        private void adicionarColunas_Finalizado()
        {
            dgvPedido.Columns.Add(new ColunaVisualizar());
            dgvPedido.Columns.Add(new ColunaReativar());

            dgvPedido.Columns[10].HeaderText = "Visualizar";
            dgvPedido.Columns[10].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); //visualizar
            dgvPedido.Columns[11].HeaderText = "Reativar";
            dgvPedido.Columns[11].DefaultCellStyle.Padding = new Padding(5, 5, 5, 5); //reativar
        }

        private void formataGrid(bool Status)
        {
            if (Status)
            {
                dgvPedido.Columns[0].HeaderText = "Número";
                dgvPedido.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[1].HeaderText = "Nome/Mesa";
                dgvPedido.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvPedido.Columns[2].HeaderText = "Valor";
                dgvPedido.Columns[2].DefaultCellStyle.Format = "f";
                dgvPedido.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[3].HeaderText = "Valor Pago";
                dgvPedido.Columns[3].DefaultCellStyle.Format = "f";
                dgvPedido.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[3].Visible = false;
                dgvPedido.Columns[4].HeaderText = "Troco";
                dgvPedido.Columns[4].DefaultCellStyle.Format = "f";
                dgvPedido.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[4].Visible = false;
                dgvPedido.Columns[5].HeaderText = "Viagem";
                dgvPedido.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[5].Visible = false;
                dgvPedido.Columns[6].HeaderText = "Status";
                dgvPedido.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[6].Visible = false;
                dgvPedido.Columns[7].HeaderText = "TaxaS";
                dgvPedido.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[7].Visible = false;
                dgvPedido.Columns[8].HeaderText = "VlTaxaS";
                dgvPedido.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[8].Visible = false;
                dgvPedido.Columns[9].HeaderText = "SubTotal";
                dgvPedido.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[9].Visible = false;
            }
            else
            {
                dgvPedido.Columns[0].HeaderText = "Número";
                dgvPedido.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[1].HeaderText = "Nome/Mesa";
                dgvPedido.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvPedido.Columns[2].HeaderText = "Valor";
                dgvPedido.Columns[2].DefaultCellStyle.Format = "f";
                dgvPedido.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[3].HeaderText = "Valor Pago";
                dgvPedido.Columns[3].DefaultCellStyle.Format = "f";
                dgvPedido.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[3].Visible = false;
                dgvPedido.Columns[4].HeaderText = "Troco";
                dgvPedido.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[4].DefaultCellStyle.Format = "f";
                dgvPedido.Columns[4].Visible = false;
                dgvPedido.Columns[5].HeaderText = "Viagem";
                dgvPedido.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[5].Visible = false;
                dgvPedido.Columns[6].HeaderText = "Status";
                dgvPedido.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[6].Visible = false;
                dgvPedido.Columns[7].HeaderText = "TaxaS";
                dgvPedido.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[7].Visible = false;
                dgvPedido.Columns[8].HeaderText = "VlTaxaS";
                dgvPedido.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[8].Visible = false;
                dgvPedido.Columns[9].HeaderText = "SubTotal";
                dgvPedido.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvPedido.Columns[9].Visible = false;
            }
        }

        private void formPedidoGerenciar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        //Colunas com imagens do grid
        public class ColunaVisualizar : DataGridViewImageColumn
        {
            public ColunaVisualizar()
            {
                Image = Image.FromFile(@"img\icons8-Mostrar propriedade.-20.png");
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                CellTemplate.ToolTipText = "Visualizar";
            }
        }

        public class ColunaApagar : DataGridViewImageColumn
        {
            public ColunaApagar()
            {
                Image = Image.FromFile(@"img\icons8-Apagar-20.png");
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                CellTemplate.ToolTipText = "Apagar";
            }
        }

        public class ColunaEditar : DataGridViewImageColumn
        {
            public ColunaEditar()
            {
                Image = Image.FromFile(@"img\icons8-editar-propriedade-20.png");
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                CellTemplate.ToolTipText = "Editar";
            }
        }

        public class ColunaReceber : DataGridViewImageColumn
        {
            public ColunaReceber()
            {
                Image = Image.FromFile(@"img\icons8-Receber dinheiro-20.png");
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                CellTemplate.ToolTipText = "Receber";
            }
        }

        public class ColunaReativar : DataGridViewImageColumn
        {
            public ColunaReativar()
            {
                Image = Image.FromFile(@"img\icons8-Ok-20.png");
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                CellTemplate.ToolTipText = "Reativar";
            }
        }

        //Eventos do grid dependendo da visualização
        private void grid_CellClick_Aberto(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10) //coluna visualizar pedido
            {
                abreCupom();
            }

            if (e.ColumnIndex == 11) //coluna editar pedido
            {
                editarPedido();
                botoes_Alterar(sender, e);
            }

            if (e.ColumnIndex == 12) //coluna receber pedido
            {
                receberPedido();
            }

            if (e.ColumnIndex == 13) //coluna apagar pedido
            {
                excluirPedido((int)dgvPedido.CurrentRow.Cells[0].Value);
                botoes_Alterar(sender, e);
            }
        }

        private void grid_CellClick_Finalizado(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10) //coluna visualizar pedido
            {
                abreCupom();
            }

            if (e.ColumnIndex == 11) //coluna reativar pedido
            {
                reativaPedido();
                botoes_Alterar(sender, e);
            }
        }

        private void fecharVisualizarPedido(object sender, EventArgs e)
        {
            visualizarPedido = null;
        }

        private void abreCupom()
        {
            if (visualizarPedido == null)
            {
                PrintPedido pp = new PrintPedido();
                pp.montaCupom((int)dgvPedido.CurrentRow.Cells[0].Value, (decimal)dgvPedido.CurrentRow.Cells[2].Value, (bool)dgvPedido.CurrentRow.Cells[5].Value, (bool)dgvPedido.CurrentRow.Cells[7].Value, (decimal)dgvPedido.CurrentRow.Cells[8].Value);

                visualizarPedido = new formPedidoVisualizar();
                visualizarPedido.PedidoID = (int)dgvPedido.CurrentRow.Cells[0].Value;
                visualizarPedido.valorTotal = (decimal)dgvPedido.CurrentRow.Cells[2].Value;
                visualizarPedido.viagem = (bool)dgvPedido.CurrentRow.Cells[5].Value;
                visualizarPedido.taxa = (bool)dgvPedido.CurrentRow.Cells[7].Value;
                visualizarPedido.vltaxa = (decimal)dgvPedido.CurrentRow.Cells[8].Value;
                visualizarPedido.MdiParent = ActiveForm;
                visualizarPedido.rtbPedido.Text = pp.Visualiza().Text;
                visualizarPedido.FormClosed += fecharVisualizarPedido;
                visualizarPedido.Show();
            }
        }

        private void mudaStatusPedido(int PedidoID, bool StatusPedido)
        {
            dalPedido ped = new dalPedido();
            ped.atualizaStatus(PedidoID, StatusPedido);
        }

        private void excluirPedido(int PedidoID)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o pedido?\n Pedido nº: " + PedidoID, "Excluir pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                dalPedido ped = new dalPedido();
                ped.deletaPedido(PedidoID);
                rbAberto.PerformClick();
                dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Excluiu o pedido nº " + PedidoID);
            }
        }

        private void novoPedido()
        {
            dalPedido dalPed = new dalPedido();
            dalConfig conf = new dalConfig();
            bool taxa = conf.retornaConfig("SERV") == "S" ? true : false;
            dalPed.inserePedido(new Pedido { Nome = tbNomePedido.Text, Data = DateTime.Now, SubTotal = 0, ValorTotal = 0, NumPessoas = 1, Viagem = false, Status = true, Troco = 0, ValorPago = 0, TaxaS = taxa, VlTaxaS = 0 });
            dalLogs.addLog(dalOperador.retornaOperador(Principal.OperadorID).Nome, "Adicionou o pedido nº: " + dalPed.selecionaUltimoPedido().PedidoID);
            tbNomePedido.Text = "";
            pedidoDetalhes = new formPedidoDetalhes();
            pedidoDetalhes.PedidoID = dalPed.selecionaUltimoPedido().PedidoID;

            pedidoDetalhes.MdiParent = ActiveForm;
            pedidoDetalhes.Show();
            pedidoDetalhes.FormClosed += PedidoDetalhes_FormClosed;
        }

        private void editarPedido()
        {
            if (pedidoDetalhes == null)
            {
                pedidoDetalhes = new formPedidoDetalhes();
                pedidoDetalhes.PedidoID = (int)dgvPedido.CurrentRow.Cells[0].Value;

                pedidoDetalhes.MdiParent = ActiveForm;
                pedidoDetalhes.Show();
                pedidoDetalhes.FormClosed += PedidoDetalhes_FormClosed;
            }
            else
            {
                pedidoDetalhes.Activate();
            }
        }

        private void receberPedido()
        {
            if (pedidoPagamento == null)
            {
                pedidoPagamento = new formPedidoPag();
                pedidoPagamento.PedidoID = (int)dgvPedido.CurrentRow.Cells[0].Value;
                pedidoPagamento.ValorTotal = (decimal)dgvPedido.CurrentRow.Cells[2].Value;
                pedidoPagamento.Viagem = (bool)dgvPedido.CurrentRow.Cells[5].Value;
                pedidoPagamento.TaxaS = (bool)dgvPedido.CurrentRow.Cells[7].Value;
                pedidoPagamento.VlTaxaS = (decimal)dgvPedido.CurrentRow.Cells[8].Value;
                pedidoPagamento.SubTotal = (decimal)dgvPedido.CurrentRow.Cells[9].Value;

                pedidoPagamento.MdiParent = ActiveForm;
                pedidoPagamento.Show();
                pedidoPagamento.FormClosed += fecharPedidoPagamento;
            }
        }

        private void reativaPedido()
        {
            reativarPedido = new formPedidoReativar();
            reativarPedido.PedidoID = (int)dgvPedido.CurrentRow.Cells[0].Value;

            reativarPedido.MdiParent = ActiveForm;
            reativarPedido.Show();
            reativarPedido.FormClosed += fecharReativarPedido;
        }

        private void PedidoDetalhes_FormClosed(object sender, EventArgs e)
        {
            pedidoDetalhes = null;
            botoes_Alterar(sender, e);
            Principal.atualizaAvisoS();
        }

        private void fecharReativarPedido(object sender, EventArgs e)
        {
            reativarPedido = null;
            botoes_Alterar(sender, e);
        }

        private void fecharPedidoPagamento(object sender, EventArgs e)
        {
            pedidoPagamento = null;
            botoes_Alterar(sender, e);
        }

        private void btNovoPedido_Click(object sender, EventArgs e)
        {
            novoPedido();
        }

        private void tbNomePedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btNovoPedido.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void formPedidoGerenciar_Activated(object sender, EventArgs e)
        {
            botoes_Alterar(sender, e);
        }
    }
}
