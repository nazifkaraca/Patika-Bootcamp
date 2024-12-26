using System.ComponentModel.DataAnnotations;

namespace _14_1_Identity.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        
        public bool RememberMe { get; set; }
    }
}
