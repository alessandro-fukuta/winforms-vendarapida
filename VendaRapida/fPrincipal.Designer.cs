namespace VendaRapida
{
    partial class fPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.txtPrazo = new System.Windows.Forms.TextBox();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblPrazo3 = new System.Windows.Forms.Label();
            this.lblPrazo2 = new System.Windows.Forms.Label();
            this.lblPrazo1 = new System.Windows.Forms.Label();
            this.btnPrazo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadProdutos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grdProdutos = new System.Windows.Forms.ListView();
            this.btnCadClientes = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda  F2 - Exibe Vendas";
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(24, 46);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(127, 20);
            this.txtVenda.TabIndex = 1;
            this.txtVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVenda.Enter += new System.EventHandler(this.txtVenda_Enter);
            this.txtVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVenda_KeyDown);
            this.txtVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenda_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOperacao);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPrazo);
            this.groupBox1.Controls.Add(this.txtPrazo);
            this.groupBox1.Controls.Add(this.btnAddGrade);
            this.groupBox1.Controls.Add(this.lblProduto);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.lblPrazo3);
            this.groupBox1.Controls.Add(this.lblPrazo2);
            this.groupBox1.Controls.Add(this.lblPrazo1);
            this.groupBox1.Controls.Add(this.btnPrazo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblTotalPagar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblDesconto);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblTotalBruto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCadProdutos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.grdProdutos);
            this.groupBox1.Controls.Add(this.btnCadClientes);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 513);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblOperacao.Location = new System.Drawing.Point(620, 0);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(54, 13);
            this.lblOperacao.TabIndex = 25;
            this.lblOperacao.Text = "Operação";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(15, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(488, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "PRODUTOS NO PEDIDO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(14, 39);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(64, 20);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(498, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "( DEL / DELETE ) = Apagar ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrazo
            // 
            this.lblPrazo.BackColor = System.Drawing.Color.Blue;
            this.lblPrazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrazo.ForeColor = System.Drawing.Color.White;
            this.lblPrazo.Location = new System.Drawing.Point(119, 379);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(286, 20);
            this.lblPrazo.TabIndex = 27;
            this.lblPrazo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrazo
            // 
            this.txtPrazo.Location = new System.Drawing.Point(18, 380);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(60, 20);
            this.txtPrazo.TabIndex = 8;
            this.txtPrazo.TextChanged += new System.EventHandler(this.txtPrazo_TextChanged);
            this.txtPrazo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrazo_KeyDown);
            this.txtPrazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrazo_KeyPress);
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.BackColor = System.Drawing.Color.White;
            this.btnAddGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGrade.Location = new System.Drawing.Point(411, 331);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(30, 22);
            this.btnAddGrade.TabIndex = 7;
            this.btnAddGrade.Text = "+";
            this.btnAddGrade.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddGrade.UseVisualStyleBackColor = false;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.BackColor = System.Drawing.Color.Blue;
            this.lblProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProduto.ForeColor = System.Drawing.Color.White;
            this.lblProduto.Location = new System.Drawing.Point(119, 333);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(286, 20);
            this.lblProduto.TabIndex = 24;
            this.lblProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(18, 333);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(63, 20);
            this.txtProduto.TabIndex = 5;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            this.txtProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProduto_KeyDown);
            this.txtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduto_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSalvar.Image = global::VendaRapida.Properties.Resources.ic_save;
            this.btnSalvar.Location = new System.Drawing.Point(14, 438);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 69);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblPrazo3
            // 
            this.lblPrazo3.BackColor = System.Drawing.Color.Blue;
            this.lblPrazo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrazo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrazo3.ForeColor = System.Drawing.Color.White;
            this.lblPrazo3.Location = new System.Drawing.Point(276, 406);
            this.lblPrazo3.Name = "lblPrazo3";
            this.lblPrazo3.Size = new System.Drawing.Size(129, 20);
            this.lblPrazo3.TabIndex = 22;
            this.lblPrazo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrazo2
            // 
            this.lblPrazo2.BackColor = System.Drawing.Color.Blue;
            this.lblPrazo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrazo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrazo2.ForeColor = System.Drawing.Color.White;
            this.lblPrazo2.Location = new System.Drawing.Point(144, 406);
            this.lblPrazo2.Name = "lblPrazo2";
            this.lblPrazo2.Size = new System.Drawing.Size(126, 20);
            this.lblPrazo2.TabIndex = 21;
            this.lblPrazo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrazo1
            // 
            this.lblPrazo1.BackColor = System.Drawing.Color.Blue;
            this.lblPrazo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrazo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrazo1.ForeColor = System.Drawing.Color.White;
            this.lblPrazo1.Location = new System.Drawing.Point(18, 406);
            this.lblPrazo1.Name = "lblPrazo1";
            this.lblPrazo1.Size = new System.Drawing.Size(121, 20);
            this.lblPrazo1.TabIndex = 20;
            this.lblPrazo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrazo
            // 
            this.btnPrazo.BackColor = System.Drawing.Color.White;
            this.btnPrazo.Location = new System.Drawing.Point(84, 379);
            this.btnPrazo.Name = "btnPrazo";
            this.btnPrazo.Size = new System.Drawing.Size(29, 22);
            this.btnPrazo.TabIndex = 9;
            this.btnPrazo.Text = "...";
            this.btnPrazo.UseVisualStyleBackColor = false;
            this.btnPrazo.Click += new System.EventHandler(this.btnPrazo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(15, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Prazo de Pagamento (F2)-Exibe Prazos Cadastrados";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.BackColor = System.Drawing.Color.Blue;
            this.lblTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.ForeColor = System.Drawing.Color.White;
            this.lblTotalPagar.Location = new System.Drawing.Point(561, 431);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(115, 20);
            this.lblTotalPagar.TabIndex = 16;
            this.lblTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(558, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Total a Pagar";
            // 
            // lblDesconto
            // 
            this.lblDesconto.BackColor = System.Drawing.Color.Blue;
            this.lblDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDesconto.ForeColor = System.Drawing.Color.White;
            this.lblDesconto.Location = new System.Drawing.Point(607, 381);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(69, 20);
            this.lblDesconto.TabIndex = 14;
            this.lblDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(561, 381);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(45, 20);
            this.txtDesconto.TabIndex = 9;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(558, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Desconto %";
            // 
            // lblTotalBruto
            // 
            this.lblTotalBruto.BackColor = System.Drawing.Color.Blue;
            this.lblTotalBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBruto.ForeColor = System.Drawing.Color.White;
            this.lblTotalBruto.Location = new System.Drawing.Point(561, 334);
            this.lblTotalBruto.Name = "lblTotalBruto";
            this.lblTotalBruto.Size = new System.Drawing.Size(115, 20);
            this.lblTotalBruto.TabIndex = 11;
            this.lblTotalBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(558, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Bruto R$";
            // 
            // btnCadProdutos
            // 
            this.btnCadProdutos.BackColor = System.Drawing.Color.White;
            this.btnCadProdutos.Location = new System.Drawing.Point(87, 331);
            this.btnCadProdutos.Name = "btnCadProdutos";
            this.btnCadProdutos.Size = new System.Drawing.Size(26, 23);
            this.btnCadProdutos.TabIndex = 6;
            this.btnCadProdutos.Text = "...";
            this.btnCadProdutos.UseVisualStyleBackColor = false;
            this.btnCadProdutos.Click += new System.EventHandler(this.btnCadProdutos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(15, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Produto (F2) - Exibe Produtos Cadastrados";
            // 
            // grdProdutos
            // 
            this.grdProdutos.FullRowSelect = true;
            this.grdProdutos.GridLines = true;
            this.grdProdutos.HideSelection = false;
            this.grdProdutos.Location = new System.Drawing.Point(15, 85);
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.OwnerDraw = true;
            this.grdProdutos.Size = new System.Drawing.Size(659, 226);
            this.grdProdutos.TabIndex = 4;
            this.grdProdutos.UseCompatibleStateImageBehavior = false;
            this.grdProdutos.View = System.Windows.Forms.View.Details;
            this.grdProdutos.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.grdProdutos_DrawColumnHeader);
            this.grdProdutos.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.grdProdutos_DrawItem);
            this.grdProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdProdutos_KeyDown);
            // 
            // btnCadClientes
            // 
            this.btnCadClientes.BackColor = System.Drawing.Color.White;
            this.btnCadClientes.Location = new System.Drawing.Point(85, 39);
            this.btnCadClientes.Name = "btnCadClientes";
            this.btnCadClientes.Size = new System.Drawing.Size(25, 21);
            this.btnCadClientes.TabIndex = 2;
            this.btnCadClientes.Tag = "Cadastro de Clientes";
            this.btnCadClientes.Text = "...";
            this.btnCadClientes.UseVisualStyleBackColor = false;
            this.btnCadClientes.Click += new System.EventHandler(this.btnCadClientes_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Blue;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(119, 40);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(555, 20);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "F2 - Exibe Clientes Cadastrados";
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(600, 36);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(113, 20);
            this.txtData.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(597, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(24, 591);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(97, 22);
            this.btnVerifica.TabIndex = 23;
            this.btnVerifica.Text = "Verifica Estrutura";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMensagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(127, 591);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(586, 22);
            this.lblMensagem.TabIndex = 24;
            this.lblMensagem.Text = "MENSAGEM";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensagem.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMensagem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnVerifica);
            this.panel1.Controls.Add(this.txtVenda);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(125, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 625);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 775);
            this.panel2.TabIndex = 27;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(106, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 775);
            this.splitter1.TabIndex = 28;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(865, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 775);
            this.panel3.TabIndex = 29;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(862, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 775);
            this.splitter2.TabIndex = 30;
            this.splitter2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitter3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(109, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(753, 56);
            this.panel4.TabIndex = 31;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(753, 3);
            this.splitter3.TabIndex = 0;
            this.splitter3.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(109, 753);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(753, 22);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter4.Location = new System.Drawing.Point(109, 750);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(753, 3);
            this.splitter4.TabIndex = 33;
            this.splitter4.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(109, 693);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(753, 57);
            this.panel5.TabIndex = 34;
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 775);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "fPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda Rápida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fPrincipal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fPrincipal_KeyPress);
            this.Resize += new System.EventHandler(this.fPrincipal_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalBruto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView grdProdutos;
        private System.Windows.Forms.Button btnCadClientes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPrazo3;
        private System.Windows.Forms.Label lblPrazo2;
        private System.Windows.Forms.Label lblPrazo1;
        private System.Windows.Forms.Button btnPrazo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.TextBox txtPrazo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Panel panel5;
    }
}

