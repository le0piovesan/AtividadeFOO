using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFaculdade.Entidades
{
    public class Curso
    {
        public static List<Curso> Cursos = new List<Curso>();
        public int IDCurso { get; set; }
        public string Nome { get; set; }
        public Professor Professor { get; set; }

        public List<Aluno> Alunos { get; set; }

        public int RetornaIndex(int id)
        {
            int index = Cursos.FindIndex(x => x.IDCurso == id);
            return index;
        }
        public void Adiciona(Curso DadosCurso)
        {
            Cursos.Add(DadosCurso);
        }

        public void RemovePeloId(int id)
        {
            int index = RetornaIndex(id);
            if (index > -1)
            {
                Cursos.RemoveAt(index);
            }
        }
        public void Remover(Curso DadosCurso)
        {
            Cursos.Remove(DadosCurso);
        }

        public void Salvar(Curso DadosCurso)
        {
            Curso cursoExistente = RetornaPeloId(DadosCurso.IDCurso);
            if (cursoExistente == null)
            {
                Adiciona(DadosCurso);
            }
            else
            {
                RemovePeloId(DadosCurso.IDCurso);
                Adiciona(DadosCurso);

            }
        }

        public Curso RetornaPeloId(int id)
        {
            return Cursos.FirstOrDefault(x => x.IDCurso == id);
        }

        public List<Curso> RetornarListaCompleta()
        {
            return Cursos;
        }

        public int ProximoID()
        {
            if (Cursos.Count <= 0)
            {
                return 1;
            }
            else
            {
                Int32 length = Cursos.Count;
                Curso curso = Cursos[length - 1];
                return curso.IDCurso + 1;
            }
        }

        public Curso() { 
            this.Alunos = new List<Aluno>();
        }

        public override string ToString()
        {
            return Nome;
        }
    }

}
