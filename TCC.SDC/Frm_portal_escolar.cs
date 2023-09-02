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
    public partial class Frm_portal_escolar : Form
    {
        public Frm_portal_escolar()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {//chama o forms login da coordenação para cadastrar o aluno
            Frm_logincoordenacaoaluno T = new Frm_logincoordenacaoaluno();
            T.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_logincoordenacaoprofessor T = new Frm_logincoordenacaoprofessor();
            T.Show();
            
            

            
        }

        private void listaDePresençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_listapresencaprofessor T = new Frm_listapresencaprofessor();
            T.Show();
        }
    }
}
