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
    }
}
