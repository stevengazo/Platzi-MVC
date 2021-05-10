using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Platzi_MVC_CSharp.Models;

namespace Platzi_MVC_CSharp.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required]
        public override string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        /*Busca en escuela el campo ID y lo mapea*/ 
        public string EscuelaId { get; set; }

        public string Dirección { get; set; }
        /*Guarda la escuela*/
        public Escuela Escuela { get; set; }
    }
}