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
    public partial class Frm_cadastroprofessor : Form
    {
        public Frm_cadastroprofessor()
        {
            InitializeComponent();
        }

        private void btn_cadastrarprofessor_Click(object sender, EventArgs e)
        {
            TCC.SDC.cadastroprofessor professor = new TCC.SDC.cadastroprofessor();
            professor.Nome = txt_nomeprofessor.Text;
            professor.CPF = txt_cpfprofessor.Text;
            professor.Senha = Convert.ToInt32(txt_senhaprofessor.Text);
            professor.Turma = txt_turmaprofessor.Text;
            professor.Ncadastro = Convert.ToInt32(txt_ncadastroprofessor.Text);
            if (professor.Cadastroprofessor() == true)
            {
                MessageBox.Show("Professor cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("erro");
            }
        }
    }
}
