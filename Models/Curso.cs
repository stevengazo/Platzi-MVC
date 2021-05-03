using System;
using System.Collections.Generic;
using platzi_curso_csharp_Etapa7.Models;

namespace platzi_curso_csharp_Etapa7.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        public string Dirección { get; set; }
    }
}