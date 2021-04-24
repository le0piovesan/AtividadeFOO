using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFaculdade.Entidades
{
    class Curso
    {
        public int IDCurso { get; set; }
        public string Nome { get; set; }
        public Professor Professor { get; set; }

        public Curso() { }
    }
}
