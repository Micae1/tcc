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
    public partial class Frm_logincoordenacaocriarturma : Form
    {
        public Frm_logincoordenacaocriarturma()
        {
            InitializeComponent();
        }

        private void btn_logincoordenacaocriarturma_Click(object sender, EventArgs e)
        {
            //verifica se a senha e o nome da coordenação estão registrados e da a liberação
            //para ir cadastrar o aluno
            string nomecoordenadoraluno = txt_nomecoordenacaocriarturma.Text;
            string senhacoordenadoraluno = txt_senhacoordenacaocriarturma.Text;



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
                    Frm_criarturma T = new Frm_criarturma();
                    T.Show();

                }

                
                else
                {



                    MessageBox.Show("Nome ou senha inválidas. Tente novamente.");
                    // Limpe os campos de entrada ou tome outras ações apropriadas
                   txt_nomecoordenacaocriarturma.Focus();
                   txt_nomecoordenacaocriarturma.Text = "";
                   txt_senhacoordenacaocriarturma.Text = "";
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
