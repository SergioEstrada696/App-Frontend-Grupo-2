namespace EmpresaMetalurgicayVidrios.Models.Interfaces
{
    public interface IUsuario
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Ci {  get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Telefono { get; set; }
        DateTime Fecha_Registro { get; set; }
        Enum Estado {  get; set; }

    }
}
