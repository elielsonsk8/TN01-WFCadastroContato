namespace WFCadastroProduto
{
    partial class FormCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblCategoria = new Label();
            txtNomeProduto = new TextBox();
            lblNomeProduto = new Label();
            lblDataVencimento = new Label();
            lblPreco = new Label();
            dtpDataVencimento = new DateTimePicker();
            cbxCategoria = new ComboBox();
            nupPreco = new NumericUpDown();
            lblObservacao = new Label();
            txtObservacao = new TextBox();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)nupPreco).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(76, 31);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(53, 64);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Código";
            txtCodigo.Size = new Size(126, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(250, 31);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(53, 134);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.PlaceholderText = "Nome do produto";
            txtNomeProduto.Size = new Size(356, 23);
            txtNomeProduto.TabIndex = 5;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(163, 116);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(103, 15);
            lblNomeProduto.TabIndex = 4;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Location = new Point(250, 186);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(113, 15);
            lblDataVencimento.TabIndex = 8;
            lblDataVencimento.Text = "Data de Vencimento";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(76, 186);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço";
            // 
            // dtpDataVencimento
            // 
            dtpDataVencimento.Format = DateTimePickerFormat.Short;
            dtpDataVencimento.Location = new Point(235, 216);
            dtpDataVencimento.Name = "dtpDataVencimento";
            dtpDataVencimento.Size = new Size(174, 23);
            dtpDataVencimento.TabIndex = 9;
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Frutas", "Legumes", "Verduras", "Hortaliças", "Ervas" });
            cbxCategoria.Location = new Point(235, 64);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(174, 23);
            cbxCategoria.TabIndex = 10;
            // 
            // nupPreco
            // 
            nupPreco.DecimalPlaces = 2;
            nupPreco.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nupPreco.Location = new Point(53, 220);
            nupPreco.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nupPreco.Name = "nupPreco";
            nupPreco.Size = new Size(120, 23);
            nupPreco.TabIndex = 11;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(173, 275);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(69, 15);
            lblObservacao.TabIndex = 12;
            lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(53, 303);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PlaceholderText = "Observação sobre o produto";
            txtObservacao.Size = new Size(356, 83);
            txtObservacao.TabIndex = 13;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(173, 425);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 43);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 521);
            Controls.Add(btnSalvar);
            Controls.Add(txtObservacao);
            Controls.Add(lblObservacao);
            Controls.Add(nupPreco);
            Controls.Add(cbxCategoria);
            Controls.Add(dtpDataVencimento);
            Controls.Add(lblDataVencimento);
            Controls.Add(lblPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblCategoria);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProduto";
            Text = "FormCadastroProduto";
            ((System.ComponentModel.ISupportInitialize)nupPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblCategoria;
        private TextBox txtNomeProduto;
        private Label lblNomeProduto;
        private Label lblDataVencimento;
        private TextBox txtPreco;
        private Label lblPreco;
        private DateTimePicker dtpDataVencimento;
        private ComboBox cbxCategoria;
        private NumericUpDown nupPreco;
        private Label lblObservacao;
        private TextBox txtObservacao;
        private Button btnSalvar;
    }
}