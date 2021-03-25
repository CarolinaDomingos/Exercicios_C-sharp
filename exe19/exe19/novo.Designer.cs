
namespace exe19
{
    partial class novo
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_utilizador = new System.Windows.Forms.TextBox();
            this.tb_palavrapasse = new System.Windows.Forms.TextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palavra-passe:";
            // 
            // tb_utilizador
            // 
            this.tb_utilizador.Location = new System.Drawing.Point(192, 78);
            this.tb_utilizador.Name = "tb_utilizador";
            this.tb_utilizador.Size = new System.Drawing.Size(450, 20);
            this.tb_utilizador.TabIndex = 2;
            // 
            // tb_palavrapasse
            // 
            this.tb_palavrapasse.Location = new System.Drawing.Point(192, 154);
            this.tb_palavrapasse.Name = "tb_palavrapasse";
            this.tb_palavrapasse.Size = new System.Drawing.Size(450, 20);
            this.tb_palavrapasse.TabIndex = 3;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(133, 220);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(509, 73);
            this.btn_inserir.TabIndex = 4;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // novo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 332);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.tb_palavrapasse);
            this.Controls.Add(this.tb_utilizador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "novo";
            this.Text = "novo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_utilizador;
        private System.Windows.Forms.TextBox tb_palavrapasse;
        private System.Windows.Forms.Button btn_inserir;
    }
}