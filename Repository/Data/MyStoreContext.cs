using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Domain.Enums;

namespace Repository.Data
{
    public class MyStoreContext : DbContext
    {
        public MyStoreContext(DbContextOptions<MyStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProductsTags> ProductsTags { get; set; }
        public DbSet<Domain.Models.Attribute> Attributes { get; set; }
        public DbSet<AttributeValues> AttributeValues { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductAttribute>()
                .HasKey(pa => new { pa.ProductId, pa.AttributeValueId });
            // Configure indexes
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.Name);
            
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.CategoryId);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.PhoneNumber)
                .IsUnique();

            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();

            modelBuilder.Entity<Tag>()
                .HasIndex(t => t.Name)
                .IsUnique();

            // Configure relationships
            modelBuilder.Entity<ProductsTags>()
                .HasKey(pt => new { pt.ProductId, pt.TagId });

            // Seed Data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1,Name = "لپ تاپ", Description = "انواع لپ تاپ", CreatedAt = new DateTime(2024, 1, 1), IsDeleted = false },
                new Category { Id = 2, Name = "موبایل", Description = "انواع گوشی موبایل", CreatedAt = new DateTime(2024, 1, 1), IsDeleted = false },
                new Category { Id = 3, Name = "تبلت", Description = "انواع تبلت", CreatedAt = new DateTime(2024, 1, 1), IsDeleted = false }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Email = "admin@mystore.com",
                    Password = "$2a$11$Xo2x3SsNzVZFRJX.sy9ghe/2MOy/j9DgJgc2C5fa3j6fa0nk/7pba",
                    FirstName = "مدیر",
                    LastName = "سیستم",
                    PhoneNumber = "09123456789",
                    Address = "تهران",
                    Role = Roles.admin,
                    CreatedAt = new DateTime(2024, 1, 1),
                    IsDeleted = false
                }
            );

            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, Name = "پرفروش", CreatedAt = new DateTime(2024, 1, 1), IsDeleted = false },
                new Tag { Id = 2, Name = "جدید", CreatedAt = new DateTime(2024, 1, 1), IsDeleted = false },
                new Tag { Id = 3, Name = "تخفیف دار", CreatedAt = new DateTime(2024, 1, 1), IsDeleted = false }
            );
        }
        public override int SaveChanges()
        {
            UpdateAuditFields();

            return base.SaveChanges();
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateAuditFields();

            return await base.SaveChangesAsync();
        }
        private void UpdateAuditFields()
        {
            var entries = ChangeTracker.Entries()
                 .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property(nameof(Base.CreatedAt)).CurrentValue = DateTime.UtcNow;
                }

                entry.Property(nameof(Base.UpdatedAt)).CurrentValue = DateTime.UtcNow;
            }
        }
    }
}
