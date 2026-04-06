namespace Proyecto1.Models
{
    public class Trabajador
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int AreaId { get; set; }
        public string? CodigoTrabajador { get; set; }
        public string HorarioLaboral {  get; set; }
        public bool Estado { get; set; }

    }
}
