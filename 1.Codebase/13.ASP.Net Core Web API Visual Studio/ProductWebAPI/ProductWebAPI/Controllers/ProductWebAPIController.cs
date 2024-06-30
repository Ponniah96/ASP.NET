using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ProductWebAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/ProductDetails")]
    [ApiController]
    public class ProductWebAPIController : ControllerBase
    {
        //Initialize static field data
        private static readonly string[] MobileNames = new[] { "iPhone", "One Plus", "Google Pixel", "Samsung Galaxy", "Vivo"};
        private static readonly string[] MobileDescription = new[] { "Apple Product", "Best Android Phone", "Google Product", "Android Elite Models", "Affordable Smartphones" };
        private static readonly string MobileCategory = "Mobiles";
        //Create new logger
        private readonly ILogger<ProductWebAPIController> _logger;
        public ProductWebAPIController(ILogger<ProductWebAPIController> logger)
        {
            _logger = logger;
        }

        //Create action method or controller to store data in product model
        //Create GET Method
        [HttpGet(Name ="GetProductDetails")]
        public IEnumerable<ProductModelData> Get() {
            return Enumerable.Range(0, MobileNames.Length).Select(index => new ProductModelData
            {
                ModelName = MobileNames[index],
                ModelDescription = MobileDescription[index],
                originalPrice = Random.Shared.Next(10000, 100000),
                ModelCategory = MobileCategory,
            }).ToArray();
        }
    }
}
