// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL_DataAccesLayer.Context;

namespace _1_DAL_DataAccesLayer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211107085217_vc8")]
    partial class vc8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.CHATLIEU", b =>
                {
                    b.Property<string>("MACHATLIEU")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TENCHATLIEU")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TRANGTHAI")
                        .HasColumnType("int");

                    b.HasKey("MACHATLIEU");

                    b.ToTable("CHATLIEU");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.CHITIETPHIEUNHAP", b =>
                {
                    b.Property<string>("MACHITIETPHIEUNHAP")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("DONGIA")
                        .HasColumnType("float");

                    b.Property<int?>("ID")
                        .HasColumnType("int");

                    b.Property<string>("PhieunhapsMAPHIEUNHAP")
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("SOLUONG")
                        .HasColumnType("real");

                    b.Property<int?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ThongtinhanghoasMATHONGTIN")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MACHITIETPHIEUNHAP");

                    b.HasIndex("PhieunhapsMAPHIEUNHAP");

                    b.HasIndex("ThongtinhanghoasMATHONGTIN");

                    b.ToTable("CHITIETPHIEUNHAP");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.CHUCVU", b =>
                {
                    b.Property<string>("MACHUCVU")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TENCHUCVU")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("MACHUCVU");

                    b.ToTable("CHUCVU");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.DONVITINH", b =>
                {
                    b.Property<string>("MADONVITINH")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ChatlieusMACHATLIEU")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TENDONVITINH")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TRANGTHAI")
                        .HasColumnType("int");

                    b.HasKey("MADONVITINH");

                    b.HasIndex("ChatlieusMACHATLIEU");

                    b.ToTable("DONVITINH");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.HANGHOA", b =>
                {
                    b.Property<string>("MAHANGHOA")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TENHANGHOA")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TRANGTHAI")
                        .HasColumnType("int");

                    b.HasKey("MAHANGHOA");

                    b.ToTable("HANGHOA");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.HOADON", b =>
                {
                    b.Property<string>("MAHOADON")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("NGAYXUAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhanvienMANHANVIEN")
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("THANHTIEN")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("MAHOADON");

                    b.HasIndex("NhanvienMANHANVIEN");

                    b.ToTable("HOADON");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.HOADONCHITIET", b =>
                {
                    b.Property<string>("MAHOADONCHITIET")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BARCODE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("DONGIA")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("HOADONMAHOADON")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .HasColumnType("int");

                    b.Property<int>("SOLUONG")
                        .HasColumnType("int");

                    b.Property<int?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ThongtinhanghoaMATHONGTIN")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MAHOADONCHITIET");

                    b.HasIndex("HOADONMAHOADON");

                    b.HasIndex("ThongtinhanghoaMATHONGTIN");

                    b.ToTable("HOADONCHITIET");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.LOAIHANG", b =>
                {
                    b.Property<string>("MALOAIHANG")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TENLOAIHANG")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TRANGTHAI")
                        .HasColumnType("int");

                    b.HasKey("MALOAIHANG");

                    b.ToTable("LOAIHANG");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.NHACUNGCAP", b =>
                {
                    b.Property<string>("MANHACUNGCAP")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("SODIENTHOAI")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TENNHACUNGCAP")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TRANGTHAI")
                        .HasColumnType("int");

                    b.HasKey("MANHACUNGCAP");

                    b.ToTable("NHACUNGCAP");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.NHANVIEN", b =>
                {
                    b.Property<string>("MANHANVIEN")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ChucvuMACHUCVU")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DIACHI")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("MATKHAU")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NAMSINH")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("SOCMND")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SODIENTHOAI")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("TENNHANVIEN")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("MANHANVIEN");

                    b.HasIndex("ChucvuMACHUCVU");

                    b.ToTable("NHANVIEN");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.PHIEUNHAP", b =>
                {
                    b.Property<string>("MAPHIEUNHAP")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("NGAYNHAP")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhacungcapsMANHACUNGCAP")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NhanvienMANHANVIEN")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("MAPHIEUNHAP");

                    b.HasIndex("NhacungcapsMANHACUNGCAP");

                    b.HasIndex("NhanvienMANHANVIEN");

                    b.ToTable("PHIEUNHAP");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.THONGTINHANGHOA", b =>
                {
                    b.Property<string>("MATHONGTIN")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BARCODE")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("DONGIA")
                        .HasColumnType("float");

                    b.Property<string>("DonvitinhsMADONVITINH")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("HANSUDUNG")
                        .HasColumnType("datetime2");

                    b.Property<string>("HINHANH")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("HanghoasMAHANGHOA")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("LoaihangsMALOAIHANG")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SOLUONG")
                        .HasColumnType("int");

                    b.Property<int?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("XuatxusMAXUATXU")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MATHONGTIN");

                    b.HasIndex("DonvitinhsMADONVITINH");

                    b.HasIndex("HanghoasMAHANGHOA");

                    b.HasIndex("LoaihangsMALOAIHANG");

                    b.HasIndex("XuatxusMAXUATXU");

                    b.ToTable("THONGTINHANGHOA");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.XUATXU", b =>
                {
                    b.Property<string>("MAXUATXU")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("TENNUOC")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MAXUATXU");

                    b.ToTable("XUATXU");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.CHITIETPHIEUNHAP", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.PHIEUNHAP", "Phieunhaps")
                        .WithMany("Chitietphieunhaps")
                        .HasForeignKey("PhieunhapsMAPHIEUNHAP");

                    b.HasOne("_1_DAL_DataAccesLayer.Entities.THONGTINHANGHOA", "Thongtinhanghoas")
                        .WithMany("Chitietphieunhaps")
                        .HasForeignKey("ThongtinhanghoasMATHONGTIN");

                    b.Navigation("Phieunhaps");

                    b.Navigation("Thongtinhanghoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.DONVITINH", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.CHATLIEU", "Chatlieus")
                        .WithMany("Donvitinhs")
                        .HasForeignKey("ChatlieusMACHATLIEU");

                    b.Navigation("Chatlieus");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.HOADON", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.NHANVIEN", "Nhanvien")
                        .WithMany("Hoadons")
                        .HasForeignKey("NhanvienMANHANVIEN");

                    b.Navigation("Nhanvien");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.HOADONCHITIET", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.HOADON", null)
                        .WithMany("Hoadonchitiets")
                        .HasForeignKey("HOADONMAHOADON");

                    b.HasOne("_1_DAL_DataAccesLayer.Entities.THONGTINHANGHOA", "Thongtinhanghoa")
                        .WithMany("Hoadonchitiets")
                        .HasForeignKey("ThongtinhanghoaMATHONGTIN");

                    b.Navigation("Thongtinhanghoa");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.NHANVIEN", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.CHUCVU", "Chucvu")
                        .WithMany("Nhanviens")
                        .HasForeignKey("ChucvuMACHUCVU");

                    b.Navigation("Chucvu");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.PHIEUNHAP", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.NHACUNGCAP", "Nhacungcaps")
                        .WithMany("Phieunhaps")
                        .HasForeignKey("NhacungcapsMANHACUNGCAP");

                    b.HasOne("_1_DAL_DataAccesLayer.Entities.NHANVIEN", "Nhanvien")
                        .WithMany("Phieunhaps")
                        .HasForeignKey("NhanvienMANHANVIEN");

                    b.Navigation("Nhacungcaps");

                    b.Navigation("Nhanvien");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.THONGTINHANGHOA", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.DONVITINH", "Donvitinhs")
                        .WithMany("Thongtinhanghoas")
                        .HasForeignKey("DonvitinhsMADONVITINH");

                    b.HasOne("_1_DAL_DataAccesLayer.Entities.HANGHOA", "Hanghoas")
                        .WithMany("Thongtinhanghoas")
                        .HasForeignKey("HanghoasMAHANGHOA");

                    b.HasOne("_1_DAL_DataAccesLayer.Entities.LOAIHANG", "Loaihangs")
                        .WithMany("Thongtinhanghoas")
                        .HasForeignKey("LoaihangsMALOAIHANG");

                    b.HasOne("_1_DAL_DataAccesLayer.Entities.XUATXU", "Xuatxus")
                        .WithMany("Thongtinhanghoas")
                        .HasForeignKey("XuatxusMAXUATXU");

                    b.Navigation("Donvitinhs");

                    b.Navigation("Hanghoas");

                    b.Navigation("Loaihangs");

                    b.Navigation("Xuatxus");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.CHATLIEU", b =>
                {
                    b.Navigation("Donvitinhs");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.CHUCVU", b =>
                {
                    b.Navigation("Nhanviens");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.DONVITINH", b =>
                {
                    b.Navigation("Thongtinhanghoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.HANGHOA", b =>
                {
                    b.Navigation("Thongtinhanghoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.HOADON", b =>
                {
                    b.Navigation("Hoadonchitiets");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.LOAIHANG", b =>
                {
                    b.Navigation("Thongtinhanghoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.NHACUNGCAP", b =>
                {
                    b.Navigation("Phieunhaps");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.NHANVIEN", b =>
                {
                    b.Navigation("Hoadons");

                    b.Navigation("Phieunhaps");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.PHIEUNHAP", b =>
                {
                    b.Navigation("Chitietphieunhaps");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.THONGTINHANGHOA", b =>
                {
                    b.Navigation("Chitietphieunhaps");

                    b.Navigation("Hoadonchitiets");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.XUATXU", b =>
                {
                    b.Navigation("Thongtinhanghoas");
                });
#pragma warning restore 612, 618
        }
    }
}
