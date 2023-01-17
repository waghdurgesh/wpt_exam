using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace crud_basic.Models
{
    public partial class transflower_misContext : DbContext
    {
        public transflower_misContext()
        {
        }

        public transflower_misContext(DbContextOptions<transflower_misContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Qualification> Qualifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;user id=root;password=123456789;database=transflower_mis");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Qualification>(entity =>
            {
                entity.ToTable("qualifications");

                entity.HasIndex(e => e.Id, "qid_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Degree)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("degree");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
