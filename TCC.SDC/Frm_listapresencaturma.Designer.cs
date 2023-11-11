namespace TCC.SDC
{
    partial class Frm_listapresencaturma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_listapresencaturma));
            this.btn_consultarpresencaturma = new System.Windows.Forms.Button();
            this.txt_nometurma = new System.Windows.Forms.TextBox();
            this.lbl_nometurma = new System.Windows.Forms.Label();
            this.txt_nomealuno = new System.Windows.Forms.TextBox();
            this.txt_senhaaluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_listapresencaturma = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listapresencaturma)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consultarpresencaturma
            // 
            this.btn_consultarpresencaturma.BackColor = System.Drawing.Color.Navy;
            this.btn_consultarpresencaturma.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_consultarpresencaturma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_consultarpresencaturma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_consultarpresencaturma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultarpresencaturma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarpresencaturma.Location = new System.Drawing.Point(282, 140);
            this.btn_consultarpresencaturma.Name = "btn_consultarpresencaturma";
            this.btn_consultarpresencaturma.Size = new System.Drawing.Size(88, 23);
            this.btn_consultarpresencaturma.TabIndex = 3;
            this.btn_consultarpresencaturma.Text = "Consultar";
            this.btn_consultarpresencaturma.UseVisualStyleBackColor = false;
            this.btn_consultarpresencaturma.Click += new System.EventHandler(this.btn_consultarpresencaturma_Click);
            // 
            // txt_nometurma
            // 
            this.txt_nometurma.Location = new System.Drawing.Point(16, 33);
            this.txt_nometurma.Name = "txt_nometurma";
            this.txt_nometurma.Size = new System.Drawing.Size(283, 20);
            this.txt_nometurma.TabIndex = 0;
            // 
            // lbl_nometurma
            // 
            this.lbl_nometurma.AutoSize = true;
            this.lbl_nometurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nometurma.Location = new System.Drawing.Point(12, 10);
            this.lbl_nometurma.Name = "lbl_nometurma";
            this.lbl_nometurma.Size = new System.Drawing.Size(118, 16);
            this.lbl_nometurma.TabIndex = 3;
            this.lbl_nometurma.Text = "Nome da Turma";
            // 
            // txt_nomealuno
            // 
            this.txt_nomealuno.Location = new System.Drawing.Point(16, 89);
            this.txt_nomealuno.Name = "txt_nomealuno";
            this.txt_nomealuno.Size = new System.Drawing.Size(245, 20);
            this.txt_nomealuno.TabIndex = 1;
            // 
            // txt_senhaaluno
            // 
            this.txt_senhaaluno.Location = new System.Drawing.Point(16, 143);
            this.txt_senhaaluno.Name = "txt_senhaaluno";
            this.txt_senhaaluno.PasswordChar = '*';
            this.txt_senhaaluno.Size = new System.Drawing.Size(245, 20);
            this.txt_senhaaluno.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha";
            // 
            // dgv_listapresencaturma
            // 
            this.dgv_listapresencaturma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listapresencaturma.Location = new System.Drawing.Point(12, 189);
            this.dgv_listapresencaturma.Name = "dgv_listapresencaturma";
            this.dgv_listapresencaturma.Size = new System.Drawing.Size(854, 328);
            this.dgv_listapresencaturma.TabIndex = 8;
            this.dgv_listapresencaturma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listapresencaturma_CellContentClick);
            // 
            // Frm_listapresencaturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(878, 529);
            this.Controls.Add(this.dgv_listapresencaturma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_senhaaluno);
            this.Controls.Add(this.txt_nomealuno);
            this.Controls.Add(this.lbl_nometurma);
            this.Controls.Add(this.txt_nometurma);
            this.Controls.Add(this.btn_consultarpresencaturma);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Frm_listapresencaturma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista da Presença Turma";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listapresencaturma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_consultarpresencaturma;
        private System.Windows.Forms.TextBox txt_nometurma;
        private System.Windows.Forms.Label lbl_nometurma;
        private System.Windows.Forms.TextBox txt_nomealuno;
        private System.Windows.Forms.TextBox txt_senhaaluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_listapresencaturma;
    }
}