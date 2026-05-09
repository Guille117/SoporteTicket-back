using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication1.DTO.ComentarioDto
{
    public class CreateComentarioDto
    {
        [Required(ErrorMessage = "Debe ingresar contenido del comentario.")]
        public string? Contenido { get; set; }

        [Required(ErrorMessage = "Debe indicar tarea.")]
        public int IdTarea { get; set; }

        [Required(ErrorMessage = "Debe indicar usuario emisor")]
        public int IdUsuario { get; set; }

        public DateTime FechaHora { get; set; } = DateTime.Now;
    }
}
