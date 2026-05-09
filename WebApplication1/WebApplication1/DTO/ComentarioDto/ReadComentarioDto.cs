using WebApplication1.Models;

namespace WebApplication1.DTO.ComentarioDto
{
    public class ReadComentarioDto
    {
        public int IdComentario { get; set; }
        public string? Contenido { get; set; }

        public int IdTarea { get; set; }

        public string NombreCreador { get; set; } = string.Empty;

        public DateTime FechaHora { get; set; }
    }
}
