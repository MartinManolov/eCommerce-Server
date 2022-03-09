namespace eCommerceServer.Features.Adresses
{
    using eCommerceServer.Data.Models;
    using eCommerceServer.Data.Repositories;
    using eCommerceServer.Features.Identity;
    using System.Threading.Tasks;

    public class AddressesService : IAddressesService
    {
        private readonly IDeletableEntityRepository<Adress> addressRepository;
        private readonly IIdentityService identityService;

        public AddressesService(IDeletableEntityRepository<Adress> addressRepository,
                               IIdentityService identityService)
        {
            this.addressRepository = addressRepository;
            this.identityService = identityService;
        }
        public async Task<int> AddAdress(AddAddressRequestModel model)
        {
            var userId = await this.identityService.GetUserId();

            var address = new Adress()
            {
                UserId = userId,
                City = model.City,
                PostalCode = model.PostalCode,
                Country = model.Country,
                Street = model.Street,
                Number = model.Number
            };

            await this.addressRepository.AddAsync(address);
            await this.addressRepository.SaveChangesAsync();

            return address.Id;
        }
    }
}
