using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Domains.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalcController : ControllerBase
    {
        private readonly ILogger<CalcController> _logger;
        private readonly ICalculationHandler handler;

        public CalcController(ILogger<CalcController> logger, ICalculationHandler handler)
        {
            _logger = logger;
            this.handler = handler;
        }

        [HttpGet]
        public ActionResult Get(int a, int b)
        {
            var result = handler.Add(a, b);
            return Ok(result);
        }
    }
}
