namespace eCommerceServer.Features.Products
{
    using System.Threading.Tasks;

    public interface IProductsService
    {
        Task<int> AddProduct(AddProductRequestModel model);
    }
}
