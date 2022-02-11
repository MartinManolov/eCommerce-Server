namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;

    public class OrderItem: BaseDeletableModel<int>
    {
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int OrderDetailsId { get; set; }

        public virtual OrderDetails OrderDetails { get; set; }

        public int Quantity { get; set; }
    }
}
