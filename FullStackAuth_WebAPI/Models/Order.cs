using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace FullStackAuth_WebAPI.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DataType OrderDate { get; set; }
        [Required]
        public double TotalAmount { get; set; }
        [Required]
        public string OrderStatus { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }


    }
}
