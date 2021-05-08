using System;
using System.Collections.Generic;
using Platzi_MVC_CSharp.Models;

namespace Platzi_MVC_CSharp.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        public string Dirección { get; set; }
    }
}