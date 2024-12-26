using System.ComponentModel.DataAnnotations;

namespace Week14_3_JWT.Data.Dto
{
    public class SignInDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
