using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCC.SDC
{
    public partial class Frm_listapresencaturma : Form
    {
        DataTable Dt = new DataTable();

        private MySqlConnection connection;
        public Frm_listapresencaturma()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            Dt.Columns.Add("ID", typeof(string));
            Dt.Columns.Add("id_aluno", typeof(string));
            Dt.Columns.Add("Nome", typeof(string));
            Dt.Columns.Add("Turma", typeof(string));           
            Dt.Columns.Add("Função", typeof(string));
            Dt.Columns.Add("Presença", typeof(string));
            Dt.Columns.Add("Entrada", typeof(string));
            Dt.Columns.Add("Saida", typeof(string));
            Dt.Columns.Add("Ausencia", typeof(string));



            dgv_listapresencaturma.DataSource = Dt;
        }


       

        private void dgv_listapresencaturma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_consultarpresencaturma_Click(object sender, EventArgs e)
        {
            // Configuração da conexão com o MySQL
            string connectionString = "Server=localhost;Database=senai;Uid=root;Pwd=123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Comando SQL para selecionar os dados da tabela
            string sqlQuery = $"SELECT ID,id_aluno,Nome, Turma, Presença, Função, data_hora_entrada, data_hora_saida, Ausencia FROM {txt_nometurma.Text}";

            // Crie um adaptador de dados
            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection);

            // Crie um objeto DataTable para armazenar os resultados
            DataTable dataTable = new DataTable();


            try
            {
                // Abra a conexão com o banco de dados
                connection.Open();

                // Preencha o DataTable com os dados do adaptador
                adapter.Fill(dataTable);

                // Associe o DataTable ao DataGridView
                dgv_listapresencaturma.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Trate qualquer exceção que possa ocorrer durante a operação de banco de dados
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                // Certifique-se de fechar a conexão, independentemente de ocorrer uma exceção ou não
                connection.Close();
            }

          dgv_listapresencaturma.ReadOnly = false;

            // Manipule o evento CellDoubleClick para atualizar os dados

        }

    }
    }


    

