namespace eCommerceServer.Features.Products
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class ProductsController: ApiController
    {
        private readonly IProductsService productService;

        public ProductsController(IProductsService productService)
        {
            this.productService = productService;
        }

        [HttpPost]
        [Route("AddProduct")]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<ActionResult<int>> AddProduct(AddProductRequestModel model)
        {
            return await this.productService.AddProduct(model);
        }
    }
}
