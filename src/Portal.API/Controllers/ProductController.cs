using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portal.API.Services;

namespace Portal.API.Controllers
{
    [Route("api/Product")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductRepository _productRepository;

        public ProductController(ILogger<ProductController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }


        [Route("GetProducts")]
        [HttpGet]
        public IActionResult GetProducts()
        {

            var userId = User.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;

            return Ok(_productRepository.GetProducts(int.Parse(userId)));
        }

        [Route("EditProduct")]
        [HttpGet]
        [Authorize("GlobalAdmin")]
        public IActionResult EditProduct()
        {
            return Ok();
        }
    }
}