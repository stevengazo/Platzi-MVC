using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Platzi_MVC_CSharp.Models;

namespace Platzi_MVC_CSharp.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required(ErrorMessage="Nombre del curso es requerido")]
        [StringLength(5)]
        public override string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        /*Busca en escuela el campo ID y lo mapea*/ 
        public string EscuelaId { get; set; }

[Display(Prompt="Direccón correpondencia",Name="Address")]
        [Required(ErrorMessage="Se requiere incluir una dirección")]
        [MinLength(10,ErrorMessage="La longitud minima de la dirección es 10")]
        
        public string Dirección { get; set; }
        /*Guarda la escuela*/
        public Escuela Escuela { get; set; }
    }
}