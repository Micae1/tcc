namespace TCC.SDC
{
    partial class Frm_logincoordenacaoprofessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_logincoordenacaoprofessor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_coordenacaosenhaprofessor = new System.Windows.Forms.TextBox();
            this.txt_coordenacaonomeprofessor = new System.Windows.Forms.TextBox();
            this.lbl_coordenacaosenhaprofessor = new System.Windows.Forms.Label();
            this.lbl_coordenacaonomeprofessor = new System.Windows.Forms.Label();
            this.btn_coordenacaologinprofessor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txt_coordenacaosenhaprofessor);
            this.groupBox1.Controls.Add(this.txt_coordenacaonomeprofessor);
            this.groupBox1.Controls.Add(this.lbl_coordenacaosenhaprofessor);
            this.groupBox1.Controls.Add(this.lbl_coordenacaonomeprofessor);
            this.groupBox1.Controls.Add(this.btn_coordenacaologinprofessor);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Coordenação";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_coordenacaosenhaprofessor
            // 
            this.txt_coordenacaosenhaprofessor.Location = new System.Drawing.Point(92, 113);
            this.txt_coordenacaosenhaprofessor.Name = "txt_coordenacaosenhaprofessor";
            this.txt_coordenacaosenhaprofessor.PasswordChar = '#';
            this.txt_coordenacaosenhaprofessor.Size = new System.Drawing.Size(230, 20);
            this.txt_coordenacaosenhaprofessor.TabIndex = 1;
            // 
            // txt_coordenacaonomeprofessor
            // 
            this.txt_coordenacaonomeprofessor.Location = new System.Drawing.Point(92, 35);
            this.txt_coordenacaonomeprofessor.Name = "txt_coordenacaonomeprofessor";
            this.txt_coordenacaonomeprofessor.Size = new System.Drawing.Size(230, 20);
            this.txt_coordenacaonomeprofessor.TabIndex = 0;
            // 
            // lbl_coordenacaosenhaprofessor
            // 
            this.lbl_coordenacaosenhaprofessor.AutoSize = true;
            this.lbl_coordenacaosenhaprofessor.Location = new System.Drawing.Point(6, 113);
            this.lbl_coordenacaosenhaprofessor.Name = "lbl_coordenacaosenhaprofessor";
            this.lbl_coordenacaosenhaprofessor.Size = new System.Drawing.Size(43, 13);
            this.lbl_coordenacaosenhaprofessor.TabIndex = 2;
            this.lbl_coordenacaosenhaprofessor.Text = "Senha";
            // 
            // lbl_coordenacaonomeprofessor
            // 
            this.lbl_coordenacaonomeprofessor.AutoSize = true;
            this.lbl_coordenacaonomeprofessor.Location = new System.Drawing.Point(6, 38);
            this.lbl_coordenacaonomeprofessor.Name = "lbl_coordenacaonomeprofessor";
            this.lbl_coordenacaonomeprofessor.Size = new System.Drawing.Size(39, 13);
            this.lbl_coordenacaonomeprofessor.TabIndex = 1;
            this.lbl_coordenacaonomeprofessor.Text = "Nome";
            // 
            // btn_coordenacaologinprofessor
            // 
            this.btn_coordenacaologinprofessor.BackColor = System.Drawing.Color.Blue;
            this.btn_coordenacaologinprofessor.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_coordenacaologinprofessor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_coordenacaologinprofessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_coordenacaologinprofessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_coordenacaologinprofessor.Location = new System.Drawing.Point(167, 158);
            this.btn_coordenacaologinprofessor.Name = "btn_coordenacaologinprofessor";
            this.btn_coordenacaologinprofessor.Size = new System.Drawing.Size(75, 39);
            this.btn_coordenacaologinprofessor.TabIndex = 2;
            this.btn_coordenacaologinprofessor.Text = "Login";
            this.btn_coordenacaologinprofessor.UseVisualStyleBackColor = false;
            this.btn_coordenacaologinprofessor.Click += new System.EventHandler(this.btn_coordenacaologinprofessor_Click);
            // 
            // Frm_logincoordenacaoprofessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(396, 247);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_logincoordenacaoprofessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_coordenacaosenhaprofessor;
        private System.Windows.Forms.TextBox txt_coordenacaonomeprofessor;
        private System.Windows.Forms.Label lbl_coordenacaosenhaprofessor;
        private System.Windows.Forms.Label lbl_coordenacaonomeprofessor;
        private System.Windows.Forms.Button btn_coordenacaologinprofessor;
    }
}