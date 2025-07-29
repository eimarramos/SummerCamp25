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
        // GET: api/apartamentos
        [HttpGet]
        public IActionResult Get()
        {
            // Devuelve una lista de apartamentos simulada
            var lista = new List<ApartamentoDto>
            {
                new ApartamentoDto { Id = 1, Nombre = "Apartamento 1", Ciudad = "Ciudad A" },
                new ApartamentoDto { Id = 2, Nombre = "Apartamento 2", Ciudad = "Ciudad B" },
                new ApartamentoDto { Id = 3, Nombre = "Apartamento 3", Ciudad = "Ciudad C" }
            };

            return Ok(lista);
        }
    }
}
