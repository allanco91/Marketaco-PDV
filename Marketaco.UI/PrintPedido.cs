using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Marketaco.DAL;

namespace Marketaco.UI
{
    public class PrintPedido : IDisposable
    {
        RichTextBox txtFormat;
        string itens;

        public void montaCupom(int id, decimal valorTotal, bool viagem, bool taxas, decimal vltaxa)
        {
            Cupom(id, valorTotal, viagem, taxas, vltaxa);
        }

        public int montaEstoqueMin()
        {
            return avisoEstoque();
        }

        #region Cupom Capri Café
        private void CupomCAPRI(int PedidoID, decimal valorTotal, bool viagem, bool taxas, decimal vltaxa)
        {
            //41 Caracteres - Fonte: Lucida Console - Tamanho: 8
            int padding = 41;
            dalPedido dalPed = new dalPedido();
            dalItensPedido dalIPed = new dalItensPedido();
            dalEmpresa emp = new dalEmpresa();
            dalPedidoPagamento dalPP = new dalPedidoPagamento();
            txtFormat = new RichTextBox();
            txtFormat.Font = new Font("Lucida Console", 10);
            var ItensCupom = dalIPed.listaItensCupom(PedidoID);
            var PedidoCupom = dalPed.PedidoImprimir(PedidoID);
            decimal Pagamento = dalPP.PagamentoPedido(PedidoID);

            string linha = "-----------------------------------------";
            string cabecalho = string.Format("{0}", emp.retornaEmpresa().NomeFantasia);
            string cabecalho2 = string.Format("{0}, {1}", emp.retornaEmpresa().Endereco, emp.retornaEmpresa().Numero);
            string cabecalho3 = string.Format("{0}", emp.retornaEmpresa().Telefone1);
            string info = string.Format("Pedido   No:   {0}", PedidoID);
            string infoD = string.Format("{0:dd/MM/yy   HH:mm}", PedidoCupom.Data);
            string infoN = string.Format("Nome/Mesa:   {0}", PedidoCupom.Nome);
            string cab_itens = string.Format("{0,-41}\n{1,10}{2,10}{3,10}{4,11}", "PRODUTO", "QTD", "V.UNI", "DESC", "TOTAL");


            txtFormat.Text = cabecalho.PadBoth(padding) + "";
            txtFormat.AppendText("\r\n");
            txtFormat.AppendText(cabecalho2.PadBoth(padding));
            txtFormat.AppendText("\r\n");
            txtFormat.AppendText(cabecalho3.PadBoth(padding));
            txtFormat.AppendText("\r\n");
            txtFormat.AppendText(linha);
            txtFormat.AppendText("\r\n");
            txtFormat.AppendText(info + infoD.PadLeft(padding - info.Length));
            txtFormat.AppendText("\r\n");
            txtFormat.AppendText(linha);
            txtFormat.AppendText("\r\n");
            txtFormat.AppendText(infoN.PadBoth(padding));
            txtFormat.AppendText("\r\n");
            txtFormat.AppendText(linha);
            txtFormat.AppendText("\r\n");
            txtFormat.AppendText(cab_itens);
            txtFormat.AppendText("\r\n");

            foreach (var item in ItensCupom)
            {
                itens = string.Format("{0,-41}\n{1,10:f}{2,10:f}{3,10}{4,11:f}", item.produto, "x" + item.quantidade, item.valorUnit, item.desconto == 0 ? "" : string.Format("-{0:f}", item.desconto), item.valorTotal);
                txtFormat.AppendText(itens);
                txtFormat.AppendText("\r\n");
            }

            txtFormat.AppendText(linha);
            txtFormat.AppendText("\r\n");
            if (PedidoCupom.TaxaS)
            {
                txtFormat.AppendText(string.Format("{0,-31}{1,10:f}", "SUBTOTAL DO PEDIDO..........: ", valorTotal - vltaxa));
                txtFormat.AppendText("\r\n");
                txtFormat.AppendText(string.Format("{0,-31}{1,10:f}", "SERVICO (OPCIONAL)..........: ", vltaxa));
                txtFormat.AppendText("\r\n");
                txtFormat.AppendText("\r\n");
                txtFormat.AppendText(string.Format("{0,-31}{1,10:f}", "TOTAL DO PEDIDO+SERVICO.....: ", valorTotal));
                txtFormat.AppendText("\r\n");
                txtFormat.AppendText(string.Format("{0,-31}{1,10:f}", "TOTAL DO PEDIDO.............: ", valorTotal - vltaxa));
                if (Pagamento > 0)
                {
                    txtFormat.AppendText("\r\n");
                    txtFormat.AppendText("\r\n");
                    txtFormat.AppendText(string.Format("{0,-31}{1,10:f}", "VALOR PAGO..................: ", Pagamento));
                    txtFormat.AppendText("\r\n");
                    txtFormat.AppendText("\r\n");
                    txtFormat.AppendText(string.Format("{0,-31}{1,10:f}", "SALDO A PAGAR+SERVICO.......: ", (valorTotal - Pagamento) < 0 ? 0 : (valorTotal - Pagamento)));
                    txtFormat.AppendText("\r\n");
                    txtFormat.AppendText(string.Format("{0,-31}{1,10:f}", "SALDO A PAGAR...............: ", ((valorTotal - vltaxa) - Pagamento) < 0 ? 0 : (valorTotal - vltaxa) - Pagamento));
                }
            }
            else
            {
                txtFormat.AppendText(string.Format("{0,-31}{1,10:f}", "SUBTOTAL DO PEDIDO..........: ", valorTotal - vltaxa));
                txtFormat.AppendText("\r\n");
                txtFormat.AppendText("\r\n");
                txtFormat.AppendText(string.Format("{0,-31}{1,10:f}", "TOTAL DO PEDIDO.............: ", valorTotal - vltaxa));
                txtFormat.AppendText("\r\n");
                txtFormat.AppendText("\r\n");
                txtFormat.AppendText(string.Format("{0,-31}{1,10:f}", "VALOR PAGO..................: ", Pagamento));
                txtFormat.AppendText("\r\n");
                txtFormat.AppendText("\r\n");
                txtFormat.AppendText(string.Format("{0,-31}{1,10:f}", "SALDO A PAGAR...............: ", ((valorTotal - vltaxa) - Pagamento) < 0 ? 0 : (valorTotal - vltaxa) - Pagamento));
            }
            txtFormat.AppendText("\r\n");
            txtFormat.AppendText("\r\n");
            if (!PedidoCupom.Status)
            {
                txtFormat.AppendText("\r\n");
                if (PedidoCupom.Troco != 0)
                {
                    txtFormat.AppendText(string.Format("{0,-31}{1,10:f}", "TROCO.......................: ", PedidoCupom.Troco));
                    txtFormat.AppendText("\r\n");
                }
                else
                {
                    txtFormat.AppendText("\r\n");
                }
                txtFormat.AppendText(string.Format("{0,-41}\n{1,-41}", "FORMA DE PAGAMENTO:", PedidoCupom.FormaPagamento));
                txtFormat.AppendText("\r\n");
            }

            if (viagem)
            {
                string s = "PARA VIAGEM!";
                txtFormat.AppendText("\r\n");
                txtFormat.AppendText(s.PadBoth(padding));
                txtFormat.AppendText("\r\n");
            }
            else
            {
                txtFormat.AppendText("\r\n");
            }

            txtFormat.AppendText(linha);
            txtFormat.AppendText("\r\n");
            txtFormat.AppendText("Marketaco".PadBoth(padding));
        }
        #endregion

