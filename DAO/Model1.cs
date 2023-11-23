using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiTapNho.DAO
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<BookCopies> BookCopies { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BookTransactions> BookTransactions { get; set; }
        public virtual DbSet<Borrowers> Borrowers { get; set; }
        public virtual DbSet<Fines> Fines { get; set; }
        public virtual DbSet<LibraryBranches> LibraryBranches { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Borrowers>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Borrowers>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Borrowers>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Fines>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<LibraryBranches>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<LibraryBranches>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<LibraryBranches>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.LibraryBranches)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.MSV)
                .IsFixedLength();
        }
    }
}
