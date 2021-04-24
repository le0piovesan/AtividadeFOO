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
    public partial class FormularioProfessor : Form
    {
        public FormularioProfessor()
        {
            InitializeComponent();

            lbNomeFormulario.Text = "Cadastro de Professor";


            Professor p = new Professor();

            txtID.Text = p.IDProfessor.ToString();
            txtNome.Text = p.Nome;
            txtEmail.Text = p.Email;
            mtxtCPF.Text = p.CPF;
            txtEndereco.Text = p.Endereco;
            txtNumero.Text = p.Numero.ToString();
            txtComplemento.Text = p.Complemento;
            txtBairro.Text = p.Bairro;
            txtCidade.Text = p.Cidade;
            txtEstado.Text = p.Estado;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Professor p = new Professor();
            p.IDProfessor = Convert.ToInt32(txtID.Text);
            p.Nome = txtNome.Text;
            p.Email = txtEmail.Text;
            p.CPF = mtxtCPF.Text;
            p.Endereco = txtEndereco.Text;
            p.Numero = Convert.ToInt32(txtNumero.Text);
            p.Complemento = txtComplemento.Text;
            p.Bairro = txtBairro.Text;
            p.Cidade = txtCidade.Text;
            p.Estado = txtEstado.Text;

            if (!ValidarObjeto(p))
                return;

            LimparTela();

            bool ValidarObjeto(Professor ProfessorValidar)
            {
                if (string.IsNullOrEmpty(ProfessorValidar.Nome))
                {
                    MessageBox.Show(this, "Preencha o campo Nome!", "ATENÇÃO!!");
                    return false;
                }

                if (string.IsNullOrEmpty(ProfessorValidar.CPF))
                {
                    MessageBox.Show(this, "Preencha o campo CPF!", "ATENÇÃO!!");
                    return false;
                }

                return true;
            }

        }

        private void LimparTela()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            mtxtCPF.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
