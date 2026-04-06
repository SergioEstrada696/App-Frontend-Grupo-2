namespace Proyecto1.Models.Interface
{
    public interface IPeticion
    {
        int Id { get; set; }
        int ClienteId { get; set; }
        int ProductoId { get; set; }
        string Altura { get; set; }
        string Ancho { get; set; }
        int Cantidad { get; set; }
        string? Descripcion { get; set; }
        bool Estado { get; set; }
    }
}
