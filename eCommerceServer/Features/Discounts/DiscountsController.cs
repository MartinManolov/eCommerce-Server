using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceServer.Features.Discounts
{
    public class DiscountsController: ApiController
    {
        private readonly IDiscountsService discountService;

        public DiscountsController(IDiscountsService discountService)
        {
            this.discountService = discountService;
        }

        [HttpPost]
        [Route("AddDiscount")]
        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        public async Task<ActionResult<int>> AddDiscount(AddDiscountRequestModel model)
        {
            return await this.discountService.AddDiscount(model);
        }
    }
}
