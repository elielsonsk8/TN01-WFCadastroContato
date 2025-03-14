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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormContato form = new FormContato();
            form.ShowDialog();
        }

        private void mnsListagem_Click(object sender, EventArgs e)
        {
            FormListagem form = new FormListagem();
            form.ShowDialog();
        }
    }
}
