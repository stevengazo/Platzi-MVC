using Microsoft.AspNetCore.Mvc;
using Platzi_MVC_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Platzi_MVC_CSharp.Controllers
{
    public class CursoController : Controller
    {
        [Route("Curso")]
        [Route("Curso/Index")]
        [Route("Curso/Index/{id}")]
        public IActionResult Index(string id)
        {
            ViewBag.Fecha = DateTime.Now;
            if (!string.IsNullOrWhiteSpace(id))
            {
                var curso = from curs in _context.Cursos
                            where curs.Id == id
                            select curs;
                return View(curso.SingleOrDefault());
            }
            else
            {
                ViewBag.cosaDinamica = "Prueba";
                return View("MultiCurso", this._context.Cursos.ToList());
            }
        }
        public IActionResult MultiCurso()
        {
            ViewBag.cosaDinamica = "Prueba";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiCurso", this._context.Cursos.ToList());
        }

        // [Route("Curso/Create")]
        public IActionResult Create()
        {
            ViewBag.Fecha = DateTime.Now;
            return View();
        }

        //[Route("Curso/Create")]
        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            ViewBag.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                var escuela = this._context.Escuelas.SingleOrDefault();
                curso.Id = Guid.NewGuid().ToString();
                curso.EscuelaId = escuela.Id;
                this._context.Cursos.Add(curso);
                this._context.SaveChanges();
                ViewBag.MensajeExtra="Curso Creado";
                 return View("Index",curso);
            }
            else
            {
                return View(curso);
            }


        }
        //constructor de la clase y especificación del DBContext para acceso a la DB
        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            this._context = context;
        }

    }
}