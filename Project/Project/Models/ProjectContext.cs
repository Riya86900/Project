using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project.Models
{
    public partial class ProjectContext : DbContext
    {
        public ProjectContext()
        {
        }

        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Project;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("Created_At")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("Created_By")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasColumnName("Customer_Address")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasColumnName("Mobile_Number")
                    .HasDefaultValueSql("('Null')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("Updated_At")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('Null')");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Null')");
            });
        }
    }
}
