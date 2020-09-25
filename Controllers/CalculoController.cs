using Microsoft.AspNetCore.Mvc;
using prj_01_extension_method.Services;

namespace prj_01_extension_method.Controllers
{

    [ApiController]
    [Route("calculo")]
    public class CalculoController : ControllerBase
    {
        private readonly ICalculoService _calculoService;

        public CalculoController(ICalculoService calculoService)
        {
            _calculoService = calculoService;
        }


        [HttpGet("Somar")]
        public IActionResult Somar()
        {
            return Ok(_calculoService.Somar(1,2));
        }
    }
}