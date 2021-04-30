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

            Professor prof = new Professor();

            txtID.Text = prof.ProximoID().ToString();

        }

        public void PopulaCampos(Professor prof)
        {
            txtID.Text = prof.ProximoID().ToString();
            txtNome.Text = prof.Nome;
            txtEmail.Text = prof.Email;
            mtxtCPF.Text = prof.CPF;
            txtEndereco.Text = prof.Endereco;
            txtNumero.Text = prof.Numero.ToString();
            txtComplemento.Text = prof.Complemento;
            txtBairro.Text = prof.Bairro;
            txtCidade.Text = prof.Cidade;
            txtEstado.Text = prof.Estado;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Professor p = new Professor(Convert.ToInt32(txtID.Text),
                                        txtNome.Text, 
                                        txtEmail.Text, 
                                        mtxtCPF.Text, 
                                        txtEndereco.Text, 
                                        Convert.ToInt32(txtNumero.Text), 
                                        txtComplemento.Text, 
                                        txtBairro.Text, 
                                        txtCidade.Text, 
                                        txtEstado.Text);

            p.Salvar(p);

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

            MessageBox.Show(this, "Professor salvo.", "Aviso.");
            this.Hide();

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
