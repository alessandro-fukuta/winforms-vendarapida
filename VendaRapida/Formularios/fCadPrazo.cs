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
    public partial class fCadPrazo : Form
    {
        PrazosClass Pra = new PrazosClass();
        Validacao Val = new Validacao();

        bool wp_Cria = false;


        public fCadPrazo()
        {
            InitializeComponent();
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

            Pra.Descricao = txtDescricao.Text;
            Pra.Parcela1 = int.Parse( txtParcela1.Text);
            Pra.Parcela2 = int.Parse( txtParcela2.Text);
            Pra.Parcela3 = int.Parse( txtParcela3.Text);
            Pra.Desconto = decimal.Parse( txtDesconto.Text);

        }

        private void BuscaDadosClasse()
        {

            txtDescricao.Text = Pra.Descricao;
            txtParcela1.Text = Pra.Parcela1.ToString();
            txtParcela2.Text = Pra.Parcela2.ToString();
            txtParcela3.Text = Pra.Parcela3.ToString();
            txtDesconto.Text = Pra.Desconto.ToString("N");
        }

        private void txtPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaInteiro(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                wp_Cria = false;

                if (string.IsNullOrEmpty(txtPrazo.Text))
                {
                    txtPrazo.Text = "0";
                    wp_Cria = true;
                    Habilita();
                    txtDescricao.Focus(); return;
                }
                else
                {
                    if (Pra.Consulta(int.Parse(txtPrazo.Text)))
                    {
                        wp_Cria = false;
                        BuscaDadosClasse(); Habilita();
                    }
                    else
                    {
                        MessageBox.Show("Prazo não encontrado !");
                        txtPrazo.Focus(); return;
                    }
                }
                txtDescricao.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DadosParaClasse();
            if (Pra.Salvar(wp_Cria, int.Parse(txtPrazo.Text)))
            {
                MessageBox.Show("DADOS GRAVADOS COM SUCESSO !");
                LimpaCaixasTexto(); txtPrazo.Focus(); return;
            }
            else
            {
                MessageBox.Show("Erro: Ao SALVAR os DADOS !");
                txtDescricao.Focus(); return;
            }
        }

        private void LimpaCaixasTexto()
        {
            txtDescricao.Text = ""; txtParcela1.Text = ""; txtParcela2.Text = ""; 
            txtParcela3.Text = ""; txtDesconto.Text = "";
        }

        private void fCadPrazo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void fCadPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                e.Handled = true;
                if (ActiveControl.Name.ToUpper() == "TXTPRAZO")
                {
                    this.Close();
                }
                else
                {
                    LimpaCaixasTexto();
                    txtPrazo.Focus();
                }
            }
        }

        private void txtParcela1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaInteiro(e);
        }

        private void txtParcela2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaInteiro(e);
        }

        private void txtParcela3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaInteiro(e);
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.AnalisaMoeda(e);
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            txtDesconto.Text = Val.Formata_Moeda(txtDesconto.Text);
        }
    }
}
