namespace TCC.SDC
{
    partial class Frm_logincoordenaçãolistadepresenca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_logincoordenaçãolistadepresenca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_senhacoordenacaolistaturma = new System.Windows.Forms.TextBox();
            this.txt_nomecoordenacaolistaturma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logincoordenacaolistaturma = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.txt_senhacoordenacaolistaturma);
            this.groupBox1.Controls.Add(this.txt_nomecoordenacaolistaturma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_logincoordenacaolistaturma);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Coordenação";
            // 
            // txt_senhacoordenacaolistaturma
            // 
            this.txt_senhacoordenacaolistaturma.Location = new System.Drawing.Point(89, 154);
            this.txt_senhacoordenacaolistaturma.Name = "txt_senhacoordenacaolistaturma";
            this.txt_senhacoordenacaolistaturma.PasswordChar = '*';
            this.txt_senhacoordenacaolistaturma.Size = new System.Drawing.Size(192, 20);
            this.txt_senhacoordenacaolistaturma.TabIndex = 1;
            // 
            // txt_nomecoordenacaolistaturma
            // 
            this.txt_nomecoordenacaolistaturma.Location = new System.Drawing.Point(89, 84);
            this.txt_nomecoordenacaolistaturma.Name = "txt_nomecoordenacaolistaturma";
            this.txt_nomecoordenacaolistaturma.Size = new System.Drawing.Size(192, 20);
            this.txt_nomecoordenacaolistaturma.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_logincoordenacaolistaturma
            // 
            this.btn_logincoordenacaolistaturma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_logincoordenacaolistaturma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_logincoordenacaolistaturma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logincoordenacaolistaturma.Location = new System.Drawing.Point(141, 220);
            this.btn_logincoordenacaolistaturma.Name = "btn_logincoordenacaolistaturma";
            this.btn_logincoordenacaolistaturma.Size = new System.Drawing.Size(75, 23);
            this.btn_logincoordenacaolistaturma.TabIndex = 2;
            this.btn_logincoordenacaolistaturma.Text = "Login";
            this.btn_logincoordenacaolistaturma.UseVisualStyleBackColor = true;
            this.btn_logincoordenacaolistaturma.Click += new System.EventHandler(this.btn_logincoordenacaolistaturma_Click);
            // 
            // Frm_logincoordenaçãolistadepresenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(335, 327);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_logincoordenaçãolistadepresenca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_senhacoordenacaolistaturma;
        private System.Windows.Forms.TextBox txt_nomecoordenacaolistaturma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logincoordenacaolistaturma;
    }
}