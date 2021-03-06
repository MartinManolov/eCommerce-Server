namespace eCommerceServer.Features.ProductInventories
{
    using eCommerceServer.Data.Models;
    using eCommerceServer.Data.Repositories;
    using eCommerceServer.Features.Identity;
    using System;
    using System.Threading.Tasks;

    public class ProductsInventoryService : IProductsInventoryService
    {
        private readonly IDeletableEntityRepository<ProductInventory> productInventoryRepository;
        private readonly IIdentityService identityService;

        public ProductsInventoryService(IDeletableEntityRepository<ProductInventory> productInventoryRepository,
                                       IIdentityService identityService)
        {
            this.productInventoryRepository = productInventoryRepository;
            this.identityService = identityService;
        }

        public async Task<int> AddProductInventory(AddProductInventoryRequestModel model)
        {
            var isAdmin = await this.identityService.IsAdmin();

            if (!isAdmin)
            {
                throw new Exception("UnauthorizedAccess: Admin only");
            }

            var productInventory = new ProductInventory
            {
                Quantity = model.Quantity
            };

            await this.productInventoryRepository.AddAsync(productInventory);
            await this.productInventoryRepository.SaveChangesAsync();

            return productInventory.Id;
        }
    }
}
