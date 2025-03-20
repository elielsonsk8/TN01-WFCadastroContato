using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
            CarregarProduto();

        }

        public void LimparFormulario()
        {
            txtNomeProduto.Clear();
            txtCodigo.Clear();
            txtObservacao.Clear();
           
            
            
        }

        private void CarregarProduto()
        {
            Produto.ListaProduto.Add(
               new Produto
               {
                   Codigo = "01",
                   Nome = "Uva",
                   Preco = 1000,
                   DataVencimento = Convert.ToDateTime("10/10/2025 18:35"),
                   Observacao = "Próximo ao vencimento",
                   Categoria = "Fruta"
                   
               }
           );
        }

        public void Sucesso(string mensagem = "")
        {
            MessageBox.Show(mensagem, "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Erro(string mensagem = "")
        {
            MessageBox.Show(mensagem, "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                Erro("Campo Nome não pode estar Vazio!");
                return;
            }
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                Erro("Campo Código não pode estar Vazio!");
                return;
            }
            if (string.IsNullOrEmpty(txtObservacao.Text))
            {
                Erro("Campo Observação não pode estar Vazio!");
                return;
            }
            if (string.IsNullOrEmpty(nupPreco.Text))
            {
                Erro("Campo Preço não pode estar Vazio!");
                return;
            }
            if (string.IsNullOrEmpty(dtpDataVencimento.Text))
            {
                Erro("Campo Data de vencimento não pode estar Vazio!");
                return;
            }
            if (string.IsNullOrEmpty(cbxCategoria.Text))
            {
                Erro("Campo Categoria não pode estar Vazio!");
                return;
            }

            Produto product = new Produto();

            product.Codigo = txtCodigo.Text;
            product.Nome = txtNomeProduto.Text;
            product.Preco = (double?)nupPreco.Value;
            product.DataVencimento = DateTime.Now;
            product.Observacao = txtObservacao.Text;
            product.Categoria = cbxCategoria.SelectedItem.ToString();          
      
            Produto.ListaProduto.Add(product);

            Sucesso("Produto cadastrado!");
            LimparFormulario();
        }
    }
}
