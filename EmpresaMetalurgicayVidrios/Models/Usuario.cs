using EmpresaMetalurgicayVidrios.Models.Interfaces;

namespace EmpresaMetalurgicayVidrios.Models
{
    public class Usuario : IUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ci {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public Enum Estado {  get; set; }
    }
}
