using Microsoft.AspNetCore.Mvc;
using platzi_curso_csharp_Etapa7.Models;
using System;

namespace platzi_curso_csharp_Etapa7.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoFundación= 2005;
            escuela.EscuelaId= Guid.NewGuid().ToString();
            escuela.Nombre= "Platzi Escuela";
            return View(escuela);
        }
    }
}
