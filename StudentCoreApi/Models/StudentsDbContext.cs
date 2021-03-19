using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentCoreApi.Models
{
    public partial class StudentsDbContext : DbContext
    {
        public StudentsDbContext()
        {
        }

        public StudentsDbContext(DbContextOptions<StudentsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=GIRJESH-HP-BS18;database=StudentsDb;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Students__CA19595065647412");

                entity.Property(e => e.Sid).HasColumnName("SId");

                entity.Property(e => e.Sage).HasColumnName("SAge");

                entity.Property(e => e.Scontact)
                    .IsRequired()
                    .HasColumnName("SContact")
                    .HasMaxLength(10);

                entity.Property(e => e.Scourse)
                    .IsRequired()
                    .HasColumnName("SCourse")
                    .HasMaxLength(50);

                entity.Property(e => e.Semail)
                    .IsRequired()
                    .HasColumnName("SEmail")
                    .HasMaxLength(100);

                entity.Property(e => e.Sname)
                    .IsRequired()
                    .HasColumnName("SName")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
