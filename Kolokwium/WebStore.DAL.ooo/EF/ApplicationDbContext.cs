using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Model.DataModels;

namespace WebStore.DAL.EF
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        // Table properties e.g
        // public virtual DbSet<Entity> TableName { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductStock> ProductStocks { get; set; }
        public virtual DbSet<StationaryStore> StationaryStores { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //configuration commands
            optionsBuilder.UseLazyLoadingProxies(); //enable lazy loading proxies
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent API commands

            // Relacje 1:M

            // 1 Customer : M Orders
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(x => x.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // 1 Supplier : M Products
            modelBuilder.Entity<Supplier>()
                .HasMany(s => s.Products)
                .WithOne(p => p.Supplier)
                .HasForeignKey(x => x.SupplierId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // 1 Product : M ProductStocks
            modelBuilder.Entity<Product>()
                .HasMany(p => p.ProductStocks)
                .WithOne(s => s.Product)
                .HasForeignKey(x => x.ProductId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // 1 Customer : M Addresses
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Addresses)
                .WithOne(a => a.Customer)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            // 1 Category : M Products
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // 1 Invoice : M Orders
            modelBuilder.Entity<Invoice>()
                .HasMany(i => i.Orders)
                .WithOne(o => o.Invoice)
                .HasForeignKey(x => x.InvoiceId)
                .OnDelete(DeleteBehavior.Restrict);

            // 1 StationarytStore : M Addresses
            modelBuilder.Entity<StationaryStore>()
                .HasMany(s => s.Addresses)
                .WithOne(a => a.StationaryStore)
                .HasForeignKey(x => x.StationaryStoreId)
                .OnDelete(DeleteBehavior.Restrict);

            // 1 StationaryStore : M StationaryStoreEmployees
            modelBuilder.Entity<StationaryStore>()
                .HasMany(s => s.StationaryStoreEmployees)
                .WithOne(se => se.StationaryStore)
                .HasForeignKey(x => x.StationaryStoreId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Relacja Orders N : Products M (OrderProduct)

            //Subjects : Groups
            // Zdefiniowanie złożonego klucza głównego (połączenie kolumn OrderId i ProductId będą stanowić PK tabeli pośredniej OrderProduct )
            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.OrderId, op.ProductId });

            // Zdefiniowanie klucza obcego z OrderProduct do Product
            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(x => x.ProductId);

            // Zdefiniowanie klucza obcego z OrderProduct do Order
            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderProducts)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            // Proszę zrealizować relację dziedziczenia na EF przy pomocy metody TPH dla encji User, Customer, Supplier, StationaryStoreEmployee.
            modelBuilder.Entity<User>()
                .ToTable("Users")
                .HasDiscriminator<int>("UserType")
                .HasValue<User>(0)
                .HasValue<Customer>(1)
                .HasValue<Supplier>(2)
                .HasValue<StationaryStoreEmployee>(3);
        }
    }
}