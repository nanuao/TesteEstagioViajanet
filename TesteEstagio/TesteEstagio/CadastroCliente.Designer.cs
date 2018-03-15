namespace TesteEstagio
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.vcnpj = new System.Windows.Forms.Button();
            this.vcpf = new System.Windows.Forms.Button();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.mskEmail = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnAtt = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.mskIdade = new System.Windows.Forms.MaskedTextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.Vemail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vcnpj
            // 
            this.vcnpj.BackColor = System.Drawing.SystemColors.HighlightText;
            this.vcnpj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vcnpj.BackgroundImage")));
            this.vcnpj.Location = new System.Drawing.Point(341, 240);
            this.vcnpj.Name = "vcnpj";
            this.vcnpj.Size = new System.Drawing.Size(157, 23);
            this.vcnpj.TabIndex = 38;
            this.vcnpj.Text = "VALIDAR CNPJ";
            this.vcnpj.UseVisualStyleBackColor = false;
            this.vcnpj.Click += new System.EventHandler(this.vcnpj_Click);
            // 
            // vcpf
            // 
            this.vcpf.BackColor = System.Drawing.SystemColors.HighlightText;
            this.vcpf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vcpf.BackgroundImage")));
            this.vcpf.Location = new System.Drawing.Point(341, 203);
            this.vcpf.Name = "vcpf";
            this.vcpf.Size = new System.Drawing.Size(157, 23);
            this.vcpf.TabIndex = 37;
            this.vcpf.Text = "VALIDAR CPF";
            this.vcpf.UseVisualStyleBackColor = false;
            this.vcpf.Click += new System.EventHandler(this.vcpf_Click);
            // 
            // mskCnpj
            // 
            this.mskCnpj.Location = new System.Drawing.Point(208, 242);
            this.mskCnpj.Mask = "99,999,999/9999-99";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(112, 20);
            this.mskCnpj.TabIndex = 36;
            this.mskCnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(208, 205);
            this.mskCpf.Mask = "999,999,999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(112, 20);
            this.mskCpf.TabIndex = 35;
            this.mskCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // mskEmail
            // 
            this.mskEmail.Location = new System.Drawing.Point(208, 124);
            this.mskEmail.Name = "mskEmail";
            this.mskEmail.Size = new System.Drawing.Size(180, 20);
            this.mskEmail.TabIndex = 34;
            this.mskEmail.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.BackgroundImage")));
            this.btnCadastrar.Location = new System.Drawing.Point(153, 356);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(157, 23);
            this.btnCadastrar.TabIndex = 33;
            this.btnCadastrar.Text = "CADASTRAR CLIENTE";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(208, 315);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(162, 20);
            this.txtEnd.TabIndex = 32;
            this.txtEnd.TextChanged += new System.EventHandler(this.txtEnd_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(123, 318);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "ENDEREÇO";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(110, 280);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "TIPO CLIENTE";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 245);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "CNPJ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(163, 205);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "CPF";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(151, 165);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "IDADE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 121);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "EMAIL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 84);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "NOME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(208, 81);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(290, 20);
            this.txtNome.TabIndex = 21;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(86, 50);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3);
            this.label8.Size = new System.Drawing.Size(110, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "PESQUISAR NOME";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(208, 50);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(233, 20);
            this.txtPesquisa.TabIndex = 40;
            // 
            // btnAtt
            // 
            this.btnAtt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAtt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtt.BackgroundImage")));
            this.btnAtt.Location = new System.Drawing.Point(341, 356);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(157, 23);
            this.btnAtt.TabIndex = 41;
            this.btnAtt.Text = "ATUALIZAR CLIENTE";
            this.btnAtt.UseVisualStyleBackColor = false;
            this.btnAtt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisar.Location = new System.Drawing.Point(447, 48);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(81, 23);
            this.btnPesquisar.TabIndex = 42;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.button2_Click);
            // 
            // mskIdade
            // 
            this.mskIdade.Location = new System.Drawing.Point(208, 165);
            this.mskIdade.Mask = "00";
            this.mskIdade.Name = "mskIdade";
            this.mskIdade.Size = new System.Drawing.Size(25, 20);
            this.mskIdade.TabIndex = 43;
            this.mskIdade.ValidatingType = typeof(int);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(208, 280);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(318, 280);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(3);
            this.label9.Size = new System.Drawing.Size(123, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "(FISICA OU JURIDICA)";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Location = new System.Drawing.Point(251, 402);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 23);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "FECHAR";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Vemail
            // 
            this.Vemail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Vemail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Vemail.BackgroundImage")));
            this.Vemail.Location = new System.Drawing.Point(394, 122);
            this.Vemail.Name = "Vemail";
            this.Vemail.Size = new System.Drawing.Size(157, 23);
            this.Vemail.TabIndex = 47;
            this.Vemail.Text = "VALIDAR EMAIL";
            this.Vemail.UseVisualStyleBackColor = false;
            this.Vemail.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(696, 449);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.Vemail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.mskIdade);
            this.Controls.Add(this.btnAtt);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vcnpj);
            this.Controls.Add(this.vcpf);
            this.Controls.Add(this.mskCnpj);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.mskEmail);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroCliente";
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vcnpj;
        private System.Windows.Forms.Button vcpf;
        private System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.MaskedTextBox mskEmail;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox mskIdade;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button Vemail;
    }
}

