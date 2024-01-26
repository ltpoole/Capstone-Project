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

        // GET: api/shoppingcartitems
        [HttpGet("{userId}")]
        public IActionResult GetCart(string userId) 
        {
            var cartItems = _context.ShoppingCartItems
                .Where(c => c.UserId == userId)
                .ToList();

            return StatusCode(201, cartItems);
        }


        // POST api/shoppingcartitems
        [HttpPost]
        public async Task<IActionResult> AddToCart([FromBody] ShoppingCartItem item)
        {
            _context.ShoppingCartItems.Add(item);
            await _context.SaveChangesAsync();

            return StatusCode(201, item);
        }


        // PUT api/shoppingcartitems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateQuantity(int id, [FromBody] int newQuantity)
        {
            var item = await _context.ShoppingCartItems.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            item.Quantity = newQuantity;
            await _context.SaveChangesAsync();

            return StatusCode(201, newQuantity);
        }
    

        // DELETE api/shoppingcartitems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveFromCart(int id)
        {
            var item = await _context.ShoppingCartItems.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            _context.ShoppingCartItems.Remove(item);
            await _context.SaveChangesAsync();

            return Ok();
        }
       
    }
}
