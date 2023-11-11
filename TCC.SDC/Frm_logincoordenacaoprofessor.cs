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
    public partial class Frm_logincoordenacaoprofessor : Form
    {
        public Frm_logincoordenacaoprofessor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_coordenacaologinprofessor_Click(object sender, EventArgs e)
        {
            string nomecoordenacaoprofessor = txt_coordenacaonomeprofessor.Text;
            string senhacoordenacaoprofessor = txt_coordenacaosenhaprofessor.Text;



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
                comando.Parameters.AddWithValue("@nome", nomecoordenacaoprofessor);
                comando.Parameters.AddWithValue("@senha", senhacoordenacaoprofessor);

                int resultado = Convert.ToInt32(comando.ExecuteScalar());
                this.Close();

                if (resultado > 0)
                {

                    MessageBox.Show("Login bem-sucedido!");
                    // Faça o que for necessário após o login bem-sucedido
                    Frm_cadastroprofessor T = new Frm_cadastroprofessor();
                    T.Show();
                    
                }


                else
                {



                    MessageBox.Show("Nome ou senha inválidas. Tente novamente.");
                    // Limpe os campos de entrada ou tome outras ações apropriadas
                    txt_coordenacaonomeprofessor.Focus();
                    txt_coordenacaonomeprofessor.Text = "";
                    txt_coordenacaosenhaprofessor.Text = "";
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
                

            
        
}   }



            



