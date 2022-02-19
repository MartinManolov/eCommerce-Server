namespace eCommerceServer.Features.Identity
{
    using eCommerceServer.Data.Models;
    using System.Threading.Tasks;

    public interface IIdentityService
    {
        Task<string> GenerateJwtToken(ApplicationUser user);

        Task<string> GetUserId();

        Task<bool> IsAdmin();
    }
}
