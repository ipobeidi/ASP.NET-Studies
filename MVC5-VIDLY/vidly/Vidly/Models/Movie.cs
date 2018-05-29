
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Vidly.CustomValidations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }

        public DateTime AddData { get; set; }

        [Display(Name = "Number in Stock")]
        public int Quantity { get; set; }

        [Display(Name="Genre")]
        public int GenreId { get; set; }

        [ForeignKey("GenreId")]
        public Genre Genres { get; set; }

        public static readonly byte Zero = 0;
        public static readonly byte Max = 20;
    }
}