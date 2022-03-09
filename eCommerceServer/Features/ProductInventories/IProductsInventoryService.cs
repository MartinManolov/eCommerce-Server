namespace eCommerceServer.Features.ProductInventories
{
    using System.Threading.Tasks;

    public interface IProductsInventoryService
    {
        Task<int> AddProductInventory(AddProductInventoryRequestModel model);
    }
}
