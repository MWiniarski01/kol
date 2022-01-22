using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolokwium;
using Kolokwium.Model.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Student> Students { get; set; }

        // public virtual DbSet<Book> Books { get; set; }
        // public virtual DbSet<Library> Libraryes { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        // public virtual DbSet<Employee> Department { get; set; }
        // public virtual DbSet<BookAuthor> BookAuthors { get; set; }
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        ) :
            base(options)
        {
        }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder
        )
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Library>()
                .HasMany(lib => lib.Books)
                .WithOne(boo => boo.Library)
                .HasForeignKey(x => x.LibraryId)
                .IsRequired();
            modelBuilder
                .Entity<Library>()
                .HasMany(lib => lib.Clients)
                .WithOne(cli => cli.Library)
                .HasForeignKey(x => x.ClientId)
                .IsRequired();
            modelBuilder
                .Entity<Library>()
                .HasMany(lib => lib.Employees)
                .WithOne(emp => emp.Library)
                .HasForeignKey(x => x.EmployeeId)
                .IsRequired();
            modelBuilder
                .Entity<Book>()
                .HasMany(boo => boo.Students)
                .WithOne(stu => stu.Book)
                .HasForeignKey(x => x.StudentId)
                .IsRequired();
            modelBuilder
                .Entity<Client>()
                .HasMany(cli => cli.BorrowedBooks)
                .WithOne(bro => bro.Client)
                .HasForeignKey(x => x.BorrowedBooksId)
                .IsRequired();
            modelBuilder
                .Entity<Department>()
                .HasMany(dep => dep.Students)
                .WithOne(stu => stu.Department)
                .HasForeignKey(x => x.StudentId)
                .IsRequired();
            modelBuilder
                .Entity<BookAuthor>()
                .HasKey(ba => new { ba.AuthorId, ba.BookId });

            modelBuilder
                .Entity<BookAuthor>()
                .HasOne(b => b.Author)
                .WithMany(ba => ba.BookAuthors)
                .HasForeignKey(x => x.AuthorId);
            modelBuilder
                .Entity<BookAuthor>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.BookAuthors)
                .HasForeignKey(x => x.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            // modelBuilder.Entity<Student>().ToTable("Students");
            // // modelBuilder.Entity<Person>().ToTable("Persons");
            // modelBuilder.Entity<Book>().ToTable("Books");
            // modelBuilder.Entity<Library>().ToTable("Libraryes");
            // // modelBuilder.Entity<Client>().ToTable("Clients");
            // // modelBuilder.Entity<Employee>().ToTable("Employees");
            // modelBuilder.Entity<Department>().ToTable("Department");
            // modelBuilder.Entity<BookAuthor>().ToTable("BookAuthor");
            // modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder
                .Entity<Person>()
                .ToTable("Person")
                .HasDiscriminator<int>("PersonType")
                .HasValue<Person>(0)
                .HasValue<Client>(1)
                .HasValue<Employee>(2)
                .HasValue<Author>(3)
                .HasValue<Student>(4);
        }
    }
}
