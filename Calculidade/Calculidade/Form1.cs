using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculidade
{
    public partial class frmCalcularidade : Form
    {
        public frmCalcularidade()
        {
            InitializeComponent();
        }

        private void txtAnoAtual_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verifica se a tecla pressionada é Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Enter pressionado!");

                // Evitar o "bip" do sistema ao pressionar Enter
                e.Handled = true;

                //Declara as variáveis
                int anonascimento, anoatual, idade;

                //Tenta converter os valores digitados
                if (int.TryParse(txtAnoNasc.Text, out anonascimento) && int.TryParse(txtAnoAtual.Text, out anoatual))
                {
                    idade = anoatual - anonascimento;
                    lblIdade.Text = idade.ToString();
                }
                else
                {
                    MessageBox.Show("Digite número válidos!");
                }
            } 
        }    
    }
}
