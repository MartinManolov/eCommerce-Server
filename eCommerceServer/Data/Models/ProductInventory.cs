namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;

    public class ProductInventory: BaseDeletableModel<int>
    {
        public int Quantity { get; set; }
    }
}
