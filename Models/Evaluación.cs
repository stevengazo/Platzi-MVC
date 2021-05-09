using System;

namespace Platzi_MVC_CSharp.Models
{
    public class Evaluación:ObjetoEscuelaBase
    {
        /*Mapeado con las otras clases y las foreign key*/
        public Alumno Alumno { get; set; }
        public string AlumnoId { get; set; }
        public Asignatura Asignatura  { get; set; }
        public string AsignaturaId { get; set; }

        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}