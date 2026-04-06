namespace EmpresaMetalurgicayVidrios.Models
{
    public class Trabajador
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdArea { get; set; }
        public string CodigoEmpleado { get; set; }
        public string Especialidad { get; set; }
        public string HorarioTrabajo { get; set; }
    }
}
