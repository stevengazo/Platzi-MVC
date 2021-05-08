using System;
using System.Collections.Generic;

namespace Platzi_MVC_CSharp.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}