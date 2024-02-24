using System.ComponentModel.DataAnnotations;

namespace Mission6_Stokes.Models
{
    public class Class
    {
        [Key]
        [Required]
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public bool Edited { get; set; }

        public string Rating { get; set; }

        public string Notes { get; set; }
    }
}
