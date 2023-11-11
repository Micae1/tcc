namespace TCC.SDC
{
    partial class Frm_consutarlistapresencaaluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consutarlistapresencaaluno));
            this.btn_consultarlistaaluno = new System.Windows.Forms.Button();
            this.txt_listadepresencaturma = new System.Windows.Forms.TextBox();
            this.dgv_listapresencaalunos = new System.Windows.Forms.DataGridView();
            this.txt_nomedoaluno = new System.Windows.Forms.TextBox();
            this.txt_senhadoaluno = new System.Windows.Forms.TextBox();
            this.lbl_Turma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listapresencaalunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consultarlistaaluno
            // 
            this.btn_consultarlistaaluno.BackColor = System.Drawing.Color.Navy;
            this.btn_consultarlistaaluno.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_consultarlistaaluno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_consultarlistaaluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_consultarlistaaluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultarlistaaluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarlistaaluno.ForeColor = System.Drawing.Color.White;
            this.btn_consultarlistaaluno.Location = new System.Drawing.Point(320, 72);
            this.btn_consultarlistaaluno.Name = "btn_consultarlistaaluno";
            this.btn_consultarlistaaluno.Size = new System.Drawing.Size(100, 23);
            this.btn_consultarlistaaluno.TabIndex = 3;
            this.btn_consultarlistaaluno.Text = "Consultar";
            this.btn_consultarlistaaluno.UseVisualStyleBackColor = false;
            this.btn_consultarlistaaluno.Click += new System.EventHandler(this.btn_consultarlistaaluno_Click);
            // 
            // txt_listadepresencaturma
            // 
            this.txt_listadepresencaturma.Location = new System.Drawing.Point(116, 19);
            this.txt_listadepresencaturma.Name = "txt_listadepresencaturma";
            this.txt_listadepresencaturma.Size = new System.Drawing.Size(174, 20);
            this.txt_listadepresencaturma.TabIndex = 0;
            // 
            // dgv_listapresencaalunos
            // 
            this.dgv_listapresencaalunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listapresencaalunos.Location = new System.Drawing.Point(12, 145);
            this.dgv_listapresencaalunos.Name = "dgv_listapresencaalunos";
            this.dgv_listapresencaalunos.Size = new System.Drawing.Size(858, 150);
            this.dgv_listapresencaalunos.TabIndex = 4;
            // 
            // txt_nomedoaluno
            // 
            this.txt_nomedoaluno.Location = new System.Drawing.Point(116, 46);
            this.txt_nomedoaluno.Name = "txt_nomedoaluno";
            this.txt_nomedoaluno.Size = new System.Drawing.Size(174, 20);
            this.txt_nomedoaluno.TabIndex = 1;
            // 
            // txt_senhadoaluno
            // 
            this.txt_senhadoaluno.Location = new System.Drawing.Point(116, 74);
            this.txt_senhadoaluno.Name = "txt_senhadoaluno";
            this.txt_senhadoaluno.Size = new System.Drawing.Size(174, 20);
            this.txt_senhadoaluno.TabIndex = 2;
            // 
            // lbl_Turma
            // 
            this.lbl_Turma.AutoSize = true;
            this.lbl_Turma.BackColor = System.Drawing.Color.Navy;
            this.lbl_Turma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turma.ForeColor = System.Drawing.Color.White;
            this.lbl_Turma.Location = new System.Drawing.Point(32, 19);
            this.lbl_Turma.Name = "lbl_Turma";
            this.lbl_Turma.Size = new System.Drawing.Size(51, 16);
            this.lbl_Turma.TabIndex = 5;
            this.lbl_Turma.Text = "Turma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // Frm_consutarlistapresencaaluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 307);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Turma);
            this.Controls.Add(this.txt_senhadoaluno);
            this.Controls.Add(this.txt_nomedoaluno);
            this.Controls.Add(this.dgv_listapresencaalunos);
            this.Controls.Add(this.txt_listadepresencaturma);
            this.Controls.Add(this.btn_consultarlistaaluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_consutarlistapresencaaluno";
            this.Text = "Lista de Presença da Turma";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listapresencaalunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consultarlistaaluno;
        private System.Windows.Forms.TextBox txt_listadepresencaturma;
        private System.Windows.Forms.DataGridView dgv_listapresencaalunos;
        private System.Windows.Forms.TextBox txt_nomedoaluno;
        private System.Windows.Forms.TextBox txt_senhadoaluno;
        private System.Windows.Forms.Label lbl_Turma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}