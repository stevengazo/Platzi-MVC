using Microsoft.AspNetCore.Mvc;
using Platzi_MVC_CSharp.Models;
using System;

namespace Platzi_MVC_CSharp.Controllers
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
            escuela.Ciudad="San jose";
            escuela.Pais="Costa Rica";
            escuela.Dirección="Avenida Segunda";
            escuela.TipoEscuela= TiposEscuela.Secundaria;
            ViewBag.cosaDinamica = "La Monja";
            //Retorna la vista y el pasa el modelo (datos)
            return View(escuela);
        }
    }
}
