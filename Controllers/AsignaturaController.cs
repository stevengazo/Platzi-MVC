using Microsoft.AspNetCore.Mvc;
using Platzi_MVC_CSharp.Models;
using System;
using System.Collections.Generic;

namespace Platzi_MVC_CSharp.Controllers
{
    public class AsignaturaController : Controller
    {

        public IActionResult Index(){
            ViewBag.Fecha= DateTime.Now;
            return View(new Asignatura{Nombre="Programación",     Id= Guid.NewGuid().ToString()} );
        }
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>(){
                new Asignatura{Nombre="Matematicas",        Id= Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Educación Fisica",   Id= Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Castellano",         Id= Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Programación",         Id= Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Ciencias Naturales", Id= Guid.NewGuid().ToString()}
            };
        
            ViewBag.cosaDinamica = "Prueba";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignatura",listaAsignaturas);
        }

        

    }
}