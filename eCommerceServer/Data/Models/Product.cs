namespace eCommerceServer.Data.Models
{
    using eCommerceServer.Data.Models.Common;
    using System.Collections.Generic;

    public class Product: BaseDeletableModel<int>
    {
        public Product()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public int DiscountId { get; set; }

        public virtual Discount Discount { get; set; }

        public int InventoryId { get; set; }

        public virtual ProductInventory ProductInventory { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int SubCategoryId { get; set; }

        public virtual SubCategory SubCategory { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
