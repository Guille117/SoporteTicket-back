using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    // hereda de dbContext -> base de Entity framework
    public class ApplicationDbContext : DbContext
    {
        // El constructor configura la conexión (se llena automáticamente con lo que se agregue en appsettings.json)
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Aquí registras tus modelos. DbSet significa "Crea una tabla en la BD basada en esta clase"
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
    }
}
