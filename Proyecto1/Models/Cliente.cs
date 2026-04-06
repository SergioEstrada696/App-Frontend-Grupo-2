using Proyecto1.Models.Interface;

namespace Proyecto1.Models
{
    public class Cliente : ICliente
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? CodigoCliente { get; set; }
        public bool Estado { get; set; }
    }
}
