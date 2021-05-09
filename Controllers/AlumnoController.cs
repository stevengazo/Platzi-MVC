using Microsoft.AspNetCore.Mvc;
using Platzi_MVC_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Platzi_MVC_CSharp.Controllers
{
    public class AlumnoController : Controller
    {
        [Route("Alumno")]
        [Route("Alumno/Index")]
        [Route("Alumno/Index/{id}")]
        public IActionResult Index(string id)
        {
            ViewBag.Fecha = DateTime.Now;
            if (!string.IsNullOrWhiteSpace(id))
            {
                var alumno = from alumn in _context.Alumnos
                             where alumn.Id == id
                             select alumn;
                return View(alumno.SingleOrDefault());
            }
            else
            {
                ViewBag.cosaDinamica = "Prueba";
                return View("MultiAlumno", this._context.Alumnos.ToList());

            }
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