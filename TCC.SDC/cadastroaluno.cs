using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace TCC.SDC
{
    internal class cadastroaluno
    {
        private int id_aluno;
        private string nome;
        private string cpf;
        private int senha;
        private string turma;
        private int ncadastro;
        private string funcao;
        private string presença;

        //public static long LastInsertedId { get; internal set; }


        public int Id_aluno
        {
            get { return id_aluno; }
            set { id_aluno = value; }
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

        public string Presença
        {
            get { return presença; }
            set { presença = value; }
        }

        public bool Cadastroaluno()
        {
            try
            {
                conexao com = new conexao();
                MySqlConnection MySqlconexaobanco = com.Conexao();


                string insert = $"insert into {turma}(id_aluno,nome,presença,cpf,senha,turma,ncadastro,função)values('{id_aluno }','{nome}', '{presença}','{CPF}','{Senha}','{turma}','{ncadastro}','{funcao}')";
                string inserte = $"insert into cadastro_aluno(id_aluno,nome,cpf,senha,turma,ncadastro,função)values('{id_aluno}','{nome}','{CPF}','{Senha}','{turma}','{ncadastro}','{funcao}')";

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

        internal MySqlDataReader pesquisaraluno()
        {
            


            try
            {

                MySqlConnection MySqlconexaobanco = new MySqlConnection(conexao.bancoservidor);
                MySqlconexaobanco.Open();

                string select = $" select id_aluno,nome,senha,cpf,turma,ncadastro,Função from cadastro_aluno where cpf = '{cpf}';";

                MySqlCommand comandoSql = MySqlconexaobanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error no banco dedados metodo pesquisar aluno" + ex.Message);
                return null;
            }

        }







    }
}
        
          
          
        
    



