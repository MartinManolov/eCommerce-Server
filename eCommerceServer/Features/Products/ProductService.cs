namespace eCommerceServer.Features.Products
{
    using eCommerceServer.Data.Models;
    using eCommerceServer.Data.Repositories;
    using eCommerceServer.Features.Identity;
    using eCommerceServer.Features.ProductInventories;
    using System;
    using System.Threading.Tasks;

    public class ProductService : IProductService
    {
        private readonly IDeletableEntityRepository<Product> productRepository;
        private readonly IIdentityService identityService;
        private readonly IProductInventoryService productInventoryService;

        public ProductService(IDeletableEntityRepository<Product> productRepository,
                              IIdentityService identityService,
                              IProductInventoryService productInventoryService)
        {
            this.productRepository = productRepository;
            this.identityService = identityService;
            this.productInventoryService = productInventoryService;
        }

        public async Task<int> AddProduct(AddProductRequestModel model)
        {
            var isAdmin = await this.identityService.IsAdmin();

            if (!isAdmin)
            {
                throw new Exception("UnauthorizedAccess: Admin only");
            }

            var productInventoryId = await this.productInventoryService
                                               .AddProductInventory(new AddProductInventoryRequestModel
                                                                   {
                                                                      Quantity = model.InventoryQuantity 
                                                                   });
            var product = new Product
            {
                Name = model.Name,
                Price = model.Price,
                DiscountId = model.DiscountId,
                InventoryId = productInventoryId,
                Description = model.Description,
                CategoryId = model.CategoryId,
                SubCategoryId = model.SubCategoryId
            };

            await this.productRepository.AddAsync(product);
            await this.productRepository.SaveChangesAsync();

            return product.Id;
        }
    }
}
