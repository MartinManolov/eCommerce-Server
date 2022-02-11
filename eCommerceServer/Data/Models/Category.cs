namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;
    using System.Collections.Generic;

    public class Category: BaseDeletableModel<int>
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
            this.SubCategories = new HashSet<SubCategory>();
        }

        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