        #region Cupom King Açaí
        private void Cupom(int PedidoID, decimal valorTotal, bool viagem, bool taxas, decimal vltaxa)
        {

            //41 Caracteres - Fonte: Lucida Console - Tamanho: 8
            int padding = 41;
            dalPedido dalPed = new dalPedido();
            dalItensPedido dalIPed = new dalItensPedido();
            dalEmpresa emp = new dalEmpresa();
            dalPedidoPagamento dalPP = new dalPedidoPagamento();
            dalConfig conf = new dalConfig();
            txtFormat = new RichTextBox();
            txtFormat.Font = new Font("Lucida Console", 8);
            var ItensCupom = dalIPed.listaItensCupom(PedidoID);
            var PedidoCupom = dalPed.PedidoImprimir(PedidoID);
            decimal Pagamento = dalPP.PagamentoPedido(PedidoID);

            string linha = "-----------------------------------------";
            string cabecalho = string.Format("{0}", emp.retornaEmpresa().NomeFantasia);
            string cabecalho2 = string.Format("{0}, {1}", emp.retornaEmpresa().Endereco, emp.retornaEmpresa().Numero);
            string cabecalho3 = string.Format("{0}", emp.retornaEmpresa().Telefone1);
            string info = string.Format("Pedido No: {0}", PedidoID);
            string infoD = string.Format("{0:dd/MM/yy HH:mm}", PedidoCupom.Data);
            string infoN = string.Format("Nome/Mesa: {0}", PedidoCupom.Nome);
            string cab_itens = string.Format("{0,-22}{1,5}{2,7}{3,7}", "ITEM", "QTD", "V.UNI", "TOTAL");

            txtFormat.Text = cabecalho.PadBoth(padding) + "\r\n";
            txtFormat.AppendText(cabecalho2.PadBoth(padding) + "\r\n");
            txtFormat.AppendText(cabecalho3.PadBoth(padding) + "\r\n");
            txtFormat.AppendText(linha + "\r\n");
            txtFormat.AppendText(info + infoD.PadLeft(padding - info.Length) + "\r\n");
            txtFormat.AppendText(linha + "\r\n");
            txtFormat.AppendText(cab_itens + "\r\n");



            //Itens
            foreach (var item in ItensCupom)
            {
                if (conf.ListaAppConfig("pula").Any(item.categoria.Contains))
                {
                    int inicio_selecao = txtFormat.Text.Length + 23;
                    int inicio_seleca2 = txtFormat.Text.Length;
                    itens = string.Format("{0,-22}{1,5:N}{2,7:N}{3,7:N}", item.produto, item.quantidade, item.valorUnit, item.valorTotal);
                    txtFormat.AppendText("\r\n" + itens + "\r\n");

                    txtFormat.Select(inicio_seleca2, padding);
                    txtFormat.SelectionFont = new Font(txtFormat.Font, FontStyle.Bold);

                    if (item.quantidade > 1)
                    {
                        txtFormat.Select(inicio_selecao, item.quantidade.ToString().Length + 4);
                        txtFormat.SelectionFont = new Font(txtFormat.Font, FontStyle.Bold | FontStyle.Underline);
                    }
                }
                else
                {
                    int inicio_selecao = txtFormat.Text.Length + 23;
                    itens = string.Format("{0,-22}{1,5:N}{2,7:N}{3,7:N}", item.produto, item.quantidade, item.valorUnit, item.valorTotal);
                    txtFormat.AppendText(itens + "\r\n");
                    if (item.quantidade > 1)
                    {
                        txtFormat.Select(inicio_selecao, item.quantidade.ToString().Length + 3);
                        txtFormat.SelectionFont = new Font(txtFormat.Font, FontStyle.Bold | FontStyle.Underline);
                    }
                }
            }

            txtFormat.AppendText(linha + "\r\n");
            if (!PedidoCupom.Status)
            {
                if (PedidoCupom.TaxaS)
                    txtFormat.AppendText(string.Format("{0,-34}{1,7:f}", "SERVIÇO (OPCIONAL)..............: ", vltaxa) + "\r\n");

                txtFormat.AppendText(string.Format("TOTAL DO PEDIDO.................: {0,7:f}".PadBoth(padding), PedidoCupom.ValorTotal) + "\r\n");
                txtFormat.AppendText(string.Format("VALOR PAGO......................: {0,7:f}".PadBoth(padding), PedidoCupom.VlPago) + "\r\n");
                txtFormat.AppendText(string.Format("TROCO...........................: {0,7:f}", PedidoCupom.Troco).PadBoth(padding) + "\r\n\r\n");
                txtFormat.AppendText(string.Format("{0,-41}\r\n{1,-41}", "FORMA DE PAGAMENTO:" , PedidoCupom.FormaPagamento));
                txtFormat.AppendText("\r\n");
            }

            if (!string.IsNullOrEmpty(PedidoCupom.Nome))
            {
                int padleft = ((41 - infoN.Length) / 2) + 6;
                int length = txtFormat.Text.Length + padleft;
                txtFormat.AppendText("\r\n" + infoN.PadBoth(padding) + "\r\n");

                txtFormat.Select(length, PedidoCupom.Nome.Length);
                txtFormat.SelectionFont = new Font(txtFormat.Font, FontStyle.Bold);
            }

            if (viagem)
            {
                string s = "PARA VIAGEM!";
                int padleft2 = ((41 - s.Length) / 2);
                int length2 = txtFormat.Text.Length + padleft2;
                txtFormat.AppendText(s.PadBoth(padding) + "\r\n\r\n");

                txtFormat.Select(length2, s.Length);
                txtFormat.SelectionFont = new Font(txtFormat.Font, FontStyle.Bold);
            }
            else
            {
                txtFormat.AppendText("\r\n");
            }

            txtFormat.AppendText(linha + "\r\n");
            txtFormat.AppendText("Marketaco".PadBoth(padding));
        }
        #endregion

