using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieViewModel
    {
        public IEnumerable<Genre>   Genres { get; set; }
        
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleasedDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public int? Quantity { get; set ; }


        public MovieViewModel()
        {
            Id = 0;
        }
        public MovieViewModel(Movie movie)
        {

            Id = movie.Id;
            Name = movie.Name;
            ReleasedDate = movie.ReleasedDate;
            Quantity = movie.Quantity;
            GenreId = movie.GenreId;
        }
    }
}