// Aplicación QuebrantaPrecios

var district = new District();

// Crear instancia de la clase Building para buildingNewGardens

var buildingNewGardens = new Building();

buildingNewGardens.Name = "Edificio Central New Gardens IV";
buildingNewGardens.Id = 1;
buildingNewGardens.FloorsNumber = 10;
buildingNewGardens.HasLift = true;

//Crear instancia de la clase Building para buildingDreamTowers

var buildingDreamTowers = new Building
{
    Name = "Torre de los sueños",
    Id = 2,
    FloorsNumber = 20,
    HasLift = true
};

// Crear instancia de la clase Building para buildingSkyline

var buildingSkyline = new Building
(
    name: "Skyline Towers",
    id: 3,
    floorNumber: 15,
    hasLift: true
);

// Crear lista de edificios

var buildings = new List<Building>
{
    buildingNewGardens,
    buildingDreamTowers,
    buildingSkyline
};

// Mostrar información de los edificios
// Mostar el número total de apartamentos por edificio

foreach (var building in buildings)
{
    Console.WriteLine(building);
}