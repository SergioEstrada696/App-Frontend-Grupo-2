namespace Proyecto1.Models.ViewModels
{
    public class ProductoDetalleVM
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Imagen { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public string CategoriaNombre { get; set; }
    }
}
