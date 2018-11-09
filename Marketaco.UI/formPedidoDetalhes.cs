using Marketaco.DAL;
using Marketaco.DOM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Marketaco.UI
{
    public partial class formPedidoDetalhes : Form
    {
        public formPedidoDetalhes()
        {
            InitializeComponent();
        }

        formPedidoImportar pedidoImportar;
        formPedidoPag pedidoPag;
        int index_dgvpedido;
        public int PedidoID { get; set; }

        #region Métodos

        private void adicionarProduto(int id)
        {
            //valor subtotal = preco de venda pq a quantidade padrao está 1 -- desconto padrão = 0
            try
            {
                dalItensPedido dalIPed = new dalItensPedido();
                dalProduto dalProd = new dalProduto();
                Produto prod = dalProd.listaProdutoID(id);
                dalIPed.insereItensPedido(new ItensPedido
                {
                    PedidoID = PedidoID,
                    ProdutoID = prod.ProdutoID,
                    Quantidade = 1,
                    ValorUnitario = prod.PrecoV,
                    Desconto = 0,
                    ValorTotal = prod.PrecoV,
                    Data = DateTime.Now
                });
            }
            catch (Exception)
            {
                MessageBox.Show("É preciso selecionar um produto para adicionar.", "ERRO");
            }

        }

        #region Desconto Diário
        private void descontoDiario()
        {
            dalConfig conf = new dalConfig();
            decimal desc = Convert.ToDecimal(conf.retornaConfig(DateTime.Now.DayOfWeek.ToString()));
            foreach (DataGridViewRow row in dgvPedProduto.Rows)
            {
                string cat = (string)row.Cells[3].Value;

                if (conf.ListaAppConfig("DIA").Any(cat.Contains) && conf.ListaAppConfig("ESP05").Any(cat.Contains))
                {
                    decimal descA = (decimal)row.Cells[6].Value;
                    decimal desconto = ((decimal)row.Cells[5].Value * desc) / 100;
                    desconto += descA;
                    lancaDesconto(row.Index, desconto);
                }
                else if (conf.ListaAppConfig("DIA").Any(cat.Contains) && conf.ListaAppConfig("ESP10").Any(cat.Contains))
                {
                    decimal descA = (decimal)row.Cells[6].Value;
                    decimal desconto = ((decimal)row.Cells[5].Value * desc) / 100;
                    desconto += descA;
                    lancaDesconto(row.Index, desconto);
                }
                else if (conf.ListaAppConfig("DIA").Any(cat.Contains) && !conf.ListaAppConfig("ESP05").Any(cat.Contains))
                {
                    decimal desconto = ((decimal)row.Cells[5].Value * desc) / 100;
                    lancaDesconto(row.Index, desconto);
                }
                else if (conf.ListaAppConfig("DIA").Any(cat.Contains) && !conf.ListaAppConfig("ESP10").Any(cat.Contains))
                {
                    decimal desconto = ((decimal)row.Cells[5].Value * desc) / 100;
                    lancaDesconto(row.Index, desconto);
                }
            }
        }
        #endregion

        #region Desconto Especial
        private void descontoEspecial()
        {
            dalConfig conf = new dalConfig();
            decimal descA = 0, descB = 0;
            foreach (DataGridViewRow row in dgvPedProduto.Rows)
            {
                string cat = (string)row.Cells[3].Value;
                if (conf.ListaAppConfig("ESP05").Any(cat.Contains))
                {
                    int x = dgvPedProduto.Rows.Count - 1 <= row.Index + 5 ? dgvPedProduto.Rows.Count - 1 : row.Index + 5;

                    for (int i = row.Index + 1; i <= x; i++)
                    {
                        descA += (decimal)dgvPedProduto.Rows[i].Cells["Subtotal"].Value;
                    }

                    lancaDesconto(row.Index, descA);
                    descA = 0;
                }
                if (conf.ListaAppConfig("ESP10").Any(cat.Contains))
                {
                    int x = dgvPedProduto.Rows.Count - 1 <= row.Index + 10 ? dgvPedProduto.Rows.Count - 1 : row.Index + 10;

                    for (int i = row.Index + 1; i <= x; i++)
                    {
                        descB += (decimal)dgvPedProduto.Rows[i].Cells["Subtotal"].Value;
                    }

                    lancaDesconto(row.Index, descB);
                    descB = 0;
                }
            }
        }

        private void lancaDesconto(int index, decimal desc)
        {
            try
            {
                dalItensPedido dalIPed = new dalItensPedido();
                dalIPed.atualizaItensPedido(new ItensPedido
                {
                    ItensPedidoID = (int)dgvPedProduto.Rows[index].Cells[0].Value,
                    PedidoID = PedidoID,
                    ProdutoID = (int)dgvPedProduto.Rows[index].Cells[1].Value,
                    Quantidade = (decimal)dgvPedProduto.Rows[index].Cells[4].Value,
                    ValorUnitario = (decimal)dgvPedProduto.Rows[index].Cells[5].Value,
                    Desconto = desc,
                    ValorTotal = (decimal)dgvPedProduto.Rows[index].Cells[5].Value - desc
                });

                populaGridPedProdutos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro interno com o desconto especial", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void selecionaRow()
        {
            dgvPedProduto.Rows[index_dgvpedido].Selected = true;
            dgvPedProduto.CurrentCell = dgvPedProduto[2, index_dgvpedido];
        }

        private void mudaOrdem(int PedidoID, int POS1, int POS2)
        {
            try
            {
                dalItensPedido dalIPed = new dalItensPedido();
                dalIPed.mudaOrdem(PedidoID, POS1, POS2);
                populaGridPedProdutos();
                //-----------------------------------
                descontoEspecial();
                descontoDiario();
                //-----------------------------------
                calculaValorTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void concederDesconto(decimal qnt, decimal desconto)
        {
            try
            {
                if ((decimal)dgvPedProduto.CurrentRow.Cells[5].Value > desconto)
                {
                    dalItensPedido dalIPed = new dalItensPedido();
                    index_dgvpedido = dgvPedProduto.CurrentRow.Index;
                    decimal valor = (decimal)dgvPedProduto.CurrentRow.Cells[5].Value;
                    decimal valortotal = (qnt * (valor - desconto));
                    dalIPed.atualizaItensPedido(new ItensPedido
                    {
                        ItensPedidoID = (int)dgvPedProduto.CurrentRow.Cells[0].Value,
                        PedidoID = PedidoID,
                        ProdutoID = (int)dgvPedProduto.CurrentRow.Cells[1].Value,
                        Quantidade = qnt,
                        ValorUnitario = valor,
                        Desconto = desconto,
                        ValorTotal = valortotal
                    });
                    populaGridPedProdutos();
                    calculaValorTotal();
                }

                else
                {
                    MessageBox.Show("O valor do desconto não pode ser maior ou igual o valor do produto.", "ERRO");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("É preciso selecionar um produto para alterar o valor.", "ERRO");
            }
        }

        private void alterarQuantidade(decimal quantidade, decimal valortotal)
        {
            try
            {
                dalItensPedido dalIPed = new dalItensPedido();
                index_dgvpedido = dgvPedProduto.CurrentRow.Index;
                dalIPed.atualizaItensPedido(new ItensPedido
                {
                    ItensPedidoID = (int)dgvPedProduto.CurrentRow.Cells[0].Value,
                    PedidoID = PedidoID,
                    ProdutoID = (int)dgvPedProduto.CurrentRow.Cells[1].Value,
                    Quantidade = quantidade,
                    Desconto = (decimal)dgvPedProduto.CurrentRow.Cells[6].Value,
                    ValorUnitario = (decimal)dgvPedProduto.CurrentRow.Cells[5].Value,
                    ValorTotal = valortotal - (decimal)dgvPedProduto.CurrentRow.Cells[6].Value * quantidade
                });
                populaGridPedProdutos();
                calculaValorTotal();
            }
            catch (Exception)
            {
                MessageBox.Show("É preciso selecionar um produto para alterar a quantidade.", "ERRO");
            }
        }

        private void deletaPedido()
        {
            dalPedido dalPed = new dalPedido();
            dalPed.deletaPedido(PedidoID);
        }

        private void atualizaPedido()
        {
            dalPedido dalPed = new dalPedido();
            dalPed.atualizaPedido(new Pedido
            {
                PedidoID = PedidoID,
                Nome = tbNome.Text,
                Data = DateTime.Now,
                SubTotal = Convert.ToDecimal(tbSubtotal.Text),
                ValorTotal = Convert.ToDecimal(tbTotal.Text),
                NumPessoas = (int)nupNumPessoa.Value,
                Viagem = cbViagem.Checked,
                TaxaS = cbTaxa.Checked,
                VlTaxaS = Convert.ToDecimal(tbTaxa.Text)
            });
        }

        private void calculaValorTotal()
        {
            decimal subtotal = 0, valorpedido = 0, taxa = 0;

            for (int i = 0; i < dgvPedProduto.Rows.Count; i++)
            {
                subtotal += (decimal)dgvPedProduto.Rows[i].Cells[7].Value;
            }

            taxa = cbTaxa.Checked ? (subtotal * 10) / 100 : 0;
            valorpedido = subtotal + taxa;

            tbSubtotal.Text = string.Format("{0:f}", subtotal);
            tbTaxa.Text = string.Format("{0:f}", taxa);
            tbTotal.Text = string.Format("{0:f}", valorpedido);
            atualizaPedido();
        }

        private void deletaItem()
        {
            try
            {
                dalItensPedido dalIPed = new dalItensPedido();
                dalIPed.deletaItensPedido((int)dgvPedProduto.CurrentRow.Cells[0].Value);
                dalIPed.atualizaOrdem(PedidoID);
            }
            catch (Exception)
            {
                MessageBox.Show("É preciso selecionar um produto para excluir.", "ERRO");
            }

        }
        #endregion

        #region Eventos
        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                adicionarProduto((int)dgvProduto.CurrentRow.Cells[0].Value);
                populaGridPedProdutos();
                //-----------------------------------
                descontoEspecial();
                descontoDiario();
                //-----------------------------------
                calculaValorTotal();

                tbPesquisa.Text = "";
                tbPesquisa.Select();
            }
            catch (Exception)
            {
                MessageBox.Show("É preciso selecionar um produto para adicionar no pedido.","ERRO: Adicionar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //valorPorPessoa(nupNumPessoa.Value);
        }

        private void formPedidoDetalhes_Activated(object sender, EventArgs e)
        {
            dalPedido ped = new dalPedido();
            Pedido pedido = ped.selecionaPedido(PedidoID);
            tbNome.Text = pedido.Nome;
            cbViagem.Checked = pedido.Viagem;
            cbTaxa.Checked = pedido.TaxaS;

            populaGridProduto(tbPesquisa.Text);
            populaGridPedProdutos();
            formataGridPedProdutos();
            calculaValorTotal();
            comboBoxProduto();
        }

        private void btExcluirProduto_Click(object sender, EventArgs e)
        {
            deletaItem();
            populaGridPedProdutos();
            //-----------------------------------
            descontoEspecial();
            descontoDiario();
            //-----------------------------------
            calculaValorTotal();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o pedido?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deletaPedido();
                Close();
            }
        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            populaGridProduto(tbPesquisa.Text);
        }

        private void btQuantidadeMais_Click(object sender, EventArgs e)
        {
            try
            {
                decimal qnt = Convert.ToDecimal(dgvPedProduto.CurrentRow.Cells[4].Value);
                qnt = qnt + 1;
                decimal vltotal = (qnt * (decimal)dgvPedProduto.CurrentRow.Cells[5].Value);
                alterarQuantidade(qnt, vltotal);
                selecionaRow();
            }
            catch (Exception)
            {
                MessageBox.Show("Não há produtos para aumentar a quantidade", "Erro");
            }
        }

        private void btQuantidadeMenos_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dgvPedProduto.CurrentRow.Cells[4].Value) > 1)
                {
                    decimal qnt = Convert.ToDecimal(dgvPedProduto.CurrentRow.Cells[4].Value);
                    qnt = qnt - 1;
                    decimal vltotal = (qnt * (decimal)dgvPedProduto.CurrentRow.Cells[5].Value);
                    alterarQuantidade(qnt, vltotal);
                    selecionaRow();
                }
                else MessageBox.Show("A quantidade ja é 1. Impossível diminuir mais", "Erro");
            }
            catch (Exception)
            {
                MessageBox.Show("Não há produtos para diminuir a quantidade", "Erro");
            }
        }

        private void btPagamento_Click(object sender, EventArgs e)
        {
            receberPedido();
        }

        private void receberPedido()
        {
            if (pedidoPag == null)
            {
                pedidoPag = new formPedidoPag();
                pedidoPag.PedidoID = PedidoID;
                pedidoPag.SubTotal = Convert.ToDecimal(tbSubtotal.Text);
                pedidoPag.ValorTotal = Convert.ToDecimal(tbTotal.Text);
                pedidoPag.Viagem = cbViagem.Checked;
                pedidoPag.TaxaS = cbTaxa.Checked;
                pedidoPag.VlTaxaS = Convert.ToDecimal(tbTaxa.Text);
                Visible = false;

                pedidoPag.MdiParent = ActiveForm;
                pedidoPag.Show();
                pedidoPag.FormClosed += fecharPedidoPag;
            }
        }

        private void PedidoImportar_FormClosed(object sender, FormClosedEventArgs e)
        {
            pedidoImportar = null;
            Visible = true;
        }

        private void fecharPedidoPag(object sender, FormClosedEventArgs e)
        {
            pedidoPag = null;
            Visible = true;
            Close();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            PrintPedido print = new PrintPedido();
            print.montaCupom(PedidoID, Convert.ToDecimal(tbTotal.Text), cbViagem.Checked, cbTaxa.Checked, Convert.ToDecimal(tbTaxa.Text));
            print.Imprimir();
        }

        private void btDesconto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDesconto.Text))
            {
                try
                {
                    decimal qnt = Convert.ToDecimal(dgvPedProduto.CurrentRow.Cells[4].Value);
                    decimal desconto = Convert.ToDecimal(tbDesconto.Text);
                    concederDesconto(qnt, desconto);
                    tbDesconto.Text = "";
                    selecionaRow();
                }
                catch (Exception)
                {
                    MessageBox.Show("É preciso selecionar um produto para conceder desconto.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O valor do desconto não pode ser em branco", "ERRO");
            }
        }

        private void dgvProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btAdicionarProduto_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btImportar_Click(object sender, EventArgs e)
        {
            if (pedidoImportar == null)
            {
                pedidoImportar = new formPedidoImportar();
                pedidoImportar.id_pedido = PedidoID;
                Visible = false;

                pedidoImportar.MdiParent = ActiveForm;
                pedidoImportar.Show();
                pedidoImportar.FormClosed += PedidoImportar_FormClosed;
            }
        }

        private void btCima_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedProduto.Rows.Count != 0
                    && (int)dgvPedProduto.CurrentRow.Cells[9].Value > 1)
                {
                    int i = dgvPedProduto.CurrentRow.Index;
                    index_dgvpedido = i - 1;
                    mudaOrdem(PedidoID, (int)dgvPedProduto.Rows[i].Cells[0].Value, (int)dgvPedProduto.Rows[i - 1].Cells[0].Value);
                    selecionaRow();
                }
                else
                {
                    MessageBox.Show("Impossível subir a posição do produto selecionado. Ele é o primeiro da lista", "ERRO");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("É preciso selecionar um produto para alterar a posição.", "ERRO");
            }
        }

        private void btBaixo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedProduto.Rows.Count != 0
                    && (int)dgvPedProduto.CurrentRow.Cells[9].Value < dgvPedProduto.Rows.Count)
                {
                    int i = dgvPedProduto.CurrentRow.Index;
                    index_dgvpedido = i + 1;
                    mudaOrdem(PedidoID, (int)dgvPedProduto.Rows[i].Cells[0].Value, (int)dgvPedProduto.Rows[i + 1].Cells[0].Value);
                    selecionaRow();
                }
                else
                {
                    MessageBox.Show("Impossível descer a posição do produto selecionado. Ele é o último da lista", "ERRO");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("É preciso selecionar um produto para alterar a posição.", "ERRO");
            }
        }
        #endregion

        #region KeyDown
        private void formPedidoDetalhes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btImprimir_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btPagamento_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                btImportar_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void tbPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btAdicionarProduto.PerformClick();

                e.Handled = true;
                e.SuppressKeyPress = true;

            }

            if (e.KeyCode == Keys.Down)
            {
                dgvProduto.Select();
            }
        }

        private void tbValorNovo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textboxNumeros_Leave(sender, e);
                btDesconto_Click(sender, e);
            }
        }
        #endregion

        #region Textbox Números
        public static void AllowNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1) ||
                (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf('.') > -1) ||
                (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf(',') > -1) ||
                (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textboxNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(sender, e);
        }

        private void textboxNumeros_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as TextBox).Text))
            {
                string muda = (sender as TextBox).Text.Replace('.', ',');
                (sender as TextBox).Text = string.Format("{0:N}", Convert.ToDecimal(muda));
            }
        }
        #endregion

        #region Grid Produtos
        private void populaGridProduto(string nome)
        {
            dalProduto dalProd = new dalProduto();
            dgvProduto.DataSource = dalProd.listaProdutosAddProd(nome);
            dgvProduto.Columns[0].HeaderText = "ID";
            dgvProduto.Columns[0].Visible = false;
            dgvProduto.Columns[1].HeaderText = "Código";
            dgvProduto.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvProduto.Columns[2].HeaderText = "Nome";
            dgvProduto.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduto.Columns[3].HeaderText = "Preço de venda";
            dgvProduto.Columns[3].DefaultCellStyle.Format = "f";
            dgvProduto.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void comboBoxProduto()
        {
            dalProduto dalProd = new dalProduto();
            
            cbProduto.DropDownStyle = ComboBoxStyle.DropDown;
            cbProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbProduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbProduto.DataSource = dalProd.listaProdutosAddProd2();
            cbProduto.DisplayMember = "Nome";
            cbProduto.ValueMember = "ProdutoID";
            cbProduto.SelectedIndex = -1;
            cbProduto.Update();
        }
        #endregion

        #region Grid Pedido Produtos
        public void populaGridPedProdutos()
        {
            dalItensPedido dalIPed = new dalItensPedido();
            dgvPedProduto.DataSource = dalIPed.listaItensPedido(PedidoID);
            setRowNumber(dgvPedProduto);
        }

        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        public void formataGridPedProdutos()
        {
            dgvPedProduto.Columns[0].HeaderText = "ID";
            dgvPedProduto.Columns[0].Visible = false;
            dgvPedProduto.Columns[1].HeaderText = "Código";
            dgvPedProduto.Columns[1].Visible = false;
            dgvPedProduto.Columns[2].HeaderText = "Nome";
            dgvPedProduto.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPedProduto.Columns[3].HeaderText = "Categoria";
            dgvPedProduto.Columns[3].Visible = false;
            dgvPedProduto.Columns[4].HeaderText = "Qtde";
            dgvPedProduto.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPedProduto.Columns[5].HeaderText = "Vlr-Unit";
            dgvPedProduto.Columns[5].DefaultCellStyle.Format = "f";
            dgvPedProduto.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPedProduto.Columns[6].HeaderText = "Desc-Unit";
            dgvPedProduto.Columns[6].DefaultCellStyle.Format = "f";
            dgvPedProduto.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPedProduto.Columns[7].HeaderText = "Subtotal";
            dgvPedProduto.Columns[7].DefaultCellStyle.Format = "f";
            dgvPedProduto.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPedProduto.Columns[8].HeaderText = "Data";
            dgvPedProduto.Columns[8].Visible = false;
            dgvPedProduto.Columns[9].HeaderText = "Ordem";
            dgvPedProduto.Columns[9].Visible = false;
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btAdicionarProduto.PerformClick();
        }

        private void dgvPedProduto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                        btQuantidadeMais.PerformClick();
                    break;
                case MouseButtons.Right:
                    btQuantidadeMenos.PerformClick();
                    break;
            }
        }

        private void dgvPedProduto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    dgvPedProduto.CurrentCell = dgvPedProduto[e.ColumnIndex, e.RowIndex];
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            receberPedido();
        }

        private void cbTaxa_CheckedChanged(object sender, EventArgs e)
        {
            calculaValorTotal();
        }

        private void cbProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                adicionarProduto((int)cbProduto.SelectedValue);
                populaGridPedProdutos();
                calculaValorTotal();

                cbProduto.Text = "";
                cbProduto.Select();
            }
        }
        #endregion
        
        //Fix combobox
        private void comboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            cbo.PreviewKeyDown += new PreviewKeyDownEventHandler(comboBox_PreviewKeyDown);
        }

        private void comboBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            cbo.PreviewKeyDown -= comboBox_PreviewKeyDown;
            if (cbo.DroppedDown) cbo.Focus();
        }

        private void tbNome_Leave(object sender, EventArgs e)
        {
            atualizaPedido();
        }

        private void cbViagem_Click(object sender, EventArgs e)
        {
            atualizaPedido();
        }
    }
}
