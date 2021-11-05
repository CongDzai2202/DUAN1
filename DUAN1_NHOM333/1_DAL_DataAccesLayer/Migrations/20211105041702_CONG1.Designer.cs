﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL_DataAccesLayer.DatabaseContext;

namespace _1_DAL_DataAccesLayer.Migrations
{
    [DbContext(typeof(DatabaseContext1))]
    [Migration("20211105041702_CONG1")]
    partial class CONG1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.CHITIETPHIEUNHAP", b =>
                {
                    b.Property<string>("MACHITIETPHIEUNHAP")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("DONGIA")
                        .HasColumnType("float");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<float>("SOLUONG")
                        .HasColumnType("real");

                    b.Property<bool>("TRANGTHAI")
                        .HasColumnType("bit");

                    b.HasKey("MACHITIETPHIEUNHAP");

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

                    b.Property<bool?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.HasKey("MACHUCVU");

                    b.ToTable("CHUCVU");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.HANGHOA", b =>
                {
                    b.Property<string>("MAHANGHOA")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .HasColumnType("int");

                    b.Property<string>("TENHANGHOA")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("THONGTINHANGHOAMATHONGTIN")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MAHANGHOA");

                    b.HasIndex("THONGTINHANGHOAMATHONGTIN");

                    b.ToTable("HANGHOA");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.HOADON", b =>
                {
                    b.Property<string>("MAHOADON")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HOADONCHITIETMAHOADONCHITIET")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .HasColumnType("int");

                    b.Property<string>("MANHANVIEN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NGAYXUAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("NHANVIENSMANHANVIEN")
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("THANHTIEN")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<bool?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.HasKey("MAHOADON");

                    b.HasIndex("HOADONCHITIETMAHOADONCHITIET");

                    b.HasIndex("NHANVIENSMANHANVIEN");

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

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("SOLUONG")
                        .HasColumnType("int");

                    b.Property<bool?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.HasKey("MAHOADONCHITIET");

                    b.ToTable("HOADONCHITIET");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.KICHTHUOC", b =>
                {
                    b.Property<string>("MAKICHTHUOC")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DONVITINH")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .HasColumnType("int");

                    b.Property<string>("THONGTINHANGHOAMATHONGTIN")
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("TRONGLUONG")
                        .HasColumnType("real");

                    b.HasKey("MAKICHTHUOC");

                    b.HasIndex("THONGTINHANGHOAMATHONGTIN");

                    b.ToTable("KICHTHUOC");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.LOAIHANG", b =>
                {
                    b.Property<string>("MALOAIHANG")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .HasColumnType("int");

                    b.Property<string>("TENLOAIHANG")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("THONGTINHANGHOAMATHONGTIN")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MALOAIHANG");

                    b.HasIndex("THONGTINHANGHOAMATHONGTIN");

                    b.ToTable("LOAIHANG");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.NHACUNGCAP", b =>
                {
                    b.Property<string>("MANHACUNGCAP")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .HasColumnType("int");

                    b.Property<string>("PHIEUNHAPMAPHIEUNHAP")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SODIENTHOAI")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TENNHACUNGCAP")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MANHACUNGCAP");

                    b.HasIndex("PHIEUNHAPMAPHIEUNHAP");

                    b.ToTable("NHACUNGCAP");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.NHANVIEN", b =>
                {
                    b.Property<string>("MANHANVIEN")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CHUCVUSMACHUCVU")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DIACHI")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("MACHUCVU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MATKHAU")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("NAMSINH")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<string>("PHIEUNHAPMAPHIEUNHAP")
                        .HasColumnType("nvarchar(50)");

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

                    b.Property<bool?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.HasKey("MANHANVIEN");

                    b.HasIndex("CHUCVUSMACHUCVU");

                    b.HasIndex("PHIEUNHAPMAPHIEUNHAP");

                    b.ToTable("NHANVIEN");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.PHIEUNHAP", b =>
                {
                    b.Property<string>("MAPHIEUNHAP")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CHITIETPHIEUNHAPMACHITIETPHIEUNHAP")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("NGAYNHAP")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.HasKey("MAPHIEUNHAP");

                    b.HasIndex("CHITIETPHIEUNHAPMACHITIETPHIEUNHAP");

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

                    b.Property<string>("CHITIETPHIEUNHAPMACHITIETPHIEUNHAP")
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("DONGIA")
                        .HasColumnType("float");

                    b.Property<DateTime>("HANSUDUNG")
                        .HasColumnType("datetime2");

                    b.Property<string>("HINHANH")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("HOADONCHITIETMAHOADONCHITIET")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("SOLUONG")
                        .HasColumnType("int");

                    b.Property<bool?>("TRANGTHAI")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.HasKey("MATHONGTIN");

                    b.HasIndex("CHITIETPHIEUNHAPMACHITIETPHIEUNHAP");

                    b.HasIndex("HOADONCHITIETMAHOADONCHITIET");

                    b.ToTable("THONGTINHANGHOA");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.HANGHOA", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.THONGTINHANGHOA", null)
                        .WithMany("Hanghoas")
                        .HasForeignKey("THONGTINHANGHOAMATHONGTIN");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.HOADON", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.HOADONCHITIET", null)
                        .WithMany("Hoadons")
                        .HasForeignKey("HOADONCHITIETMAHOADONCHITIET");

                    b.HasOne("_1_DAL_DataAccesLayer.Entities.NHANVIEN", "NHANVIENS")
                        .WithMany()
                        .HasForeignKey("NHANVIENSMANHANVIEN");

                    b.Navigation("NHANVIENS");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.KICHTHUOC", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.THONGTINHANGHOA", null)
                        .WithMany("Kichthuocs")
                        .HasForeignKey("THONGTINHANGHOAMATHONGTIN");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.LOAIHANG", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.THONGTINHANGHOA", null)
                        .WithMany("Loaihangs")
                        .HasForeignKey("THONGTINHANGHOAMATHONGTIN");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.NHACUNGCAP", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.PHIEUNHAP", null)
                        .WithMany("Nhacungcaps")
                        .HasForeignKey("PHIEUNHAPMAPHIEUNHAP");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.NHANVIEN", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.CHUCVU", "CHUCVUS")
                        .WithMany()
                        .HasForeignKey("CHUCVUSMACHUCVU");