        private int avisoEstoque()
        {
            //36 Caracteres - Fonte: Lucida Console - Tamanho: 10
            dalEstoque Est = new dalEstoque();
            txtFormat = new RichTextBox();
            txtFormat.Font = new Font("Lucida Console", 10);
            var ItensEstoqueMin = Est.verificaEstoqueMin();

            string linha = "------------------------------------";
            string cabecalho = "Produtos com estoque mínimo";
            string data = string.Format("Atualizado em: {0:dd/MM/yy HH:mm:ss}", DateTime.Now);
            string cab_itens = string.Format("{0,-36}\n{1,18:f}{2,18:f}", "PRODUTO", "QTD IDEAL", "QTD ATUAL");


            txtFormat.Text = linha + "\r\n";
            txtFormat.AppendText(cabecalho.PadBoth(36) + "\r\n");
            txtFormat.AppendText(linha + "\r\n");
            txtFormat.AppendText(data.PadBoth(36) + "\r\n");
            txtFormat.AppendText(linha + "\r\n\r\n");
            txtFormat.AppendText(cab_itens + "\r\n");
            txtFormat.AppendText(linha + "\r\n");

            foreach (var p in ItensEstoqueMin)
            {
                itens = string.Format("{0,-36}\n{1,18:f}{2,18:f}", p.Produto, p.QtdM, p.QtdA);
                txtFormat.AppendText(itens + "\r\n");
            }

            return ItensEstoqueMin.Count();
        }

