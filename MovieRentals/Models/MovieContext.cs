using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;

namespace MovieRentals.Models
{
    public partial class MovieContext : DbContext
    {
      
       public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public  DbSet<Movie> Movies { get; set; }
        public  DbSet<Payments> Payments { get; set; }
        public  DbSet<Rentals> Rentals { get; set; }
        public  DbSet<Staff> Staffs { get; set; }

        protected virtual void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder) { 
        modelBuilder.Entity<Customer>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.TelNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Rentals)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.Genre)
                .IsUnicode(false);

            modelBuilder.Entity<Payments>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payments>()
                .Property(e => e.Payment_due)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Staff>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Rentals)
                .WithRequired(e => e.Staff)
                .WillCascadeOnDelete(false);
        }
    }
}
