
namespace exe18
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
            this.btn_encriptar = new System.Windows.Forms.Button();
            this.tb_original = new System.Windows.Forms.TextBox();
            this.lbl_encriptar = new System.Windows.Forms.Label();
            this.btn_desencriptar = new System.Windows.Forms.Button();
            this.lbl_desencriptado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto Original:";
            // 
            // btn_encriptar
            // 
            this.btn_encriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encriptar.Location = new System.Drawing.Point(241, 94);
            this.btn_encriptar.Name = "btn_encriptar";
            this.btn_encriptar.Size = new System.Drawing.Size(497, 84);
            this.btn_encriptar.TabIndex = 1;
            this.btn_encriptar.Text = "Encriptar";
            this.btn_encriptar.UseVisualStyleBackColor = true;
            this.btn_encriptar.Click += new System.EventHandler(this.btn_encriptar_Click);
            // 
            // tb_original
            // 
            this.tb_original.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_original.Location = new System.Drawing.Point(241, 38);
            this.tb_original.Name = "tb_original";
            this.tb_original.Size = new System.Drawing.Size(497, 35);
            this.tb_original.TabIndex = 2;
            // 
            // lbl_encriptar
            // 
            this.lbl_encriptar.AutoSize = true;
            this.lbl_encriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_encriptar.Location = new System.Drawing.Point(12, 201);
            this.lbl_encriptar.Name = "lbl_encriptar";
            this.lbl_encriptar.Size = new System.Drawing.Size(0, 29);
            this.lbl_encriptar.TabIndex = 3;
            // 
            // btn_desencriptar
            // 
            this.btn_desencriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desencriptar.Location = new System.Drawing.Point(241, 237);
            this.btn_desencriptar.Name = "btn_desencriptar";
            this.btn_desencriptar.Size = new System.Drawing.Size(497, 84);
            this.btn_desencriptar.TabIndex = 4;
            this.btn_desencriptar.Text = "Desencriptar";
            this.btn_desencriptar.UseVisualStyleBackColor = true;
            this.btn_desencriptar.Click += new System.EventHandler(this.btn_desencriptar_Click);
            // 
            // lbl_desencriptado
            // 
            this.lbl_desencriptado.AutoSize = true;
            this.lbl_desencriptado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desencriptado.Location = new System.Drawing.Point(76, 356);
            this.lbl_desencriptado.Name = "lbl_desencriptado";
            this.lbl_desencriptado.Size = new System.Drawing.Size(0, 29);
            this.lbl_desencriptado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 407);
            this.Controls.Add(this.lbl_desencriptado);
            this.Controls.Add(this.btn_desencriptar);
            this.Controls.Add(this.lbl_encriptar);
            this.Controls.Add(this.tb_original);
            this.Controls.Add(this.btn_encriptar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_encriptar;
        private System.Windows.Forms.TextBox tb_original;
        private System.Windows.Forms.Label lbl_encriptar;
        private System.Windows.Forms.Button btn_desencriptar;
        private System.Windows.Forms.Label lbl_desencriptado;
    }
}

