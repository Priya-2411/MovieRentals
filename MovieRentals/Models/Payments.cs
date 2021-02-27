using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieRentals.Models
{
    public class Payments
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]

        public int CustomerId { get; set; }
        [Required]
        public int staff_id { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal Payment_due { get; set; }


        public virtual Customer Customer { get; set; }

        public virtual Staff Staff { get; set; }
    }
}

