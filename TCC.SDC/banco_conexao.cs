using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TCC.SDC
{
     class banco_conexao


    {
        private const string servidor = "localhost";
        private const string bancoDados = "senai";
        private const string usuario = "root";
        private const string senha = "123";

        static public string bancoservidor = $"server={servidor};user id={usuario};database={bancoDados};password={senha}";

        public static ConnectionState State { get; internal set; }

        internal static void Open()
        {
            throw new NotImplementedException();
        }

        public MySqlConnection Banco_Conexao()
        {
            MySqlConnection com = new MySqlConnection(bancoservidor);
            com.Open();
            return com;

        }




    }
}
