using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1_DAL_DataAccesLayer.Models;

#nullable disable

namespace _1_DAL_DataAccesLayer.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChatLieu> ChatLieus { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DonViTinh> DonViTinhs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<LoaiHang> LoaiHangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuNhapChiTiet> PhieuNhapChiTiets { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<ThongTinSanPham> ThongTinSanPhams { get; set; }
        public virtual DbSet<XuatXu> XuatXus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=JWTMM5OHEEIIJGK\\SQLEXPRESS;Initial Catalog=DuAnQuanLyCuaHang;Persist Security Info=True;User ID=cong;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatLieu>(entity =>
            {
                entity.HasKey(e => e.MaChatLieu)
                    .HasName("PK__ChatLieu__453995BC5CE130EC");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaChucVu)
                    .HasName("PK__ChucVu__D463953353B3D403");
            });

            modelBuilder.Entity<DonViTinh>(entity =>
            {
                entity.HasKey(e => e.MaDonViTinh)
                    .HasName("PK__DonViTin__ADD89AA28E119973");

                entity.HasOne(d => d.MaChatLieuNavigation)
                    .WithMany(p => p.DonViTinhs)
                    .HasForeignKey(d => d.MaChatLieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DonViTinh__MaCha__1DE57479");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13B31F70734");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNhanVien)
                    .HasConstraintName("FK__HoaDon__MaNhanVi__15502E78");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaHoaDonChiTiet)
                    .HasName("PK__HoaDonCh__6C2FD0CEE76CD702");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__MaHoa__31EC6D26");

                entity.HasOne(d => d.MaThongTinNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaThongTin)
                    .HasConstraintName("FK__HoaDonChi__MaTho__32E0915F");
            });

            modelBuilder.Entity<LoaiHang>(entity =>
            {
                entity.HasKey(e => e.MaLoaiHang)
                    .HasName("PK__LoaiHang__5EEA4160F0855630");
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.MaNhaCungCap)
                    .HasName("PK__NhaCungC__53DA9205E5D3F485");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA4788C321CD");

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaChucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__MaChuc__1273C1CD");
            });

            modelBuilder.Entity<PhieuNhap>(entity =>
            {
                entity.HasKey(e => e.MaPhieuNhap)
                    .HasName("PK__PhieuNha__1470EF3B066ECC85");

                entity.HasOne(d => d.MaNhaCungCapNavigation)
                    .WithMany(p => p.PhieuNhaps)
                    .HasForeignKey(d => d.MaNhaCungCap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhieuNhap__MaNha__286302EC");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.PhieuNhaps)
                    .HasForeignKey(d => d.MaNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhieuNhap__MaNha__29572725");
            });

            modelBuilder.Entity<PhieuNhapChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaCtphieuNhap)
                    .HasName("PK__PhieuNha__792081746FC75D89");

                entity.HasOne(d => d.MaPhieuNhapNavigation)
                    .WithMany(p => p.PhieuNhapChiTiets)
                    .HasForeignKey(d => d.MaPhieuNhap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhieuNhap__MaPhi__35BCFE0A");

                entity.HasOne(d => d.MaThongTinNavigation)
                    .WithMany(p => p.PhieuNhapChiTiets)
                    .HasForeignKey(d => d.MaThongTin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PhieuNhap__MaTho__36B12243");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__FAC7442DE3DFECE3");
            });

            modelBuilder.Entity<ThongTinSanPham>(entity =>
            {
                entity.HasKey(e => e.MaThongTin)
                    .HasName("PK__ThongTin__5E4CADDCAB0AD860");

                entity.HasOne(d => d.MaDonViTinhNavigation)
                    .WithMany(p => p.ThongTinSanPhams)
                    .HasForeignKey(d => d.MaDonViTinh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThongTinS__MaDon__2C3393D0");

                entity.HasOne(d => d.MaLoaiHangNavigation)
                    .WithMany(p => p.ThongTinSanPhams)
                    .HasForeignKey(d => d.MaLoaiHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThongTinS__MaLoa__2D27B809");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.ThongTinSanPhams)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThongTinS__MaSan__2F10007B");

                entity.HasOne(d => d.MaXuatXuNavigation)
                    .WithMany(p => p.ThongTinSanPhams)
                    .HasForeignKey(d => d.MaXuatXu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThongTinS__MaXua__2E1BDC42");
            });

            modelBuilder.Entity<XuatXu>(entity =>
            {
                entity.HasKey(e => e.MaXuatXu)
                    .HasName("PK__XuatXu__27BB6B197AAB7E78");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
