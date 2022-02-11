namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Adresses = new HashSet<Adress>();
            this.OrderDetails = new HashSet<OrderDetails>();
            this.UserPayments = new HashSet<UserPayment>();
            this.ShoppingSessions = new HashSet<ShoppingSession>();
        }
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
        
        public DateTime CreatedOn { get ; set; }
        
        public DateTime? ModifiedOn { get ; set; }
        
        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }
        
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<Adress> Adresses { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public virtual ICollection<UserPayment> UserPayments { get; set; }

        public virtual ICollection<ShoppingSession> ShoppingSessions { get; set; }

    }
}
