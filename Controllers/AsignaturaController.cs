using Microsoft.AspNetCore.Mvc;
using Platzi_MVC_CSharp.Models;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Platzi_MVC_CSharp.Controllers
{
    public class AsignaturaController : Controller
    {
        [Route("Asignatura")]
        [Route("Asignatura/Index")]        
        [Route("Asignatura/Index/{asignaturaId}")]
        public IActionResult Index(string asignaturaId)
        {
            if (!string.IsNullOrEmpty(asignaturaId))
            {
                var asignatura = from asig in _context.Asignaturas
                                 where asig.Id == asignaturaId
                                 select asig;
                return View(asignatura.SingleOrDefault());
            }
            else
            {
return View("MultiAsignatura", this._context.Asignaturas);
            }

        }
        public IActionResult MultiAsignatura()
        {
            ViewBag.cosaDinamica = "Prueba";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignatura", this._context.Asignaturas);
        }
        //constructor de la clase y especificación del DBContext
        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            this._context = context;
        }


    }
}