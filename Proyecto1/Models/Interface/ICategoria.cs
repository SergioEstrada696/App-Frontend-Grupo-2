namespace Proyecto1.Models.Interface
{
    public interface ICategoria
    {
        int Id { get; set; }
        string Nombre { get; set; }
        bool Estado { get; set; }
    }
}
