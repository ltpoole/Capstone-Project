namespace FullStackAuth_WebAPI.Models
{
    public class PaymentModel
    {
        public decimal Amount { get; set; } 
        public string Description { get; set; }
        public string Token { get; set; }

    }
}
