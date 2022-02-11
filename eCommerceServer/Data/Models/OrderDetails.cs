namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class OrderDetails: BaseDeletableModel<int>
    {
        public OrderDetails()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public decimal Total { get; set; }

        public int PaymentDetailsId { get; set; }

        public virtual PaymentDetails PaymentDetails { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
