using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace TCC.SDC
{
    public partial class Frm_criarturma : Form
    {
        public Frm_criarturma()
        {
            InitializeComponent();
        }

        private void btn_criarturma_Click(object sender, EventArgs e)
        {



            string connectionString = "Server=localhost;Database=senai;Uid=root;Pwd=123;";

            MySqlConnection conexao = new MySqlConnection(connectionString);

            try
            {
                conexao.Open();

                // Obtenha o nome da tabela da TextBox
                string nomeDaTabela = txt_criarturma.Text.Trim();


                if (string.IsNullOrEmpty(nomeDaTabela))
                {
                    MessageBox.Show("Por favor, insira um nome para a turma.");
                    return;
                }

                string criarTabelaSQL = $"CREATE TABLE IF NOT EXISTS {nomeDaTabela} (" +
                    "ID INT AUTO_INCREMENT PRIMARY KEY," +
                    "id_aluno INT(20)," +
                    "id_professor INT(20)," +
                    "Nome VARCHAR(255)," +
                    "cpf VARCHAR(15)," +
                    "Turma VARCHAR(100)," +
                    "ncadastro INT(50)," +
                    "Presença VARCHAR(50)," +
                    "Função VARCHAR(100)," +
                    "data_hora_entrada datetime," +
                    "data_hora_saida datetime," +
                    "Ausencia VARCHAR(15)," +
                    "foto BLOB," +
                    "senha INT (10))";


                MySqlCommand cmd = new MySqlCommand(criarTabelaSQL, conexao);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Turma '{nomeDaTabela}' criada com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao criar a turma, não deixar espaços entre as palavras:  ");
                
            }
            finally
            {
                conexao.Close();
            }

            


        }

        private void btn_excluirturma_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost;Database=senai;Uid=root;Pwd=123;";

            MySqlConnection conexao = new MySqlConnection(connectionString);

            try
            {
                using (conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();


                    {
                        // Nome da tabela que você deseja excluir
                        string nomeTabela = $"{txt_criarturma.Text}";

                        string query = $"DROP TABLE {nomeTabela}";

                        MySqlCommand comando = new MySqlCommand(query, conexao);
                        comando.ExecuteNonQuery();

                        MessageBox.Show($"A turma {nomeTabela} foi excluída com sucesso!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar a turma: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

       





    }
} 



            

                 


                  

           
            
        
    





        
    
    

