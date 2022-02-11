namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ShoppingSession: BaseDeletableModel<int>
    {
        public ShoppingSession()
        {
            this.CartItems = new HashSet<CartItem>();
        }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public decimal Total { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
