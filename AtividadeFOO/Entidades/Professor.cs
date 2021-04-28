using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFaculdade.Entidades
{
    class Professor
    { 
        public static List<Professor> Professores = new List<Professor>();

        public int IDProfessor { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public void Salvar(Professor DadosProfessor)
        {
            Professores.Add(new Professor(DadosProfessor.IDProfessor,
                                          DadosProfessor.Nome,
                                          DadosProfessor.Email,
                                          DadosProfessor.CPF,
                                          DadosProfessor.Endereco,
                                          DadosProfessor.Numero,
                                          DadosProfessor.Complemento,
                                          DadosProfessor.Bairro,
                                          DadosProfessor.Cidade,
                                          DadosProfessor.Estado));

            Console.WriteLine(Professores);
        }

        public List<Professor> RetornarListaCompleta()
        {
            Console.WriteLine(Professores);
            return Professores;
        }

        public Professor(int idprofessor, string nome, string email, string cpf, string endereco, int numero, string complemento, string bairro, string cidade, string estado) {
            IDProfessor = idprofessor;
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

        public Professor() { }

       public override string ToString()
        {
            return String.Concat(IDProfessor.ToString(), " - ", Nome);
        }
    }
}
