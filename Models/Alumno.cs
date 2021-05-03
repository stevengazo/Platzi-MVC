using System;
using System.Collections.Generic;

namespace platzi_curso_csharp_Etapa7.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}