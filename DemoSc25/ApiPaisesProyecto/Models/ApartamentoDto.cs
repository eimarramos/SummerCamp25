namespace ApiPaisesProyecto.Models
{
    public class ApartamentoDto
    {   public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int NumeroHabitaciones { get; set; }
        public int NumeroBanios { get; set; }
        public double Superficie { get; set; } // en metros cuadrados
        public string Ubicacion { get; set; } // dirección o ubicación del apartamento
        public decimal Precio { get; set; } // precio del apartamento
        public bool Disponible { get; set; } // indica si el apartamento está disponible para alquilar o vender
    }
}
