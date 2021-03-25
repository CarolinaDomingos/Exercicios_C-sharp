
namespace exe16
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
            this.tbc = new System.Windows.Forms.TabControl();
            this.tb_todos = new System.Windows.Forms.TabPage();
            this.tb_25 = new System.Windows.Forms.TabPage();
            this.rtb_todos = new System.Windows.Forms.RichTextBox();
            this.tb_curso = new System.Windows.Forms.TabPage();
            this.cbb_filtrar = new System.Windows.Forms.ComboBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_curso = new System.Windows.Forms.RichTextBox();
            this.rtb_25 = new System.Windows.Forms.RichTextBox();
            this.tbc.SuspendLayout();
            this.tb_todos.SuspendLayout();
            this.tb_25.SuspendLayout();
            this.tb_curso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tb_todos);
            this.tbc.Controls.Add(this.tb_curso);
            this.tbc.Controls.Add(this.tb_25);
            this.tbc.Location = new System.Drawing.Point(44, 16);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(681, 349);
            this.tbc.TabIndex = 0;
            // 
            // tb_todos
            // 
            this.tb_todos.Controls.Add(this.rtb_todos);
            this.tb_todos.Location = new System.Drawing.Point(4, 22);
            this.tb_todos.Name = "tb_todos";
            this.tb_todos.Padding = new System.Windows.Forms.Padding(3);
            this.tb_todos.Size = new System.Drawing.Size(673, 323);
            this.tb_todos.TabIndex = 0;
            this.tb_todos.Text = "Todos";
            this.tb_todos.UseVisualStyleBackColor = true;
            // 
            // tb_25
            // 
            this.tb_25.Controls.Add(this.rtb_25);
            this.tb_25.Location = new System.Drawing.Point(4, 22);
            this.tb_25.Name = "tb_25";
            this.tb_25.Padding = new System.Windows.Forms.Padding(3);
            this.tb_25.Size = new System.Drawing.Size(673, 323);
            this.tb_25.TabIndex = 1;
            this.tb_25.Text = "Maiores de 25";
            this.tb_25.UseVisualStyleBackColor = true;
            // 
            // rtb_todos
            // 
            this.rtb_todos.Location = new System.Drawing.Point(21, 24);
            this.rtb_todos.Name = "rtb_todos";
            this.rtb_todos.Size = new System.Drawing.Size(625, 298);
            this.rtb_todos.TabIndex = 0;
            this.rtb_todos.Text = "";
            // 
            // tb_curso
            // 
            this.tb_curso.Controls.Add(this.rtb_curso);
            this.tb_curso.Controls.Add(this.label1);
            this.tb_curso.Controls.Add(this.btn_filtrar);
            this.tb_curso.Controls.Add(this.cbb_filtrar);
            this.tb_curso.Location = new System.Drawing.Point(4, 22);
            this.tb_curso.Name = "tb_curso";
            this.tb_curso.Size = new System.Drawing.Size(673, 323);
            this.tb_curso.TabIndex = 2;
            this.tb_curso.Text = "Cursos";
            this.tb_curso.UseVisualStyleBackColor = true;
            // 
            // cbb_filtrar
            // 
            this.cbb_filtrar.FormattingEnabled = true;
            this.cbb_filtrar.Location = new System.Drawing.Point(231, 21);
            this.cbb_filtrar.Name = "cbb_filtrar";
            this.cbb_filtrar.Size = new System.Drawing.Size(121, 21);
            this.cbb_filtrar.TabIndex = 0;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(375, 21);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 1;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Curso:";
            // 
            // rtb_curso
            // 
            this.rtb_curso.Location = new System.Drawing.Point(49, 71);
            this.rtb_curso.Name = "rtb_curso";
            this.rtb_curso.Size = new System.Drawing.Size(580, 221);
            this.rtb_curso.TabIndex = 3;
            this.rtb_curso.Text = "";
            // 
            // rtb_25
            // 
            this.rtb_25.Location = new System.Drawing.Point(24, 21);
            this.rtb_25.Name = "rtb_25";
            this.rtb_25.Size = new System.Drawing.Size(590, 253);
            this.rtb_25.TabIndex = 0;
            this.rtb_25.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 377);
            this.Controls.Add(this.tbc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbc.ResumeLayout(false);
            this.tb_todos.ResumeLayout(false);
            this.tb_25.ResumeLayout(false);
            this.tb_curso.ResumeLayout(false);
            this.tb_curso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tb_todos;
        private System.Windows.Forms.TabPage tb_25;
        private System.Windows.Forms.RichTextBox rtb_todos;
        private System.Windows.Forms.TabPage tb_curso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.ComboBox cbb_filtrar;
        private System.Windows.Forms.RichTextBox rtb_curso;
        private System.Windows.Forms.RichTextBox rtb_25;
    }
}

