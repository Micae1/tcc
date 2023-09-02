using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC.SDC
{
    public partial class Frm_cadastroaluno : Form
    {
        public Frm_cadastroaluno()
        {
            InitializeComponent();
        }

        private void btn_cadastraraluno_Click(object sender, EventArgs e)
        {
            TCC.SDC.cadastroaluno aluno = new TCC.SDC.cadastroaluno();
            aluno.Nome = txt_nomealuno.Text;
            aluno.CPF = txt_cpfaluno.Text;
            aluno.Senha = Convert.ToInt32(txt_senhaaluno.Text);
            aluno.Turma = txt_turmaaluno.Text;
            aluno.Ncadastro = Convert.ToInt32(txt_ncadastroaluno.Text);
            if (aluno.Cadastroaluno() == true)
            {
                MessageBox.Show("Aluno cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("erro");
            }
        }
    }
}
