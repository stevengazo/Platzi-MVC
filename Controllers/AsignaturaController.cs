using Microsoft.AspNetCore.Mvc;
using Platzi_MVC_CSharp.Models;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Platzi_MVC_CSharp.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index(string AsignaturaId){
            var asignatura = from asig in _context.Asignaturas
                            where asig.Id == AsignaturaId
                            select asig;
            return View(asignatura.SingleOrDefault());
        }
        public IActionResult MultiAsignatura()
        {        
            ViewBag.cosaDinamica = "Prueba";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignatura",this._context.Asignaturas);
        }
        //constructor de la clase y especificación del DBContext
        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context){
            this._context = context;
        }
        

    }
}