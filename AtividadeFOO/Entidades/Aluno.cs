using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFaculdade.Entidades
{
    class Aluno
    {
        public static List<Aluno> Alunos = new List<Aluno>();
        public int IDAluno { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public void Salvar(Aluno DadosAluno)
        {
            Alunos.Add(new Aluno(DadosAluno.IDAluno,
                                          DadosAluno.Nome,
                                          DadosAluno.Email,
                                          DadosAluno.CPF,
                                          DadosAluno.Endereco,
                                          DadosAluno.Numero,
                                          DadosAluno.Complemento,
                                          DadosAluno.Bairro,
                                          DadosAluno.Cidade,
                                          DadosAluno.Estado));
        }

        public List<Aluno> RetornarListaCompleta()
        {
            return Alunos;
        }

        public Aluno(int idaluno, string nome, string email, string cpf, string endereco, int numero, string complemento, string bairro, string cidade, string estado)
        {
            IDAluno = idaluno;
            Nome = nome;
            Email = email;
            CPF = cpf;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public Aluno() { }

        public override string ToString()
        {
            return String.Concat(IDAluno.ToString(), " - ", Nome);
        }
    }

}
