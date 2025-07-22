namespace CrearClasesProyecto.Models
{
    public class VendingMachine
    {
        public int Id { get; set; }

        public Slot Slot1 { get; set; }
        public Slot Slot2 { get; set; }
        public Slot Slot3 { get; set; }
        public Monedero Monedero { get; set; }
        





        /** public List<Slot> Slots { get; set; } = [];

        public VendingMachine(List<Slot> slots) {
            Slots = slots;
        }

        public void MostrarProductos()
        {
            foreach(var slot in Slots)
            {
                Console.WriteLine($"Nº:{slot.Id}, Producto: {slot.Producto.Name}");
            }
        }
        **/
    }
}
