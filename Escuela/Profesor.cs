using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    internal class Profesor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Sueldo { get; set; }
        public string Titulo { get; set; }
        public List<Curso> cursos { get; set; } = new();
    }
}
