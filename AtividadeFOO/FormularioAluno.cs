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
    public partial class FormularioAluno : Form
    {
        public FormularioAluno()
        {
            InitializeComponent();

            lbNomeFormulario.Text = "Cadastro de Aluno";

            Aluno a = new Aluno();

            txtID.Text = a.IDAluno.ToString();
            txtNome.Text = a.Nome;
            txtEmail.Text = a.Email;
            mtxtCPF.Text = a.CPF;
            txtEndereco.Text = a.Endereco;
            txtNumero.Text = a.Numero.ToString();
            txtComplemento.Text = a.Complemento;
            txtBairro.Text = a.Bairro;
            txtCidade.Text = a.Cidade;
            txtEstado.Text = a.Estado;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno();
            a.IDAluno = Convert.ToInt32(txtID.Text);
            a.Nome = txtNome.Text;
            a.Email = txtEmail.Text;
            a.CPF = mtxtCPF.Text;
            a.Endereco = txtEndereco.Text;
            a.Numero = Convert.ToInt32(txtNumero.Text);
            a.Complemento = txtComplemento.Text;
            a.Bairro = txtBairro.Text;
            a.Cidade = txtCidade.Text;
            a.Estado = txtEstado.Text;

            if (!ValidarObjeto(a))
                return;

            LimparTela();

            bool ValidarObjeto(Aluno AlunoValidar)
            {
                if (string.IsNullOrEmpty(AlunoValidar.Nome))
                {
                    MessageBox.Show(this, "Preencha o campo Nome!", "ATENÇÃO!!");
                    return false;
                }

                if (string.IsNullOrEmpty(AlunoValidar.CPF))
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
