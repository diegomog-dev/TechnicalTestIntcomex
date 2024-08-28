using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Characteristics> Characteristics { get; set; }
        public virtual DbSet<Characteristic_Value> Characteristic_Value { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Category_Characteristic> Category_Characteristic { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_Category> Product_Category { get; set; }
        public virtual DbSet<Product_Subcategory> Product_Subcategory { get; set; }
        public virtual DbSet<Subcategory> Subcategory { get; set; }
        public virtual DbSet<Subcategory_Characteristic> Subcategory_Characteristic { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product_Category>().HasKey(pc => new { pc.Id_Category, pc.Id_Product });
            modelBuilder.Entity<Product_Subcategory>().HasKey(ps => new { ps.Id_Subcategory, ps.Id_Product });
            modelBuilder.Entity<Category_Characteristic>().HasKey(ca => new {ca.Id_Category, ca.Id_Characteristic });
            modelBuilder.Entity<Subcategory_Characteristic>().HasKey(sa => new {sa.Id_Subcategory, sa.Id_Characteristic });
        }
    }
}
