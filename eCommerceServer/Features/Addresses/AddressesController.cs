namespace eCommerceServer.Features.Adresses
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class AddressesController : ApiController
    {
        private readonly IAddressesService adressesService;

        public AddressesController(IAddressesService adressesService)
        {
            this.adressesService = adressesService;
        }

        [HttpPost]
        [Authorize]
        [Route("addAdress")]
        public async Task<ActionResult<int>> AddAdress(AddAddressRequestModel model)
        {
            return await this.adressesService.AddAdress(model);
        }
    }
}
