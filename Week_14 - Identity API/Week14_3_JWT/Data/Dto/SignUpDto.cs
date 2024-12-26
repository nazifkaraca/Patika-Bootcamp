using System.ComponentModel.DataAnnotations;

namespace Week14_3_JWT.Data.Dto
{
    public class SignUpDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(16)]
        public string Password { get; set; }
    }
}
