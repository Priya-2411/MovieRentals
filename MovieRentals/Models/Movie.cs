using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieRentals.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName = "varchar(10)")]
        [Required]
        public string Genre { get; set; }

        [Required]
        public int Length { get; set; }
    }
}

