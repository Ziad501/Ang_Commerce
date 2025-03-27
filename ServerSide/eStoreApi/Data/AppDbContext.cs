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
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__categori__3213E83FFD1BFE48");

                entity.ToTable("categories", "estore");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Category1)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("category");
                entity.Property(e => e.ParentCategoryId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("parent_category_id");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__products__3213E83F2B2B7AC6");

                entity.ToTable("products", "estore");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.CategoryId)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("category_id");
                entity.Property(e => e.Price)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("price");
                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("product_description");
                entity.Property(e => e.ProductImg)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("product_img");
                entity.Property(e => e.ProductName)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("product_name");
                entity.Property(e => e.Ratings)
                    .HasDefaultValueSql("(NULL)")
                    .HasColumnName("ratings");

                entity.HasOne(d => d.Category).WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Products_Categories");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
