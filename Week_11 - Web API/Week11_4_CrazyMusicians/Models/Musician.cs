using System.ComponentModel.DataAnnotations;

namespace Week11_4_CrazyMusicians.Models
{
    public class Musician
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full Name is mandatory.")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Occupation is mandatory.")]
        [StringLength(50, ErrorMessage = "Occupation cannot exceed 50 characters.")]
        public string Occupation { get; set; } = string.Empty;

        public string? Feature { get; set; }
    }
}
