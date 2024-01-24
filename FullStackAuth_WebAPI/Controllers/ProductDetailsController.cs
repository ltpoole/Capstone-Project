using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductDetailsController(ApplicationDbContext context)
        { 
            _context = context; 
        }

        // GET api/productdetails/1
        [HttpGet("{productId}")]
        public IActionResult GetProductDetails(string productId)
        {
            var reviews = _context.Reviews.Where(r => r.ProductId == productId).Select(r => new ReviewWithUserDto
            {
                Id = r.Id,
                ProductId = r.ProductId,
                Text = r.Text,
                Rating = r.Rating,
                User = new UserForDisplayDto
                {
                    Id = r.User.Id,
                    FirstName = r.User.FirstName,
                    LastName = r.User.LastName,
                    UserName = r.User.UserName,
                }
            }).ToList();

            var averageRating = reviews.Any() ? reviews.Average(r => r.Rating) : 0;

            var productDetailsDto = new ProductDetailsDto
            {
                Reviews = reviews,
                AverageRating = averageRating,
            };

            return StatusCode(200, productDetailsDto);
        }
    }
}
