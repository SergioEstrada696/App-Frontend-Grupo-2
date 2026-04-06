namespace Proyecto1.Models.Interface
{
    public interface ICliente
    {
        int Id { get; set; }
        int UserId { get; set; }
        string? CodigoCliente { get; set; }
        bool Estado { get; set; }
    }
}
