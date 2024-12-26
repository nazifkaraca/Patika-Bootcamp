using System.ComponentModel.DataAnnotations;

namespace Week14_3_JWT.Data.Entity
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(16)]
        public string Password { get; set; }
    }
}
