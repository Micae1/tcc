namespace TCC.SDC
{
    partial class Frm_loginprofessor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_loginprofessor = new System.Windows.Forms.Button();
            this.lbl_nomeloginprofessor = new System.Windows.Forms.Label();
            this.lbl_senhaloginprofessor = new System.Windows.Forms.Label();
            this.txt_nomeloginprofessor = new System.Windows.Forms.TextBox();
            this.txt_senhaloginprofessor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_senhaloginprofessor);
            this.groupBox1.Controls.Add(this.txt_nomeloginprofessor);
            this.groupBox1.Controls.Add(this.lbl_senhaloginprofessor);
            this.groupBox1.Controls.Add(this.lbl_nomeloginprofessor);
            this.groupBox1.Controls.Add(this.btn_loginprofessor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Professor";
            // 
            // btn_loginprofessor
            // 
            this.btn_loginprofessor.Location = new System.Drawing.Point(130, 189);
            this.btn_loginprofessor.Name = "btn_loginprofessor";
            this.btn_loginprofessor.Size = new System.Drawing.Size(75, 23);
            this.btn_loginprofessor.TabIndex = 0;
            this.btn_loginprofessor.Text = "Login";
            this.btn_loginprofessor.UseVisualStyleBackColor = true;
            this.btn_loginprofessor.Click += new System.EventHandler(this.btn_loginprofessor_Click);
            // 
            // lbl_nomeloginprofessor
            // 
            this.lbl_nomeloginprofessor.AutoSize = true;
            this.lbl_nomeloginprofessor.Location = new System.Drawing.Point(7, 60);
            this.lbl_nomeloginprofessor.Name = "lbl_nomeloginprofessor";
            this.lbl_nomeloginprofessor.Size = new System.Drawing.Size(35, 13);
            this.lbl_nomeloginprofessor.TabIndex = 1;
            this.lbl_nomeloginprofessor.Text = "Nome";
            // 
            // lbl_senhaloginprofessor
            // 
            this.lbl_senhaloginprofessor.AutoSize = true;
            this.lbl_senhaloginprofessor.Location = new System.Drawing.Point(10, 137);
            this.lbl_senhaloginprofessor.Name = "lbl_senhaloginprofessor";
            this.lbl_senhaloginprofessor.Size = new System.Drawing.Size(38, 13);
            this.lbl_senhaloginprofessor.TabIndex = 2;
            this.lbl_senhaloginprofessor.Text = "Senha";
            // 
            // txt_nomeloginprofessor
            // 
            this.txt_nomeloginprofessor.Location = new System.Drawing.Point(109, 52);
            this.txt_nomeloginprofessor.Name = "txt_nomeloginprofessor";
            this.txt_nomeloginprofessor.Size = new System.Drawing.Size(100, 20);
            this.txt_nomeloginprofessor.TabIndex = 3;
            // 
            // txt_senhaloginprofessor
            // 
            this.txt_senhaloginprofessor.Location = new System.Drawing.Point(109, 129);
            this.txt_senhaloginprofessor.Name = "txt_senhaloginprofessor";
            this.txt_senhaloginprofessor.Size = new System.Drawing.Size(100, 20);
            this.txt_senhaloginprofessor.TabIndex = 4;
            // 
            // Frm_loginprofessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 267);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_loginprofessor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_senhaloginprofessor;
        private System.Windows.Forms.TextBox txt_nomeloginprofessor;
        private System.Windows.Forms.Label lbl_senhaloginprofessor;
        private System.Windows.Forms.Label lbl_nomeloginprofessor;
        private System.Windows.Forms.Button btn_loginprofessor;
    }
}