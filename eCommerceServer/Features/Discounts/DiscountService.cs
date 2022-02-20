using eCommerceServer.Data.Models;
using eCommerceServer.Data.Repositories;
using eCommerceServer.Features.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceServer.Features.Discounts
{
    public class DiscountService : IDiscountService
    {
        private readonly IDeletableEntityRepository<Discount> discountRepository;
        private readonly IIdentityService identityService;

        public DiscountService(IDeletableEntityRepository<Discount> discountRepository,
                               IIdentityService identityService)
        {
            this.discountRepository = discountRepository;
            this.identityService = identityService;
        }

        public async Task<int> AddDiscount(AddDiscountRequestModel model)
        {
            var isAdmin = await this.identityService.IsAdmin();

            if (!isAdmin)
            {
                throw new Exception("UnauthorizedAccess: Admin only");
            }

            var discount = new Discount
            {
                Name = model.Name,
                Description = model.Description,
                Percent = model.DiscountPercent,
                Active = model.Active
            };

            await this.discountRepository.AddAsync(discount);
            await this.discountRepository.SaveChangesAsync();

            return discount.Id;
        }
    }
}
