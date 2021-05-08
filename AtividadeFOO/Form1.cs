using ProjetoFaculdade.Entidades;
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
        private List<object> Professores;

        public Form1()
        {
            InitializeComponent();

            lbNomeFormulario.Text = "Trabalho Bimestral Univel.";
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

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultarAluno fca = new FormConsultarAluno();
            fca.ShowDialog(this);
        }

        private void professorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            FormConsultarProfessor fcp = new FormConsultarProfessor();
            fcp.ShowDialog(this);
        }

        private void cursoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultarCurso fcc = new FormConsultarCurso();
            fcc.ShowDialog(this);
        }
    }
}
