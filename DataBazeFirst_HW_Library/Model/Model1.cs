using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataBazeFirst_HW_Library
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<ProductionHouses> ProductionHouses { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>()
                .HasMany(e => e.Books)
                .WithOptional(e => e.Authors)
                .HasForeignKey(e => e.Author_Id);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Books)
                .WithOptional(e => e.Categories)
                .HasForeignKey(e => e.Category_Id);

            modelBuilder.Entity<ProductionHouses>()
                .HasMany(e => e.Books)
                .WithOptional(e => e.ProductionHouses)
                .HasForeignKey(e => e.ProductionHouse_Id);
        }
    }
}
