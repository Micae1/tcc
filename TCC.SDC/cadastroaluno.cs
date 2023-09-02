using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.SDC
{
    internal class cadastroaluno
    {

        private string nome;
        private string cpf;
        private int senha;
        private string turma;
        private int ncadastro;


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

        public bool Cadastroaluno()
        {
            try
            {
                conexao com = new conexao();
                MySqlConnection MySqlconexaobanco = com.Conexao();


                string insert = $"insert into cadastro_aluno (nome,cpf,senha,turma,ncadastro)values('{nome}','{CPF}','{Senha}','{turma}',{ncadastro})";

                MySqlCommand comandoSql = new MySqlCommand(insert, MySqlconexaobanco);


                comandoSql.ExecuteNonQuery();
                MySqlconexaobanco.Close();
                return true;


            }
            catch (Exception ex)
            {

                MessageBox.Show("erro no banco de dados" + ex.Message);
                return false;
            }
        }

    }


}
