namespace TCC.SDC
{
    partial class Frm_listapresencaprofessor
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
            this.dGV_listapresencaprofessor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_listapresencaprofessor)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_listapresencaprofessor
            // 
            this.dGV_listapresencaprofessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_listapresencaprofessor.Location = new System.Drawing.Point(118, 70);
            this.dGV_listapresencaprofessor.Name = "dGV_listapresencaprofessor";
            this.dGV_listapresencaprofessor.Size = new System.Drawing.Size(557, 237);
            this.dGV_listapresencaprofessor.TabIndex = 0;
            this.dGV_listapresencaprofessor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_listapresencaprofessor_CellContentClick);
            // 
            // Frm_listapresencaprofessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGV_listapresencaprofessor);
            this.Name = "Frm_listapresencaprofessor";
            this.Text = "Frm_listapresencaprofessor";
            this.Load += new System.EventHandler(this.Frm_listapresencaprofessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_listapresencaprofessor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_listapresencaprofessor;
    }
}