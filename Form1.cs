using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

//acessando o pacote do mysql

using MySql.Data.MySqlClient;

namespace crud

{

    public partial class frmCadastrodeClientes : Form

    {

        //Conexão com o banco de dados MySQl

        MySqlConnection Conexao;

        string data_source = "datasource=localhost; username=root; password=; database=db_cadastro";
        private object txtNomeCompleto;
        private object txtNomeSocial;
        private object txtEmail;
        private object txtCPF;
        private object lstCliente;

        public object TabControl1 { get; private set; }

        public frmCadastrodeClientes()

        {

            InitializeComponent();

            //Configuração inicial do ListView para exibição dos dados dos clientes

            LstCliente.View = View.Details;  //Define a visualização em "detalhes"

            LstCliente.LabelEdit = true; //Permite editar os títulos das colunas

            LstCliente.AllowColumnReorder = true; //Permite reordenar as colunas

            LstCliente.FullRowSelect = true; //Seleciona a linha inteira ao clicar

            LstCliente.GridLines = true; //Exibe as linhas de grade no ListView


            //Definindo as colunas do Listview

            LstCliente.Columns.Add("Código", 100, HorizontalAlignment.Left); // Coluna do código

            LstCliente.Columns.Add("Nome Completo", 200, HorizontalAlignment.Left); //Coluna de Nome Completo

            LstCliente.Columns.Add("Nome Social", 200, HorizontalAlignment.Left); //Coluna de Nome Social

            LstCliente.Columns.Add("E-mail", 200, HorizontalAlignment.Left); // Coluna de E-mail

            LstCliente.Columns.Add("CPF", 200, HorizontalAlignment.Left); //Coluna de CPF

            //Carrega os dados dos clientes na interface

            carregar_clientes();

        }

        private void btnSalvar_Click(object sender, EventArgs e)

        {

            try

            {

                //Validando campos obrigatórios

                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||

                    string.IsNullOrEmpty(txtEmail.Text.Trim()) ||

                    string.IsNullOrEmpty(txtCPF.Text.Trim()))

                {

                    MessageBox.Show("Todos os campos devem ser preenchidos.",

                                    "Validação",

                                    MessageBoxButtons.OK,

                                    MessageBoxIcon.Warning);

                    return; // Impede o prosseguimento se algum campo estiver vazio

                }

                //validação do CPF

                string cpf = txtCPF.Text.Trim();

                if (!isValidCPFLength(cpf))

                {

                    MessageBox.Show("CPF inválido. Certifique-se de que o CPF tenha 11 dígitos númericos.",

                        "Validação de CPF",

                        MessageBoxButtons.OK,

                        MessageBoxIcon.Warning);

                    return; // Impede o prosseguimento se o CPF for inválido

                }

                //Cria a conexão com o banco de dados

                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                //Comando SQL para inserir um novo cliente no banco de dados

                MySqlCommand cmd = new MySqlCommand

                {

                    Connection = Conexao

                };

                cmd.Prepare();

                cmd.CommandText = "INSERT INTO dadosdocliente(nomecompleto, nomesocial, email, cpf) " +

                "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";

                //Adiciona os parâmetros com os dados do formulário

                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());

                cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());

                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim());

                //Executa o comando de inserção no banco

                cmd.ExecuteNonQuery();

                //Mensagem de sucesso

                MessageBox.Show("Contato inserido com Sucesso: ",

                                "Sucesso",

                                MessageBoxButtons.OK,

                                MessageBoxIcon.Information);

                //Limpa os campos após o sucesso
                txtNomeCompleto.text = String.Empty;
                txtNomeSocial.text = "";
                txtEmail.text = "";
                txtCPF.Text = "";

                //REcarrega os clientes na ListVIew
                carregar_clientes();

                //Muda para a aba de consulta 
                TabControl1.SelectedIndex = 1;


            }

            catch (MySqlException ex)

            {

                //Trata erros relacionados ao MySQL

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,

                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception ex)

            {

                //Trata outros tipos de erro

                MessageBox.Show("Ocorreu: " + ex.Message,

                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally

            {

                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro

                if (Conexao != null && Conexao.State == ConnectionState.Open)

                {

                    Conexao.Close();

                }

            }

        }

        // Função para validar o comprimento e formato do CPF

        private bool isValidCPFLength(string cpf)

        {

            // Remove todos os caracteres não numéricos

            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se o CPF tem exatamente 11 dígitos

            return cpf.Length == 11;

        }
          

        private void btnPesquisar_Click(object sender, EventArgs e)

        {
            string query = "SELECT * FROM dadosdocliente WHERE nomecompleto LIKE @q OR nomesocial LIKE @q ORDER BY codigo DESC";
            carregar_clientes_com_query(query);
        }

        private void carregar_clientes_com_query(string query)

        {

            try

            {

                //Cria a conexão com o banco de dados

                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                //Executa a consulta SQL fornecida

                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //Se a consulta contém o parâmetro @q, adiciona o valor da caixa de pesquisa

                if (query.Contains("@q"))

                {

                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");

                }

                //Executa o comando e obtém os resultados

                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os itens existentes no Listview antes de adicionar novos

                LstCliente.Items.Clear();

                //Preenche o ListView com os dados dos clientes

                while (reader.Read())

                {

                    //Cria uma linha para cada cliente com os dados retornados da consulta

                    string[] row =

                    {

                        Convert.ToString(reader.GetInt32(0)), //Código

                        reader.GetString(1),                  //Nome Completo

                        reader.GetString(2),                  //Nome Social

                        reader.GetString(3),                  //E-mail

                        reader.GetString(4)                   //CPF

                    };

                    //Adiciona a linha ao ListView

                    LstCliente.Items.Add(new ListViewItem(row));

                }

            }

            catch (MySqlException ex)

            {

                //Trata erros relacionados ao MySQL

                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,

                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception ex)

            {

                //Trata outros tipos de erro

                MessageBox.Show("Ocorreu: " + ex.Message,

                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally

            {

                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro

                if (Conexao != null && Conexao.State == ConnectionState.Open)

                {

                    Conexao.Close();

                }

            }

        }

        private void carregar_clientes()

        {

            string query = "SELECT * FROM dadosdocliente ORDER BY codigo DESC";

            carregar_clientes_com_query(query);

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {

        }
    }

}




