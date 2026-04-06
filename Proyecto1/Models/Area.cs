using Proyecto1.Models.Interface;

namespace Proyecto1.Models
{
    public class Area : IArea
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
