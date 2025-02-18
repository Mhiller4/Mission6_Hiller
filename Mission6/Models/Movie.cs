using System.ComponentModel.DataAnnotations;

namespace Mission6.Models
{
    public class Movie //Creates class for Movies and contains all parameters we're going to pass through
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1888, 2100, ErrorMessage = "Enter a valid year.")]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        public bool? Edited { get; set; } // Nullable boolean for optional field

        [Required]
        public string Rating { get; set; } // Dropdown selection (G, PG, PG-13, R)

        public string? Lent { get; set; } // Optional

        [MaxLength(25, ErrorMessage = "Notes must be 25 characters or fewer.")]
        public string? Notes { get; set; } // Optional with length restriction
    }
}