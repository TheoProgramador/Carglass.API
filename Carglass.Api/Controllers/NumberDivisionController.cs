using Microsoft.AspNetCore.Mvc;
using Carglass.Service;
using Carglass.Entities;

namespace Carglass.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberDivisionController : Controller
    {
        private readonly NumberService _numberService;

        public NumberDivisionController()
        {
            _numberService = new NumberService();
        }

        /// <summary>
        /// Retorna os divisores de um numero e seus divisores primos
        /// </summary>
        /// <remarks>
        /// Endpoint destinado a decompor números
        /// </remarks>
        /// <returns>Lista de numeros divisores do numero inserido e outra lista dos numeros primos destes divisores</returns>
        /// <response code="200">Retorna a lista de divisores e outra com os divisores primos</response>
        /// <response code="500">Se ocorrer um erro no servidor</response>
        [HttpGet("/numberdivision/decompose/{number}")]
        public IActionResult Decompose(int number)
        {
            try
            {
                if (number <= 0)
                    return BadRequest("Number must be greater than 0.");

                var divisors = _numberService.GetDivisors(number);
                var primeDivisors = _numberService.GetPrimeDivisors(divisors);
                var numbers = new ResponseNumber();

                numbers.InputNumber = number;
                numbers.PrimeDivisors = primeDivisors;
                numbers.Divisors = divisors;

                return Ok(numbers);
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }

        }
    }
}
