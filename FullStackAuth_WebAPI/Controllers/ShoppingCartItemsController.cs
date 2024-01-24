using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using ZstdSharp.Unsafe;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/shoppingcart
        [HttpGet("{userId}")]
        public IActionResult GetShoppingCartItems(string userId)
        {
            var shoppingCartItems = _context.ShoppingCartItems.Where(s => s.UserId == userId).ToList();

            return Ok(shoppingCartItems);
            
        }

        // POST api/shoppingcartitems
        [HttpPost("{userId}/{productId}")]
        public IActionResult AddToCart(string userId, string productId, [FromBody] int quantity)
        {
            if (quantity <= 0)
            {
                return BadRequest("Quantity should be greater than 0.");
            }

            var existingItem = _context.ShoppingCartItems.FirstOrDefault(e => e.UserId == userId && e.ProductId == productId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                var newItem = new ShoppingCartItem
                {
                    ProductId = productId,
                    Quantity = quantity
                };

                _context.ShoppingCartItems.Add(newItem);
            }

            _context.SaveChanges();
            return Ok("Product added to the shopping cart");
        }

        // PUT api/<ShoppingCartItemsController>/5
        [HttpPut("{userId}/{productId}")]
        public IActionResult AdjustQuantity(string userId, string productId, [FromBody] int quantity)
        {
            if (quantity <= 0)
            {
                return BadRequest("Quantity should be greater than 0.");
            }

            var itemToAdjust = _context.ShoppingCartItems
                .FirstOrDefault(i => i.UserId == userId && i.ProductId == productId);

            if (itemToAdjust == null)
            {
                return NotFound("Product not found in the shopping cart.");
            }

            itemToAdjust.Quantity = quantity;
            _context.SaveChanges();

            return Ok("Quantity adjusted in the shopping cart.");
        }

        // DELETE api/<ShoppingCartItemsController>/5
        [HttpDelete("{userId}/{productId}")]
        public IActionResult RemoveFromCart(string userId, string productId)
        {
            var itemToRemove = _context.ShoppingCartItems
                .FirstOrDefault(i => i.UserId == userId && i.ProductId == productId);
        
            if (itemToRemove == null)
            {
                return NotFound("Product not found in the shopping cart.");
            }

            _context.ShoppingCartItems.Remove(itemToRemove);
            _context.SaveChanges();

            return Ok("Product removed from the shopping cart.");
        }
    }
}
