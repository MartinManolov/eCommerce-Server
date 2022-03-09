namespace eCommerceServer.Features.Categories
{
    using eCommerceServer.Data.Models;
    using eCommerceServer.Data.Repositories;
    using eCommerceServer.Features.Identity;
    using System;
    using System.Threading.Tasks;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoryRepository;
        private readonly IDeletableEntityRepository<SubCategory> subCategoryRepository;
        private readonly IIdentityService identityService;

        public CategoriesService(IDeletableEntityRepository<Category> categoryRepository,
                               IDeletableEntityRepository<SubCategory> subCategoryRepository,
                               IIdentityService identityService)
        {
            this.categoryRepository = categoryRepository;
            this.subCategoryRepository = subCategoryRepository;
            this.identityService = identityService;
        }

        public async Task<int> AddCategory(AddCategoryRequestModel model)
        {
            var isAdmin = await identityService.IsAdmin();
            if(!isAdmin)
            {
                throw new Exception("UnauthorizedAccess: Admin only");
            }

            var category = new Category { Name = model.Name };

            await this.categoryRepository.AddAsync(category);
            await this.categoryRepository.SaveChangesAsync();

            return category.Id;
        }

        public async Task<int> AddSubCategory(AddSubCategoryRequestModel model)
        {
            var isAdmin = await identityService.IsAdmin();
            if (!isAdmin)
            {
                throw new Exception("UnauthorizedAccess: Admin only");
            }

            var subCategory = new SubCategory { Name = model.Name, CategoryId = model.CategoryId };

            await this.subCategoryRepository.AddAsync(subCategory);
            await this.subCategoryRepository.SaveChangesAsync();

            return subCategory.Id;
        }

    }
}
