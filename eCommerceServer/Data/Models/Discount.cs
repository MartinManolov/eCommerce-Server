namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;

    public class Discount: BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Percent { get; set; }

        public bool Active { get; set; }
    }
}
