using eStoreApi.Models;
using Microsoft.EntityFrameworkCore;

namespace eStoreApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("estore");

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(10,2)");

            modelBuilder.Entity<Category>()
            .HasMany(c => c.SubCategories)
            .WithOne(c => c.ParentCategory)
            .HasForeignKey(c => c.ParentCategoryId)
            .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Men", ParentCategoryId = null },
                new Category { Id = 2, Name = "Women", ParentCategoryId = null },
                new Category { Id = 3, Name = "Kids", ParentCategoryId = null },
                new Category { Id = 4, Name = "Casual Wear", ParentCategoryId = 1 },
                new Category { Id = 5, Name = "Party Wear", ParentCategoryId = 2 },
                new Category { Id = 6, Name = "Foot Wear", ParentCategoryId = 2 },
                new Category { Id = 7, Name = "Accessories", ParentCategoryId = 3 }


            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, ProductName = "Jacket", ProductDescription = "Jacket description goes here", Price = 100.00m, Ratings = 5, CategoryId = 5, ProductImg = "shop-1.jpg" },
                new Product { Id = 2, ProductName = "Purse", ProductDescription = "Very nice purse", Price = 25.00m, Ratings = 3, CategoryId = 7, ProductImg = "shop-2.jpg" },
                new Product { Id = 3, ProductName = "Dress", ProductDescription = "Nice Party Dress", Price = 45.00m, Ratings = 4, CategoryId = 5, ProductImg = "shop-3.jpg" }
            );
        }
    }
}
