namespace VendaRapida.Formularios
{
    partial class fCadPrazo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtParcela3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParcela2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParcela1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrazo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtParcela3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtParcela2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtParcela1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(18, 121);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 33);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(447, 82);
            this.txtDesconto.MaxLength = 5;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(79, 20);
            this.txtDesconto.TabIndex = 6;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Desconto";
            // 
            // txtParcela3
            // 
            this.txtParcela3.Location = new System.Drawing.Point(220, 82);
            this.txtParcela3.MaxLength = 2;
            this.txtParcela3.Name = "txtParcela3";
            this.txtParcela3.Size = new System.Drawing.Size(79, 20);
            this.txtParcela3.TabIndex = 5;
            this.txtParcela3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtParcela3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcela3_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parcela Dias 3";
            // 
            // txtParcela2
            // 
            this.txtParcela2.Location = new System.Drawing.Point(120, 82);
            this.txtParcela2.MaxLength = 2;
            this.txtParcela2.Name = "txtParcela2";
            this.txtParcela2.Size = new System.Drawing.Size(79, 20);
            this.txtParcela2.TabIndex = 4;
            this.txtParcela2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtParcela2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcela2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parcela Dias 2";
            // 
            // txtParcela1
            // 
            this.txtParcela1.Location = new System.Drawing.Point(18, 82);
            this.txtParcela1.MaxLength = 2;
            this.txtParcela1.Name = "txtParcela1";
            this.txtParcela1.Size = new System.Drawing.Size(79, 20);
            this.txtParcela1.TabIndex = 3;
            this.txtParcela1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtParcela1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParcela1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parcela Dias 1";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(18, 34);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(508, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // txtPrazo
            // 
            this.txtPrazo.Location = new System.Drawing.Point(12, 28);
            this.txtPrazo.MaxLength = 2;
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(79, 20);
            this.txtPrazo.TabIndex = 0;
            this.txtPrazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrazo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrazo_KeyDown);
            this.txtPrazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrazo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prazo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "F2 - Mostra Cadastrados";
            // 
            // fCadPrazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 246);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "fCadPrazo";
            this.Text = "Cadastro de Prazos de Pagamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fCadPrazo_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fCadPrazo_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtParcela3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParcela2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParcela1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrazo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}