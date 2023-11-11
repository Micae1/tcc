namespace TCC.SDC
{
    partial class Frm_loginaluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_loginaluno));
            this.groupBoxaluno = new System.Windows.Forms.GroupBox();
            this.txt_nometurmaaluno = new System.Windows.Forms.TextBox();
            this.lbl_nometurmaaluno = new System.Windows.Forms.Label();
            this.txt_senhaaluno = new System.Windows.Forms.TextBox();
            this.txt_nomealuno = new System.Windows.Forms.TextBox();
            this.lbl_senhaaluno = new System.Windows.Forms.Label();
            this.lbl_nomealuno = new System.Windows.Forms.Label();
            this.btn_loginaluno = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            this.groupBoxaluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxaluno
            // 
            this.groupBoxaluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxaluno.BackgroundImage")));
            this.groupBoxaluno.Controls.Add(this.txt_nometurmaaluno);
            this.groupBoxaluno.Controls.Add(this.lbl_nometurmaaluno);
            this.groupBoxaluno.Controls.Add(this.txt_senhaaluno);
            this.groupBoxaluno.Controls.Add(this.txt_nomealuno);
            this.groupBoxaluno.Controls.Add(this.lbl_senhaaluno);
            this.groupBoxaluno.Controls.Add(this.lbl_nomealuno);
            this.groupBoxaluno.Controls.Add(this.btn_loginaluno);
            this.groupBoxaluno.ForeColor = System.Drawing.Color.White;
            this.groupBoxaluno.Location = new System.Drawing.Point(12, 12);
            this.groupBoxaluno.Name = "groupBoxaluno";
            this.groupBoxaluno.Size = new System.Drawing.Size(377, 241);
            this.groupBoxaluno.TabIndex = 0;
            this.groupBoxaluno.TabStop = false;
            this.groupBoxaluno.Text = "Login Aluno";
            // 
            // txt_nometurmaaluno
            // 
            this.txt_nometurmaaluno.Location = new System.Drawing.Point(109, 94);
            this.txt_nometurmaaluno.Name = "txt_nometurmaaluno";
            this.txt_nometurmaaluno.Size = new System.Drawing.Size(232, 20);
            this.txt_nometurmaaluno.TabIndex = 1;
            // 
            // lbl_nometurmaaluno
            // 
            this.lbl_nometurmaaluno.AutoSize = true;
            this.lbl_nometurmaaluno.Location = new System.Drawing.Point(6, 94);
            this.lbl_nometurmaaluno.Name = "lbl_nometurmaaluno";
            this.lbl_nometurmaaluno.Size = new System.Drawing.Size(37, 13);
            this.lbl_nometurmaaluno.TabIndex = 3;
            this.lbl_nometurmaaluno.Text = "Turma";
            // 
            // txt_senhaaluno
            // 
            this.txt_senhaaluno.Location = new System.Drawing.Point(109, 138);
            this.txt_senhaaluno.Name = "txt_senhaaluno";
            this.txt_senhaaluno.PasswordChar = '*';
            this.txt_senhaaluno.Size = new System.Drawing.Size(232, 20);
            this.txt_senhaaluno.TabIndex = 2;
            // 
            // txt_nomealuno
            // 
            this.txt_nomealuno.Location = new System.Drawing.Point(109, 55);
            this.txt_nomealuno.Name = "txt_nomealuno";
            this.txt_nomealuno.Size = new System.Drawing.Size(232, 20);
            this.txt_nomealuno.TabIndex = 0;
            // 
            // lbl_senhaaluno
            // 
            this.lbl_senhaaluno.AutoSize = true;
            this.lbl_senhaaluno.Location = new System.Drawing.Point(7, 138);
            this.lbl_senhaaluno.Name = "lbl_senhaaluno";
            this.lbl_senhaaluno.Size = new System.Drawing.Size(38, 13);
            this.lbl_senhaaluno.TabIndex = 2;
            this.lbl_senhaaluno.Text = "Senha";
            // 
            // lbl_nomealuno
            // 
            this.lbl_nomealuno.AutoSize = true;
            this.lbl_nomealuno.Location = new System.Drawing.Point(7, 55);
            this.lbl_nomealuno.Name = "lbl_nomealuno";
            this.lbl_nomealuno.Size = new System.Drawing.Size(35, 13);
            this.lbl_nomealuno.TabIndex = 1;
            this.lbl_nomealuno.Text = "Nome";
            // 
            // btn_loginaluno
            // 
            this.btn_loginaluno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_loginaluno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_loginaluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_loginaluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loginaluno.Location = new System.Drawing.Point(174, 195);
            this.btn_loginaluno.Name = "btn_loginaluno";
            this.btn_loginaluno.Size = new System.Drawing.Size(75, 23);
            this.btn_loginaluno.TabIndex = 2;
            this.btn_loginaluno.Text = "Login";
            this.btn_loginaluno.UseVisualStyleBackColor = true;
            this.btn_loginaluno.Click += new System.EventHandler(this.btn_loginaluno_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateBatchSize = 0;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Frm_loginaluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(412, 266);
            this.Controls.Add(this.groupBoxaluno);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_loginaluno";
            this.groupBoxaluno.ResumeLayout(false);
            this.groupBoxaluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxaluno;
        private System.Windows.Forms.TextBox txt_senhaaluno;
        private System.Windows.Forms.TextBox txt_nomealuno;
        private System.Windows.Forms.Label lbl_senhaaluno;
        private System.Windows.Forms.Label lbl_nomealuno;
        private System.Windows.Forms.Button btn_loginaluno;
        private System.Windows.Forms.TextBox txt_nometurmaaluno;
        private System.Windows.Forms.Label lbl_nometurmaaluno;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
    }
}