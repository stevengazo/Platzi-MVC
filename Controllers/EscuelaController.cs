using Microsoft.AspNetCore.Mvc;
using Platzi_MVC_CSharp.Models;
using System.Linq;
using System;

namespace Platzi_MVC_CSharp.Controllers
{
    ///Controlador de la vista Escuela
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context){
            this._context= context;
        }
        /// Metodo para llamar Index en la vista Index
        public IActionResult Index()
        {
            var escuela = new Escuela();

            ViewBag.cosaDinamica = "La Monja";
            escuela =this._context.Escuelas.FirstOrDefault();
            //Retorna la vista y el pasa el modelo (datos)
            return View(escuela);
        }
    }
}
