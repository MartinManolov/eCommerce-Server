namespace eCommerceServer.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(eCommerceDbContext dbContext, IServiceProvider serviceProvider);
    }
}
