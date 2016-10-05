namespace Clientes
{
    partial class frmPrincipal
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
            this.bntBuscarNome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboUf = new System.Windows.Forms.ComboBox();
            this.bntBuscarId = new System.Windows.Forms.Button();
            this.bntNovo = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntBuscarNome
            // 
            this.bntBuscarNome.Location = new System.Drawing.Point(361, 89);
            this.bntBuscarNome.Name = "bntBuscarNome";
            this.bntBuscarNome.Size = new System.Drawing.Size(53, 23);
            this.bntBuscarNome.TabIndex = 0;
            this.bntBuscarNome.Text = "Buscar";
            this.bntBuscarNome.UseVisualStyleBackColor = true;
            this.bntBuscarNome.Click += new System.EventHandler(this.bntBuscarNome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CNPJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Logradouro";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(78, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(134, 20);
            this.txtId.TabIndex = 6;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Enabled = false;
            this.txtCnpj.Location = new System.Drawing.Point(78, 118);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(134, 20);
            this.txtCnpj.TabIndex = 7;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(79, 145);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(335, 20);
            this.txtLogradouro.TabIndex = 8;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(79, 171);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(79, 198);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(79, 224);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CEP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "UF";
            // 
            // cboUf
            // 
            this.cboUf.DisplayMember = "UF";
            this.cboUf.Enabled = false;
            this.cboUf.FormattingEnabled = true;
            this.cboUf.Location = new System.Drawing.Point(79, 251);
            this.cboUf.Name = "cboUf";
            this.cboUf.Size = new System.Drawing.Size(40, 21);
            this.cboUf.TabIndex = 16;
            this.cboUf.ValueMember = "id";
            // 
            // bntBuscarId
            // 
            this.bntBuscarId.Location = new System.Drawing.Point(218, 63);
            this.bntBuscarId.Name = "bntBuscarId";
            this.bntBuscarId.Size = new System.Drawing.Size(49, 23);
            this.bntBuscarId.TabIndex = 17;
            this.bntBuscarId.Text = "Buscar";
            this.bntBuscarId.UseVisualStyleBackColor = true;
            this.bntBuscarId.Click += new System.EventHandler(this.bntBuscarId_Click);
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(12, 12);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(75, 23);
            this.bntNovo.TabIndex = 18;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Enabled = false;
            this.bntEditar.Location = new System.Drawing.Point(93, 12);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(75, 23);
            this.bntEditar.TabIndex = 19;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.Enabled = false;
            this.bntSalvar.Location = new System.Drawing.Point(174, 12);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 23);
            this.bntSalvar.TabIndex = 20;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Enabled = false;
            this.bntCancelar.Location = new System.Drawing.Point(255, 12);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(75, 23);
            this.bntCancelar.TabIndex = 21;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 284);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.bntBuscarId);
            this.Controls.Add(this.cboUf);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntBuscarNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntBuscarNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bntBuscarId;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button bntCancelar;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtCnpj;
        public System.Windows.Forms.TextBox txtLogradouro;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtCep;
        public System.Windows.Forms.ComboBox cboUf;
    }
}

