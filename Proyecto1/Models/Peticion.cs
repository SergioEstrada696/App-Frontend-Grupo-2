using Proyecto1.Models.Interface;

namespace Proyecto1.Models
{
    public class Peticion : IPeticion
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ProductoId { get; set; }
        public string Altura { get; set; }
        public string Ancho { get; set; }
        public int Cantidad {  get; set; }
        public string? Descripcion { get; set; }
        public bool Estado { get; set; }

    }
}
