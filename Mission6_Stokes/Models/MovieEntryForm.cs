using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Stokes.Models
{
    public class MovieEntryForm
    {
        [Key]
        [Required]
        public int MovieId { get; set; }


        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required]
        public string Title { get; set; }


        [Required]
        [Range(/*minValue*/ 1888, int.MaxValue, ErrorMessage = "Year must be greater than or equal to 1888")]
        public int Year { get; set; }

        public string? Director { get; set; }

        [Required(ErrorMessage = "Please indicate whether edited or not.")]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }
        public string? Rating { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
