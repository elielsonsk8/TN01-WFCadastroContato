namespace TN01_WFCadastroContato
{
    partial class FormContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContato));
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            txtSobreNome = new TextBox();
            lblSobreNome = new Label();
            label2 = new Label();
            mkdTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            gbxTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            label1 = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnSalvar = new Button();
            btnVoltar = new Button();
            gbxTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(25, 18);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(97, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome completo:";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(25, 36);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(182, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // txtSobreNome
            // 
            txtSobreNome.Location = new Point(227, 36);
            txtSobreNome.Name = "txtSobreNome";
            txtSobreNome.Size = new Size(216, 23);
            txtSobreNome.TabIndex = 3;
            // 
            // lblSobreNome
            // 
            lblSobreNome.AutoSize = true;
            lblSobreNome.Location = new Point(227, 18);
            lblSobreNome.Name = "lblSobreNome";
            lblSobreNome.Size = new Size(74, 15);
            lblSobreNome.TabIndex = 2;
            lblSobreNome.Text = "Sobre nome:";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(25, 75);
            label2.Name = "label2";
            label2.Size = new Size(418, 1);
            label2.TabIndex = 12;
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(25, 124);
            mkdTelefone.Mask = "(00) 90000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(160, 23);
            mkdTelefone.TabIndex = 13;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(25, 106);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(83, 15);
            lblTelefone.TabIndex = 14;
            lblTelefone.Text = "DDD/Telefone:";
            // 
            // gbxTelefone
            // 
            gbxTelefone.Controls.Add(rdbRecado);
            gbxTelefone.Controls.Add(rdbComercial);
            gbxTelefone.Controls.Add(rdbPessoal);
            gbxTelefone.Location = new Point(204, 106);
            gbxTelefone.Name = "gbxTelefone";
            gbxTelefone.Size = new Size(239, 54);
            gbxTelefone.TabIndex = 15;
            gbxTelefone.TabStop = false;
            gbxTelefone.Text = "Tipo de telefone:";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(166, 24);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(81, 22);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(11, 24);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(25, 182);
            label1.Name = "label1";
            label1.Size = new Size(418, 1);
            label1.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(25, 216);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(418, 23);
            txtEmail.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(25, 198);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email:";
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(329, 309);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(114, 52);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(168, 309);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(114, 52);
            btnVoltar.TabIndex = 20;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // FormContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 407);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(label1);
            Controls.Add(gbxTelefone);
            Controls.Add(mkdTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(label2);
            Controls.Add(txtSobreNome);
            Controls.Add(lblSobreNome);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            Name = "FormContato";
            Text = "FormContato";
            gbxTelefone.ResumeLayout(false);
            gbxTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private TextBox txtSobreNome;
        private Label lblSobreNome;
        private Label label2;
        private MaskedTextBox mkdTelefone;
        private Label lblTelefone;
        private GroupBox gbxTelefone;
        private Label label1;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnSalvar;
        private Button btnVoltar;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
    }
}