namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserPayment: BaseDeletableModel<int>
    {
        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string PaymentType { get; set; }

        public string Provider { get; set; }

        public int AccountNumber { get; set; }

        public DateTime Expire { get; set; }
    }
}
