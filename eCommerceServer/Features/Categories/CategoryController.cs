using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eCommerceServer.Features.Categories
{
    public class CategoryController : ApiController
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpPost]
        [Route("addCategory")]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<ActionResult<int>> AddCategory(AddCategoryRequestModel model)
        {
            return await this.categoryService.AddCategory(model);
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<ActionResult<int>> AddSubCategory(AddSubCategoryRequestModel model)
        {
            return await this.categoryService.AddSubCategory(model);
        }
    }
}
