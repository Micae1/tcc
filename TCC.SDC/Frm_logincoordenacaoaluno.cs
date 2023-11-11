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
    public partial class Frm_logincoordenacaoaluno : Form
    {
        public Frm_logincoordenacaoaluno()
        {
            InitializeComponent();
        }

        private void btn_ligincoordenacaoaluno_Click(object sender, EventArgs e)
        {//verifica se a senha e o nome da coordenação estão registrados e da a liberação
         //para ir cadastrar o aluno
            string nomecoordenadoraluno = txt_coordenacaonomealuno.Text;
            string senhacoordenadoraluno = txt_coordenacaosenhaaluno.Text;



            // Configurar a string de conexão
            string connectionString = "server=localhost;user id=root;database=senai;password=123";



            // Criar uma instância de MySqlConnection
            MySqlConnection conexao = new MySqlConnection(connectionString);

            try
            {
                conexao.Open();

                // Consulta SQL para verificar as credenciais
                string consulta = "SELECT * FROM coordenacao WHERE Nome = @nome AND Senha = @senha";
                MySqlCommand comando = new MySqlCommand(consulta, conexao);
                comando.Parameters.AddWithValue("@nome", nomecoordenadoraluno);
                comando.Parameters.AddWithValue("@senha", senhacoordenadoraluno);

                int resultado = Convert.ToInt32(comando.ExecuteScalar());
                this.Close();

                if (resultado > 0)
                {

                    MessageBox.Show("Login bem-sucedido!");
                    // Faça o que for necessário após o login bem-sucedido
                    Frm_cadastroaluno T = new Frm_cadastroaluno();
                    T.Show();

                }


                else
                {



                    MessageBox.Show("Nome ou senha inválidas. Tente novamente.");
                    // Limpe os campos de entrada ou tome outras ações apropriadas
                    txt_coordenacaonomealuno.Focus();
                    txt_coordenacaonomealuno.Text = "";
                    txt_coordenacaosenhaaluno.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

        
    }
}
