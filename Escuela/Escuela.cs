using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    internal class Escuela
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public List<Curso> cursos { get; set; } = new();
    }
}
