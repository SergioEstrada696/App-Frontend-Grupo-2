using EmpresaMetalurgicayVidrios.Models.Interfaces;

namespace EmpresaMetalurgicayVidrios.Models
{
    public class Categoria : ICategoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Enum Estado { get; set; }
    }
}
