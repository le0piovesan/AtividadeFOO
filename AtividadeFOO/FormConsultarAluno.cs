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

            Aluno a = new Aluno();
            List<Aluno> Alunos = a.RetornarListaCompleta();

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
    }
}
