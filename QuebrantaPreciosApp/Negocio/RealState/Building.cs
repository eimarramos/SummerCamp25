using Business.Location;

namespace Business.RealState;

public class Building
{
    public Building() { }
    public Building(string name = "", int id = 1, int floorNumber = 1, bool hasLift = false)
    {
        Name = name;
        Id = id;
        FloorsNumber = floorNumber;
        HasLift = hasLift;
        AparmentsPerFloor = 4;
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public int FloorsNumber { get; set; }
    public bool HasLift { get; set; }
    public int AparmentsPerFloor { get; set; }
    public District District { get; set; } = new District();

    private void ShowApartmentNumber()
    {
        Console.WriteLine($"Número total de apartamentos: {AparmentsPerFloor * FloorsNumber}");
    }

    public override string? ToString()
    {
        return $"Edifício: {Name}, ID: {Id}, Plantas: {FloorsNumber}, Ascensor: {(HasLift ? "Sí" : "No")}, Apartamentos por planta: {AparmentsPerFloor}, Total apartamentos: {ShowApartmentNumber}";
    }
}

