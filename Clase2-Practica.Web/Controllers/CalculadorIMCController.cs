using Clase2_Practica.Entidades;
using Clase2_Practica.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase2_Practica.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadorIMCController : ControllerBase
    {
        
        private readonly ILogger<CalculadorIMCController> _logger;
        private readonly ICalculadorIMCService _calculadorIMCService;

        public CalculadorIMCController(ILogger<CalculadorIMCController> logger, ICalculadorIMCService calculadorIMCService)
        {
            _logger = logger;
            _calculadorIMCService = calculadorIMCService;
        }

        [HttpPost]
        public double Post(double peso, double altura)
        {
            return _calculadorIMCService.calcular(peso , altura);
        }

    }
}
