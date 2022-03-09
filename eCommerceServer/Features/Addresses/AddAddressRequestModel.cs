namespace eCommerceServer.Features.Adresses
{
    public class AddAddressRequestModel
    {
        public string City { get; set; }

        public int PostalCode { get; set; }

        public string Country { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }
    }
}
