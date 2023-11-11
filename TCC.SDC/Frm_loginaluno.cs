using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.SDC
{
    

    public partial class Frm_loginaluno : Form
    {
        
        public Frm_loginaluno()
        {
            InitializeComponent();
        }

        private void btn_loginaluno_Click(object sender, EventArgs e)
        {
            


            string nomealuno = txt_nomealuno.Text;
            string nometurmaaluno = txt_nometurmaaluno.Text;
            string senhaaluno = txt_senhaaluno.Text;
            



            // Configurar a string de conexão
            string connectionString = "server=localhost;user id=root;database=senai;password=123";



            // Criar uma instância de MySqlConnection
            MySqlConnection conexao = new MySqlConnection(connectionString);

            try
            {
                conexao.Open();

                // Consulta SQL para verificar as credenciais
                string consulta = $"SELECT * FROM {txt_nometurmaaluno.Text} WHERE Nome = @nome AND Senha = @senha AND Turma = @turma";
                MySqlCommand comando = new MySqlCommand(consulta, conexao);
                comando.Parameters.AddWithValue("@nome", nomealuno);
                comando.Parameters.AddWithValue("@turma", nometurmaaluno);
                comando.Parameters.AddWithValue("@senha", senhaaluno);
         

                int resultado = Convert.ToInt32(comando.ExecuteScalar());

                this.Close();

                if (resultado > 0)
                {

                   

                   


                    MessageBox.Show("Login bem-sucedido!");
                    // Faça o que for necessário após o login bem-sucedido
                    Frm_listapresencaturma T = new Frm_listapresencaturma();
                    T.Show();
                    

                }


                else
                {



                    MessageBox.Show("Nome, senha ou Turma inválidas. Tente novamente.");
                    // Limpe os campos de entrada ou tome outras ações apropriadas
                    txt_nomealuno.Focus();
                    txt_nomealuno.Text = "";
                    txt_senhaaluno.Text = "";
                    txt_nometurmaaluno.Text = "";
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
