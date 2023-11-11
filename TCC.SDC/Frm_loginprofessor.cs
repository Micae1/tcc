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
    public partial class Frm_loginprofessor : Form
    {
        public Frm_loginprofessor()
        {
            InitializeComponent();
        }

        private void btn_loginprofessor_Click(object sender, EventArgs e)
        {
            

            string nomeprofessor = txt_nomeloginprofessor.Text;
            string nometurmaprofessor =txt_nometurmaprofessor.Text;
            string senhaprofessor = txt_senhaloginprofessor.Text;



            // Configurar a string de conexão
            string connectionString =  "server=localhost;user id=root;database=senai;password=123";



            // Criar uma instância de MySqlConnection
            MySqlConnection conexao = new MySqlConnection(connectionString);

            try
            {
                conexao.Open();

                // Consulta SQL para verificar as credenciais
                string consulta = $"SELECT * FROM cadastro_professor WHERE Nome = @nome AND Senha = @senha AND Turma = @turma";
                MySqlCommand comando = new MySqlCommand(consulta, conexao);
                comando.Parameters.AddWithValue("@nome", nomeprofessor);
                comando.Parameters.AddWithValue("@turma", nometurmaprofessor);
                comando.Parameters.AddWithValue("@senha", senhaprofessor);

                int resultado = Convert.ToInt32(comando.ExecuteScalar());

                this.Close();

                if (resultado > 0)
                {
                    
                    MessageBox.Show("Login bem-sucedido!");
                    // Faça o que for necessário após o login bem-sucedido
                    Frm_listapresencaprofessor T = new Frm_listapresencaprofessor();
                    T.Show();

                }


                else
                {
                   


                    MessageBox.Show("Nome, senha ou Turma inválidas. Tente novamente.");
                    // Limpe os campos de entrada ou tome outras ações apropriadas
                    txt_nomeloginprofessor.Focus();
                    txt_nomeloginprofessor.Text = "";
                    txt_senhaloginprofessor.Text = "";
                    txt_nometurmaprofessor.Text = "";
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

