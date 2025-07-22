namespace CrearClasesProyecto.Models
{
    public class Transaccion
    {
        public Producto Producto { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Cambio { get; set; }
        public bool Exitosa { get; set; }
    }
}
