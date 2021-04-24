
namespace AtividadeFOO
{
    partial class FormConsultarProfessor
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
            this.lvProfessor = new System.Windows.Forms.ListView();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbNomeFormulario = new System.Windows.Forms.Label();
            this.cbProfessor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvProfessor
            // 
            this.lvProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProfessor.HideSelection = false;
            this.lvProfessor.Location = new System.Drawing.Point(27, 110);
            this.lvProfessor.Name = "lvProfessor";
            this.lvProfessor.Size = new System.Drawing.Size(752, 325);
            this.lvProfessor.TabIndex = 7;
            this.lvProfessor.UseCompatibleStateImageBehavior = false;
            this.lvProfessor.SelectedIndexChanged += new System.EventHandler(this.lvProfessor_SelectedIndexChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(23, 61);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(51, 20);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome";
            // 
            // lbNomeFormulario
            // 
            this.lbNomeFormulario.AutoSize = true;
            this.lbNomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFormulario.Location = new System.Drawing.Point(22, 16);
            this.lbNomeFormulario.Name = "lbNomeFormulario";
            this.lbNomeFormulario.Size = new System.Drawing.Size(202, 29);
            this.lbNomeFormulario.TabIndex = 5;
            this.lbNomeFormulario.Text = "Nome Formulario";
            // 
            // cbProfessor
            // 
            this.cbProfessor.FormattingEnabled = true;
            this.cbProfessor.Location = new System.Drawing.Point(80, 61);
            this.cbProfessor.Name = "cbProfessor";
            this.cbProfessor.Size = new System.Drawing.Size(311, 21);
            this.cbProfessor.TabIndex = 4;
            this.cbProfessor.SelectedIndexChanged += new System.EventHandler(this.cbNome_SelectedIndexChanged);
            // 
            // FormConsultarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvProfessor);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbNomeFormulario);
            this.Controls.Add(this.cbProfessor);
            this.Name = "FormConsultarProfessor";
            this.Text = "FormConsultarProfessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProfessor;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbNomeFormulario;
        private System.Windows.Forms.ComboBox cbProfessor;
    }
}