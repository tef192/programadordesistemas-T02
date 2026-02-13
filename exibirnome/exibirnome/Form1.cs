using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exibirnome
{
    public partial class FrmExibirNome : Form
    {
        public FrmExibirNome()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            MessageBox.Show("Meu nome é: " + " \n" + nome);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
