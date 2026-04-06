namespace EmpresaMetalurgicayVidrios.Models.Interfaces
{
    public interface IPeticionCliente
    {
        int Id { get; set; }
        int IdCliente { get; set; }
        int IdProducto { get; set; }
        string Alto { get; set; }
        string Ancho { get; set; }
        int Cantidad { get; set; }
        string? Descripcion { get; set; }
        Enum Estado { get; set; }
    }
}
