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
    public partial class Frm_logincoordenacaoprofessor : Form
    {
        public Frm_logincoordenacaoprofessor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_coordenacaologinprofessor_Click(object sender, EventArgs e)
        {
            {//verifica se a senha e o nome da coordenação estão registrados e da a liberação
             //para ir cadastrar o professor
                try
                {
                    if (txt_coordenacaonomeprofessor.Text.Equals("Micael") && txt_coordenacaosenhaprofessor.Text.Equals("123"))
                    {
                        Frm_cadastroprofessor T = new Frm_cadastroprofessor();
                        T.Show();
                        

                    }
                    
                    else
                    {
                        MessageBox.Show("Usuario ou senha incorretos",
                            "Desculpe",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        txt_coordenacaonomeprofessor.Focus();
                        txt_coordenacaosenhaprofessor.Text = "";
                        txt_coordenacaonomeprofessor.Text = "";
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Usuario ou senha incorretos",
                                            "Desculpe",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                    txt_coordenacaonomeprofessor.Focus();
                    txt_coordenacaosenhaprofessor.Text = "";
                    txt_coordenacaonomeprofessor.Text = "";

                }
            }
        }
    }
}



