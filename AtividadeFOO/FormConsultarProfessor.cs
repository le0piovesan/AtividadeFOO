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
    public partial class FormConsultarProfessor : Form
    {
        public FormConsultarProfessor()
        {
            InitializeComponent();

            InicializaCombo();

            lbConsultaProfessor.Text = "Consulta de Professores";
            lbID.Text = "";
            lbEmail.Text = "";
            lbCPF.Text = "";
            lbEndereco.Text = "";
            lbNumero.Text = "";
            lbComplemento.Text = "";
            lbBairro.Text = "";
            lbCidade.Text = "";
            lbEstado.Text = "";
        }

        public void InicializaCombo()
        {
            Professor p = new Professor();
            List<Professor> Professores = p.RetornarListaCompleta();

            cbNome.Items.Clear();

            foreach (Professor professor in Professores)
            {
                cbNome.Items.Add(professor);
            }
        }

        public void lvProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbProfessor_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            Professor p = cbNome.SelectedItem as Professor;

            Professor prof = new Professor();
            List<Professor> Professores = prof.RetornarListaCompleta();

           

            foreach (Professor professor in Professores)
            {
                if (p.IDProfessor == professor.IDProfessor)
                {
                    lbID.Text = p.IDProfessor.ToString();
                    lbEmail.Text = p.Email;
                    lbCPF.Text = p.CPF;
                    lbEndereco.Text = p.Endereco;
                    lbNumero.Text = p.Numero.ToString();
                    lbComplemento.Text = p.Complemento;
                    lbBairro.Text = p.Bairro;
                    lbCidade.Text = p.Cidade;
                    lbEstado.Text = p.Estado;
                }
            }

        }

        private void FormConsultarProfessor_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Professor p = cbNome.SelectedItem as Professor;

            Professor prof = new Professor();
            List<Professor> Professores = prof.RetornarListaCompleta();

            FormularioProfessor fp = new FormularioProfessor();
            fp.PopulaCampos(p);
            fp.ShowDialog();

            InicializaCombo();

            cbNome.Refresh();

            cbNome.Text = "";
            lbID.Text = "";
            lbEmail.Text = "";
            lbCPF.Text = "";
            lbEndereco.Text = "";
            lbNumero.Text = "";
            lbComplemento.Text = "";
            lbBairro.Text = "";
            lbCidade.Text = "";
            lbEstado.Text = "";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Professor p = cbNome.SelectedItem as Professor;

            Professor prof = new Professor();
            List<Professor> Professores = prof.RetornarListaCompleta();



            foreach (Professor professor in Professores)
            {
                if (p.IDProfessor == professor.IDProfessor)
                {
                    cbNome.Items.Remove(professor);
                }
            }

            p.Remover(p);


            cbNome.Text = "";
            lbID.Text = "";
            lbEmail.Text = "";
            lbCPF.Text = "";
            lbEndereco.Text = "";
            lbNumero.Text = "";
            lbComplemento.Text = "";
            lbBairro.Text = "";
            lbCidade.Text = "";
            lbEstado.Text = "";
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
