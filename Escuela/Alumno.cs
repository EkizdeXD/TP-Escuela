using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    internal class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Año { get; set; }
        public List<Curso> cursos { get; set; } = new();
    }
}
