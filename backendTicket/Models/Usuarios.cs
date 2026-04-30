using System.ComponentModel.DataAnnotations;

namespace backendTicket.Models
{
    public enum Rol
    {
        Administrador,
        Agente
    }

    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public string PrimerNombre { get; set; } = string.Empty;
        public string? SegundoNombre { get; set; }
        public string PrimerApellido { get; set; } = string.Empty;
        public string? SegundoApellido { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Rol Rol { get; set; }
        public bool Activo { get; set; }
    }
}