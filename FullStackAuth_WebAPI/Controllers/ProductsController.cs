using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/products
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            try
            {
                var products = _context.Products.ToList();

                return StatusCode(200, products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/products/5
        [HttpGet("{productId}"), Authorize]
        public IActionResult GetProductById(int? productId)
        {
            if (productId == null)
            {
                return NotFound();
            }
            var product = _context.Products.FirstOrDefault(p => p.Id == productId);

            if (product == null)
            {
                return NotFound();
            }
            return StatusCode(200, product);
        }

        // POST api/products
        [HttpPost]
        public IActionResult PostProduct([FromBody] Product product)
        {
            try
            {
            _context.Products.Add(product);
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
            _context.SaveChanges();

            return StatusCode(201, product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/products/5
        [HttpPut("{productId}")]
        public IActionResult EditProduct(int productId, [FromBody] Product product)
        {
            var data = _context.Products.FirstOrDefault(p => p.Id == productId);

            if (data != null)
            {
                data.Name = product.Name;
                data.Description = product.Description;
                data.Price = product.Price;
                data.Quantity = product.Quantity;
                _context.SaveChanges();
            }
            return StatusCode(200, product);
        }

        // DELETE api/products/5
        [HttpDelete("{productId}")]
        public IActionResult DeleteProduct(int productId)
        {
            var product = _context.Products.FirstOrDefault(p =>p.Id == productId);
            if (product == null) 
            { 
                return NotFound(); 
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
