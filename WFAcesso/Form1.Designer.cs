namespace WFAcesso
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsusario = new TextBox();
            txtSenha = new TextBox();
            lblUsuario = new Label();
            lblSenha = new Label();
            btnLogar = new Button();
            SuspendLayout();
            // 
            // txtUsusario
            // 
            txtUsusario.Location = new Point(49, 52);
            txtUsusario.Name = "txtUsusario";
            txtUsusario.Size = new Size(212, 23);
            txtUsusario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(49, 119);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(212, 23);
            txtSenha.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(53, 29);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(53, 101);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(118, 182);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 4;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnCriar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 273);
            Controls.Add(btnLogar);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtUsusario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsusario;
        private TextBox txtSenha;
        private Label lblUsuario;
        private Label lblSenha;
        private Button btnLogar;
    }
}
