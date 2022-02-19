namespace eCommerceServer.Features.Identity
{
    using eCommerceServer.Data.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.Options;
    using Microsoft.IdentityModel.Tokens;
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IHttpContextAccessor httpContext;
        private readonly IOptions<AppSettings> appSettings;

        public IdentityService(UserManager<ApplicationUser> userManager,
                               IHttpContextAccessor httpContext,
                               IOptions<AppSettings> appSettings)
        {
            this.userManager = userManager;
            this.httpContext = httpContext;
            this.appSettings = appSettings;
        }
        public async Task<string> GenerateJwtToken(ApplicationUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(this.appSettings.Value.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id) ,
                        new Claim(ClaimTypes.Name,user.UserName)
                    }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var userRoles = await userManager.GetRolesAsync(user);

            foreach (var userRole in userRoles)
            {
                tokenDescriptor.Subject.AddClaim(new Claim(ClaimTypes.Role, userRole));
            }

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var encryptedToken = tokenHandler.WriteToken(token);

            return encryptedToken;
        }

        public async Task<string> GetUserId()
        {
            var user = await this.userManager.GetUserAsync(this.httpContext.HttpContext.User);
                
            return user.Id;
        }

        public async Task<bool> IsAdmin()
        {
            
            var user = await this.userManager.GetUserAsync(this.httpContext.HttpContext.User);
            
            return await userManager.IsInRoleAsync(user, GlobalConstants.AdministratorRoleName);
        }
    }
}
