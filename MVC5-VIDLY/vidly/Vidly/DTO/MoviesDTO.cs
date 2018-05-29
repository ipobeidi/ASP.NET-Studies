using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Vidly.DTO
{
    public class MoviesDTO
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime ReleasedDate { get; set; }

        public DateTime AddData { get; set; }

        
        public int Quantity { get; set; }

       
        public int GenreId { get; set; }
    }
}