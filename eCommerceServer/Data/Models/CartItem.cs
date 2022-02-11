namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;

    public class CartItem: BaseDeletableModel<int>
    {
        public int ShoppingSessionId { get; set; }

        public virtual ShoppingSession ShoppingSession { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
