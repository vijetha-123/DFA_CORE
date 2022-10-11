using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DFA_CORE.Models
{
    public partial class TE_Core_MVCContext : DbContext
    {
        public TE_Core_MVCContext()
        {
        }

        public TE_Core_MVCContext(DbContextOptions<TE_Core_MVCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ELW5144\\SQLEXPRESS;Database=TE_Core_MVC;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OId)
                    .HasName("PK__ORDERS__5AA80810AE99F555");

                entity.ToTable("ORDERS");

                entity.Property(e => e.OId)
                    .ValueGeneratedNever()
                    .HasColumnName("O_id");

                entity.Property(e => e.OItem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("O_item");

                entity.Property(e => e.OName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("O_name");

                entity.Property(e => e.OQuantity).HasColumnName("O_quantity");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
