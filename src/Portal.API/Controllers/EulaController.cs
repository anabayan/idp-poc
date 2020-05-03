using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Portal.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EulaController : ControllerBase
    {
        private readonly ILogger<EulaController> _logger;

        public EulaController(ILogger<EulaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Eula Get()
        {
            return new Eula
            {
                Date = DateTime.Now,
                EulaText = "This is the Eula Body"
            };
        }
    }
}