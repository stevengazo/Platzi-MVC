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
            var Escuela = this._context.Escuelas.FirstOrDefault();
            ViewBag.cosaDinamica = "La Monja";        
            //Retorna la vista y el pasa el modelo (datos)
            return View(Escuela);
        }

    }
}
