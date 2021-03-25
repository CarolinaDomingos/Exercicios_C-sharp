
namespace exe19
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_caminho = new System.Windows.Forms.TextBox();
            this.btn_ficheiro = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_lerficheiro = new System.Windows.Forms.Button();
            this.lst_utilizadores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_utilizador = new System.Windows.Forms.TextBox();
            this.tb_palavrapasse = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUtilizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ficheiro de dados:";
            // 
            // tb_caminho
            // 
            this.tb_caminho.Enabled = false;
            this.tb_caminho.Location = new System.Drawing.Point(166, 33);
            this.tb_caminho.Name = "tb_caminho";
            this.tb_caminho.Size = new System.Drawing.Size(604, 20);
            this.tb_caminho.TabIndex = 1;
            // 
            // btn_ficheiro
            // 
            this.btn_ficheiro.Location = new System.Drawing.Point(782, 33);
            this.btn_ficheiro.Name = "btn_ficheiro";
            this.btn_ficheiro.Size = new System.Drawing.Size(75, 23);
            this.btn_ficheiro.TabIndex = 2;
            this.btn_ficheiro.Text = "Escolher";
            this.btn_ficheiro.UseVisualStyleBackColor = true;
            this.btn_ficheiro.Click += new System.EventHandler(this.btn_ficheiro_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_lerficheiro
            // 
            this.btn_lerficheiro.Location = new System.Drawing.Point(690, 63);
            this.btn_lerficheiro.Name = "btn_lerficheiro";
            this.btn_lerficheiro.Size = new System.Drawing.Size(167, 23);
            this.btn_lerficheiro.TabIndex = 3;
            this.btn_lerficheiro.Text = "Ler ficheiro";
            this.btn_lerficheiro.UseVisualStyleBackColor = true;
            this.btn_lerficheiro.Click += new System.EventHandler(this.btn_lerficheiro_Click);
            // 
            // lst_utilizadores
            // 
            this.lst_utilizadores.FormattingEnabled = true;
            this.lst_utilizadores.Location = new System.Drawing.Point(12, 78);
            this.lst_utilizadores.Name = "lst_utilizadores";
            this.lst_utilizadores.Size = new System.Drawing.Size(336, 316);
            this.lst_utilizadores.TabIndex = 4;
            this.lst_utilizadores.SelectedIndexChanged += new System.EventHandler(this.lst_utilizadores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Utilizador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Palavra-passe:";
            // 
            // tb_utilizador
            // 
            this.tb_utilizador.Enabled = false;
            this.tb_utilizador.Location = new System.Drawing.Point(465, 122);
            this.tb_utilizador.Name = "tb_utilizador";
            this.tb_utilizador.Size = new System.Drawing.Size(339, 20);
            this.tb_utilizador.TabIndex = 7;
            // 
            // tb_palavrapasse
            // 
            this.tb_palavrapasse.Location = new System.Drawing.Point(502, 168);
            this.tb_palavrapasse.Name = "tb_palavrapasse";
            this.tb_palavrapasse.Size = new System.Drawing.Size(302, 20);
            this.tb_palavrapasse.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUtilizadorToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // novoUtilizadorToolStripMenuItem
            // 
            this.novoUtilizadorToolStripMenuItem.Name = "novoUtilizadorToolStripMenuItem";
            this.novoUtilizadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoUtilizadorToolStripMenuItem.Text = "Novo Utilizador";
            this.novoUtilizadorToolStripMenuItem.Click += new System.EventHandler(this.novoUtilizadorToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(612, 251);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(199, 56);
            this.btn_gravar.TabIndex = 10;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(372, 251);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(199, 56);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 402);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.tb_palavrapasse);
            this.Controls.Add(this.tb_utilizador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_utilizadores);
            this.Controls.Add(this.btn_lerficheiro);
            this.Controls.Add(this.btn_ficheiro);
            this.Controls.Add(this.tb_caminho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestão de Utilizadores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_caminho;
        private System.Windows.Forms.Button btn_ficheiro;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_lerficheiro;
        private System.Windows.Forms.ListBox lst_utilizadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_utilizador;
        private System.Windows.Forms.TextBox tb_palavrapasse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUtilizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}

