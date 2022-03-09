using System.Threading.Tasks;

namespace eCommerceServer.Features.Categories
{
    public interface ICategoriesService
    {
        Task<int> AddCategory(AddCategoryRequestModel model);

        Task<int> AddSubCategory(AddSubCategoryRequestModel model);
    }
}
