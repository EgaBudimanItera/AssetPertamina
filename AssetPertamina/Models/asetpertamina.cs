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

        public virtual DbSet<TbAlokasi> TbAlokasi { get; set; }
        public virtual DbSet<TbAset> TbAset { get; set; }
        public virtual DbSet<TbFileUpload> TbFileUpload { get; set; }
        public virtual DbSet<TbHistoryAset> TbHistoryAset { get; set; }
        public virtual DbSet<TbKategori> TbKategori { get; set; }
        public virtual DbSet<TbPenilaianAset> TbPenilaianAset { get; set; }
        public virtual DbSet<TbResponAdmin> TbResponAdmin { get; set; }
        public virtual DbSet<TbResponFungsi> TbResponFungsi { get; set; }
        public virtual DbSet<TbSatuan> TbSatuan { get; set; }
        public virtual DbSet<TbUnit> TbUnit { get; set; }
        public virtual DbSet<TbUser> TbUser { get; set; }
        public virtual DbSet<TbVendor> TbVendor { get; set; }
        public virtual DbSet<VwAset> VwAset { get; set; }
        public virtual DbSet<VwUserUnit> VwUserUnit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=194.59.165.12;Database=db_aset_pertamina;uid=developer_aset;pwd=Dev_aset123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "Data_Editor");

            modelBuilder.Entity<TbAlokasi>(entity =>
            {
                entity.HasKey(e => e.IdAlokasi);

                entity.ToTable("tb_alokasi", "dbo");

                entity.Property(e => e.IdAlokasi).HasColumnName("id_alokasi");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KodeAlokasi)
                    .IsRequired()
                    .HasColumnName("kode_alokasi")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NamaAlokasi)
                    .IsRequired()
                    .HasColumnName("nama_alokasi")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbAset>(entity =>
            {
                entity.HasKey(e => e.IdAset);

                entity.ToTable("tb_aset", "dbo");

                entity.Property(e => e.IdAset).HasColumnName("id_aset");

                entity.Property(e => e.AsalAset).HasColumnName("asal_aset");

                entity.Property(e => e.AsalVendor)
                    .HasColumnName("asal_vendor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ButuhPerawatan)
                    .HasColumnName("butuh_perawatan")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Y/T");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasColumnName("deleted_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedTime)
                    .HasColumnName("deleted_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiterimaOleh)
                    .HasColumnName("diterima_oleh")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdAlokasi).HasColumnName("id_alokasi");

                entity.Property(e => e.IdKategori).HasColumnName("id_kategori");

                entity.Property(e => e.IdSatuan).HasColumnName("id_satuan");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NamaAset)
                    .HasColumnName("nama_aset")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NilaiPerolehan).HasColumnName("nilai_perolehan");

                entity.Property(e => e.PerkiraanUmur)
                    .HasColumnName("perkiraan_umur")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Perolehan)
                    .HasColumnName("perolehan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SnAset)
                    .HasColumnName("sn_aset")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalMasuk)
                    .HasColumnName("tanggal_masuk")
                    .HasColumnType("date");

                entity.Property(e => e.UnitPenerima).HasColumnName("unit_penerima");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AsalAsetNavigation)
                    .WithMany(p => p.TbAsetAsalAsetNavigation)
                    .HasForeignKey(d => d.AsalAset)
                    .HasConstraintName("FK_tb_aset_tb_unit1");

                entity.HasOne(d => d.IdAlokasiNavigation)
                    .WithMany(p => p.TbAset)
                    .HasForeignKey(d => d.IdAlokasi)
                    .HasConstraintName("alokasi_aset");

                entity.HasOne(d => d.IdKategoriNavigation)
                    .WithMany(p => p.TbAset)
                    .HasForeignKey(d => d.IdKategori)
                    .HasConstraintName("kategori_aset");

                entity.HasOne(d => d.IdSatuanNavigation)
                    .WithMany(p => p.TbAset)
                    .HasForeignKey(d => d.IdSatuan)
                    .HasConstraintName("satuan_aset");

                entity.HasOne(d => d.UnitPenerimaNavigation)
                    .WithMany(p => p.TbAsetUnitPenerimaNavigation)
                    .HasForeignKey(d => d.UnitPenerima)
                    .HasConstraintName("FK_tb_aset_tb_unit");
            });

            modelBuilder.Entity<TbFileUpload>(entity =>
            {
                entity.HasKey(e => e.IdFile);

                entity.ToTable("tb_file_upload", "dbo");

                entity.Property(e => e.IdFile)
                    .HasColumnName("id_file")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasColumnName("deleted_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedTime)
                    .HasColumnName("deleted_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAset).HasColumnName("id_aset");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KetGambar)
                    .HasColumnName("ket_gambar")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdAsetNavigation)
                    .WithMany(p => p.TbFileUpload)
                    .HasForeignKey(d => d.IdAset)
                    .HasConstraintName("aset");
            });

            modelBuilder.Entity<TbHistoryAset>(entity =>
            {
                entity.HasKey(e => e.IdHistoryAset);

                entity.ToTable("tb_history_aset", "dbo");

                entity.Property(e => e.IdHistoryAset).HasColumnName("id_history_aset");

                entity.Property(e => e.Alokasi)
                    .HasColumnName("alokasi")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AsalAset)
                    .HasColumnName("asal_aset")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fisik).HasColumnName("fisik");

                entity.Property(e => e.Fungsi).HasColumnName("fungsi");

                entity.Property(e => e.IdAset).HasColumnName("id_aset");

                entity.Property(e => e.Kategori)
                    .HasColumnName("kategori")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kehandalan).HasColumnName("kehandalan");

                entity.Property(e => e.KetKejadian)
                    .HasColumnName("ket_kejadian")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PenerimaAset)
                    .HasColumnName("penerima_aset")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Penilai)
                    .HasColumnName("penilai")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tanggal)
                    .HasColumnName("tanggal")
                    .HasColumnType("date");

                entity.Property(e => e.Vendor)
                    .HasColumnName("vendor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAsetNavigation)
                    .WithMany(p => p.TbHistoryAset)
                    .HasForeignKey(d => d.IdAset)
                    .HasConstraintName("FK_tb_history_aset_tb_aset");
            });

            modelBuilder.Entity<TbKategori>(entity =>
            {
                entity.HasKey(e => e.IdKategori);

                entity.ToTable("tb_kategori", "dbo");

                entity.Property(e => e.IdKategori).HasColumnName("id_kategori");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KodeKategori)
                    .IsRequired()
                    .HasColumnName("kode_kategori")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NamaKategori)
                    .IsRequired()
                    .HasColumnName("nama_kategori")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPenilaianAset>(entity =>
            {
                entity.HasKey(e => e.IdPenilaian);

                entity.ToTable("tb_penilaian_aset", "dbo");

                entity.Property(e => e.IdPenilaian)
                    .HasColumnName("id_penilaian")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasColumnName("deleted_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedTime)
                    .HasColumnName("deleted_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fisik).HasColumnName("fisik");

                entity.Property(e => e.Fungsi).HasColumnName("fungsi");

                entity.Property(e => e.IdAset).HasColumnName("id_aset");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Kehandalan).HasColumnName("kehandalan");

                entity.Property(e => e.NamaPenilai)
                    .HasColumnName("nama_penilai")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalPenilaian)
                    .HasColumnName("tanggal_penilaian")
                    .HasColumnType("date");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdAsetNavigation)
                    .WithMany(p => p.TbPenilaianAset)
                    .HasForeignKey(d => d.IdAset)
                    .HasConstraintName("FK_tb_penilaian_aset_tb_aset");
            });

            modelBuilder.Entity<TbResponAdmin>(entity =>
            {
                entity.HasKey(e => e.IdResponAdmin);

                entity.ToTable("tb_respon_admin", "dbo");

                entity.Property(e => e.IdResponAdmin).HasColumnName("id_respon_admin");

                entity.Property(e => e.BiayaPerbaikan).HasColumnName("biaya_perbaikan");

                entity.Property(e => e.DiterimaOleh)
                    .HasColumnName("diterima_oleh")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdResponFungsi).HasColumnName("id_respon_fungsi");

                entity.Property(e => e.JenisRespon)
                    .HasColumnName("jenis_respon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KetRespon)
                    .HasColumnName("ket_respon")
                    .IsUnicode(false);

                entity.Property(e => e.TanggalResponAdmin)
                    .HasColumnName("tanggal_respon_admin")
                    .HasColumnType("date");

                entity.HasOne(d => d.IdResponFungsiNavigation)
                    .WithMany(p => p.TbResponAdmin)
                    .HasForeignKey(d => d.IdResponFungsi)
                    .HasConstraintName("FK_tb_respon_admin_tb_respon_fungsi");
            });

            modelBuilder.Entity<TbResponFungsi>(entity =>
            {
                entity.HasKey(e => e.IdResponFungsi);

                entity.ToTable("tb_respon_fungsi", "dbo");

                entity.Property(e => e.IdResponFungsi).HasColumnName("id_respon_fungsi");

                entity.Property(e => e.Alasan)
                    .HasColumnName("alasan")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasColumnName("deleted_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedTime)
                    .HasColumnName("deleted_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DikirimKe)
                    .HasColumnName("dikirim_ke")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdAset).HasColumnName("id_aset");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JenisRespon)
                    .HasColumnName("jenis_respon")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusRespon)
                    .HasColumnName("status_respon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalProses)
                    .HasColumnName("tanggal_proses")
                    .HasColumnType("date");

                entity.Property(e => e.TanggalResponFungsi)
                    .HasColumnName("tanggal_respon_fungsi")
                    .HasColumnType("date");

                entity.Property(e => e.TanggalSelesai)
                    .HasColumnName("tanggal_selesai")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAsetNavigation)
                    .WithMany(p => p.TbResponFungsi)
                    .HasForeignKey(d => d.IdAset)
                    .HasConstraintName("FK_tb_respon_fungsi_tb_aset");
            });

            modelBuilder.Entity<TbSatuan>(entity =>
            {
                entity.HasKey(e => e.IdSatuan);

                entity.ToTable("tb_satuan", "dbo");

                entity.Property(e => e.IdSatuan).HasColumnName("id_satuan");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NamaSatuan)
                    .IsRequired()
                    .HasColumnName("nama_satuan")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbUnit>(entity =>
            {
                entity.HasKey(e => e.IdUnit);

                entity.ToTable("tb_unit", "dbo");

                entity.Property(e => e.IdUnit).HasColumnName("id_unit");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.NamaUnit)
                    .IsRequired()
                    .HasColumnName("nama_unit")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("tb_user", "dbo");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.AksesUser)
                    .IsRequired()
                    .HasColumnName("akses_user")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("'admin'/'fungsi'/'super'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .HasColumnName("deleted_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedTime)
                    .HasColumnName("deleted_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FotoUser)
                    .HasColumnName("foto_user")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdUnit).HasColumnName("id_unit");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NamaUser)
                    .IsRequired()
                    .HasColumnName("nama_user")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdUnitNavigation)
                    .WithMany(p => p.TbUser)
                    .HasForeignKey(d => d.IdUnit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tb_user_tb_unit_FK");
            });

            modelBuilder.Entity<TbVendor>(entity =>
            {
                entity.HasKey(e => e.IdVendor);

                entity.ToTable("tb_vendor", "dbo");

                entity.Property(e => e.IdVendor).HasColumnName("id_vendor");

                entity.Property(e => e.AlamatVendor)
                    .IsRequired()
                    .HasColumnName("alamat_vendor")
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NamaVendor)
                    .IsRequired()
                    .HasColumnName("nama_vendor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoTelp)
                    .IsRequired()
                    .HasColumnName("no_telp")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAset>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aset", "dbo");

                entity.Property(e => e.AsalAset).HasColumnName("asal_aset");

                entity.Property(e => e.AsalVendor)
                    .HasColumnName("asal_vendor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ButuhPerawatan)
                    .HasColumnName("butuh_perawatan")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DiterimaOleh)
                    .HasColumnName("diterima_oleh")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdAlokasi).HasColumnName("id_alokasi");

                entity.Property(e => e.IdAset).HasColumnName("id_aset");

                entity.Property(e => e.IdKategori).HasColumnName("id_kategori");

                entity.Property(e => e.IdSatuan).HasColumnName("id_satuan");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KodeAlokasi)
                    .IsRequired()
                    .HasColumnName("kode_alokasi")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.KodeKategori)
                    .IsRequired()
                    .HasColumnName("kode_kategori")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NamaAlokasi)
                    .IsRequired()
                    .HasColumnName("nama_alokasi")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaAset)
                    .HasColumnName("nama_aset")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaKategori)
                    .IsRequired()
                    .HasColumnName("nama_kategori")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaSatuan)
                    .IsRequired()
                    .HasColumnName("nama_satuan")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaUnit)
                    .IsRequired()
                    .HasColumnName("nama_unit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NilaiPerolehan).HasColumnName("nilai_perolehan");

                entity.Property(e => e.PerkiraanUmur)
                    .HasColumnName("perkiraan_umur")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Perolehan)
                    .HasColumnName("perolehan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SnAset)
                    .HasColumnName("sn_aset")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalMasuk)
                    .HasColumnName("tanggal_masuk")
                    .HasColumnType("date");

                entity.Property(e => e.UnitPenerima).HasColumnName("unit_penerima");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VwUserUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_user_unit", "dbo");

                entity.Property(e => e.AksesUser)
                    .IsRequired()
                    .HasColumnName("akses_user")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdUnit).HasColumnName("id_unit");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("is_deleted")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NamaUnit)
                    .IsRequired()
                    .HasColumnName("nama_unit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamaUser)
                    .IsRequired()
                    .HasColumnName("nama_user")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