        private void documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 0;
            int y = 0;
            int charpos = 0;

            while (charpos < txtFormat.Text.Length)
            {
                if (txtFormat.Text[charpos] == '\n')
                {
                    charpos++;
                    y += 11;
                    x = 0;
                }
                else if (txtFormat.Text[charpos] == '\r')
                {
                    charpos++;
                }
                else
                {
                    txtFormat.Select(charpos, 1);
                    e.Graphics.DrawString(txtFormat.SelectedText, txtFormat.SelectionFont, new SolidBrush(txtFormat.SelectionColor), new PointF(x, y));
                    x = x + 7;
                    charpos++;
                }
            }
        }

        public void Imprimir()
        {
            dalConfig conf = new dalConfig();

            PrintDocument documento = new PrintDocument();
            if (conf.retornaConfig("Impressora") != "Impressora padrão")
                documento.PrinterSettings.PrinterName = conf.retornaConfig("Impressora");
            documento.PrintPage += documento_PrintPage;
            documento.Print();
            Dispose();

            // visualiza impressao para depois imprimir
            /*PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = documento;
            dialog.ShowDialog();*/
        }

        public RichTextBox Visualiza()
        {
            return txtFormat;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                txtFormat.Dispose();
            }
            // free native resources
        }
    }
}
