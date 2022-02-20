namespace eCommerceServer.Features.Products
{
    public class AddProductRequestModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? DiscountId { get; set; }

        public int InventoryQuantity { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public int? SubCategoryId { get; set; }
    }
}
