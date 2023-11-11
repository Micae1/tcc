using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.SDC
{
    
    
        internal class cadastroprofessor
        {

            private int id_professor;
            private string nome;
            private string cpf;
            private int senha;
            private string turma;
            private int ncadastro;
            private string funcao;



        public int Id_professor
        {
            get { return id_professor; }
            set { id_professor = value; }
        }
        public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }
            public string CPF
            {
                get { return cpf; }
                set { cpf = value; }
            }

            public int Senha
            {
                get { return senha; }
                set { senha = value; }
            }
            public string Turma
            {
                get { return turma; }
                set { turma = value; }
            }
            public int Ncadastro
            {
                get { return ncadastro; }
                set { ncadastro = value; }
            }

           public string Funcao
           {
            get { return funcao; }
            set { funcao = value; }
           }

        public bool Cadastroprofessor()
            {
                try
                {
                    conexao com = new conexao();
                    MySqlConnection MySqlconexaobanco = com.Conexao();


                    string insert = $"insert into {turma} (id_professor,nome,cpf,senha,turma,ncadastro,função)values('{id_professor}','{nome}','{CPF}','{Senha}','{turma}','{ncadastro}','{funcao}')";
                    string inserte = $"insert into cadastro_professor (id_professor,nome,cpf,senha,turma,ncadastro,função)values('{id_professor}','{nome}','{CPF}','{Senha}','{turma}','{ncadastro}','{funcao}')";

                    MySqlCommand comandoSql = new MySqlCommand(insert, MySqlconexaobanco);
                    MySqlCommand comandSql = new MySqlCommand(inserte, MySqlconexaobanco);

                    comandoSql.ExecuteNonQuery();
                    comandSql.ExecuteNonQuery();
                MySqlconexaobanco.Close();
                    return true;


                }
                catch (Exception ex)
                {

                    MessageBox.Show("erro no banco de dados" + ex.Message);
                    return false;
                }
            }

        internal MySqlDataReader pesquisarprofessor()
        {


            try
            {

                MySqlConnection MySqlconexaobanco = new MySqlConnection(conexao.bancoservidor);
                MySqlconexaobanco.Open();

                string select = $" select id_professor,nome,senha,cpf,turma,ncadastro,Função from cadastro_professor where cpf = '{cpf}';";

                MySqlCommand comandoSql = MySqlconexaobanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error no banco dedados metodo pesquisar professor" + ex.Message);
                return null;
            }

        }
        }
    
}

