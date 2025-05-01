using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    internal class Curso
    {
        public string Nombre {  get; set; }
        public Profesor Profesor { get; set; }
        public Alumno Alumno { get; set; }
        public List<Escuela> escuelas { get; set; } = new();

        public void AsignarProfesor(Profesor profesor)
        {
            profesor.Nombre;
            profesor.Apellido;
            profesor.Sueldo;
            profesor.Titulo;
        }

        public void Inscribir(Alumno alumno)
        {
            alumno.Nombre;
            alumno.Apellido;
            alumno.Año;
        }
    }
}
