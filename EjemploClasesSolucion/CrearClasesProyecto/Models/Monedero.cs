namespace CrearClasesProyecto.Models
{
    public class Monedero
    {
        public int Id { get; set; }
        public decimal Saldo { get; private set; }
        public int MonedaTipoEuro { get; set; }
        public int MonedaCincuentaCentimos { get; set; }
    }
}
