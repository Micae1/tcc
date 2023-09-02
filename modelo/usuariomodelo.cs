
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Usuariomodelo
    {

        //variaveis do objeto usuario
        public int id;
        public string nome;
        public string cpf;
        public string turma;
        public int senha;
        public int ncadastro;
        //crio o construtor do objeto
        public Usuariomodelo()
        {
            //inicializar o objeto vazio
            id = 0;
            nome = null;
            cpf = null;
            turma = null;
            senha = 1;
            ncadastro = 1;
        }
    }
}
