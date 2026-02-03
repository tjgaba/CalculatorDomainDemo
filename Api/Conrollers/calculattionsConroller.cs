using CalculatorDomainDemo
using CalculationServices

namespace Api.controllers
{
    [ApiController]
    [Route(api/Calculation)]

    public class CalculationController : controllers
    {
        private readonly CalculationServices calculater;

        public CalculationController(CalculationServices calculater)
        {
            calculater = _calculator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var calculations = await _calculator.GetAllAsync;

        }
    }

    [HttpPost]
    public async Task <ActionResult>
}