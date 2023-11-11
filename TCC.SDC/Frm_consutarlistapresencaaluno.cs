using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.SDC
{
    public partial class Frm_consutarlistapresencaaluno : Form
    {

        DataTable dt = new DataTable();
        private MySqlConnection Connection;
        public Frm_consutarlistapresencaaluno()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("id_aluno", typeof(string));
            dt.Columns.Add("id_professor", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Turma", typeof(string));
            dt.Columns.Add("Função", typeof(string));
            dt.Columns.Add("Presença", typeof(string));
            dt.Columns.Add("Entrada", typeof(string));
            dt.Columns.Add("Saida", typeof(string));
            dt.Columns.Add("Ausencia", typeof(string));



            dgv_listapresencaalunos.DataSource = dt;
        }

        private void btn_consultarlistaaluno_Click(object sender, EventArgs e)
        {
            
                string nomealuno = txt_nomedoaluno.Text;
                string nometurmaaluno = txt_listadepresencaturma.Text;
                string senhaaluno = txt_senhadoaluno.Text;

                // Configurar a string de conexão
                string connectionString = "Server=localhost;Database=senai;Uid=root;Pwd=123;";

                // Criar uma instância de MySqlConnection
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Consulta SQL para selecionar os dados do aluno com base no nome, turma e senha
                        string sqlQuery = $"SELECT ID, id_aluno, Nome, Turma, Função,Presença, data_hora_entrada, data_hora_saida, Ausencia FROM {nometurmaaluno} WHERE Nome = @nome AND Senha = @senha";
                        MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                        command.Parameters.AddWithValue("@nome", nomealuno);
                        command.Parameters.AddWithValue("@senha", senhaaluno);

                        // Crie um adaptador de dados
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                        // Crie um objeto DataTable para armazenar os resultados
                        DataTable dataTable = new DataTable();

                        // Preencha o DataTable com os dados do adaptador
                        adapter.Fill(dataTable);

                        // Associe o DataTable ao DataGridView (dgv_listapresencaturma)
                        dgv_listapresencaalunos.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao consultar o banco de dados: " + ex.Message);
                    }
                    finally
                    {
                        // Certifique-se de fechar a conexão, independentemente de ocorrer uma exceção ou não
                        connection.Close();
                    }
                }
            

        }
    }
}
