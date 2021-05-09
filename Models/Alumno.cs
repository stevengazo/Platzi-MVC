using System;
using System.Collections.Generic;

namespace Platzi_MVC_CSharp.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } 
        
        /*Busca en curs el campo ID y lo mapea*/
        public string CursoId { get; set; }
        public Curso Curso { get; set; }
        
    }
}