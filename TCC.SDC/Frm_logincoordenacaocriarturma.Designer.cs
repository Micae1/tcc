namespace TCC.SDC
{
    partial class Frm_logincoordenacaocriarturma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_logincoordenacaocriarturma));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_logincoordenacaocriarturma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_senhacoordenacaocriarturma = new System.Windows.Forms.MaskedTextBox();
            this.txt_nomecoordenacaocriarturma = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Blue;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btn_logincoordenacaocriarturma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_senhacoordenacaocriarturma);
            this.groupBox1.Controls.Add(this.txt_nomecoordenacaocriarturma);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Coordenação";
            // 
            // btn_logincoordenacaocriarturma
            // 
            this.btn_logincoordenacaocriarturma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_logincoordenacaocriarturma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_logincoordenacaocriarturma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_logincoordenacaocriarturma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logincoordenacaocriarturma.Location = new System.Drawing.Point(214, 189);
            this.btn_logincoordenacaocriarturma.Name = "btn_logincoordenacaocriarturma";
            this.btn_logincoordenacaocriarturma.Size = new System.Drawing.Size(75, 46);
            this.btn_logincoordenacaocriarturma.TabIndex = 2;
            this.btn_logincoordenacaocriarturma.Text = "Login";
            this.btn_logincoordenacaocriarturma.UseVisualStyleBackColor = true;
            this.btn_logincoordenacaocriarturma.Click += new System.EventHandler(this.btn_logincoordenacaocriarturma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // txt_senhacoordenacaocriarturma
            // 
            this.txt_senhacoordenacaocriarturma.Location = new System.Drawing.Point(140, 136);
            this.txt_senhacoordenacaocriarturma.Name = "txt_senhacoordenacaocriarturma";
            this.txt_senhacoordenacaocriarturma.PasswordChar = '*';
            this.txt_senhacoordenacaocriarturma.Size = new System.Drawing.Size(232, 20);
            this.txt_senhacoordenacaocriarturma.TabIndex = 1;
            // 
            // txt_nomecoordenacaocriarturma
            // 
            this.txt_nomecoordenacaocriarturma.Location = new System.Drawing.Point(140, 61);
            this.txt_nomecoordenacaocriarturma.Name = "txt_nomecoordenacaocriarturma";
            this.txt_nomecoordenacaocriarturma.Size = new System.Drawing.Size(232, 20);
            this.txt_nomecoordenacaocriarturma.TabIndex = 0;
            // 
            // Frm_logincoordenacaocriarturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(427, 284);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_logincoordenacaocriarturma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_senhacoordenacaocriarturma;
        private System.Windows.Forms.MaskedTextBox txt_nomecoordenacaocriarturma;
        private System.Windows.Forms.Button btn_logincoordenacaocriarturma;
    }
}