using WebApplication1.Models;

namespace WebApplication1.Dto.UsuarioDto
{
    public class ReadUsuarioDto
    {
        public int IdUsuario { get; set; }
        public string? PrimerNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? NombreCompleto { get; set; }
        public Rol Rol { get; set; }
        public bool Activo { get; set; }
    }
}