                    b.HasOne("_1_DAL_DataAccesLayer.Entities.PHIEUNHAP", null)
                        .WithMany("Nhanviens")
                        .HasForeignKey("PHIEUNHAPMAPHIEUNHAP");

                    b.Navigation("CHUCVUS");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.PHIEUNHAP", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.CHITIETPHIEUNHAP", null)
                        .WithMany("Phieunhaps")
                        .HasForeignKey("CHITIETPHIEUNHAPMACHITIETPHIEUNHAP");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.THONGTINHANGHOA", b =>
                {
                    b.HasOne("_1_DAL_DataAccesLayer.Entities.CHITIETPHIEUNHAP", null)
                        .WithMany("Thongtinhanghoas")
                        .HasForeignKey("CHITIETPHIEUNHAPMACHITIETPHIEUNHAP");

                    b.HasOne("_1_DAL_DataAccesLayer.Entities.HOADONCHITIET", null)
                        .WithMany("Thongtinhanghoas")
                        .HasForeignKey("HOADONCHITIETMAHOADONCHITIET");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.CHITIETPHIEUNHAP", b =>
                {
                    b.Navigation("Phieunhaps");

                    b.Navigation("Thongtinhanghoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.HOADONCHITIET", b =>
                {
                    b.Navigation("Hoadons");

                    b.Navigation("Thongtinhanghoas");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.PHIEUNHAP", b =>
                {
                    b.Navigation("Nhacungcaps");

                    b.Navigation("Nhanviens");
                });

            modelBuilder.Entity("_1_DAL_DataAccesLayer.Entities.THONGTINHANGHOA", b =>
                {
                    b.Navigation("Hanghoas");

                    b.Navigation("Kichthuocs");

                    b.Navigation("Loaihangs");
                });
#pragma warning restore 612, 618
        }
    }
}
