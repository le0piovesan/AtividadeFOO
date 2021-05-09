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
    public partial class FormularioCurso : Form
    {
        public FormularioCurso()
        {
            InitializeComponent();

            lbNomeFormulario.Text = "Cadastro de Turma";

            InitializeProfessores();
            InitializeComboAlunos();

            Curso c = new Curso();

            txtID.Text = c.ProximoID().ToString();
        }

        public void InitializeProfessores()
        {
            Professor prof = new Professor();
            List<Professor> Professores = prof.RetornarListaCompleta(); 
            cbProfessor.Items.Clear();
            Professores.ForEach(professor =>
            {
                cbProfessor.Items.Add(professor);
            });
        }

        private void InitializeComboAlunos()
        {
            List<Aluno> alunos = new Aluno().RetornarListaCompleta();
            chlbAlunos.Items.Clear();
            alunos.ForEach(aluno =>
            {
                chlbAlunos.Items.Add(aluno, false);
            });
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Professor p = cbProfessor.SelectedItem as Professor;
            List<Aluno>  alunos = chlbAlunos.SelectedItems.OfType<Aluno>().ToList();


            Curso c = new Curso();
            c.IDCurso = Convert.ToInt32(txtID.Text);
            c.Nome = txtNome.Text;
            c.Professor = p;
            c.Alunos = alunos;

            c.Salvar(c);

            if (!ValidarObjeto(c))
                return;

            LimparTela();

            bool ValidarObjeto(Curso CursoValidar)
            {
                if (string.IsNullOrEmpty(CursoValidar.Nome))
                {
                    MessageBox.Show(this, "Preencha o campo Nome!", "ATENÇÃO!!");
                    return false;
                }

                return true;
            }

            MessageBox.Show(this, "Curso salvo.", "Aviso.");
            this.Hide();

        }

        public void PopulaCampos(Curso cr)
        {
            txtID.Text = cr.ProximoID().ToString();
            txtNome.Text = cr.Nome;
            cbProfessor.SelectedItem = cr.Professor;
            cr.Alunos.ForEach(aluno =>
            {
                int index = chlbAlunos.Items.IndexOf(aluno);
                chlbAlunos.SetItemChecked(index, true);
            });
        }

        private void LimparTela()
        {
            txtID.Text = "";
            txtNome.Text = "";
            cbProfessor.Items.Clear();
            chlbAlunos.Items.Clear();
        }
    }
}
