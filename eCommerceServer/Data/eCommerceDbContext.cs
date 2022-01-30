namespace eCommerceServer.Data
{
    using eCommerceServer.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class eCommerceDbContext : IdentityDbContext<ApplicationUser>
    {
        public eCommerceDbContext(DbContextOptions<eCommerceDbContext> options)
            : base(options)
        {
        }
    }
}
