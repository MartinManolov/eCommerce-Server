namespace eCommerceServer.Models.Users
{
    using System.ComponentModel.DataAnnotations;

    public class UserRegisterModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
