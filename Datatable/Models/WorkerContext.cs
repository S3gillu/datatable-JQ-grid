using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Datatable.Models
{
    public class WorkerContext:DbContext
    {
        public WorkerContext():base("MyConnection")
        {

        }
        public DbSet<Worker> Workers { get; set; }

        public DbSet<Office> Offices { get; set; }
        public DbSet<Position> Positions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Office>()
                .HasMany(c => c.Workers)
                .WithRequired(a => a.Office);

            modelBuilder.Entity<Worker>()
                .Property(c => c.Name)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Worker>()
                .Property(c => c.Age)
                .IsRequired();

            modelBuilder.Entity<Worker>()
                .Property(c => c.Address)
                .IsRequired();

            modelBuilder.Entity<Worker>()
                .Property(c => c.Email)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Office>()
                .Property(c => c.OfficePlace)
                .HasMaxLength(200)
                .IsRequired();

            modelBuilder.Entity<Office>()
                .Property(c => c.StartDate)
                .IsRequired();
                
                
                

                
        }
    }
}