using System.ComponentModel.DataAnnotations;

namespace VediGroup.Pages.Account
{
    public class RegisterViewModel
    {
        [Required]
        [MinLength(4)]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}