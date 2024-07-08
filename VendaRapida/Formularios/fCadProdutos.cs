using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendaRapida.Models;

namespace VendaRapida.Formularios
{
    public partial class fCadProdutos : Form
    {
        ProdutosClass Pro = new ProdutosClass();
        Validacao Val = new Validacao();

        bool wp_Cria = false;


        public fCadProdutos()
        {
            InitializeComponent();
        }

        private void txtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                fShow fsw = new fShow("Produtos",
            new string[] { "Id", "DESCRICAO", "PRECOVENDA", "ESTOQUE" }, "Id");

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

        private void Habilita()
        {
            groupBox1.Enabled = true;
        }
        private void Desabilita()
        {
            groupBox1.Enabled = false;
        }

        private void DadosParaClasse()
        {
            Pro.Descricao = txtDescricao.Text;
            Pro.Custo = decimal.Parse(txtCusto.Text);
            Pro.Margem = decimal.Parse(txtMargem.Text);
            Pro.PrecoVenda = decimal.Parse(txtPrecoVenda.Text);
            Pro.Estoque = int.Parse(txtEstoque.Text);
        }

        private void BuscaDadosClasse()
        {
            txtDescricao.Text = Pro.Descricao;
            txtCusto.Text = Pro.Custo.ToString("n");
            txtMargem.Text = Pro.Margem.ToString("n");
            txtPrecoVenda.Text = Pro.PrecoVenda.ToString("n");
            txtEstoque.Text = Pro.Estoque.ToString();
        }

        private void txtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                wp_Cria = false;

                if (string.IsNullOrEmpty(txtProduto.Text))
                {
                    txtProduto.Text = "0";
                    wp_Cria = true;
                    Habilita();
                    txtDescricao.Focus(); return;
                }
                else
                {
                    if (Pro.Consulta(int.Parse(txtProduto.Text)))
                    {
                        wp_Cria = false;
                        BuscaDadosClasse(); Habilita();
                    }
                    else
                    {
                        MessageBox.Show("PRODUTO não encontrado !");
                        txtProduto.Focus(); return;
                    }
                }
                txtDescricao.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DadosParaClasse();
            if (Pro.Salvar(wp_Cria, int.Parse(txtProduto.Text)))
            {
                MessageBox.Show("DADOS GRAVADOS COM SUCESSO !");
                LimpaCaixasTexto(); txtProduto.Focus(); return;
            }
            else
            {
                MessageBox.Show("Erro: Ao SALVAR os DADOS !");
                txtDescricao.Focus(); return;
            }
        }


        private void LimpaCaixasTexto()
        {
            txtDescricao.Text = "";
            txtCusto.Text = "";
            txtMargem.Text = "";
            txtPrecoVenda.Text = "";
            txtEstoque.Text = "";

        }

        private void fCadProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                e.Handled = true;
                if (ActiveControl.Name.ToUpper() == "TXTPRODUTO")
                {
                    this.Close();
                }
                else
                {
                    LimpaCaixasTexto();
                    txtProduto.Focus();
                }
            }
        }

        private void txtCusto_Leave(object sender, EventArgs e)
        {
            txtCusto.Text = Val.Formata_Moeda(txtCusto.Text);
        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaMoeda(e);
        }

        private void txtMargem_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaMoeda(e);
        }

        private void txtMargem_Leave(object sender, EventArgs e)
        {
            txtMargem.Text = Val.Formata_Moeda(txtMargem.Text);
            txtPrecoVenda.Text = CalculaPreco(decimal.Parse(txtCusto.Text), decimal.Parse(txtMargem.Text)).ToString("N");

        }

        private decimal CalculaPreco(decimal pCusto, decimal pMargem)
        {
            return pCusto + ((pCusto * pMargem) / 100);
        }


        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaMoeda(e);
        }

        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            txtPrecoVenda.Text = Val.Formata_Moeda(txtPrecoVenda.Text);
        }


        // fim da classe

    }
}

