namespace WFCadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            CarregarLista();
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

        private void CarregarLista()
        {
            Usuario.ListaUsuario.Add(
                new Usuario
                {
                    Codigo = 0001,
                    Login = "admin",
                    Senha = "123456",
                    DataCadastro = Convert.ToDateTime("10/01/2025 18:30"),

                }
            );
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Login = txtLogin.Text;
            user.Senha = txtSenha.Text;


            if (string.IsNullOrEmpty(user.Login) || string.IsNullOrEmpty(user.Senha))
            {
                Erro("Login ou senha não podem estar vazios.");
                return;
            }

            bool loginValido = false;

            foreach (var pessoa in Usuario.ListaUsuario)
            {

                if (pessoa == null)
                {
                    continue;
                }


                if (user.Login == pessoa.Login && user.Senha == pessoa.Senha)
                {
                    Sucesso("Login efetuado com sucesso!");
                    loginValido = true;

                    FormMenu form = new FormMenu();
                    form.ShowDialog();

                    txtLogin.Clear();
                    txtSenha.Clear();
                    Close();


                    return;
                }

            }

            if (!loginValido)
            {
                Erro("Erro ao efetuar login! Verifique suas credenciais.");
            }
        }

        
    }
}
