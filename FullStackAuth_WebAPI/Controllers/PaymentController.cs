using FullStackAuth_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System.Web.Http;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/payment/process")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        // POST api/payment/process
        [HttpPost]
        public IHttpActionResult ProcessPayment(PaymentModel paymentModel)
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_51OdbM4LgN1EOODqAkxZW2sDxQShhYQ29QDMWlSnl8y2qXlf1i1xIvBagT0WAPVa4QnbISyWazWiK4uqAjRCjzysa00oPWIXf7q";

                var options = new ChargeCreateOptions
                {
                    Amount = (long?)(paymentModel.Amount * 100),
                    Currency = "usd",
                    Description = paymentModel.Description,
                    Source = paymentModel.Token,
                };

                var service = new ChargeService();
                var charge = service.Create(options);

                return (IHttpActionResult)Ok(new { Message = "Payment successful", PaymentId = charge.Id });
            }
            catch (Exception ex)
            {
                return (IHttpActionResult)BadRequest($"Payment failed: {ex.Message}");
            }
        }

        
    }
}
