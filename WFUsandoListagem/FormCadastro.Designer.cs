namespace WFUsandoListagem
{
    partial class FormCadastro
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
            lblLoginCadastro = new Label();
            txtLoginCadastro = new TextBox();
            txtSenhaCadastro = new TextBox();
            lblSenhaCadastro = new Label();
            txtConfirmarSenha = new TextBox();
            lblConfirmarSenha = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblLoginCadastro
            // 
            lblLoginCadastro.AutoSize = true;
            lblLoginCadastro.Location = new Point(33, 33);
            lblLoginCadastro.Name = "lblLoginCadastro";
            lblLoginCadastro.Size = new Size(40, 15);
            lblLoginCadastro.TabIndex = 0;
            lblLoginCadastro.Text = "Login:";
            // 
            // txtLoginCadastro
            // 
            txtLoginCadastro.Location = new Point(33, 51);
            txtLoginCadastro.Name = "txtLoginCadastro";
            txtLoginCadastro.PlaceholderText = "Informe um login";
            txtLoginCadastro.Size = new Size(176, 23);
            txtLoginCadastro.TabIndex = 1;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Location = new Point(33, 107);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PlaceholderText = "Informe uma senha";
            txtSenhaCadastro.Size = new Size(176, 23);
            txtSenhaCadastro.TabIndex = 3;
            // 
            // lblSenhaCadastro
            // 
            lblSenhaCadastro.AutoSize = true;
            lblSenhaCadastro.Location = new Point(33, 89);
            lblSenhaCadastro.Name = "lblSenhaCadastro";
            lblSenhaCadastro.Size = new Size(42, 15);
            lblSenhaCadastro.TabIndex = 2;
            lblSenhaCadastro.Text = "Senha:";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(33, 166);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PlaceholderText = "Confirme a senha";
            txtConfirmarSenha.Size = new Size(176, 23);
            txtConfirmarSenha.TabIndex = 5;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(33, 148);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(95, 15);
            lblConfirmarSenha.TabIndex = 4;
            lblConfirmarSenha.Text = "Confirmar senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(88, 223);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 326);
            Controls.Add(btnCadastrar);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(txtSenhaCadastro);
            Controls.Add(lblSenhaCadastro);
            Controls.Add(txtLoginCadastro);
            Controls.Add(lblLoginCadastro);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoginCadastro;
        private TextBox txtLoginCadastro;
        private TextBox txtSenhaCadastro;
        private Label lblSenhaCadastro;
        private TextBox txtConfirmarSenha;
        private Label lblConfirmarSenha;
        private Button btnCadastrar;
    }
}