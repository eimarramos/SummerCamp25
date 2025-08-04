using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPaisesProyecto.BaseDatos;
using ApiPaisesProyecto.Entities;
using ApiPaisesProyecto.Models;

namespace ApiPaisesProyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistritosController : ControllerBase
    {
        private readonly ContextoBaseDatos _context;

        public DistritosController(ContextoBaseDatos context)
        {
            _context = context;
        }

        // GET: api/Distritos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DistritoDto>>> GetDistritos()
        {
            var distritos = await _context.Distritos.ToListAsync();
            var distritosDto = distritos.Select(d => new DistritoDto { Id = d.Id, Nombre = d.Nombre }).ToList();

            return distritosDto;
        }

        // GET: api/Distritos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Distrito>> GetDistrito(int id)
        {
            var distrito = await _context.Distritos.FindAsync(id);

            if (distrito == null)
            {
                return NotFound();
            }

            return distrito;
        }

        // PUT: api/Distritos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDistrito(int id, Distrito distrito)
        {
            if (id != distrito.Id)
            {
                return BadRequest();
            }

            _context.Entry(distrito).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DistritoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Distritos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Distrito>> PostDistrito(Distrito distrito)
        {
            _context.Distritos.Add(distrito);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDistrito", new { id = distrito.Id }, distrito);
        }

        // DELETE: api/Distritos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDistrito(int id)
        {
            var distrito = await _context.Distritos.FindAsync(id);
            if (distrito == null)
            {
                return NotFound();
            }

            _context.Distritos.Remove(distrito);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DistritoExists(int id)
        {
            return _context.Distritos.Any(e => e.Id == id);
        }
    }
}
