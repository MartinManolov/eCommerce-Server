namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;

    public class ProductInventory: BaseDeletableModel<int>
    {
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
