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
using MySql.Data.MySqlClient;




namespace TCC.SDC
{
    public partial class Frm_listapresencaprofessor : Form
    {
        

        DataTable dt = new DataTable();

        private MySqlConnection connection;
        

        public Frm_listapresencaprofessor()
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

        

            dGV_listapresencaprofessor.DataSource = dt;
        }

        



        private void btn_consultarturmaprofessor_Click_1(object sender, EventArgs e)
        {

            // Configuração da conexão com o MySQL
            string connectionString = "Server=localhost;Database=senai;Uid=root;Pwd=123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Comando SQL para selecionar os dados da tabela
            string sqlQuery = $"SELECT ID,id_aluno,id_professor,Nome, Turma, Presença, Função, data_hora_entrada, data_hora_saida, Ausencia FROM {txt_consultarturmaprofessor.Text}";

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
                dGV_listapresencaprofessor.DataSource = dataTable;
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

            dGV_listapresencaprofessor.ReadOnly = false;

            // Manipule o evento CellDoubleClick para atualizar os dados

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Adicione o código para desenhar o conteúdo que será impresso nesta página.
            // Você pode usar o objeto "e.Graphics" para desenhar gráficos, texto, etc.
            e.Graphics.DrawString($"Nome da Turma {txt_consultarturmaprofessor}", new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
            // Define as configurações de margem e área de impressão.
            int marginLeft = 50;
            int marginTop = 150;
            int maxWidth = e.PageBounds.Width - (marginLeft * 2);

            // Calcula a largura de cada coluna com base na largura da página.
            int columnWidth = maxWidth / dGV_listapresencaprofessor.ColumnCount;

            // Define a posição inicial de impressão.
            int y = marginTop;

            // Loop através das linhas do DataGridView e imprima cada célula.
            foreach (DataGridViewRow row in dGV_listapresencaprofessor.Rows)
            {
                // Loop através das células da linha.
                for (int i = 0; i < dGV_listapresencaprofessor.ColumnCount; i++)
                {
                    string cellValue = row.Cells[i].Value != null ? row.Cells[i].Value.ToString() : string.Empty;


                    // Define o retângulo de impressão para a célula atual.
                    Rectangle cellRect = new Rectangle(marginLeft + (i * columnWidth), y, columnWidth, row.Height);

                    // Desenha o conteúdo da célula.
                    e.Graphics.DrawString(cellValue, dGV_listapresencaprofessor.Font, Brushes.Black, cellRect, StringFormat.GenericDefault);
                }

                // Move para a próxima linha.
                y += row.Height;
            }
        }

        private void btn_printlistapresencaprofessor_Click(object sender, EventArgs e)
        {
            {
                // Crie uma instância do PrintDialog.
                PrintDialog printDialog1 = new PrintDialog();

                // Defina o Documento a ser impresso.
                printDialog1.Document = printDocument1; // Substitua "printDocument1" pelo nome do seu PrintDocument.

                // Exibe o diálogo de impressão e verifica se o usuário clicou em "OK".
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Se o usuário selecionou uma impressora e clicou em "OK", você pode agora
                    // configurar o seu objeto PrintDocument com as configurações da impressora selecionada.

                    // Exemplo de configuração da impressora selecionada:
                    printDocument1.PrinterSettings = printDialog1.PrinterSettings;

                    // Agora, você pode chamar o método Print do seu objeto PrintDocument para imprimir o documento.
                    printDocument1.Print();
                }
            }
        }

        

