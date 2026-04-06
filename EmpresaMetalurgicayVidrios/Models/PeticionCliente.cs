namespace EmpresaMetalurgicayVidrios.Models
{
    public class PeticionCliente
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public string Alto { get; set; }
        public string Ancho { get; set; }
        public int Cantidad { get; set; }
        public string? Descripcion { get; set; }
        public Enum Estado { get; set; }
    }
}
