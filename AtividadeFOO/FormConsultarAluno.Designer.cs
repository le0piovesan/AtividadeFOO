
namespace AtividadeFOO
{
    partial class FormConsultarAluno
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
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.lbNomeFormulario = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lvAluno = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cbNome
            // 
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(70, 54);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(311, 21);
            this.cbNome.TabIndex = 0;
            // 
            // lbNomeFormulario
            // 
            this.lbNomeFormulario.AutoSize = true;
            this.lbNomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFormulario.Location = new System.Drawing.Point(12, 9);
            this.lbNomeFormulario.Name = "lbNomeFormulario";
            this.lbNomeFormulario.Size = new System.Drawing.Size(202, 29);
            this.lbNomeFormulario.TabIndex = 1;
            this.lbNomeFormulario.Text = "Nome Formulario";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(13, 54);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(51, 20);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // lvAluno
            // 
            this.lvAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAluno.HideSelection = false;
            this.lvAluno.Location = new System.Drawing.Point(17, 103);
            this.lvAluno.Name = "lvAluno";
            this.lvAluno.Size = new System.Drawing.Size(752, 325);
            this.lvAluno.TabIndex = 3;
            this.lvAluno.UseCompatibleStateImageBehavior = false;
            // 
            // FormConsultarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvAluno);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbNomeFormulario);
            this.Controls.Add(this.cbNome);
            this.Name = "FormConsultarAluno";
            this.Text = "FormConsultarAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.Label lbNomeFormulario;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ListView lvAluno;
    }
}