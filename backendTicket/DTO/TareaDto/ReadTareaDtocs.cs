using backendTicket.Models;


namespace backendTicket.DTO
{
    public class ReadTareaDtocs
    {
        public int IdTarea { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        
        public string NombreCreador { get; set; } = string.Empty;
        public string NombreAsignado { get; set; } = string.Empty;

        public string PrioridadNombre { get; set; } = string.Empty;
        public string EstadoNombre { get; set; } = string.Empty;

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaLimite { get; set; }
        public DateTime? FechaCulminacion { get; set; }
    }
}
