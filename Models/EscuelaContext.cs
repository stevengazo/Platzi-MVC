using Microsoft.EntityFrameworkCore;
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
   
    public EscuelaContext(DbContextOptions<EscuelaContext> options):base(options)
    {

    }
   
    }
}