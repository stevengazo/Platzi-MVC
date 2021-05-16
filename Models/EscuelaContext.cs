using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using Platzi_MVC_CSharp.Models;
namespace Platzi_MVC_CSharp.Models
{
    /// ya con esto hereda de un contexto de db
    public class EscuelaContext : DbContext
    {
        // es una tabla de la base de datos , por eso de tipo lista 
        public DbSet<Escuela> Escuelas { get; set; }

        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //OnModelCreating(modelBuilder);
            var escuela = new Escuela(); ;
            escuela.AñoDeCreación = 2005;
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi Escuela";
            escuela.Ciudad = "San jose";
            escuela.Pais = "Costa Rica";
            escuela.Dirección = "Avenida Segunda";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            //Cargar Cursos Escuela
            var cursos = CargarCursos(escuela);

            //x cada curso  cargar: asignaturas 
            var asignaturas = CargarAsignaturas(cursos);

            //x cada curso cargar: alumnos
            var alumnos = CargarAlumnos(cursos);

            //x cada alumno en una asignatura cargar una evaluación
            var evaluaciones = CargarEvaluaciones(alumnos, asignaturas);



            // SIEMBRA DE DATOS
            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());
            modelBuilder.Entity<Evaluación>().HasData(evaluaciones.ToArray());

            static List<Curso> CargarCursos(Escuela escuela)
            {
                return (new List<Curso>(){
                new Curso(){Id= Guid.NewGuid().ToString(), EscuelaId= escuela.Id, Nombre="101",Jornada= TiposJornada.Mañana, Dirección="Avenida"},
                new Curso(){Id= Guid.NewGuid().ToString(), EscuelaId= escuela.Id, Nombre="102",Jornada= TiposJornada.Mañana, Dirección="Avenida"},
                new Curso(){Id= Guid.NewGuid().ToString(), EscuelaId= escuela.Id, Nombre="103",Jornada= TiposJornada.Tarde, Dirección="Avenida"},
                new Curso(){Id= Guid.NewGuid().ToString(), EscuelaId= escuela.Id, Nombre="104",Jornada= TiposJornada.Noche, Dirección="Avenida"},
                new Curso(){Id= Guid.NewGuid().ToString(), EscuelaId= escuela.Id, Nombre="105",Jornada= TiposJornada.Mañana, Dirección="Avenida"},
            });
            }
        }

        private List<Evaluación> CargarEvaluaciones(List<Alumno> alumnos, List<Asignatura> asignaturas)
        {
            Random rnd = new Random();
            var tmpList = new List<Evaluación>();
            foreach (var alumno in alumnos)
            {
                foreach (var asignatura in asignaturas)
                {
                    var temp = new Evaluación()
                    {
                        Nombre = $"Eval: {alumno.Nombre} - {asignatura.Nombre}",
                        Id = Guid.NewGuid().ToString(),
                        AlumnoId = alumno.Id,
                        AsignaturaId = asignatura.Id,
                        Nota = rnd.Next(50, 80)
                    };
                    tmpList.Add(temp);
                }
            }
            return tmpList;
        }

        private List<Asignatura> CargarAsignaturas(List<Curso> Cursos)
        {
            var ListaCompleta = new List<Asignatura>();
            foreach (var Curso in Cursos)
            {
                var tmpList = new List<Asignatura>{
                    new Asignatura{Id= Guid.NewGuid().ToString(),CursoId= Curso.Id, Nombre= "Matematicas"},
                    new Asignatura{Id= Guid.NewGuid().ToString(),CursoId= Curso.Id, Nombre= "Español"},
                    new Asignatura{Id= Guid.NewGuid().ToString(),CursoId= Curso.Id, Nombre= "Ciencias"},
                    new Asignatura{Id= Guid.NewGuid().ToString(),CursoId= Curso.Id, Nombre= "Ingles"},
                    new Asignatura{Id= Guid.NewGuid().ToString(),CursoId= Curso.Id, Nombre= "Programación"}
                };
                ListaCompleta.AddRange(tmpList);
                //Curso.Asignaturas= tmpList;
            }
            return ListaCompleta;
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad, Curso curso)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   Nombre = $"{n1} {n2} {a1}",
                                   Id = Guid.NewGuid().ToString(),
                                   CursoId = curso.Id
                               };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }

        private List<Alumno> CargarAlumnos(List<Curso> cursos)
        {
            var listaAlumnos = new List<Alumno>();
            Random rnd = new Random();
            foreach (var _curso in cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                var tmpList = GenerarAlumnosAlAzar(cantRandom, _curso);
                listaAlumnos.AddRange(tmpList);

            }
            return listaAlumnos;
        }
    }
}