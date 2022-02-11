namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;
    
    public class PaymentDetails: BaseDeletableModel<int>
    {
        public decimal Amount { get; set; }

        public string Provider { get; set; }

        public string Status { get; set; }

        public virtual OrderDetails OrderDetails { get; set; }
    }
}
