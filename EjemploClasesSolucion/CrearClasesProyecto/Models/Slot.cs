namespace CrearClasesProyecto.Models
{
    public class Slot
    {
        public int Id { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public int Capacidad { get; set; }
        public DateTime UltimaReposicion { get; set; }
        public int StockMinimo { get; set; }

        public void Reponer(int cantidad)
        {
            if (Cantidad + cantidad <= Capacidad)
            {
                Cantidad += cantidad;
                UltimaReposicion = DateTime.Now;
            }
        }

        public void EstablecerProducto(Producto producto)
        {
            Producto = producto;
            Cantidad = 0;
            UltimaReposicion = DateTime.Now;
        }

        public bool NecesidadReposicion()
        {
            return Cantidad < StockMinimo;
        }

        public bool RetirarProducto()
        {
            if (Cantidad > 0)
            {
                Cantidad--;
                return true;
            }
            return false;
        }

        public bool ContienePordicto(string nombreProdicto)
        {
            return Producto !=  null && Producto.Nombre.Equals(nombreProdicto);
        }

        public void Vaciar()
        {
            Cantidad = 0;
            Producto = null;
            UltimaReposicion = DateTime.MinValue;
        }
    }
}
