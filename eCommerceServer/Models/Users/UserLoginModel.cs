namespace eCommerceServer.Models.Users
{
    using System.ComponentModel.DataAnnotations;

    public class UserLoginModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
