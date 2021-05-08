
namespace AtividadeFOO
{
    partial class FormConsultarCurso
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
            this.lbConsultarCurso = new System.Windows.Forms.Label();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.lbAlunos = new System.Windows.Forms.ListBox();
            this.lbProfessor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbConsultarCurso
            // 
            this.lbConsultarCurso.AutoSize = true;
            this.lbConsultarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultarCurso.Location = new System.Drawing.Point(12, 9);
            this.lbConsultarCurso.Name = "lbConsultarCurso";
            this.lbConsultarCurso.Size = new System.Drawing.Size(202, 29);
            this.lbConsultarCurso.TabIndex = 2;
            this.lbConsultarCurso.Text = "Nome Formulario";
            // 
            // bntCancelar
            // 
            this.bntCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelar.Location = new System.Drawing.Point(585, 56);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(86, 33);
            this.bntCancelar.TabIndex = 53;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(493, 56);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(86, 33);
            this.btnRemover.TabIndex = 52;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(412, 56);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 33);
            this.btnEditar.TabIndex = 51;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(13, 59);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(62, 24);
            this.lbNome.TabIndex = 50;
            this.lbNome.Text = "Nome";
            // 
            // cbNome
            // 
            this.cbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(81, 59);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(311, 28);
            this.cbNome.TabIndex = 49;
            this.cbNome.SelectedIndexChanged += new System.EventHandler(this.cbNome_SelectedIndexChanged);
            // 
            // txtProfessor
            // 
            this.txtProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessor.Location = new System.Drawing.Point(113, 111);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.Size = new System.Drawing.Size(375, 26);
            this.txtProfessor.TabIndex = 54;
            // 
            // lbAlunos
            // 
            this.lbAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlunos.FormattingEnabled = true;
            this.lbAlunos.ItemHeight = 24;
            this.lbAlunos.Location = new System.Drawing.Point(17, 157);
            this.lbAlunos.Name = "lbAlunos";
            this.lbAlunos.Size = new System.Drawing.Size(654, 268);
            this.lbAlunos.TabIndex = 55;
            // 
            // lbProfessor
            // 
            this.lbProfessor.AutoSize = true;
            this.lbProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfessor.Location = new System.Drawing.Point(13, 111);
            this.lbProfessor.Name = "lbProfessor";
            this.lbProfessor.Size = new System.Drawing.Size(94, 24);
            this.lbProfessor.TabIndex = 56;
            this.lbProfessor.Text = "Professor:";
            // 
            // FormConsultarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.lbProfessor);
            this.Controls.Add(this.lbAlunos);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.lbConsultarCurso);
            this.Name = "FormConsultarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConsultarCurso;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.ListBox lbAlunos;
        private System.Windows.Forms.Label lbProfessor;
    }
}