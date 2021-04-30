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
            txtID.Text = "ID: " + "";
            txtEmail.Text = "Email: " + "";
            txtCPF.Text = "CPF: " + "";
            txtEndereco.Text = "Endereço: " + "";
            txtNumero.Text = "Número: " + "";
            txtComplemento.Text = "Complemento: " + "";
            txtBairro.Text = "Bairro: " + "";
            txtCidade.Text = "Cidade: " + "";
            txtEstado.Text = "Estado: " + "";
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
                    txtID.Text = "ID: " + prof.IDProfessor.ToString();
                    txtEmail.Text = $"Email: " + prof.Email;
                    txtCPF.Text = $"CPF: " + prof.CPF;
                    txtEndereco.Text = $"Endereço: " + prof.Endereco;
                    txtNumero.Text = $"Número: " + prof.Numero.ToString();
                    txtComplemento.Text = $"Complemento: " + prof.Complemento;
                    txtBairro.Text = $"Bairro: " + prof.Bairro;
                    txtCidade.Text = $"Cidade: " + prof.Cidade;
                    txtEstado.Text = $"Estado: " + prof.Estado;
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
            txtID.Text = "ID: " + "";
            txtEmail.Text = "Email: " + "";
            txtCPF.Text = "CPF: " + "";
            txtEndereco.Text = "Endereço: " + "";
            txtNumero.Text = "Número: " + "";
            txtComplemento.Text = "Complemento: " + "";
            txtBairro.Text = "Bairro: " + "";
            txtCidade.Text = "Cidade: " + "";
            txtEstado.Text = "Estado: " + "";
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
            txtID.Text = "ID: " + "";
            txtEmail.Text = "Email: " + "";
            txtCPF.Text = "CPF: " + "";
            txtEndereco.Text = "Endereço: " + "";
            txtNumero.Text = "Número: " + "";
            txtComplemento.Text = "Complemento: " + "";
            txtBairro.Text = "Bairro: " + "";
            txtCidade.Text = "Cidade: " + "";
            txtEstado.Text = "Estado: " + "";
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
