using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoNB;


            //Validação de campos obrigatorios
            if (string.IsNullOrWhiteSpace(txtnumerocadastrado.Text))
            {
                MessageBox.Show("Por favor, preencha o número de cadastro. ");
                return; //Interrompe a execução do código caso o campo esteja vazio
            }
            if (string.IsNullOrWhiteSpace(txtnumerocadastrado.Text))
            {
                MessageBox.Show("Por favor, preencha o nome completo. ");
                return; //Interrompe a execução do código caso o campo esteja vazio

            }
            if (comboBoxCidade.SelectedIndex == null)
            {
                MessageBox.Show("por favor,selecione a cidade");
                return;
            }

            if (!rbFeminino.Checked && !rbMasculino.Checked && !rbNaoBinario.Checked)
            {
                MessageBox.Show("por favor,selecione a gênero.");
                return;
            }

            //Agora,caso todos os campos estejam preenchidos,a validação prossegue
            numeroCadastro = Convert.ToInt32(txtnumerocadastrado.Text);
            nomeUsuario = txtNomeCompleto.Text;
            dataNascimento = dateTimePicker1.Value;
            cidade = comboBoxCidade.Text;
            generoF = rbFeminino.Checked;
            generoM = rbMasculino.Checked;
            generoNB = rbNaoBinario.Checked;

            //Formatar a data para exibir apenas a data (sem a hora)
            string dataFormatada = dataNascimento.ToString("dd/MM/yyyy");

            //Determinar o gênero selecionado
            string generoSelecionado = "Não informado"; //Caso nenhum gênero seja selecionado

            if (generoF)
                generoSelecionado = "Feminino";
            else if (generoM)
                generoSelecionado = "Masculino";
            else
                generoSelecionado = "Não Binario";

            //Exibir as Informacões em Messagebox
            MessageBox.Show("Número cadastrado: " + numeroCadastro);
            MessageBox.Show("nome: " + nomeUsuario);
            MessageBox.Show("Data de Nascimento: " + dataFormatada);
            MessageBox.Show("Cidade: " + cidade);
            MessageBox.Show("Gênero; " + generoSelecionado);

        }

        private void txtnumerocadastrado_Leave(object sender, EventArgs e)
        {
            txtnumerocadastrado.Clear();
        }

        private void txtNomeCompleto_Leave(object sender, EventArgs e)
        {
            txtNomeCompleto.Clear();
        }
    }        
}
