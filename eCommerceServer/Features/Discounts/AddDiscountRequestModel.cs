namespace eCommerceServer.Features.Discounts
{
    public class AddDiscountRequestModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal DiscountPercent { get; set; }

        public bool Active { get; set; }
    }
}
