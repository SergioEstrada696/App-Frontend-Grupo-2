namespace Proyecto1.Models.Interface
{
    public interface IArea
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Descripcion { get; set; }
        bool Estado { get; set; }
    }
}
