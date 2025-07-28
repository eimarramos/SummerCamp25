using ApiPaisesProyecto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiPaisesProyecto.Controllers
{
    // Este es un controlador de API vacío, preparado para manejar solicitudes HTTP en rutas como /api/apartamentos. Para que sea funcional, debes agregar métodos (acciones) como Get, Post, Put o Delete que gestionen los apartamentos.

    // Nomebre del controlador === Apartamentos

    [Route("api/apartamentos")] // Ruta base para el controlador : api/apartamentos
    [ApiController]
    public class ApartamentosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Craa una lista de apartamentos (actualmente vacía)
            // rellena la lista con datos simulados
            // y devuelve la lista como respuesta HTTP 200 OK. 

            var apartamentos = new List<ApartamentoDto>(); // Aquí deberías usar un modelo de datos real para los apartamentos

            // Simulación de datos de apartamentos
            apartamentos.Add(new ApartamentoDto
            {
                Id = 1,
                Nombre = "Apartamento en el centro",
                Descripcion = "Un hermoso apartamento en el corazón de la ciudad.",
                NumeroHabitaciones = 2,
                NumeroBanios = 1,
                Superficie = 75.5,
                Ubicacion = "Calle Falsa 123, Ciudad",
                Precio = 150000.00m,
                Disponible = true
            });
            apartamentos.Add(new ApartamentoDto
            {
                Id = 2,
                Nombre = "Apartamento en la playa",
                Descripcion = "Un apartamento con vistas al mar.",
                NumeroHabitaciones = 3,
                NumeroBanios = 2,
                Superficie = 120.0,
                Ubicacion = "Avenida del Mar 456, Playa",
                Precio = 250000.00m,
                Disponible = false
            });
            apartamentos.Add(new ApartamentoDto
            {
                Id = 3,
                Nombre = "Apartamento en las montañas",
                Descripcion = "Un acogedor apartamento en la montaña.",
                NumeroHabitaciones = 1,
                NumeroBanios = 1,
                Superficie = 50.0,
                Ubicacion = "Calle de la Montaña 789, Montaña",
                Precio = 100000.00m,
                Disponible = true
            });


            return Ok(apartamentos); // Devuelve la lista de apartamentos con un estado HTTP 200 OK
        }
    }
}
