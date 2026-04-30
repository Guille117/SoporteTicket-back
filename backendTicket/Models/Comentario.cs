using System.ComponentModel.DataAnnotations;

namespace backendTicket.Models
{
    public class Comentario
    {
        [Key]
        public int IdComentario { get; set; }
        public string? Contenido { get; set; }
        
        public int IdTarea { get; set; }
        public int IdUsuario { get; set; }
        
        public Tareas Tarea { get; set; } = null!;
        public Usuarios Usuario { get; set; } = null!;
        
        public DateTime FechaHora { get; set; }
    }
}