using Microsoft.AspNetCore.Mvc;
using platzi_curso_csharp_Etapa7.Models;
using System;

namespace platzi_curso_csharp_Etapa7.Controllers
{
    ///Controlador de la vista Escuela
    public class EscuelaController : Controller
    {
        /// Metodo para llamar Index en la vista Index
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación= 2005;    
            escuela.UniqueId = Guid.NewGuid().ToString();        
            escuela.Nombre= "Platzi Escuela";

            ViewBag.cosaDinamica = "La Monja";
            //Retorna la vista y el pasa el modelo (datos)
            return View(escuela);
        }
    }
}
