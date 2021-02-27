using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentals.Models
{
    public class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Payments = new HashSet<Payments>();
            Rentals = new HashSet<Rentals>();
        }
        [Key]
        public int CustomerId { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string LastName { get; set; }
        [Column(TypeName = "char(10)")]
        [Required]
        public string TelNumber { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payments> Payments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rentals> Rentals { get; set; }
    }
}

