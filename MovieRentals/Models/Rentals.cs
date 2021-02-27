using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieRentals.Models
{
    public class Rentals
    {
        [Key]
        public int RentalId { get; set; }


        public DateTime RentalDate { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int staff_id { get; set; }

        [Required]
        public int Movie_id { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Staff Staff { get; set; }
    }
}

