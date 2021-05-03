using System;

namespace platzi_curso_csharp_Etapa7.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
        }

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}