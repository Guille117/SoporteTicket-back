using System.ComponentModel.DataAnnotations;

namespace backendTicket.Models
{
    public enum Prioridad
    {
        Baja,
        Media,
        Alta
    }

    public enum Estado
    {
        Pendiente,
        EnProceso,
        Culminado
    }

    public class Tareas
    {
        [Key]
        public int IdTarea { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        public int IdCreador { get; set; }
        public int IdAsignado { get; set; }
        
        public Usuarios Creador { get; set; } = null!;
        public Usuarios Asignado { get; set; } = null!;
        
        public Prioridad Prioridad { get; set; }
        public Estado Estado { get; set; }
        
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaLimite { get; set; }
        public DateTime? FechaCulminacion { get; set; }
    }
}