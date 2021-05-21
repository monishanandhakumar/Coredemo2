using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ViewModelCore.Models
{
    public partial class dbMoviesContext : DbContext
    {
        public dbMoviesContext()
        {
        }

        public dbMoviesContext(DbContextOptions<dbMoviesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Disc> Disc { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }

  /*      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-U8J1M3C\\MSSQLSERVER01;Database=dbMovies;Trusted_Connection=True;");
            }
        }
  */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disc>(entity =>
            {
                entity.Property(e => e.DiscName).HasMaxLength(30);

                entity.HasOne(d => d.M)
                    .WithMany(p => p.Disc)
                    .HasForeignKey(d => d.Mid)
                    .HasConstraintName("FK__Disc__Mid__398D8EEE");
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.Property(e => e.MovieName).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
