using Proyecto1.Models.Interface;

namespace Proyecto1.Models
{

    public class Producto : IProducto
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string? Imagen { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public bool Estado { get; set; }

    }
}
