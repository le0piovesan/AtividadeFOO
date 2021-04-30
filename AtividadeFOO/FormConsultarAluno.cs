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
            txtID.Text = "ID: " + "";
            txtEmail.Text = "Email: " + "";
            txtCPF.Text = "CPF: " + "";
            txtEndereco.Text ="Endereço: " + "";
            txtNumero.Text ="Número: " + "";
            txtComplemento.Text ="Complemento: " + "";
            txtBairro.Text ="Bairro: " + "";
            txtCidade.Text ="Cidade: " + "";
            txtEstado.Text ="Estado: " + "";
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
                    txtID.Text = $"ID: " + a.IDAluno.ToString();
                    txtEmail.Text = $"Email: " + a.Email;
                    txtCPF.Text = $"CPF: " + a.CPF;
                    txtEndereco.Text = $"Endereço: " + a.Endereco;
                    txtNumero.Text = $"Número: " + a.Numero.ToString();
                    txtComplemento.Text = $"Complemento: " + a.Complemento;
                    txtBairro.Text = $"Bairro: " + a.Bairro;
                    txtCidade.Text = $"Cidade: " + a.Cidade;
                    txtEstado.Text = $"Estado: " + a.Estado;
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

        private void bntAtualizar_Click(object sender, EventArgs e)
        {

            
        }
    }
}
