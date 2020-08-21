namespace Assignment5
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;


    /*
     Name = Arshdeep Singh
     Student id No + 301118326
     Assignment 5
    */
    public partial class DollarComputersEntity : DbContext
    {
        public DollarComputersEntity()
            : base("name=DollarComputersConn")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
