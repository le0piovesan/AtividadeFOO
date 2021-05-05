
namespace AtividadeFOO
{
    partial class FormularioCurso
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
            this.chlbAlunos = new System.Windows.Forms.CheckedListBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbNomeFormulario = new System.Windows.Forms.Label();
            this.lbIDCurso = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbProfessor = new System.Windows.Forms.ComboBox();
            this.lbProfessor = new System.Windows.Forms.Label();
            this.lbAlunos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chlbAlunos
            // 
            this.chlbAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlbAlunos.FormattingEnabled = true;
            this.chlbAlunos.Location = new System.Drawing.Point(12, 218);
            this.chlbAlunos.Name = "chlbAlunos";
            this.chlbAlunos.Size = new System.Drawing.Size(1072, 349);
            this.chlbAlunos.TabIndex = 0;
            this.chlbAlunos.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 574);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 45);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(127, 574);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 45);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbNomeFormulario
            // 
            this.lbNomeFormulario.AutoSize = true;
            this.lbNomeFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFormulario.Location = new System.Drawing.Point(9, 9);
            this.lbNomeFormulario.Name = "lbNomeFormulario";
            this.lbNomeFormulario.Size = new System.Drawing.Size(202, 29);
            this.lbNomeFormulario.TabIndex = 3;
            this.lbNomeFormulario.Text = "Nome Formulario";
            this.lbNomeFormulario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbIDCurso
            // 
            this.lbIDCurso.AutoSize = true;
            this.lbIDCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDCurso.Location = new System.Drawing.Point(12, 52);
            this.lbIDCurso.Name = "lbIDCurso";
            this.lbIDCurso.Size = new System.Drawing.Size(26, 20);
            this.lbIDCurso.TabIndex = 4;
            this.lbIDCurso.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(67, 52);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(10, 78);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(51, 20);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // cbProfessor
            // 
            this.cbProfessor.FormattingEnabled = true;
            this.cbProfessor.Location = new System.Drawing.Point(93, 104);
            this.cbProfessor.Name = "cbProfessor";
            this.cbProfessor.Size = new System.Drawing.Size(234, 21);
            this.cbProfessor.TabIndex = 8;
            // 
            // lbProfessor
            // 
            this.lbProfessor.AutoSize = true;
            this.lbProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfessor.Location = new System.Drawing.Point(10, 105);
            this.lbProfessor.Name = "lbProfessor";
            this.lbProfessor.Size = new System.Drawing.Size(77, 20);
            this.lbProfessor.TabIndex = 9;
            this.lbProfessor.Text = "Professor";
            // 
            // lbAlunos
            // 
            this.lbAlunos.AutoSize = true;
            this.lbAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlunos.Location = new System.Drawing.Point(12, 194);
            this.lbAlunos.Name = "lbAlunos";
            this.lbAlunos.Size = new System.Drawing.Size(58, 20);
            this.lbAlunos.TabIndex = 10;
            this.lbAlunos.Text = "Alunos";
            // 
            // FormularioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1100, 631);
            this.Controls.Add(this.lbAlunos);
            this.Controls.Add(this.lbProfessor);
            this.Controls.Add(this.cbProfessor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbIDCurso);
            this.Controls.Add(this.lbNomeFormulario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chlbAlunos);
            this.Name = "FormularioCurso";
            this.Text = "FormularioCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chlbAlunos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbNomeFormulario;
        private System.Windows.Forms.Label lbIDCurso;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbProfessor;
        private System.Windows.Forms.Label lbProfessor;
        private System.Windows.Forms.Label lbAlunos;
    }
}