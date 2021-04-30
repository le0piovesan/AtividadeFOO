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
    public partial class FormConsultarAluno : Form
    {
        public FormConsultarAluno()
        {
            InitializeComponent();

            InicializaCombo();

            lbConsultaAluno.Text = "Consulta de Alunos";
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
            Aluno a = new Aluno();
            List<Aluno> Alunos = a.RetornarListaCompleta();

            cbNome.Items.Clear();

            foreach (Aluno aluno in Alunos)
            {
                cbNome.Items.Add(aluno);
            }
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluno a = cbNome.SelectedItem as Aluno;

            Aluno al = new Aluno();
            List<Aluno> Alunos = al.RetornarListaCompleta();



            foreach (Aluno aluno in Alunos)
            {
                if (a.IDAluno == aluno.IDAluno)
                {
                    lbID.Text = a.IDAluno.ToString();
                    lbEmail.Text = a.Email;
                    lbCPF.Text = a.CPF;
                    lbEndereco.Text = a.Endereco;
                    lbNumero.Text = a.Numero.ToString();
                    lbComplemento.Text = a.Complemento;
                    lbBairro.Text = a.Bairro;
                    lbCidade.Text = a.Cidade;
                    lbEstado.Text = a.Estado;
                }
            }
        }

        private void FormConsultarAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            Aluno a = cbNome.SelectedItem as Aluno;

            Aluno al = new Aluno();
            List<Aluno> Alunos = al.RetornarListaCompleta();

            FormularioAluno fa = new FormularioAluno();
            fa.PopulaCampos(a);
            fa.ShowDialog();

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
            Aluno a = cbNome.SelectedItem as Aluno;

            Aluno al = new Aluno();
            List<Aluno> Alunos = al.RetornarListaCompleta();



            foreach (Aluno aluno in Alunos)
            {
                if (a.IDAluno == aluno.IDAluno)
                {
                    cbNome.Items.Remove(aluno); 
                }
            }

            a.Remover(a);
            

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

        private void bntAtualizar_Click(object sender, EventArgs e)
        {

            
        }
    }
}
