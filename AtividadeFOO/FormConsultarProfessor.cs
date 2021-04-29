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

            Professor p = new Professor();
            List<Professor> Professores = p.RetornarListaCompleta();

            foreach (Professor professor in Professores)
            {
                Console.WriteLine(professor);
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
    }
}
