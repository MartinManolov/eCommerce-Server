namespace eCommerceServer.Features.Discounts
{
    using System.Threading.Tasks;

    public interface IDiscountsService
    {
        Task<int> AddDiscount(AddDiscountRequestModel model);
    }
}
