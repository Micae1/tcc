namespace TCC.SDC
{
    partial class Frm_conexaocomoarduino
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
            this.btn_Presença = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_id_aluno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Presença
            // 
            this.btn_Presença.Location = new System.Drawing.Point(286, 244);
            this.btn_Presença.Name = "btn_Presença";
            this.btn_Presença.Size = new System.Drawing.Size(75, 23);
            this.btn_Presença.TabIndex = 0;
            this.btn_Presença.Text = "Presença";
            this.btn_Presença.UseVisualStyleBackColor = true;
            this.btn_Presença.Click += new System.EventHandler(this.btn_Presença_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txt_id_aluno
            // 
            this.txt_id_aluno.Location = new System.Drawing.Point(267, 137);
            this.txt_id_aluno.Name = "txt_id_aluno";
            this.txt_id_aluno.Size = new System.Drawing.Size(100, 20);
            this.txt_id_aluno.TabIndex = 2;
            // 
            // Frm_conexaocomoarduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_id_aluno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Presença);
            this.Name = "Frm_conexaocomoarduino";
            this.Text = "Frm_conexaocomoarduino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Presença;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_id_aluno;
    }
}