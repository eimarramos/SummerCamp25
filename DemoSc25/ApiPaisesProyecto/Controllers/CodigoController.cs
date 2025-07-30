using ApiPaisesProyecto.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPaisesProyecto.Controllers
{
    [Route("api/codigo")]
    [ApiController]
    public class CodigoController : ControllerBase
    {
        private readonly ICodigoGenerador _codigoGenerador;
        private readonly ILogger<CodigoController> _logger;

        public CodigoController(ICodigoGenerador codigoGenerador, ILogger<CodigoController> logger)
        {
            _codigoGenerador = codigoGenerador;
            _logger = logger;
        }

        [HttpGet("{prefijo}")]
        public IActionResult Get(string prefijo)
        {
            string codigo = _codigoGenerador.GenerarCodigo(prefijo);
            _logger.LogInformation("Código generado: {Codigo}", codigo);

            return Ok(codigo);
        }
    }
}
