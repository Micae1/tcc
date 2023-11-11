using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCC.SDC
{
    public partial class Frm_cadastroaluno : Form

    {


        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=senai;Uid=root;Pwd=123;";


        public Frm_cadastroaluno()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }


        private void btn_excluiraluno_Click(object sender, EventArgs e)
        {
            // Configurar a string de conexão com o banco de dados
            string connectionString = "Server=localhost;Database=senai;User id=root;Pwd=123;";
            MySqlConnection conexao = new MySqlConnection(connectionString);



            string cpfaluno = txt_cpfaluno.Text;

            try
            {
                // Abrir a conexão com o banco de dados
                conexao.Open();

                // Consultar o banco de dados para encontrar o registro correspondente
                string consulta = $"DELETE FROM {txt_turmaaluno.Text} WHERE cpf =@CPF";
                MySqlCommand cmd = new MySqlCommand(consulta, conexao);
                cmd.Parameters.AddWithValue("@CPF", cpfaluno);

                string consult = $"DELETE FROM cadastro_aluno WHERE cpf =@CPF";
                MySqlCommand cm = new MySqlCommand(consult, conexao);
                cm.Parameters.AddWithValue("@CPF", cpfaluno);



                // Executar o comando de exclusão
                int linhasAfetadas = cmd.ExecuteNonQuery();
                int linhasAfetada = cm.ExecuteNonQuery();


                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado para exclusão.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o registro: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão com o banco de dados
                conexao.Close();
            }




        }

        private void btn_pesquisaraluno_Click(object sender, EventArgs e)
        {


            try
            {
                if (!txt_cpfaluno.Text.Equals(""))
                {
                    cadastroaluno cadaluno = new cadastroaluno();
                    cadaluno.CPF = txt_cpfaluno.Text;

                    MySqlDataReader reader = cadaluno.pesquisaraluno();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            //lblId.Text = reader["id"].ToString();
                            txt_id_aluno.Text = reader["id_aluno"].ToString();
                            txt_nomealuno.Text = reader["nome"].ToString();
                            txt_turmaaluno.Text = reader["turma"].ToString();
                            txt_senhaaluno.Text = reader["senha"].ToString();
                            txt_ncadastroaluno.Text = reader["ncadastro"].ToString();
                            txt_funcaoaluno.Text = reader["função"].ToString();





                        }
                        else
                        {
                            MessageBox.Show("aluno nao encontrado");
                            txt_id_aluno.Clear();
                            txt_cpfaluno.Clear();
                            txt_nomealuno.Clear();
                            txt_senhaaluno.Clear();
                            txt_turmaaluno.Clear();
                            txt_ncadastroaluno.Clear();
                            txt_funcaoaluno.Clear();
                            txt_cpfaluno.Focus();
                            //lblId.Text = ""; 
                        }

                    }

                    else
                    {
                        MessageBox.Show("aluno nao encontrado");
                        txt_id_aluno.Clear();
                        txt_cpfaluno.Clear();
                        txt_nomealuno.Clear();
                        txt_senhaaluno.Clear();
                        txt_turmaaluno.Clear();
                        txt_ncadastroaluno.Clear();
                        txt_funcaoaluno.Clear();
                        txt_cpfaluno.Focus();
                        //lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("favor preencher o campo cpf para realizar a pesquisa");
                    txt_id_aluno.Clear();
                    txt_cpfaluno.Clear();
                    txt_nomealuno.Clear();
                    txt_senhaaluno.Clear();
                    txt_turmaaluno.Clear();
                    txt_ncadastroaluno.Clear();
                    txt_funcaoaluno.Clear();
                    txt_cpfaluno.Focus();
                    //lblId.Text = "";

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("não foi possivel localizar o aluno" + ex.Message);
            }
        }

        private void btn_cadastraraluno_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=senai;User id=root;Pwd=123;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO {txt_turmaaluno.Text} (id_aluno, Nome, Turma, senha, cpf, Função, nCadastro, foto) VALUES (@id_aluno, @nome, @turma, @senha, @cpf, @funcao, @nCadastro, @foto)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                string qquery = $"INSERT INTO cadastro_aluno (id_aluno, Nome, Turma, senha, cpf, Função, nCadastro, foto) VALUES (@iid_aluno, @nnome, @tturma, @ssenha, @ccpf, @ffuncao, @nnCadastro, @ffoto)";
                MySqlCommand ccmd = new MySqlCommand(qquery, connection);

                cmd.Parameters.AddWithValue("@id_aluno", int.Parse(txt_id_aluno.Text)); // Substitua txt_idaluno pelo controle de ID do aluno
                cmd.Parameters.AddWithValue("@nome", txt_nomealuno.Text);
                cmd.Parameters.AddWithValue("@turma", txt_turmaaluno.Text);
                cmd.Parameters.AddWithValue("@senha", txt_senhaaluno.Text);
                cmd.Parameters.AddWithValue("@cpf", txt_cpfaluno.Text);
                cmd.Parameters.AddWithValue("@funcao", txt_funcaoaluno.Text);
                cmd.Parameters.AddWithValue("@nCadastro", int.Parse(txt_ncadastroaluno.Text));

                ccmd.Parameters.AddWithValue("@iid_aluno", int.Parse(txt_id_aluno.Text)); // Substitua txt_idaluno pelo controle de ID do aluno
                ccmd.Parameters.AddWithValue("@nnome", txt_nomealuno.Text);
                ccmd.Parameters.AddWithValue("@tturma", txt_turmaaluno.Text);
                ccmd.Parameters.AddWithValue("@ssenha", txt_senhaaluno.Text);
                ccmd.Parameters.AddWithValue("@ccpf", txt_cpfaluno.Text);
                ccmd.Parameters.AddWithValue("@ffuncao", txt_funcaoaluno.Text);
                ccmd.Parameters.AddWithValue("@nnCadastro", int.Parse(txt_ncadastroaluno.Text));



                // Para a imagem, você precisará convertê-la em bytes (byte array) se tiver uma imagem no PictureBox
                if (pictureBox1_aluno.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1_aluno.Image.Save(ms, pictureBox1_aluno.Image.RawFormat);
                        cmd.Parameters.AddWithValue("@foto", ms.ToArray());

                        ccmd.Parameters.AddWithValue("@ffoto", ms.ToArray());
                    }
                }
                else
                {
                    cmd.Parameters.AddWithValue("@foto", new byte[0]); // Se nenhuma imagem estiver disponível, insira um array de bytes vazio

                    ccmd.Parameters.AddWithValue("@ffoto", new byte[0]);
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    ccmd.ExecuteNonQuery();
                    MessageBox.Show("Aluno cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar aluno: " + ex.Message);
                }
            }



           




        }

        

        private void btn_inserirfotoaluno_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1_aluno.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
    } 
    
}
    


    


        
    
        
    

