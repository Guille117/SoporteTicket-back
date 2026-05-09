using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication1.DTO.TareaDto
{
    public class CreateTareaDto
    {
        [Required(ErrorMessage = "Debe ingresar título de ticket.")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "Debe ingresar descripción de ticket.")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Debe ingresar creador del ticket")]
        public int IdCreador { get; set; }
        
        [Required(ErrorMessage = "Debe asignar el ticket")]
        public int IdAsignado { get; set; }

        [Range(1, 3, ErrorMessage = "Seleccione una prioridad válida.")]
        public Prioridad Prioridad { get; set; }

        public Estado Estado { get; set; } = Estado.Pendiente;

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Debe ingresar una fecha de tolerancia")]
        public DateTime FechaLimite { get; set; }
    }
}
