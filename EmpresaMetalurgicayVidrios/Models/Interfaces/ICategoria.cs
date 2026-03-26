namespace EmpresaMetalurgicayVidrios.Models.Interfaces
{
    public interface ICategoria
    {
        int Id { get; set; }
        string Nombre { get; set; }
        Enum Estado { get; set; }
    }
}
