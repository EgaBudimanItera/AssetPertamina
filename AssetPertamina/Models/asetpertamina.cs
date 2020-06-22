using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AssetPertamina.Models
{
    public partial class asetpertamina : DbContext
    {
        public asetpertamina()
        {
        }

        public asetpertamina(DbContextOptions<asetpertamina> options)
            : base(options)
        {
        }

        public virtual DbSet<TbUnit> TbUnit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=194.59.165.12;Database=db_aset_pertamina;uid=SA;pwd=Qwerty123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbUnit>(entity =>
            {
                entity.HasKey(e => e.IdUnit);

                entity.ToTable("tb_unit");

                entity.Property(e => e.IdUnit).HasColumnName("id_unit");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.NamaUnit)
                    .HasColumnName("nama_unit")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
