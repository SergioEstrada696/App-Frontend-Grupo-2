using Proyecto1.Models.Interface;

namespace Proyecto1.Models
{
    public class Categoria : ICategoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
    }
}
