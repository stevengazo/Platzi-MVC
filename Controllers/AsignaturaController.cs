using Microsoft.AspNetCore.Mvc;
using platzi_curso_csharp_Etapa7.Models;
using System;

namespace platzi_curso_csharp_Etapa7.Controllers
{
    public class AsignaturaController: Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura(){
                UniqueId= Guid.NewGuid().ToString(),
                Nombre= "Programación"
            };
            ViewBag.cosaDinamica= "Prueba";
            ViewBag.Fecha = DateTime.Now;
            return View(asignatura);
        }
    }
}