namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;
    using System.Collections.Generic;

    public class SubCategory: BaseDeletableModel<int>
    {
        public SubCategory()
        {
            this.Products = new HashSet<Product>();
        }

        public string Name { get; set; }

        public string CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
