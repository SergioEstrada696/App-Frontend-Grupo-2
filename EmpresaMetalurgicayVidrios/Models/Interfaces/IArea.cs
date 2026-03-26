namespace EmpresaMetalurgicayVidrios.Models.Interfaces
{
    public interface IArea
    {
        int Id { get; set; }
        string Name { get; set; }
        string Descripcion { get; set; }
        Enum Estado { get; set; }
    }
}
