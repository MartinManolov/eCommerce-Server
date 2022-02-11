namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Adress: BaseDeletableModel<int>
    {
        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string City { get; set; }

        public int PostalCode { get; set; }

        public string Country { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }
    }
}
