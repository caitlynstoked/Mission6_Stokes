using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DateMe.Models
{
    public class Application
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
