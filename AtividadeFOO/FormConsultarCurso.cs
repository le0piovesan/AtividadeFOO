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
    public partial class FormConsultarCurso : Form
    {
        public FormConsultarCurso()
        {
            InitializeComponent();

            lbConsultarCurso.Text = "Consulta de Cursos";


            InitializeDados();
        }

        private void InitializeDados()
        {
            Curso cr = new Curso();
            List<Curso> Cursos = cr.RetornarListaCompleta();

            cbNome.Items.Clear();
            cbNome.Items.AddRange(Cursos.ToArray());
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            Curso c = cbNome.SelectedItem as Curso;

            lbAlunos.Items.Clear();
            lbAlunos.Items.AddRange(c.Alunos.ToArray());

            txtProfessor.Text = c.Professor.Nome;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Curso c = cbNome.SelectedItem as Curso;

            FormularioCurso fc = new FormularioCurso();
            fc.PopulaCampos(c);
            fc.ShowDialog();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Curso c = cbNome.SelectedItem as Curso;

            Curso cr = new Curso();
            List<Curso> Cursos = cr.RetornarListaCompleta();

            foreach (Curso curso in Cursos)
            {
                if (c.IDCurso == curso.IDCurso)
                {
                    cbNome.Items.Remove(curso);
                }
            }


            c.Remover(c);

            cbNome.Items.Clear();
            txtProfessor.Text = ""; 
            lbAlunos.Items.Clear();
          
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
