namespace eCommerceServer.Features.Products
{
    using System.Threading.Tasks;

    public interface IProductService
    {
        Task<int> AddProduct(AddProductRequestModel model);
    }
}
