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
    public partial class Frm_logincoordenacaoaluno : Form
    {
        public Frm_logincoordenacaoaluno()
        {
            InitializeComponent();
        }

        private void btn_ligincoordenacaoaluno_Click(object sender, EventArgs e)
        {//verifica se a senha e o nome da coordenação estão registrados e da a liberação
            //para ir cadastrar o aluno
            try
            {
                if (txt_coordenacaonomealuno.Text.Equals("Micael") && txt_coordenacaosenhaaluno.Text.Equals("123"))
                {
                    Frm_cadastroaluno T = new Frm_cadastroaluno();
                    T.Show();
                }
                else 
                {
                    MessageBox.Show("Usuario ou senha incorretos",
                        "Desculpe",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txt_coordenacaonomealuno.Focus();
                    txt_coordenacaosenhaaluno.Text = "";
                    txt_coordenacaonomealuno.Text = "";
                }

                
            }
            catch (Exception )
            {
                MessageBox.Show("Usuario ou senha incorretos",
                                        "Desculpe",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                txt_coordenacaonomealuno.Focus();
                txt_coordenacaosenhaaluno.Text = "";
                txt_coordenacaonomealuno.Text = "";

            }
            
        }

        
    }
}
