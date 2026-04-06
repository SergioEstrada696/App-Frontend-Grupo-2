namespace Proyecto1.Models.Interface
{
    public interface IProducto
    {
        int Id { get; set; }
        int CategoriaId { get; set; }
        string Nombre { get; set; }
        string? Imagen {  get; set; }
        string Descripcion { get; set; }
        string Precio { get; set; }
        bool Estado { get; set; }

    }
}
