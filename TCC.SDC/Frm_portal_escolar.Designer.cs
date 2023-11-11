namespace TCC.SDC
{
    partial class Frm_portal_escolar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_portal_escolar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.coordenaçaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePresençaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePresençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePresençaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coordenaçaoToolStripMenuItem,
            this.professorToolStripMenuItem1,
            this.alunoToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // coordenaçaoToolStripMenuItem
            // 
            this.coordenaçaoToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.coordenaçaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem,
            this.criarTurmaToolStripMenuItem,
            this.listaDePresençaToolStripMenuItem2});
            this.coordenaçaoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.coordenaçaoToolStripMenuItem.Name = "coordenaçaoToolStripMenuItem";
            this.coordenaçaoToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.coordenaçaoToolStripMenuItem.Text = "Coordenação";
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem});
            this.cadastrarAlunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarAlunoToolStripMenuItem.Image")));
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar ";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alunoToolStripMenuItem.Image")));
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("professorToolStripMenuItem.Image")));
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.professorToolStripMenuItem.Text = "Professor";
            this.professorToolStripMenuItem.Click += new System.EventHandler(this.professorToolStripMenuItem_Click);
            // 
            // criarTurmaToolStripMenuItem
            // 
            this.criarTurmaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("criarTurmaToolStripMenuItem.Image")));
            this.criarTurmaToolStripMenuItem.Name = "criarTurmaToolStripMenuItem";
            this.criarTurmaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.criarTurmaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.criarTurmaToolStripMenuItem.Text = "Criar Turma";
            this.criarTurmaToolStripMenuItem.Click += new System.EventHandler(this.criarTurmaToolStripMenuItem_Click);
            // 
            // listaDePresençaToolStripMenuItem2
            // 
            this.listaDePresençaToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("listaDePresençaToolStripMenuItem2.Image")));
            this.listaDePresençaToolStripMenuItem2.Name = "listaDePresençaToolStripMenuItem2";
            this.listaDePresençaToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.listaDePresençaToolStripMenuItem2.Size = new System.Drawing.Size(204, 22);
            this.listaDePresençaToolStripMenuItem2.Text = "Lista de Presença";
            this.listaDePresençaToolStripMenuItem2.Click += new System.EventHandler(this.listaDePresençaToolStripMenuItem2_Click);
            // 
            // professorToolStripMenuItem1
            // 
            this.professorToolStripMenuItem1.BackColor = System.Drawing.Color.Navy;
            this.professorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDePresençaToolStripMenuItem});
            this.professorToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.professorToolStripMenuItem1.Name = "professorToolStripMenuItem1";
            this.professorToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.professorToolStripMenuItem1.Text = "Professor";
            // 
            // listaDePresençaToolStripMenuItem
            // 
            this.listaDePresençaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDePresençaToolStripMenuItem.Image")));
            this.listaDePresençaToolStripMenuItem.Name = "listaDePresençaToolStripMenuItem";
            this.listaDePresençaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.listaDePresençaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listaDePresençaToolStripMenuItem.Text = "Lista de Presença";
            this.listaDePresençaToolStripMenuItem.Click += new System.EventHandler(this.listaDePresençaToolStripMenuItem_Click);
            // 
            // alunoToolStripMenuItem1
            // 
            this.alunoToolStripMenuItem1.BackColor = System.Drawing.Color.Navy;
            this.alunoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDePresençaToolStripMenuItem1});
            this.alunoToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.alunoToolStripMenuItem1.Name = "alunoToolStripMenuItem1";
            this.alunoToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.alunoToolStripMenuItem1.Text = "aluno";
            // 
            // listaDePresençaToolStripMenuItem1
            // 
            this.listaDePresençaToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("listaDePresençaToolStripMenuItem1.Image")));
            this.listaDePresençaToolStripMenuItem1.Name = "listaDePresençaToolStripMenuItem1";
            this.listaDePresençaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.listaDePresençaToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.listaDePresençaToolStripMenuItem1.Text = "Lista de Presença";
            this.listaDePresençaToolStripMenuItem1.Click += new System.EventHandler(this.listaDePresençaToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1148, 660);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_portal_escolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(959, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3497, 3000);
            this.MinimumSize = new System.Drawing.Size(960, 486);
            this.Name = "Frm_portal_escolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem coordenaçaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDePresençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDePresençaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem criarTurmaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem listaDePresençaToolStripMenuItem2;
    }
}

