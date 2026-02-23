using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcuçadora__tef
{
    public partial class calculadora : Form
    {
        private object txtResultado;

        public calculadora()
        {
            InitializeComponent();
        }
        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btnsete_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnUm_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            textBox1.Text = result + "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
