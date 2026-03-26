namespace EmpresaMetalurgicayVidrios.Models
{
    public class PeticionPendiente
    {
        public int Id { get; set; }
        public int IdPeticionCliente { get; set; }
        public int IdArea {  get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int Prioridad { get; set; }
        public string? Observacion { get; set; }
        public Enum Estado {  get; set; }
    }
}
