using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStackAuth_WebAPI.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }


    }
}
