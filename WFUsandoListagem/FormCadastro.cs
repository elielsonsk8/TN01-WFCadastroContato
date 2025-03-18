using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUsandoListagem
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();

        }
        public void LimparFormulario()
        {
            txtLoginCadastro.Clear();
            txtSenhaCadastro.Clear();
            txtSenhaCadastro.Clear();
           
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Login = txtLoginCadastro.Text;
            user.Senha = txtSenhaCadastro.Text;
            user.DataCadastro = DateTime.Now;
            user.Codigo = Usuario.ListaUsuario.Count + 1;
           
            
            string confirmSenha = txtConfirmarSenha.Text;

            if (string.IsNullOrEmpty(user.Login) || string.IsNullOrEmpty(user.Senha) || string.IsNullOrEmpty(confirmSenha))
            {
                MessageBox.Show("Login ou senha não podem estar vazios.");
                return;
            }

            if (user.Senha == confirmSenha)
            {
                Usuario.ListaUsuario.Add(user);

                MessageBox.Show("Cadastro realizado com sucesso!", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparFormulario();
                Close();

            } else
            {
                MessageBox.Show("As senhas não batem.");
            }
        }
    }
}
