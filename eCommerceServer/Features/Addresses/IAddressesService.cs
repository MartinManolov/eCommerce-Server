using System.Threading.Tasks;

namespace eCommerceServer.Features.Adresses
{
    public interface IAddressesService
    {
        Task<int> AddAdress(AddAddressRequestModel model);
    }
}
