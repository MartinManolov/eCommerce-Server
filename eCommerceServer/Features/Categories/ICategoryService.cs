using System.Threading.Tasks;

namespace eCommerceServer.Features.Categories
{
    public interface ICategoryService
    {
        public Task<int> AddCategory(AddCategoryRequestModel model);

        public Task<int> AddSubCategory(AddSubCategoryRequestModel model);
    }
}
