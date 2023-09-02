namespace TCC.SDC
{
    partial class Frm_logincoordenacaoaluno
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
            this.txt_coordenacaonomealuno = new System.Windows.Forms.TextBox();
            this.txt_coordenacaosenhaaluno = new System.Windows.Forms.TextBox();
            this.lbl_nomecoordenacaoaluno = new System.Windows.Forms.Label();
            this.lbl_coordenacaosenhaaluno = new System.Windows.Forms.Label();
            this.btn_ligincoordenacaoaluno = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_coordenacaonomealuno
            // 
            this.txt_coordenacaonomealuno.Location = new System.Drawing.Point(97, 29);
            this.txt_coordenacaonomealuno.Name = "txt_coordenacaonomealuno";
            this.txt_coordenacaonomealuno.Size = new System.Drawing.Size(196, 20);
            this.txt_coordenacaonomealuno.TabIndex = 0;
            // 
            // txt_coordenacaosenhaaluno
            // 
            this.txt_coordenacaosenhaaluno.Location = new System.Drawing.Point(97, 111);
            this.txt_coordenacaosenhaaluno.Name = "txt_coordenacaosenhaaluno";
            this.txt_coordenacaosenhaaluno.PasswordChar = '#';
            this.txt_coordenacaosenhaaluno.Size = new System.Drawing.Size(196, 20);
            this.txt_coordenacaosenhaaluno.TabIndex = 1;
            // 
            // lbl_nomecoordenacaoaluno
            // 
            this.lbl_nomecoordenacaoaluno.AutoSize = true;
            this.lbl_nomecoordenacaoaluno.Location = new System.Drawing.Point(14, 36);
            this.lbl_nomecoordenacaoaluno.Name = "lbl_nomecoordenacaoaluno";
            this.lbl_nomecoordenacaoaluno.Size = new System.Drawing.Size(35, 13);
            this.lbl_nomecoordenacaoaluno.TabIndex = 2;
            this.lbl_nomecoordenacaoaluno.Text = "Nome";
            // 
            // lbl_coordenacaosenhaaluno
            // 
            this.lbl_coordenacaosenhaaluno.AutoSize = true;
            this.lbl_coordenacaosenhaaluno.Location = new System.Drawing.Point(14, 114);
            this.lbl_coordenacaosenhaaluno.Name = "lbl_coordenacaosenhaaluno";
            this.lbl_coordenacaosenhaaluno.Size = new System.Drawing.Size(38, 13);
            this.lbl_coordenacaosenhaaluno.TabIndex = 3;
            this.lbl_coordenacaosenhaaluno.Text = "Senha";
            
            // 
            // btn_ligincoordenacaoaluno
            // 
            this.btn_ligincoordenacaoaluno.Location = new System.Drawing.Point(116, 182);
            this.btn_ligincoordenacaoaluno.Name = "btn_ligincoordenacaoaluno";
            this.btn_ligincoordenacaoaluno.Size = new System.Drawing.Size(75, 23);
            this.btn_ligincoordenacaoaluno.TabIndex = 4;
            this.btn_ligincoordenacaoaluno.Text = "Login";
            this.btn_ligincoordenacaoaluno.UseVisualStyleBackColor = true;
            this.btn_ligincoordenacaoaluno.Click += new System.EventHandler(this.btn_ligincoordenacaoaluno_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_nomecoordenacaoaluno);
            this.groupBox1.Controls.Add(this.btn_ligincoordenacaoaluno);
            this.groupBox1.Controls.Add(this.txt_coordenacaonomealuno);
            this.groupBox1.Controls.Add(this.txt_coordenacaosenhaaluno);
            this.groupBox1.Controls.Add(this.lbl_coordenacaosenhaaluno);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 225);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Coordenação";
            // 
            // Frm_logincoordenacaoaluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 259);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_logincoordenacaoaluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_coordenacaonomealuno;
        private System.Windows.Forms.TextBox txt_coordenacaosenhaaluno;
        private System.Windows.Forms.Label lbl_nomecoordenacaoaluno;
        private System.Windows.Forms.Label lbl_coordenacaosenhaaluno;
        private System.Windows.Forms.Button btn_ligincoordenacaoaluno;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}