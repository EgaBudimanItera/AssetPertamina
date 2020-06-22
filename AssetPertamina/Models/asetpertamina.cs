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
        public virtual DbSet<TbUser> TbUser { get; set; }
        public virtual DbSet<TbUserInternal> TbUserInternal { get; set; }

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

                entity.Property(e => e.IdUnit)
                    .HasColumnName("id_unit")
                    .ValueGeneratedNever();

                entity.Property(e => e.NamaUnit)
                    .HasColumnName("nama_unit")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("tb_user");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .ValueGeneratedNever();

                entity.Property(e => e.AksesUser)
                    .HasColumnName("akses_user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamaUser)
                    .HasColumnName("nama_user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitUser).HasColumnName("unit_user");
            });

            modelBuilder.Entity<TbUserInternal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_user_internal");

                entity.Property(e => e.AksesUser)
                    .HasColumnName("akses_user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.NamaUser)
                    .HasColumnName("nama_user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitUser).HasColumnName("unit_user");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
