using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TCC.SDC
{
    internal class conexao
    {
        private const string servidor = "localhost";
        private const string bancoDados = "senai";
        private const string usuario = "root";
        private const string senha = "123";

        static public string bancoservidor = $"server={servidor};user id={usuario};database={bancoDados};password={senha}";

        internal static void Open()
        {
            throw new NotImplementedException();
        }

        public MySqlConnection Conexao()
        {
            MySqlConnection com = new MySqlConnection(bancoservidor);
            com.Open();
            return com;

        }

        
    }
}
