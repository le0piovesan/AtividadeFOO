using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeFOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lbNomeFormulario.Text = "Curso de TADS.";
        }

        public void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioAluno fa = new FormularioAluno();
            fa.ShowDialog(this);
        }

        public void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioProfessor fp = new FormularioProfessor();
            fp.ShowDialog(this);
        }

        public void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCurso fc = new FormularioCurso();
            fc.ShowDialog(this);
        }
    }
}
