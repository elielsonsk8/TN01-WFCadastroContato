using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastroContato
{
    public partial class FormContato : Form
    {
        public FormContato()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeCompleto = txtNomeCompleto.Text;
            string sobreNome = txtSobreNome.Text;
            string phone = mkdTelefone.Text;
            string tipoTelefone = "";
            string email = txtEmail.Text;

            if (rdbComercial.Checked == true) {
                tipoTelefone = "Comercial";
            } else if (rdbPessoal.Checked == true) {
                tipoTelefone = "Pessoal";
            } else if (rdbRecado.Checked == true)
            {
                tipoTelefone = "Recado";
            } else
            {
                MessageBox.Show("Erro!");
                return;
            }




            string message = $"nome completo:{nomeCompleto} \n sobreNome: {sobreNome} \n telefone: {phone} \n tipo de telefone: {tipoTelefone} \n email: {email}";


            if (nomeCompleto == "" || sobreNome == "" || phone == "" || tipoTelefone == "" || email == "")
            {
                MessageBox.Show("Preencha todos os campos");
            } else
            {

             MessageBox.Show(message);
            }

 

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
