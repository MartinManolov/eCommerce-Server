namespace eCommerceServer.Features.Discounts
{
    using System.Threading.Tasks;

    public interface IDiscountService
    {
        Task<int> AddDiscount(AddDiscountRequestModel model);
    }
}
