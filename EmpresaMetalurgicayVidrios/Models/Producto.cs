namespace EmpresaMetalurgicayVidrios.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descipcion { get; set; }
        public Enum Estado { get; set; }
    }
}
