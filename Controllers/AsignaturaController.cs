using Microsoft.AspNetCore.Mvc;
using platzi_curso_csharp_Etapa7.Models;
using System;
using System.Collections.Generic;

namespace platzi_curso_csharp_Etapa7.Controllers
{
    public class AsignaturaController : Controller
    {

        public IActionResult Index(){
            ViewBag.Fecha= DateTime.Now;
            return View(new Asignatura{Nombre="Programación",     UniqueId= Guid.NewGuid().ToString()} );
        }
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>(){
                new Asignatura{Nombre="Matematicas",        UniqueId= Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Educación Fisica",   UniqueId= Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Castellano",         UniqueId= Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Programación",         UniqueId= Guid.NewGuid().ToString()},
                new Asignatura{Nombre="Ciencias Naturales", UniqueId= Guid.NewGuid().ToString()}
            };
        
            ViewBag.cosaDinamica = "Prueba";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignatura",listaAsignaturas);
        }

        

    }
}