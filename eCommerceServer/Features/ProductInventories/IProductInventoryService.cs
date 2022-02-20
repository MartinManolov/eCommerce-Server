namespace eCommerceServer.Features.ProductInventories
{
    using System.Threading.Tasks;

    public interface IProductInventoryService
    {
        Task<int> AddProductInventory(AddProductInventoryRequestModel model);
    }
}
