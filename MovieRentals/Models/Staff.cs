using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieRentals.Models
{
    public class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            Payments = new HashSet<Payments>();
            Rentals = new HashSet<Rentals>();
        }

        [Key]
        public int StaffId { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string LastName { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Email { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payments> Payments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rentals> Rentals { get; set; }


    }
}

