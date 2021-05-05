using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFaculdade.Entidades
{
    public class Professor
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
            Professor professorExistente = RetornaPeloId(DadosProfessor.IDProfessor);
            if (professorExistente == null)
            {
                Adiciona(DadosProfessor);
            }
            else
            {
                RemovePeloId(DadosProfessor.IDProfessor);
                Adiciona(DadosProfessor);

            }
        }


        public int ProximoID()
        {
            if (Professores.Count <= 0)
            {
                return 1;
            }
            else
            {
                Int32 length = Professores.Count;
                Professor professor = Professores[length - 1];
                return professor.IDProfessor + 1;
            }     
        }

        public void Adiciona(Professor DadosProfessor)
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
        }

        public int RetornaIndex(int id)
        {
            int index = Professores.FindIndex(x => x.IDProfessor == id);
            return index;
        }

        public void RemovePeloId(int id)
        {
            int index = RetornaIndex(id);
            if (index > -1)
            {
                Professores.RemoveAt(index);
            }
        }

        public Professor RetornaPeloId(int id)
        {
            return Professores.FirstOrDefault(x => x.IDProfessor == id);
        }

        public void Remover(Professor DadosProfessor)
        {
           Professores.Remove(DadosProfessor);
        }

        public List<Professor> RetornarListaCompleta()
        {
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
            return Nome;
        }
    }
}
