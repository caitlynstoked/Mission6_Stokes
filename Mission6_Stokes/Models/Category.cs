using System.ComponentModel.DataAnnotations;

namespace Mission6_Stokes.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
