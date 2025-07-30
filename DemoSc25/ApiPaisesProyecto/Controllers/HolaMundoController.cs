using ApiPaisesProyecto.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPaisesProyecto.Controllers
{
    [Route("api/holamundo")]
    [ApiController]
    public class HolaMundoController : ControllerBase
    {
        private readonly ISaludo _saludo;

        public HolaMundoController(ISaludo saludo)
        {
            _saludo = saludo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string saludo = _saludo.Saludar("Eimar");

            return Ok(saludo);
        }

        [HttpGet("{nombre}")]
        public IActionResult Get(string nombre)
        {
            string saludo = _saludo.Saludar(nombre);

            return Ok(saludo);
        }
    }
}
