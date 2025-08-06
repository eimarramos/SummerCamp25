using ApiPaisesProyecto.BaseDatos;
using ApiPaisesProyecto.Entities;
using ApiPaisesProyecto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiPaisesProyecto.Controllers
{
    // Este es un controlador de API vacío, preparado para manejar solicitudes HTTP en rutas como /api/apartamentos. Para que sea funcional, debes agregar métodos (acciones) como Get, Post, Put o Delete que gestionen los apartamentos.

    // Nomebre del controlador === Apartamentos

    [Route("api/apartamentos")] // Ruta base para el controlador : api/apartamentos
    [ApiController]
    public class ApartamentosController : ControllerBase
    {
        ContextoBaseDatos _context;
        public ApartamentosController(ContextoBaseDatos contextoBaseDatos)
        {
            // Constructor del controlador, puedes inicializar servicios o dependencias aquí si es necesario.
            _context = contextoBaseDatos;
        }

        // GET: api/apartamentos
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // Devuelve una lista de apartamentos simulada
            var lista = await _context.Apartamentos
                                 //.Where(apartamento => apartamento.Ciudad.Contains("a") && apartamento.Puerta.Contains("1"))
                                 .Where(apartamento => apartamento.Ciudad == "Zanebury")
                                 .OrderBy(apartamento => apartamento.Nombre)
                                 .ToListAsync();

            return Ok(lista);
        }

        [HttpPost]
        public async Task<ActionResult<Apartamento>> PostApartamento(Apartamento apartamento)
        {
            _context.Apartamentos.Add(apartamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApartamento", new { id = apartamento.Id }, apartamento);
        }
    }
}
