using VendaRapida;
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
    public partial class fCadClientes : Form
    {
        ClientesClass Cli = new ClientesClass();

        bool wp_Cria = false;

        public fCadClientes()
        {
            InitializeComponent();
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
            Cli.Nome = txtNome.Text;
            Cli.Telefone = txtTelefone.Text;
        }

        private void BuscaDadosClasse()
        {
            txtNome.Text = Cli.Nome;
            txtTelefone.Text = Cli.Telefone;
        }
            
        
        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                wp_Cria = false;

                if (string.IsNullOrEmpty(txtCliente.Text))
                {
                    txtCliente.Text = "0";
                    wp_Cria = true;
                    Habilita();
                    txtNome.Focus(); return;
                }
                else
                {
                    if (Cli.Consulta(int.Parse(txtCliente.Text)))
                    {
                        wp_Cria = false;
                        BuscaDadosClasse(); Habilita();
                    }
                    else
                    {
                        MessageBox.Show("CLIENTE não encontrado !");
                        txtCliente.Focus(); return;
                    }
                }
                txtNome.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DadosParaClasse();
            if (Cli.Salvar(wp_Cria, int.Parse(txtCliente.Text)))
            {
                MessageBox.Show("DADOS GRAVADOS COM SUCESSO !");
                LimpaCaixasTexto();txtCliente.Focus();return;
            } else
            {
                MessageBox.Show("Erro: Ao SALVAR os DADOS !");
                txtNome.Focus(); return;
            }
        }


        private void LimpaCaixasTexto()
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
        }

        private void fCadClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                e.Handled = true;
                if (ActiveControl.Name.ToUpper() == "TXTCLIENTE")
                {
                    this.Close();
                }
                else
                {
                    LimpaCaixasTexto();
                    txtCliente.Focus();
                }
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void fCadClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
