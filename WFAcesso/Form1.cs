namespace WFAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
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
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CarregarLista()
        {
            Usuario.ListaUsuario.Add(
                new Usuario
                {
                    Codigo = 001,
                    Login = "admin",
                    Senha = "admin",
                    DataCadastro = DateTime.Now,

                }

                );

            Usuario.ListaUsuario.Add(
                new Usuario
                {
                    Codigo = 002,
                    Login = "user",
                    Senha = "user",
                    DataCadastro = DateTime.Now,

                }

                );
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Login = txtUsusario.Text;
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

                
                if (user.Login == pessoa.Login && user.Senha == pessoa.Senha )
                {
                    Sucesso("Login efetuado com sucesso!");
                    loginValido = true;  
                    break;  
                } 
            }

            
            if (!loginValido)
            {
                Erro("Erro ao efetuar login! Verifique suas credenciais.");
            }


        }
    }
}
