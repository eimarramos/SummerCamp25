using CrearClasesProyecto.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Slot> products = new List<Slot>([
           new Slot { Id = 1, Producto = new Producto { Id = 1, Nombre = "Manzana"}, Cantidad = 20 },
           new Slot { Id = 2, Producto = new Producto { Id = 2, Nombre = "Chocolate"}, Cantidad = 15 }
        ]);

        VendingMachine machine = new VendingMachine(products);

        machine.MostrarProductos();
    }
}