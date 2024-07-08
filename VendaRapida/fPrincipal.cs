using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendaRapida.Formularios;
using VendaRapida.Data;
using VendaRapida.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VendaRapida
{
    public partial class fPrincipal : Form
    {
        DataBank DBK = new DataBank();
        Validacao Val = new Validacao();
        ClientesClass Cli = new ClientesClass();
        ProdutosClass Pro = new ProdutosClass();
        PrazosClass Pra = new PrazosClass();
        PedidoClass Ped = new PedidoClass();
        PedidoComplClass PedCom = new PedidoComplClass();

        bool wp_Cria = false;
        ListViewItem item;
        Decimal TotalBruto = 0;
        Decimal TotalPagar = 0;
        Decimal Desconto = 0;

        public fPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadProdutos_Click(object sender, EventArgs e)
        {
            fCadProdutos cadpro = new fCadProdutos();
            cadpro.StartPosition = FormStartPosition.CenterScreen;
            cadpro.ShowDialog();

        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            fCadClientes cadcli = new fCadClientes();
            cadcli.StartPosition = FormStartPosition.CenterScreen;
            cadcli.ShowDialog();
        }

        private void btnPrazo_Click(object sender, EventArgs e)
        {
            fCadPrazo cadprazo = new fCadPrazo();
            cadprazo.StartPosition = FormStartPosition.CenterScreen;
            cadprazo.ShowDialog();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Verificando estrutura de dados...";
            bool Ret = true;
            if (!DBK.CriarBanco())
            {
                lblMensagem.Text = "Criando o banco de dados...";
                Ret = false;
            }

            if (!DBK.CriarClientes())
            {
                lblMensagem.Text = "Criando a tabela de clientes...";
                Ret = false;
            }

            if (!DBK.CriarProdutos())
            {
                lblMensagem.Text = "Criando a tabela de produtos...";
                Ret = false;
            }

            if (!DBK.CriarPrazos())
            {
                lblMensagem.Text = "Criando a tabela de Prazos...";
                Ret = false;
            }

            if (!DBK.CriarPedidos())
            {
                lblMensagem.Text = "Criando a tabela de clientes...";
                Ret = false;
            }

            if (!DBK.CriarPedidosComplemento())
            {
                lblMensagem.Text = "Criando a tabela de clientes...";
                Ret = false;
            }


            if (Ret)
            {
                MessageBox.Show("Estrutura de Dados OK", "Atenção");
            }


        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fShow fsw = new fShow("Clientes",
            new string[] { "Id", "NOME", "TELEFONE" }, "Id");

                fsw.ShowDialog();

                if (string.IsNullOrEmpty(fsw.ParametroID.ToString()))
                {
                    fsw.ParametroID = "0";
                }
                txtCliente.Text = int.Parse(fsw.ParametroID.ToString()).ToString();

                if (!string.IsNullOrEmpty(txtCliente.Text) && txtCliente.Text != "0")
                {
                    SendKeys.SendWait("{ENTER}");
                }

            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaInteiro(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (string.IsNullOrEmpty(txtCliente.Text))
                {
                    txtCliente.Text = "0";
                    return;
                }
                else
                {
                    if (Cli.Consulta(int.Parse(txtCliente.Text)))
                    {

                        lblCliente.Text = Cli.Nome;
                    }
                    else
                    {
                        MessageBox.Show("CLIENTE não encontrado !");
                        txtCliente.Focus(); return;
                    }
                }
                txtProduto.Focus();
            }
        }
        private void BuscaDadosClasse()
        {

            txtData.Value = Ped.Data;
            txtCliente.Text = Ped.Cliente_Id.ToString();
            txtPrazo.Text = Ped.Prazo_id.ToString();
            lblPrazo1.Text = Ped.Parcela1.ToString().Substring(0,10);
            if (!string.IsNullOrEmpty(Ped.Parcela2.ToString()))
            {
                lblPrazo2.Text = Ped.Parcela2.ToString().Substring(0, 10);
            } else
            {
                lblPrazo2.Text = "";
            }
            if (!string.IsNullOrEmpty(Ped.Parcela3.ToString()))
            {
                lblPrazo3.Text = Ped.Parcela3.ToString().Substring(0, 10);
            }
            else
            {
                lblPrazo3.Text = "";
            }

            lblTotalBruto.Text = Ped.Total_Bruto.ToString("N");
            lblTotalPagar.Text = Ped.Total_Pagar.ToString("N");
            txtDesconto.Text = Ped.Desconto_por.ToString("N");
            lblDesconto.Text = Ped.Desconto_Real.ToString("N");

            if (Cli.Consulta(int.Parse(txtCliente.Text)))
            {
                lblCliente.Text = Cli.Nome;
            }
            else
            {
                lblCliente.Text = "Cliente não encontrado...";
            }

            if (Pra.Consulta(int.Parse(txtPrazo.Text)))
            {
                lblPrazo.Text = Pra.Descricao;
            }
            else
            {
                lblPrazo.Text = "Prazo não encontrado...";
            }

            PedCom.BuscaProdutosPedido(int.Parse(txtVenda.Text));

            TotalBruto = 0;
            TotalPagar = 0;
            foreach (var lvi in PedCom.lstPedCom)
            {
                item = new ListViewItem(lvi.Produto_Id.ToString()) ;
                Pro.Consulta(lvi.Produto_Id);
                // item.SubItems.Add(txtProduto.Text);
                item.SubItems.Add(Pro.Descricao);
                item.SubItems.Add(Pro.PrecoVenda.ToString("N"));
                item.SubItems.Add("1");
                item.SubItems.Add(Pro.PrecoVenda.ToString("N"));
                grdProdutos.Items.Add(item);
            }

            lblTotalBruto.Text = TotalBruto.ToString("N");
            Desconto = 0;

        }
        private void EnviaDadosClasse()
        {
            Ped.Data = txtData.Value;
            Ped.Cliente_Id = int.Parse(txtCliente.Text);
            Ped.Prazo_id = int.Parse(txtPrazo.Text);
            Ped.Desconto_por = decimal.Parse(txtDesconto.Text);
            Ped.Desconto_Real = decimal.Parse(lblDesconto.Text);
            Ped.Total_Bruto = decimal.Parse(lblTotalBruto.Text);
            Ped.Total_Pagar = decimal.Parse(lblTotalPagar.Text);


            Ped.Parcela1 = txtData.Value.AddDays(Pra.Parcela1);

            if (Pra.Parcela2 >= 1)
            {
                Ped.Parcela2 = txtData.Value.AddDays(Pra.Parcela2);
            }
            if (Pra.Parcela3 >= 1)
            {
                Ped.Parcela3 = txtData.Value.AddDays(Pra.Parcela3);
            }
        }

        private void Operacao()
        {
            if(wp_Cria)
            {
                lblOperacao.Text = "Nova Venda";
                lblOperacao.BackColor = Color.Blue;
                lblOperacao.ForeColor = Color.White;
            } else
            {
                lblOperacao.Text = "Alteração";
                lblOperacao.BackColor = Color.Yellow;
                lblOperacao.ForeColor = Color.Black;
            }
        }
        private void txtVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaInteiro(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                wp_Cria = false;

                if (string.IsNullOrEmpty(txtVenda.Text))
                {
                    txtVenda.Text = "0";
                    wp_Cria = true; Operacao();
                    txtData.Value = DateTime.Now.Date;
                    groupBox1.Enabled = true;
                    txtCliente.Focus(); return;
                }
                else
                {
                    if (Ped.Consulta(int.Parse(txtVenda.Text)))
                    {
                        wp_Cria = false; Operacao();
                        groupBox1.Enabled = true; 
                        BuscaDadosClasse();
                        CalculaTotal();
                    }
                    else
                    {
                        MessageBox.Show("VENDA não encontrado !");
                        
                    }
                }
                txtCliente.Focus();
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaMoeda(e);
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnSalvar.Focus();
            }
        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fShow fsw = new fShow("Produtos",
            new string[] { "Id", "DESCRICAO", "ESTOQUE", "PRECOVENDA" }, "Id");

                fsw.ShowDialog();

                if (string.IsNullOrEmpty(fsw.ParametroID.ToString()))
                {
                    fsw.ParametroID = "0";
                }
                txtProduto.Text = int.Parse(fsw.ParametroID.ToString()).ToString();

                if (!string.IsNullOrEmpty(txtProduto.Text) && txtProduto.Text != "0")
                {
                    SendKeys.SendWait("{ENTER}");
                }

            }
        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaInteiro(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (string.IsNullOrEmpty(txtProduto.Text))
                {
                    txtProduto.Text = "";
                    lblProduto.Text = "";
                    txtPrazo.Focus();
                }
                else
                {
                    if (Pro.Consulta(int.Parse(txtProduto.Text)))
                    {

                        lblProduto.Text = Pro.Descricao;
                    }
                    else
                    {
                        MessageBox.Show("PRODUTO não encontrado !");
                        txtProduto.Focus(); return;
                    }
                    btnAddGrade.Focus();
                }

            }
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrazo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fShow fsw = new fShow("Prazos",
            new string[] { "Id", "DESCRICAO", "DESCONTO" }, "Id");

                fsw.ShowDialog();

                if (string.IsNullOrEmpty(fsw.ParametroID.ToString()))
                {
                    fsw.ParametroID = "0";
                }
                txtPrazo.Text = int.Parse(fsw.ParametroID.ToString()).ToString();

                if (!string.IsNullOrEmpty(txtPrazo.Text) && txtPrazo.Text != "0")
                {
                    SendKeys.SendWait("{ENTER}");
                }

            }
        }

        private void txtPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaInteiro(e);

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (string.IsNullOrEmpty(txtPrazo.Text))
                {
                    txtPrazo.Text = "0";
                    return;
                }
                else
                {
                    if (Pra.Consulta(int.Parse(txtPrazo.Text)))
                    {

                        lblPrazo.Text = Pra.Descricao;
                        GeraParcelas();
                        txtDesconto.Text = Pra.Desconto.ToString("N");
                    }
                    else
                    {
                        MessageBox.Show("Prazo não encontrado !");
                        txtPrazo.Focus(); return;
                    }
                }
                txtDesconto.Focus();
            }
        }

        private void GeraParcelas()
        {

            DateTime Data;
            Data = txtData.Value;

            lblPrazo1.Text = Data.AddDays(Pra.Parcela1).ToShortDateString();

            if (Pra.Parcela2 > 0)
            {
                lblPrazo2.Text = Data.AddDays(Pra.Parcela2).ToShortDateString();
            }

            if (Pra.Parcela3 > 0)
            {
                lblPrazo3.Text = Data.AddDays(Pra.Parcela3).ToShortDateString();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fPrincipal_Load(object sender, EventArgs e)
        {
            txtData.Value = DateTime.Now.Date;
            grdProdutos.Columns.Add("ID", 50, HorizontalAlignment.Left);
            grdProdutos.Columns.Add("Descrição", 360, HorizontalAlignment.Left);
            grdProdutos.Columns.Add("Unitário", 80, HorizontalAlignment.Right);
            grdProdutos.Columns.Add("Quant", 80, HorizontalAlignment.Center);
            grdProdutos.Columns.Add("Total - R$", grdProdutos.Width - 590, HorizontalAlignment.Right);
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            item = new ListViewItem(txtProduto.Text);

            // item.SubItems.Add(txtProduto.Text);
            item.SubItems.Add(lblProduto.Text);
            item.SubItems.Add(Pro.PrecoVenda.ToString("N"));
            item.SubItems.Add("1");
            item.SubItems.Add(Pro.PrecoVenda.ToString("N"));
            grdProdutos.Items.Add(item);
            CalculaTotal();
            txtProduto.Text = ""; txtProduto.Focus();

        }

        private void CalculaTotal()
        {
            TotalBruto = 0;
            TotalPagar = 0;
            foreach (ListViewItem lvi in grdProdutos.Items)
            {
                if (lvi.SubItems[4].Text != "")
                {
                    TotalBruto += decimal.Parse(lvi.SubItems[4].Text);
                }
            }

            lblTotalBruto.Text = TotalBruto.ToString("N");
            Desconto = 0;
            // Calcula Desconto
            if (!string.IsNullOrEmpty(txtDesconto.Text))
            {
                Desconto = TotalBruto * decimal.Parse(txtDesconto.Text) / 100;
                lblDesconto.Text = Desconto.ToString("N");

            }
            TotalPagar = TotalBruto - Desconto;
            lblTotalPagar.Text = TotalPagar.ToString("N");

        }

        private void txtVenda_Enter(object sender, EventArgs e)
        {
            lblOperacao.Text = "Operação";
            lblOperacao.BackColor = Color.White;
            lblOperacao.ForeColor = Color.Blue;
            groupBox1.Enabled = false;
            txtVenda.BackColor = Color.White;
            txtVenda.ForeColor = Color.Black;
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            //CalculaTotal();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool Retorno = false;
            EnviaDadosClasse();
            if (Ped.Salvar(wp_Cria, int.Parse(txtVenda.Text)))
            {
                if (wp_Cria)
                {
                    txtVenda.Text = Ped.Id.ToString(); // Ultimo ID
                    txtVenda.BackColor = Color.Green;
                    txtVenda.ForeColor = Color.White;
                } else
                {
                    // Apagar os produtos do pedido na alteraçao

                    if (!PedCom.ExcluirProdutosPedido(int.Parse(txtVenda.Text)))
                    {
                        MessageBox.Show("Problema ao Atualizar os Produtos !", "Olá !");
                        Retorno = false;
                        return;
                    }
                }

                PedCom.lstPedCom.Clear();
                foreach (ListViewItem lvi in grdProdutos.Items)
                    {
                        if (lvi.SubItems[4].Text != "")
                        {
                            PedCom.Pedido_Id = Ped.Id;
                            PedCom.Produto_Id = int.Parse(lvi.SubItems[0].Text);
                            PedCom.Quantidade = int.Parse(lvi.SubItems[3].Text);
                            if (PedCom.SalvarProdutosPedido(Ped.Id))
                            {
                                Retorno = true;
                            }
                            else
                            {
                                Retorno = false;
                            }
                        }
                    }
                    if (Retorno)
                    {
                        MessageBox.Show("PEDIDO GRAVADO COM SUCESSO !", "PEDIDO Nº" + Ped.Id.ToString());
                    }


               
            }
        }

        private void txtPrazo_TextChanged(object sender, EventArgs e)
        {

        }

        private void fPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                e.Handled = true;

                if (ActiveControl.Name.ToUpper() == "TXTVENDA")
                {
                    this.Close();
                }
                else
                {
                    LimpaCaixasTexto();
                    txtVenda.Text = "";
                    txtVenda.Focus();
                }

            }
        }

        public void LimpaCaixasTexto()
        {
            txtCliente.Text = "0";
            lblCliente.Text = "";
            txtPrazo.Text = "";
            lblPrazo.Text = "";
            lblPrazo1.Text = "";
            lblPrazo2.Text = "";
            lblPrazo3.Text = "";
            lblDesconto.Text = "";
            txtDesconto.Text = "";
            grdProdutos.Items.Clear();
            lblTotalBruto.Text = "0,00";
            lblTotalPagar.Text = "0,00";

        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            CalculaTotal();
        }

        private void grdProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem eachItem in grdProdutos.SelectedItems)
                {
                    grdProdutos.Items.Remove(eachItem);
                }
                CalculaTotal();
            }
        }

        private void grdProdutos_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if ((e.ItemIndex % 2) == 0)
            {
                e.Item.BackColor = Color.FromArgb(230, 230, 255);
                e.Item.UseItemStyleForSubItems = true;
            }
        }

        private void grdProdutos_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void fPrincipal_Resize(object sender, EventArgs e)
        {
            OrganizaTela();
        }

        private void OrganizaTela()
        {
            int LarguraTela = this.Width;
            int LarguraPanel = panel1.Width;
            int AlturaTela = this.Height;
            int AlturaPanel = panel1.Height;

            int ResultadoLargura = (LarguraTela - LarguraPanel)/2-20;
            int ResultadoAltura = (AlturaTela - AlturaPanel) / 2 - 20;

            panel2.Width = ResultadoLargura;
            panel3.Width = ResultadoLargura;


            panel1.Left = panel2.Width + 10;

            panel1.Top = ResultadoAltura + 10;

            panel5.Top = panel1.Bottom + 30;
            panel5.Height = ResultadoAltura-40;


        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCadClientes Cli = new fCadClientes();
            Cli.TopLevel = false;
            Cli.AutoScroll = true;
            Parent.Controls.Add(Cli);
            Cli.Parent = Parent;
            Cli.FormBorderStyle = FormBorderStyle.None;
            Cli.Show();
        }

        private void txtVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fShow fsw = new fShow("PEDIDOS",
            new string[] { "Id", "DATA", "ClienteId", "Totalpagar" }, "Id");

                fsw.ShowDialog();

                if (string.IsNullOrEmpty(fsw.ParametroID.ToString()))
                {
                    fsw.ParametroID = "0";
                }
                txtVenda.Text = int.Parse(fsw.ParametroID.ToString()).ToString();

                if (!string.IsNullOrEmpty(txtVenda.Text) && txtVenda    .Text != "0")
                {
                    SendKeys.SendWait("{ENTER}");
                }

            }
        }

        // fim da classe
    }
}
