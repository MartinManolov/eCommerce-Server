namespace eCommerceServer.Features.Identity
{
    using eCommerceServer.Data.Models;
    using eCommerceServer.Features;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class IdentityController : ApiController
    {
        private readonly AppSettings appSettings;
        private readonly IIdentityService identityService;
        private readonly UserManager<ApplicationUser> userManager;
        public IdentityController(
            IIdentityService identityService,
            IOptions<AppSettings> appSettings,
            UserManager<ApplicationUser> userManager)
        {
            this.appSettings = appSettings.Value;
            this.identityService = identityService;
            this.userManager = userManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> Register([FromBody] RegisterRequestModel model)
        {
            var userExists = await userManager.FindByNameAsync(model.UserName);
            if (userExists != null)
            {
                return StatusCode(StatusCodes.Status409Conflict);
            }

            ApplicationUser user = new ApplicationUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.UserName,
            };

            var result = await userManager.CreateAsync(user, model.Password);

            await userManager.AddToRoleAsync(user, GlobalConstants.UserRoleName);

            return Ok(result);
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<object>> Login([FromBody] LoginRequestModel model)
        {
            var user = await this.userManager.FindByNameAsync(model.UserName);
            if(user == null)
            {
                return Unauthorized();
            }

            var passwordValid = await this.userManager.CheckPasswordAsync(user, model.Password);

            if(!passwordValid)
            {
                return Unauthorized();
            }

            var encryptedToken = await this.identityService.GenerateJwtToken(user);

            return new LoginResponseModel
            {
                Token = encryptedToken
            };
        }
    }
}
