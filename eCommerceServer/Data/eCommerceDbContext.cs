namespace eCommerceServer.Data
{
    using eCommerceServer.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class eCommerceDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public eCommerceDbContext(DbContextOptions<eCommerceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Adress> Adresses { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Discount> Discounts { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<PaymentDetails> PaymentDetails { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductInventory> ProductInventories { get; set; }

        public DbSet<ShoppingSession> ShoppingSessions { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<UserPayment> UserPayments { get; set; }
    }
}
