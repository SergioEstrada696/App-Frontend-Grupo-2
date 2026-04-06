namespace Proyecto1.Models.Interface
{
    public interface IUser
    {
        int Id { get; set;  }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Telefono { get; set; }
        DateTime FechaRegistro { get; set; }
        bool Estado { get; set; }
    }
}
