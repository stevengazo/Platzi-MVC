using Microsoft.AspNetCore.Mvc;
using Platzi_MVC_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Platzi_MVC_CSharp.Controllers
{
    public class AlumnoController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Alumnos.FirstOrDefault());
        }
        public IActionResult MultiAlumno()
        {        
            ViewBag.cosaDinamica = "Prueba";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAlumno", this._context.Alumnos.ToList());
        }

        //constructor de la clase y especificación del DBContext para acceso a la DB
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            this._context = context;
        }

    }
}