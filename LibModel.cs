using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace E_Library
{
    public partial class LibModel : DbContext
    {
        public LibModel()
            : base("name=LibModel")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BorrowingTransaction> BorrowingTransactions { get; set; }
        public virtual DbSet<Librarian> Librarians { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<Librarian>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Librarian>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Librarian>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Librarian>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Librarian>()
                .Property(e => e.PhoneNo)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PhoneNo)
                .IsUnicode(false);
        }
    }
}
