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
using System.Windows.Forms;

namespace TCC.SDC
{
    public partial class Frm_cadastroprofessor : Form
    {
        public Frm_cadastroprofessor()
        {
            InitializeComponent();
        }

        private void btn_cadastrarprofessor_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=senai;User id=root;Pwd=123;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO {txt_turmaprofessor.Text} (id_professor, Nome, Turma, senha, cpf, Função, nCadastro, foto) VALUES (@id_professor, @nome, @turma, @senha, @cpf, @funcao, @nCadastro, @foto)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                string qquery = $"INSERT INTO cadastro_professor (id_professor, Nome, Turma, senha, cpf, Função, nCadastro, foto) VALUES (@iid_professor, @nnome, @tturma, @ssenha, @ccpf, @ffuncao, @nnCadastro, @ffoto)";
                MySqlCommand ccmd = new MySqlCommand(qquery, connection);

                cmd.Parameters.AddWithValue("@id_professor", int.Parse(txt_id_professor.Text)); // Substitua txt_idaluno pelo controle de ID do aluno
                cmd.Parameters.AddWithValue("@nome", txt_nomeprofessor.Text);
                cmd.Parameters.AddWithValue("@turma", txt_turmaprofessor.Text);
                cmd.Parameters.AddWithValue("@senha", txt_senhaprofessor.Text);
                cmd.Parameters.AddWithValue("@cpf", txt_cpfprofessor.Text);
                cmd.Parameters.AddWithValue("@funcao", txt_funcaoprofessor.Text);
                cmd.Parameters.AddWithValue("@nCadastro", int.Parse(txt_ncadastroprofessor.Text));

                ccmd.Parameters.AddWithValue("@iid_professor", int.Parse(txt_id_professor.Text)); // Substitua txt_idaluno pelo controle de ID do aluno
                ccmd.Parameters.AddWithValue("@nnome", txt_nomeprofessor.Text);
                ccmd.Parameters.AddWithValue("@tturma", txt_turmaprofessor.Text);
                ccmd.Parameters.AddWithValue("@ssenha", txt_senhaprofessor.Text);
                ccmd.Parameters.AddWithValue("@ccpf", txt_cpfprofessor.Text);
                ccmd.Parameters.AddWithValue("@ffuncao", txt_funcaoprofessor.Text);
                ccmd.Parameters.AddWithValue("@nnCadastro", int.Parse(txt_ncadastroprofessor.Text));

                // Para a imagem, você precisará convertê-la em bytes (byte array) se tiver uma imagem no PictureBox
                if (pictureBox1_professor.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1_professor.Image.Save(ms, pictureBox1_professor.Image.RawFormat);
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
                    MessageBox.Show("Professor cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar Professor: " + ex.Message);
                }
            }

            

            

           
        }
        private void btn_pesquisarprofessor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txt_cpfprofessor.Text.Equals(""))
                {
                    cadastroprofessor cadprofessor = new cadastroprofessor();
                    cadprofessor.CPF = txt_cpfprofessor.Text;

                    MySqlDataReader reader = cadprofessor.pesquisarprofessor();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            //lblId.Text = reader["id"].ToString();
                            txt_id_professor.Text = reader["id_professor"].ToString();
                            txt_nomeprofessor.Text = reader["nome"].ToString();
                            txt_turmaprofessor.Text = reader["turma"].ToString();
                            txt_senhaprofessor.Text = reader["senha"].ToString();
                            txt_ncadastroprofessor.Text = reader["ncadastro"].ToString();
                            txt_funcaoprofessor.Text = reader["função"].ToString();




                        }
                        else
                        {
                            MessageBox.Show("professor nao encontrado");
                            txt_id_professor.Clear();
                            txt_cpfprofessor.Clear();
                            txt_nomeprofessor.Clear();
                            txt_senhaprofessor.Clear();
                            txt_turmaprofessor.Clear();
                            txt_ncadastroprofessor.Clear();
                            txt_funcaoprofessor.Clear();
                            txt_cpfprofessor.Focus();
                            //lblId.Text = ""; 
                        }

                    }

                    else
                    {
                        MessageBox.Show("aluno nao encontrado");
                        txt_id_professor.Clear();
                        txt_cpfprofessor.Clear();
                        txt_nomeprofessor.Clear();
                        txt_senhaprofessor.Clear();
                        txt_turmaprofessor.Clear();
                        txt_ncadastroprofessor.Clear();
                        txt_funcaoprofessor.Clear();
                        txt_cpfprofessor.Focus();
                        //lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("favor preencher o campo cpf para realizar a pesquisa");
                    txt_id_professor.Clear();
                    txt_cpfprofessor.Clear();
                    txt_nomeprofessor.Clear();
                    txt_senhaprofessor.Clear();
                    txt_turmaprofessor.Clear();
                    txt_ncadastroprofessor.Clear();
                    txt_funcaoprofessor.Clear();
                    txt_cpfprofessor.Focus();
                    //lblId.Text = "";

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("não foi possivel localizar o aluno" + ex.Message);
            }
        }
        private void btn_excluirprofessor_Click(object sender, EventArgs e)
        {
            // Configurar a string de conexão com o banco de dados
            string connectionString = "Server=localhost;Database=senai;User id=root;Pwd=123;";
            MySqlConnection conexao = new MySqlConnection(connectionString);



            string cpfprofessor = txt_cpfprofessor.Text;

            try
            {
                // Abrir a conexão com o banco de dados
                conexao.Open();

                // Consultar o banco de dados para encontrar o registro correspondente
                string consulta = $"DELETE FROM {txt_turmaprofessor.Text} WHERE cpf =@CPF";
                MySqlCommand cmd = new MySqlCommand(consulta, conexao);
                cmd.Parameters.AddWithValue("@CPF", cpfprofessor);

                string consult = "DELETE FROM cadastro_professor WHERE cpf =@CPF";
                MySqlCommand cm = new MySqlCommand(consult, conexao);
                cm.Parameters.AddWithValue("@CPF", cpfprofessor);



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

        private void btn_inserirfotoprofessor_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Define a imagem selecionada no PictureBox
                pictureBox1_professor.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
}  }
