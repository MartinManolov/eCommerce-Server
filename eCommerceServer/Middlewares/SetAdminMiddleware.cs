﻿namespace eCommerceServer.Middlewares
{
    using eCommerceServer.Data.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using System.Linq;
    using System.Threading.Tasks;

    public class SetAdminMiddleware
    {
        private readonly RequestDelegate next;

        public SetAdminMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(
            HttpContext context,
            UserManager<ApplicationUser> userManager)
        {
            await SeedUserInRoles(userManager);
            await this.next(context);
        }

        private static async Task SeedUserInRoles(UserManager<ApplicationUser> userManager)
        {
            if (!userManager.Users.Any(x => x.Email == GlobalConstants.AdministratorEmail))
            {
                var user = new ApplicationUser
                {
                    UserName = GlobalConstants.AdministratorUsername,
                    Email = GlobalConstants.AdministratorEmail,
                };

                var result = await userManager.CreateAsync(user, GlobalConstants.AdministratorPassword);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, GlobalConstants.AdministratorRoleName);
                }
            }
        }
    }
}
