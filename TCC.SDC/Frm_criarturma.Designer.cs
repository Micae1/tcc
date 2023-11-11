namespace TCC.SDC
{
    partial class Frm_criarturma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_criarturma));
            this.btn_criarturma = new System.Windows.Forms.Button();
            this.txt_criarturma = new System.Windows.Forms.TextBox();
            this.gpb_criarturma = new System.Windows.Forms.GroupBox();
            this.btn_excluirturma = new System.Windows.Forms.Button();
            this.gpb_criarturma.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_criarturma
            // 
            this.btn_criarturma.BackColor = System.Drawing.Color.Blue;
            this.btn_criarturma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_criarturma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_criarturma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_criarturma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_criarturma.Location = new System.Drawing.Point(122, 152);
            this.btn_criarturma.Name = "btn_criarturma";
            this.btn_criarturma.Size = new System.Drawing.Size(118, 41);
            this.btn_criarturma.TabIndex = 1;
            this.btn_criarturma.Text = "Criar Turma";
            this.btn_criarturma.UseVisualStyleBackColor = false;
            this.btn_criarturma.Click += new System.EventHandler(this.btn_criarturma_Click);
            // 
            // txt_criarturma
            // 
            this.txt_criarturma.Location = new System.Drawing.Point(38, 86);
            this.txt_criarturma.Name = "txt_criarturma";
            this.txt_criarturma.Size = new System.Drawing.Size(547, 20);
            this.txt_criarturma.TabIndex = 0;
            // 
            // gpb_criarturma
            // 
            this.gpb_criarturma.BackColor = System.Drawing.Color.Navy;
            this.gpb_criarturma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gpb_criarturma.BackgroundImage")));
            this.gpb_criarturma.Controls.Add(this.btn_excluirturma);
            this.gpb_criarturma.Controls.Add(this.txt_criarturma);
            this.gpb_criarturma.Controls.Add(this.btn_criarturma);
            this.gpb_criarturma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpb_criarturma.ForeColor = System.Drawing.Color.White;
            this.gpb_criarturma.Location = new System.Drawing.Point(13, 13);
            this.gpb_criarturma.Name = "gpb_criarturma";
            this.gpb_criarturma.Size = new System.Drawing.Size(607, 264);
            this.gpb_criarturma.TabIndex = 0;
            this.gpb_criarturma.TabStop = false;
            this.gpb_criarturma.Text = "Criar Turma";
            // 
            // btn_excluirturma
            // 
            this.btn_excluirturma.BackColor = System.Drawing.Color.Blue;
            this.btn_excluirturma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_excluirturma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_excluirturma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_excluirturma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluirturma.Location = new System.Drawing.Point(385, 152);
            this.btn_excluirturma.Name = "btn_excluirturma";
            this.btn_excluirturma.Size = new System.Drawing.Size(118, 42);
            this.btn_excluirturma.TabIndex = 2;
            this.btn_excluirturma.Text = "Excluir turma";
            this.btn_excluirturma.UseVisualStyleBackColor = false;
            this.btn_excluirturma.Click += new System.EventHandler(this.btn_excluirturma_Click);
            // 
            // Frm_criarturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(632, 289);
            this.Controls.Add(this.gpb_criarturma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_criarturma";
            this.gpb_criarturma.ResumeLayout(false);
            this.gpb_criarturma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_criarturma;
        private System.Windows.Forms.TextBox txt_criarturma;
        private System.Windows.Forms.GroupBox gpb_criarturma;
        private System.Windows.Forms.Button btn_excluirturma;
    }
}