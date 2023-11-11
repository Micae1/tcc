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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_listapresencaprofessor));
            this.dGV_listapresencaprofessor = new System.Windows.Forms.DataGridView();
            this.btn_consultarturmaprofessor = new System.Windows.Forms.Button();
            this.lbl_nometurma = new System.Windows.Forms.Label();
            this.txt_consultarturmaprofessor = new System.Windows.Forms.TextBox();
            this.btn_printlistapresencaprofessor = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_pesquisarid = new System.Windows.Forms.Button();
            this.txt_idaluno = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_registrarhoraentrada = new System.Windows.Forms.Button();
            this.btn_registrarhorasaida = new System.Windows.Forms.Button();
            this.pictureBox1_fotodgv = new System.Windows.Forms.PictureBox();
            this.btn_exibirfoto = new System.Windows.Forms.Button();
            this.txt_exibirfoto = new System.Windows.Forms.TextBox();
            this.txt_registrapresenca = new System.Windows.Forms.TextBox();
            this.txt_registrafalta = new System.Windows.Forms.TextBox();
            this.btn_apagarhoraentrada = new System.Windows.Forms.Button();
            this.btn_apagarhorasaida = new System.Windows.Forms.Button();
            this.btn_pesquisaridprofessor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idprofessor = new System.Windows.Forms.TextBox();
            this.btn_limparlista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_listapresencaprofessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_fotodgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_listapresencaprofessor
            // 
            this.dGV_listapresencaprofessor.BackgroundColor = System.Drawing.Color.White;
            this.dGV_listapresencaprofessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_listapresencaprofessor.Location = new System.Drawing.Point(12, 158);
            this.dGV_listapresencaprofessor.Name = "dGV_listapresencaprofessor";
            this.dGV_listapresencaprofessor.ReadOnly = true;
            this.dGV_listapresencaprofessor.Size = new System.Drawing.Size(663, 263);
            this.dGV_listapresencaprofessor.TabIndex = 3;
            this.dGV_listapresencaprofessor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_listapresencaprofessor_CellContentClick);
            // 
            // btn_consultarturmaprofessor
            // 
            this.btn_consultarturmaprofessor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_consultarturmaprofessor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_consultarturmaprofessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_consultarturmaprofessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultarturmaprofessor.Location = new System.Drawing.Point(12, 55);
            this.btn_consultarturmaprofessor.Name = "btn_consultarturmaprofessor";
            this.btn_consultarturmaprofessor.Size = new System.Drawing.Size(75, 23);
            this.btn_consultarturmaprofessor.TabIndex = 1;
            this.btn_consultarturmaprofessor.Text = "Consultar";
            this.btn_consultarturmaprofessor.UseVisualStyleBackColor = true;
            this.btn_consultarturmaprofessor.Click += new System.EventHandler(this.btn_consultarturmaprofessor_Click_1);
            // 
            // lbl_nometurma
            // 
            this.lbl_nometurma.AutoSize = true;
            this.lbl_nometurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nometurma.Location = new System.Drawing.Point(12, 6);
            this.lbl_nometurma.Name = "lbl_nometurma";
            this.lbl_nometurma.Size = new System.Drawing.Size(135, 20);
            this.lbl_nometurma.TabIndex = 2;
            this.lbl_nometurma.Text = "Nome da Turma";
            // 
            // txt_consultarturmaprofessor
            // 
            this.txt_consultarturmaprofessor.Location = new System.Drawing.Point(12, 29);
            this.txt_consultarturmaprofessor.Name = "txt_consultarturmaprofessor";
            this.txt_consultarturmaprofessor.Size = new System.Drawing.Size(253, 20);
            this.txt_consultarturmaprofessor.TabIndex = 0;
            // 
            // btn_printlistapresencaprofessor
            // 
            this.btn_printlistapresencaprofessor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_printlistapresencaprofessor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_printlistapresencaprofessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_printlistapresencaprofessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printlistapresencaprofessor.Location = new System.Drawing.Point(688, 218);
            this.btn_printlistapresencaprofessor.Name = "btn_printlistapresencaprofessor";
            this.btn_printlistapresencaprofessor.Size = new System.Drawing.Size(75, 23);
            this.btn_printlistapresencaprofessor.TabIndex = 13;
            this.btn_printlistapresencaprofessor.Text = "Print";
            this.btn_printlistapresencaprofessor.UseVisualStyleBackColor = true;
            this.btn_printlistapresencaprofessor.Click += new System.EventHandler(this.btn_printlistapresencaprofessor_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_pesquisarid
            // 
            this.btn_pesquisarid.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_pesquisarid.FlatAppearance.BorderSize = 0;
            this.btn_pesquisarid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_pesquisarid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_pesquisarid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisarid.Location = new System.Drawing.Point(12, 126);
            this.btn_pesquisarid.Name = "btn_pesquisarid";
            this.btn_pesquisarid.Size = new System.Drawing.Size(93, 23);
            this.btn_pesquisarid.TabIndex = 8;
            this.btn_pesquisarid.Text = "Pesquisar ";
            this.btn_pesquisarid.UseVisualStyleBackColor = true;
            this.btn_pesquisarid.Click += new System.EventHandler(this.btn_pesquisarid_Click);
            // 
            // txt_idaluno
            // 
            this.txt_idaluno.Location = new System.Drawing.Point(12, 104);
            this.txt_idaluno.Name = "txt_idaluno";
            this.txt_idaluno.Size = new System.Drawing.Size(104, 20);
            this.txt_idaluno.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(427, 16);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(87, 20);
            this.txt_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID do Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID ";
            // 
            // btn_registrarhoraentrada
            // 
            this.btn_registrarhoraentrada.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_registrarhoraentrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_registrarhoraentrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_registrarhoraentrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarhoraentrada.Location = new System.Drawing.Point(313, 68);
            this.btn_registrarhoraentrada.Name = "btn_registrarhoraentrada";
            this.btn_registrarhoraentrada.Size = new System.Drawing.Size(140, 23);
            this.btn_registrarhoraentrada.TabIndex = 3;
            this.btn_registrarhoraentrada.Text = "Registrar Hora Entrada";
            this.btn_registrarhoraentrada.UseVisualStyleBackColor = true;
            this.btn_registrarhoraentrada.Click += new System.EventHandler(this.btn_registrarhora_Click);
            // 
            // btn_registrarhorasaida
            // 
            this.btn_registrarhorasaida.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_registrarhorasaida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_registrarhorasaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btn_registrarhorasaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarhorasaida.Location = new System.Drawing.Point(489, 68);
            this.btn_registrarhorasaida.Name = "btn_registrarhorasaida";
            this.btn_registrarhorasaida.Size = new System.Drawing.Size(140, 23);
            this.btn_registrarhorasaida.TabIndex = 4;
            this.btn_registrarhorasaida.Text = "Registrar Hora  Saida";
            this.btn_registrarhorasaida.UseVisualStyleBackColor = true;
            this.btn_registrarhorasaida.Click += new System.EventHandler(this.btn_registrarhorasaida_Click);
            // 
            // pictureBox1_fotodgv
            // 
            this.pictureBox1_fotodgv.Location = new System.Drawing.Point(635, 12);
            this.pictureBox1_fotodgv.Name = "pictureBox1_fotodgv";
            this.pictureBox1_fotodgv.Size = new System.Drawing.Size(153, 134);
            this.pictureBox1_fotodgv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_fotodgv.TabIndex = 16;
            this.pictureBox1_fotodgv.TabStop = false;
            // 
            // btn_exibirfoto
            // 
            this.btn_exibirfoto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_exibirfoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_exibirfoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_exibirfoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exibirfoto.Location = new System.Drawing.Point(688, 189);
            this.btn_exibirfoto.Name = "btn_exibirfoto";
            this.btn_exibirfoto.Size = new System.Drawing.Size(75, 23);
            this.btn_exibirfoto.TabIndex = 12;
            this.btn_exibirfoto.Text = "Exibir Foto";
            this.btn_exibirfoto.UseVisualStyleBackColor = true;
            this.btn_exibirfoto.Click += new System.EventHandler(this.btn_exibirfoto_Click);
            // 
            // txt_exibirfoto
            // 
            this.txt_exibirfoto.Location = new System.Drawing.Point(688, 158);
            this.txt_exibirfoto.Name = "txt_exibirfoto";
            this.txt_exibirfoto.Size = new System.Drawing.Size(100, 20);
            this.txt_exibirfoto.TabIndex = 11;
            // 
            // txt_registrapresenca
            // 
            this.txt_registrapresenca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_registrapresenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_registrapresenca.ForeColor = System.Drawing.Color.White;
            this.txt_registrapresenca.Location = new System.Drawing.Point(371, 42);
            this.txt_registrapresenca.Name = "txt_registrapresenca";
            this.txt_registrapresenca.Size = new System.Drawing.Size(212, 20);
            this.txt_registrapresenca.TabIndex = 19;
            this.txt_registrapresenca.Text = "Digite o ID da Linha a ser Afetada";
            // 
            // txt_registrafalta
            // 
            this.txt_registrafalta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_registrafalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_registrafalta.ForeColor = System.Drawing.Color.White;
            this.txt_registrafalta.Location = new System.Drawing.Point(371, 97);
            this.txt_registrafalta.Name = "txt_registrafalta";
            this.txt_registrafalta.Size = new System.Drawing.Size(212, 20);
            this.txt_registrafalta.TabIndex = 20;
            this.txt_registrafalta.Text = "Selecione a Linha a ser Afetada";
            // 
            // btn_apagarhoraentrada
            // 
            this.btn_apagarhoraentrada.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_apagarhoraentrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagarhoraentrada.Location = new System.Drawing.Point(313, 123);
            this.btn_apagarhoraentrada.Name = "btn_apagarhoraentrada";
            this.btn_apagarhoraentrada.Size = new System.Drawing.Size(133, 23);
            this.btn_apagarhoraentrada.TabIndex = 5;
            this.btn_apagarhoraentrada.Text = "Apagar Hora Entrada";
            this.btn_apagarhoraentrada.UseVisualStyleBackColor = true;
            this.btn_apagarhoraentrada.Click += new System.EventHandler(this.btn_apagarhoraentrada_Click);
            // 
            // btn_apagarhorasaida
            // 
            this.btn_apagarhorasaida.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_apagarhorasaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagarhorasaida.Location = new System.Drawing.Point(496, 123);
            this.btn_apagarhorasaida.Name = "btn_apagarhorasaida";
            this.btn_apagarhorasaida.Size = new System.Drawing.Size(133, 23);
            this.btn_apagarhorasaida.TabIndex = 6;
            this.btn_apagarhorasaida.Text = "Apagar Hora Saida";
            this.btn_apagarhorasaida.UseVisualStyleBackColor = true;
            this.btn_apagarhorasaida.Click += new System.EventHandler(this.btn_apagarhorasaida_Click);
            // 
            // btn_pesquisaridprofessor
            // 
            this.btn_pesquisaridprofessor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_pesquisaridprofessor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_pesquisaridprofessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_pesquisaridprofessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisaridprofessor.Location = new System.Drawing.Point(162, 129);
            this.btn_pesquisaridprofessor.Name = "btn_pesquisaridprofessor";
            this.btn_pesquisaridprofessor.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisaridprofessor.TabIndex = 10;
            this.btn_pesquisaridprofessor.Text = "Pesquisar ID";
            this.btn_pesquisaridprofessor.UseVisualStyleBackColor = true;
            this.btn_pesquisaridprofessor.Click += new System.EventHandler(this.btn_pesquisaridprofessor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID do Professor";
            // 
            // txt_idprofessor
            // 
            this.txt_idprofessor.Location = new System.Drawing.Point(134, 104);
            this.txt_idprofessor.Name = "txt_idprofessor";
            this.txt_idprofessor.Size = new System.Drawing.Size(131, 20);
            this.txt_idprofessor.TabIndex = 9;
            // 
            // btn_limparlista
            // 
            this.btn_limparlista.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_limparlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparlista.Location = new System.Drawing.Point(688, 270);
            this.btn_limparlista.Name = "btn_limparlista";
            this.btn_limparlista.Size = new System.Drawing.Size(100, 23);
            this.btn_limparlista.TabIndex = 25;
            this.btn_limparlista.Text = "Limpar a lista";
            this.btn_limparlista.UseVisualStyleBackColor = true;
            this.btn_limparlista.Click += new System.EventHandler(this.btn_limparlista_Click);
            // 
            // Frm_listapresencaprofessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_limparlista);
            this.Controls.Add(this.txt_idprofessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_pesquisaridprofessor);
            this.Controls.Add(this.btn_apagarhorasaida);
            this.Controls.Add(this.btn_apagarhoraentrada);
            this.Controls.Add(this.txt_registrafalta);
            this.Controls.Add(this.txt_registrapresenca);
            this.Controls.Add(this.txt_exibirfoto);
            this.Controls.Add(this.btn_exibirfoto);
            this.Controls.Add(this.pictureBox1_fotodgv);
            this.Controls.Add(this.btn_registrarhorasaida);
            this.Controls.Add(this.btn_registrarhoraentrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_idaluno);
            this.Controls.Add(this.btn_pesquisarid);
            this.Controls.Add(this.btn_printlistapresencaprofessor);
            this.Controls.Add(this.txt_consultarturmaprofessor);
            this.Controls.Add(this.lbl_nometurma);
            this.Controls.Add(this.btn_consultarturmaprofessor);
            this.Controls.Add(this.dGV_listapresencaprofessor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_listapresencaprofessor";
            this.Text = "Lista de Presença Turma";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_listapresencaprofessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_fotodgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_listapresencaprofessor;
        private System.Windows.Forms.Button btn_consultarturmaprofessor;
        private System.Windows.Forms.Label lbl_nometurma;
        private System.Windows.Forms.TextBox txt_consultarturmaprofessor;
        private System.Windows.Forms.Button btn_printlistapresencaprofessor;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_pesquisarid;
        private System.Windows.Forms.TextBox txt_idaluno;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_registrarhoraentrada;
        private System.Windows.Forms.Button btn_registrarhorasaida;
        private System.Windows.Forms.PictureBox pictureBox1_fotodgv;
        private System.Windows.Forms.Button btn_exibirfoto;
        private System.Windows.Forms.TextBox txt_exibirfoto;
        private System.Windows.Forms.TextBox txt_registrapresenca;
        private System.Windows.Forms.TextBox txt_registrafalta;
        private System.Windows.Forms.Button btn_apagarhoraentrada;
        private System.Windows.Forms.Button btn_apagarhorasaida;
        private System.Windows.Forms.Button btn_pesquisaridprofessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_idprofessor;
        private System.Windows.Forms.Button btn_limparlista;
    }
}