        private void dGV_listapresencaprofessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_registrarhora_Click(object sender, EventArgs e)
        {



            int idAluno = Convert.ToInt32(txt_id.Text);
            DateTime horaEntrada = DateTime.Now;

            string connectionString = "Server=localhost;Database=senai;User id=root;Pwd=123;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verificar se já existe um registro para o aluno
                    string consulta = $"SELECT ID FROM {txt_consultarturmaprofessor.Text} WHERE ID = @ID";
                    MySqlCommand consultaCmd = new MySqlCommand(consulta, connection);
                    consultaCmd.Parameters.AddWithValue("@ID", idAluno);

                    object registroID = consultaCmd.ExecuteScalar();

                    if (registroID != null)
                    {
                        // Registro já existe, então atualize-o
                        string update = $"UPDATE {txt_consultarturmaprofessor.Text} SET data_hora_entrada = @horaEntrada, Presença = 'Presente' WHERE ID = @registroID";
                        MySqlCommand updateCmd = new MySqlCommand(update, connection);
                        updateCmd.Parameters.AddWithValue("@horaEntrada", horaEntrada);
                        updateCmd.Parameters.AddWithValue("@registroID", registroID);

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Registro atualizado com sucesso!");
                    }
                    else
                    {
                        // Registro não existe, então insira um novo
                        string inserir = $"INSERT INTO {txt_consultarturmaprofessor.Text} ( data_hora_entrada, Presença) VALUES ( @horaEntrada, 'Presente')";
                        MySqlCommand inserirCmd = new MySqlCommand(inserir, connection);
                        inserirCmd.Parameters.AddWithValue("@ID", idAluno);
                        inserirCmd.Parameters.AddWithValue("@horaEntrada", horaEntrada);

                        inserirCmd.ExecuteNonQuery();

                        MessageBox.Show("Registro incluído com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }



           
        }

        private void btn_registrarhorasaida_Click(object sender, EventArgs e)
        {

            int idAluno = Convert.ToInt32(txt_id.Text);
            DateTime horaEntrada = DateTime.Now;

            string connectionString = "Server=localhost;Database=senai;User id=root;Pwd=123;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verificar se já existe um registro para o aluno
                    string consulta = $"SELECT ID FROM {txt_consultarturmaprofessor.Text} WHERE ID = @ID";
                    MySqlCommand consultaCmd = new MySqlCommand(consulta, connection);
                    consultaCmd.Parameters.AddWithValue("@ID", idAluno);

                    object registroID = consultaCmd.ExecuteScalar();

                    if (registroID != null)
                    {
                        // Registro já existe, então atualize-o
                        string update = $"UPDATE {txt_consultarturmaprofessor.Text} SET data_hora_saida = @horasaida, Ausencia = 'Ausente' WHERE ID = @registroID";
                        MySqlCommand updateCmd = new MySqlCommand(update, connection);
                        updateCmd.Parameters.AddWithValue("@horasaida", horaEntrada);
                        updateCmd.Parameters.AddWithValue("@registroID", registroID);

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Registro atualizado com sucesso!");
                    }
                    else
                    {
                        // Registro não existe, então insira um novo
                        string inserir = $"INSERT INTO {txt_consultarturmaprofessor.Text} ( data_hora_saida, Ausencia) VALUES ( @horasaida, 'Ausente')";
                        MySqlCommand inserirCmd = new MySqlCommand(inserir, connection);
                        inserirCmd.Parameters.AddWithValue("@ID", idAluno);
                        inserirCmd.Parameters.AddWithValue("@horasaida", horaEntrada);

                        inserirCmd.ExecuteNonQuery();

                        MessageBox.Show("Registro incluído com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        private void btn_exibirfoto_Click(object sender, EventArgs e)
        {
            


             string nomeAluno = txt_exibirfoto.Text;

             // Configuração da conexão com o MySQL
             string connectionString = "Server=localhost;Database=senai;Uid=root;Pwd=123;";
             MySqlConnection connection = new MySqlConnection(connectionString);

             try
             {
                 connection.Open();

                 // Consulta SQL para selecionar a imagem do aluno com base no nome
                 string consultaSQL = $"SELECT foto FROM {txt_consultarturmaprofessor.Text} WHERE nome = @nome";

                 MySqlCommand comando = new MySqlCommand(consultaSQL, connection);
                 comando.Parameters.AddWithValue("@nome", nomeAluno);

                 // Execute a consulta e obtenha a imagem
                 byte[] imagemBytes = (byte[])comando.ExecuteScalar();

                 if (imagemBytes != null)
                 {
                     // Converte os bytes em uma imagem
                     Image imagem = byteArrayToImage(imagemBytes);

                     // Exibe a imagem na PictureBox
                     pictureBox1_fotodgv.Image = imagem;
                 }
                 else
                 {
                     // Limpa a PictureBox se nenhuma imagem for encontrada
                     pictureBox1_fotodgv.Image = null;
                     MessageBox.Show("Aluno não encontrado.");
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Erro ao pesquisar aluno: " + ex.Message);
             }
             finally
             {
                 connection.Close();
             }
        }

        // Método para converter byte[] em Image
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image imagem = Image.FromStream(ms);
            return imagem;
        }

        private void btn_pesquisarid_Click(object sender, EventArgs e)
        {
            // Conexão com o banco de dados
            string connectionString = "Server=localhost;Database=senai;Uid=root;Pwd=123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // Obtenha o valor do ID a ser filtrado a partir do TextBox
                int idFiltrar = Convert.ToInt32(txt_idaluno.Text);

                // Consulta SQL para obter os dados do aluno com o ID especificado
                string query = $"SELECT * FROM {txt_consultarturmaprofessor.Text} WHERE id_aluno = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", idFiltrar);

                // Crie um DataTable para armazenar os resultados da consulta
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                // Atualize o DataGridView com os resultados da consulta
                dGV_listapresencaprofessor.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_apagarhoraentrada_Click(object sender, EventArgs e)
        {

            if (dGV_listapresencaprofessor.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dGV_listapresencaprofessor.SelectedRows[0];
                selectedRow.Cells["data_hora_entrada"].Value = DBNull.Value; // Define a coluna de Data_Hora_Entrada como vazia
                selectedRow.Cells["Presença"].Value = DBNull.Value; // Define a coluna de Presença como vazia

                // Obtém o ID do aluno ou outra chave primária que identifica a linha
                int alunoID = Convert.ToInt32(selectedRow.Cells["ID"].Value); // Substitua "ID" pelo nome da coluna que contém o ID

                // Atualiza o banco de dados MySQL
                string connectionString = "Server=localhost;Database=senai;User id=root;Pwd=123;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = $"UPDATE {txt_consultarturmaprofessor.Text} SET data_hora_entrada = NULL, Presença = NULL WHERE ID = @AlunoID";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);

                    command.Parameters.AddWithValue("@AlunoID", alunoID);

                    int rowsUpdated = command.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Hora de entrada e presença removidas com sucesso e atualizadas no banco de dados.");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar no banco de dados.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para remover a hora de entrada e presença.");
            }


            
        }

        private void btn_apagarhorasaida_Click(object sender, EventArgs e)
        {
            if (dGV_listapresencaprofessor.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dGV_listapresencaprofessor.SelectedRows[0];
                selectedRow.Cells["data_hora_saida"].Value = DBNull.Value; // Define a coluna de Data_Hora_Entrada como vazia
                selectedRow.Cells["Ausencia"].Value = DBNull.Value; // Define a coluna de Presença como vazia

                // Obtém o ID do aluno ou outra chave primária que identifica a linha
                int alunoID = Convert.ToInt32(selectedRow.Cells["ID"].Value); // Substitua "ID" pelo nome da coluna que contém o ID

                // Atualiza o banco de dados MySQL
                string connectionString = "Server=localhost;Database=senai;User id=root;Pwd=123;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = $"UPDATE {txt_consultarturmaprofessor.Text} SET data_hora_saida = NULL, Ausencia = NULL WHERE ID = @AlunoID";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);

                    command.Parameters.AddWithValue("@AlunoID", alunoID);

                    int rowsUpdated = command.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Hora de Saida e Ausencia removidas com sucesso e atualizadas no banco de dados.");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar no banco de dados.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para remover a hora de Saida e Ausencia.");
            }

        }

        private void btn_pesquisaridprofessor_Click(object sender, EventArgs e)
        {
            // Conexão com o banco de dados
            string connectionString = "Server=localhost;Database=senai;Uid=root;Pwd=123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // Obtenha o valor do ID a ser filtrado a partir do TextBox
                int idFiltrar = Convert.ToInt32(txt_idprofessor.Text);

                // Consulta SQL para obter os dados do aluno com o ID especificado
                string query = $"SELECT * FROM {txt_consultarturmaprofessor.Text} WHERE id_professor = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", idFiltrar);

                // Crie um DataTable para armazenar os resultados da consulta
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                // Atualize o DataGridView com os resultados da consulta
                dGV_listapresencaprofessor.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_limparlista_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=senai;User id=root;Pwd=123;"); // Substitua pela sua string de conexão

            try
            {
                conexao.Open();

                // Iterar pelas linhas do DataGridView
                foreach (DataGridViewRow row in dGV_listapresencaprofessor.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int alunoID = Convert.ToInt32(row.Cells["ID"].Value); // Substitua "AlunoID" pelo nome da coluna que armazena o ID do aluno

                        // Limpar o valor da coluna de presença
                        row.Cells["Presença"].Value = DBNull.Value;

                        // Limpar o valor da coluna de data e hora de entrada
                        row.Cells["data_hora_entrada"].Value = DBNull.Value;

                        // Limpar o valor da coluna de ausência
                        row.Cells["Ausencia"].Value = DBNull.Value;

                        // Limpar o valor da coluna de data e hora de saída
                        row.Cells["data_hora_saida"].Value = DBNull.Value;

                        // Atualize o banco de dados para refletir as alterações
                        string query = $"UPDATE {txt_consultarturmaprofessor.Text} SET Presença = NULL, data_hora_entrada = NULL, Ausencia = NULL, data_hora_saida = NULL WHERE ID = @AlunoID"; // Substitua "SuaTabela" pelo nome da sua tabela
                        MySqlCommand cmd = new MySqlCommand(query, conexao);
                        cmd.Parameters.AddWithValue("@AlunoID", alunoID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao limpar as colunas e atualizar o banco de dados: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
       
    }
}
 
  

      

       
    

