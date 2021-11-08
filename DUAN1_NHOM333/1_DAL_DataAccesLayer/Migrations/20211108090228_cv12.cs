using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class cv12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DONVITINH_CHATLIEU_ChatlieusMACHATLIEU",
                table: "DONVITINH");

            migrationBuilder.DropForeignKey(
                name: "FK_HOADON_NHANVIEN_NhanvienMANHANVIEN",
                table: "HOADON");

            migrationBuilder.DropForeignKey(
                name: "FK_HOADONCHITIET_HOADON_HOADONMAHOADON",
                table: "HOADONCHITIET");

            migrationBuilder.DropForeignKey(
                name: "FK_HOADONCHITIET_THONGTINHANGHOA_ThongtinhanghoaMATHONGTIN",
                table: "HOADONCHITIET");

            migrationBuilder.DropForeignKey(
                name: "FK_NHANVIEN_CHUCVU_ChucvuMACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropForeignKey(
                name: "FK_PHIEUNHAP_NHACUNGCAP_NhacungcapsMANHACUNGCAP",
                table: "PHIEUNHAP");

            migrationBuilder.DropForeignKey(
                name: "FK_PHIEUNHAP_NHANVIEN_NhanvienMANHANVIEN",
                table: "PHIEUNHAP");

            migrationBuilder.DropTable(
                name: "CHITIETPHIEUNHAP");

            migrationBuilder.DropTable(
                name: "THONGTINHANGHOA");

            migrationBuilder.DropTable(
                name: "HANGHOA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_XUATXU",
                table: "XUATXU");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PHIEUNHAP",
                table: "PHIEUNHAP");

            migrationBuilder.DropIndex(
                name: "IX_PHIEUNHAP_NhacungcapsMANHACUNGCAP",
                table: "PHIEUNHAP");

            migrationBuilder.DropIndex(
                name: "IX_PHIEUNHAP_NhanvienMANHANVIEN",
                table: "PHIEUNHAP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NHANVIEN",
                table: "NHANVIEN");

            migrationBuilder.DropIndex(
                name: "IX_NHANVIEN_ChucvuMACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NHACUNGCAP",
                table: "NHACUNGCAP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LOAIHANG",
                table: "LOAIHANG");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HOADONCHITIET",
                table: "HOADONCHITIET");

            migrationBuilder.DropIndex(
                name: "IX_HOADONCHITIET_HOADONMAHOADON",
                table: "HOADONCHITIET");

            migrationBuilder.DropIndex(
                name: "IX_HOADONCHITIET_ThongtinhanghoaMATHONGTIN",
                table: "HOADONCHITIET");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HOADON",
                table: "HOADON");

            migrationBuilder.DropIndex(
                name: "IX_HOADON_NhanvienMANHANVIEN",
                table: "HOADON");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DONVITINH",
                table: "DONVITINH");

            migrationBuilder.DropIndex(
                name: "IX_DONVITINH_ChatlieusMACHATLIEU",
                table: "DONVITINH");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CHUCVU",
                table: "CHUCVU");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CHATLIEU",
                table: "CHATLIEU");

            migrationBuilder.DropColumn(
                name: "NhacungcapsMANHACUNGCAP",
                table: "PHIEUNHAP");

            migrationBuilder.DropColumn(
                name: "NhanvienMANHANVIEN",
                table: "PHIEUNHAP");

            migrationBuilder.DropColumn(
                name: "ChucvuMACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropColumn(
                name: "HOADONMAHOADON",
                table: "HOADONCHITIET");

            migrationBuilder.DropColumn(
                name: "ThongtinhanghoaMATHONGTIN",
                table: "HOADONCHITIET");

            migrationBuilder.DropColumn(
                name: "NhanvienMANHANVIEN",
                table: "HOADON");

            migrationBuilder.DropColumn(
                name: "ChatlieusMACHATLIEU",
                table: "DONVITINH");

            migrationBuilder.RenameTable(
                name: "XUATXU",
                newName: "XuatXu");

            migrationBuilder.RenameTable(
                name: "PHIEUNHAP",
                newName: "PhieuNhap");

            migrationBuilder.RenameTable(
                name: "NHANVIEN",
                newName: "NhanVien");

            migrationBuilder.RenameTable(
                name: "NHACUNGCAP",
                newName: "NhaCungCap");

            migrationBuilder.RenameTable(
                name: "LOAIHANG",
                newName: "LoaiHang");

            migrationBuilder.RenameTable(
                name: "HOADONCHITIET",
                newName: "HoaDonChiTiet");

            migrationBuilder.RenameTable(
                name: "HOADON",
                newName: "HoaDon");

            migrationBuilder.RenameTable(
                name: "DONVITINH",
                newName: "DonViTinh");

            migrationBuilder.RenameTable(
                name: "CHUCVU",
                newName: "ChucVu");

            migrationBuilder.RenameTable(
                name: "CHATLIEU",
                newName: "ChatLieu");

            migrationBuilder.RenameColumn(
                name: "TENNUOC",
                table: "XuatXu",
                newName: "TenNuoc");

            migrationBuilder.RenameColumn(
                name: "MAXUATXU",
                table: "XuatXu",
                newName: "MaXuatXu");

            migrationBuilder.RenameColumn(
                name: "TRANGTHAI",
                table: "PhieuNhap",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "NGAYNHAP",
                table: "PhieuNhap",
                newName: "NgayNhap");

            migrationBuilder.RenameColumn(
                name: "MAPHIEUNHAP",
                table: "PhieuNhap",
                newName: "MaPhieuNhap");

            migrationBuilder.RenameColumn(
                name: "TRANGTHAI",
                table: "NhanVien",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "TENNHANVIEN",
                table: "NhanVien",
                newName: "TenNhanVien");

            migrationBuilder.RenameColumn(
                name: "SODIENTHOAI",
                table: "NhanVien",
                newName: "SoDienThoai");

            migrationBuilder.RenameColumn(
                name: "SOCMND",
                table: "NhanVien",
                newName: "SoCMND");

            migrationBuilder.RenameColumn(
                name: "NAMSINH",
                table: "NhanVien",
                newName: "NamSinh");

            migrationBuilder.RenameColumn(
                name: "MATKHAU",
                table: "NhanVien",
                newName: "MatKhau");

            migrationBuilder.RenameColumn(
                name: "DIACHI",
                table: "NhanVien",
                newName: "DiaChi");

            migrationBuilder.RenameColumn(
                name: "MANHANVIEN",
                table: "NhanVien",
                newName: "MaNhanVien");

            migrationBuilder.RenameColumn(
                name: "TRANGTHAI",
                table: "NhaCungCap",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "TENNHACUNGCAP",
                table: "NhaCungCap",
                newName: "TenNhaCungCap");

            migrationBuilder.RenameColumn(
                name: "SODIENTHOAI",
                table: "NhaCungCap",
                newName: "SoDienThoai");

            migrationBuilder.RenameColumn(
                name: "MANHACUNGCAP",
                table: "NhaCungCap",
                newName: "MaNhaCungCap");

            migrationBuilder.RenameColumn(
                name: "TRANGTHAI",
                table: "LoaiHang",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "TENLOAIHANG",
                table: "LoaiHang",
                newName: "TenLoaiHang");

            migrationBuilder.RenameColumn(
                name: "MALOAIHANG",
                table: "LoaiHang",
                newName: "MaLoaiHang");

            migrationBuilder.RenameColumn(
                name: "TRANGTHAI",
                table: "HoaDonChiTiet",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "SOLUONG",
                table: "HoaDonChiTiet",
                newName: "SoLuong");

            migrationBuilder.RenameColumn(
                name: "DONGIA",
                table: "HoaDonChiTiet",
                newName: "DonGia");

            migrationBuilder.RenameColumn(
                name: "BARCODE",
                table: "HoaDonChiTiet",
                newName: "BarCode");

            migrationBuilder.RenameColumn(
                name: "MAHOADONCHITIET",
                table: "HoaDonChiTiet",
                newName: "MaHoaDonChiTiet");

            migrationBuilder.RenameColumn(
                name: "TRANGTHAI",
                table: "HoaDon",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "THANHTIEN",
                table: "HoaDon",
                newName: "ThanhTien");

            migrationBuilder.RenameColumn(
                name: "NGAYXUAT",
                table: "HoaDon",
                newName: "NgayXuat");

            migrationBuilder.RenameColumn(
                name: "MAHOADON",
                table: "HoaDon",
                newName: "MaHoaDon");

            migrationBuilder.RenameColumn(
                name: "TRANGTHAI",
                table: "DonViTinh",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "TENDONVITINH",
                table: "DonViTinh",
                newName: "TenDonViTinh");

            migrationBuilder.RenameColumn(
                name: "MADONVITINH",
                table: "DonViTinh",
                newName: "MaDonViTinh");

            migrationBuilder.RenameColumn(
                name: "TRANGTHAI",
                table: "ChucVu",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "TENCHUCVU",
                table: "ChucVu",
                newName: "TenChucVu");

            migrationBuilder.RenameColumn(
                name: "MACHUCVU",
                table: "ChucVu",
                newName: "MaChucVu");

            migrationBuilder.RenameColumn(
                name: "TRANGTHAI",
                table: "ChatLieu",
                newName: "TrangThai");

            migrationBuilder.RenameColumn(
                name: "TENCHATLIEU",
                table: "ChatLieu",
                newName: "TenChatLieu");

            migrationBuilder.RenameColumn(
                name: "MACHATLIEU",
                table: "ChatLieu",
                newName: "MaChatLieu");

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "XuatXu",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "PhieuNhap",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayNhap",
                table: "PhieuNhap",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "MaNhaCungCap",
                table: "PhieuNhap",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaNhanVien",
                table: "PhieuNhap",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "NhanVien",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TenNhanVien",
                table: "NhanVien",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SoDienThoai",
                table: "NhanVien",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "SoCMND",
                table: "NhanVien",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "NamSinh",
                table: "NhanVien",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MatKhau",
                table: "NhanVien",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "MaChucVu",
                table: "NhanVien",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "TenNhaCungCap",
                table: "NhaCungCap",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SoDienThoai",
                table: "NhaCungCap",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "NhaCungCap",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenLoaiHang",
                table: "LoaiHang",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "HoaDonChiTiet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SoLuong",
                table: "HoaDonChiTiet",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "HoaDonChiTiet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "DonGia",
                table: "HoaDonChiTiet",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "HoaDonChiTiet",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaHoaDon",
                table: "HoaDonChiTiet",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaThongTin",
                table: "HoaDonChiTiet",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenSanPham",
                table: "HoaDonChiTiet",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "HoaDon",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "ThanhTien",
                table: "HoaDon",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayXuat",
                table: "HoaDon",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "MaNhanVien",
                table: "HoaDon",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaChatLieu",
                table: "DonViTinh",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "TrangThai",
                table: "ChucVu",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK__XuatXu__27BB6B197CC59C96",
                table: "XuatXu",
                column: "MaXuatXu");

            migrationBuilder.AddPrimaryKey(
                name: "PK__PhieuNha__1470EF3B7D606C9C",
                table: "PhieuNhap",
                column: "MaPhieuNhap");

            migrationBuilder.AddPrimaryKey(
                name: "PK__NhanVien__77B2CA474BA15FD3",
                table: "NhanVien",
                column: "MaNhanVien");

            migrationBuilder.AddPrimaryKey(
                name: "PK__NhaCungC__53DA9205C78767AF",
                table: "NhaCungCap",
                column: "MaNhaCungCap");

            migrationBuilder.AddPrimaryKey(
                name: "PK__LoaiHang__5EEA4160BAF12530",
                table: "LoaiHang",
                column: "MaLoaiHang");

            migrationBuilder.AddPrimaryKey(
                name: "PK__HoaDonCh__6C2FD0CE34F8C7B8",
                table: "HoaDonChiTiet",
                column: "MaHoaDonChiTiet");

            migrationBuilder.AddPrimaryKey(
                name: "PK__HoaDon__835ED13BF13FB2F1",
                table: "HoaDon",
                column: "MaHoaDon");

            migrationBuilder.AddPrimaryKey(
                name: "PK__DonViTin__ADD89AA2022E2F1B",
                table: "DonViTinh",
                column: "MaDonViTinh");

            migrationBuilder.AddPrimaryKey(
                name: "PK__ChucVu__D4639533FC716D6C",
                table: "ChucVu",
                column: "MaChucVu");

            migrationBuilder.AddPrimaryKey(
                name: "PK__ChatLieu__453995BC8D0BF58A",
                table: "ChatLieu",
                column: "MaChatLieu");

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSanPham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SanPham__FAC7442DF37C2630", x => x.MaSanPham);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinSanPham",
                columns: table => new
                {
                    MaThongTin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    TrongLuong = table.Column<double>(type: "float", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaDonViTinh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaLoaiHang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaXuatXu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaSanPham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ThongTin__5E4CADDCEDD1F21C", x => x.MaThongTin);
                    table.ForeignKey(
                        name: "FK__ThongTinS__MaDon__286302EC",
                        column: x => x.MaDonViTinh,
                        principalTable: "DonViTinh",
                        principalColumn: "MaDonViTinh",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ThongTinS__MaLoa__29572725",
                        column: x => x.MaLoaiHang,
                        principalTable: "LoaiHang",
                        principalColumn: "MaLoaiHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ThongTinS__MaSan__2B3F6F97",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ThongTinS__MaXua__2A4B4B5E",
                        column: x => x.MaXuatXu,
                        principalTable: "XuatXu",
                        principalColumn: "MaXuatXu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhapChiTiet",
                columns: table => new
                {
                    MaCTPhieuNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    MaPhieuNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaThongTin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    DonGiaNhap = table.Column<double>(type: "float", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PhieuNha__7920817423F704B8", x => x.MaCTPhieuNhap);
                    table.ForeignKey(
                        name: "FK__PhieuNhap__MaPhi__31EC6D26",
                        column: x => x.MaPhieuNhap,
                        principalTable: "PhieuNhap",
                        principalColumn: "MaPhieuNhap",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__PhieuNhap__MaTho__32E0915F",
                        column: x => x.MaThongTin,
                        principalTable: "ThongTinSanPham",
                        principalColumn: "MaThongTin",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_MaNhaCungCap",
                table: "PhieuNhap",
                column: "MaNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_MaNhanVien",
                table: "PhieuNhap",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaChucVu",
                table: "NhanVien",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaHoaDon",
                table: "HoaDonChiTiet",
                column: "MaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaThongTin",
                table: "HoaDonChiTiet",
                column: "MaThongTin");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNhanVien",
                table: "HoaDon",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_DonViTinh_MaChatLieu",
                table: "DonViTinh",
                column: "MaChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhapChiTiet_MaPhieuNhap",
                table: "PhieuNhapChiTiet",
                column: "MaPhieuNhap");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhapChiTiet_MaThongTin",
                table: "PhieuNhapChiTiet",
                column: "MaThongTin");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinSanPham_MaDonViTinh",
                table: "ThongTinSanPham",
                column: "MaDonViTinh");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinSanPham_MaLoaiHang",
                table: "ThongTinSanPham",
                column: "MaLoaiHang");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinSanPham_MaSanPham",
                table: "ThongTinSanPham",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinSanPham_MaXuatXu",
                table: "ThongTinSanPham",
                column: "MaXuatXu");

            migrationBuilder.AddForeignKey(
                name: "FK__DonViTinh__MaCha__1A14E395",
                table: "DonViTinh",
                column: "MaChatLieu",
                principalTable: "ChatLieu",
                principalColumn: "MaChatLieu",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__HoaDon__MaNhanVi__15502E78",
                table: "HoaDon",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__HoaDonChi__MaHoa__2E1BDC42",
                table: "HoaDonChiTiet",
                column: "MaHoaDon",
                principalTable: "HoaDon",
                principalColumn: "MaHoaDon",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__HoaDonChi__MaTho__2F10007B",
                table: "HoaDonChiTiet",
                column: "MaThongTin",
                principalTable: "ThongTinSanPham",
                principalColumn: "MaThongTin",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__NhanVien__MaChuc__1273C1CD",
                table: "NhanVien",
                column: "MaChucVu",
                principalTable: "ChucVu",
                principalColumn: "MaChucVu",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__PhieuNhap__MaNha__24927208",
                table: "PhieuNhap",
                column: "MaNhaCungCap",
                principalTable: "NhaCungCap",
                principalColumn: "MaNhaCungCap",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__PhieuNhap__MaNha__25869641",
                table: "PhieuNhap",
                column: "MaNhanVien",
                principalTable: "NhanVien",
                principalColumn: "MaNhanVien",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__DonViTinh__MaCha__1A14E395",
                table: "DonViTinh");

            migrationBuilder.DropForeignKey(
                name: "FK__HoaDon__MaNhanVi__15502E78",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK__HoaDonChi__MaHoa__2E1BDC42",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK__HoaDonChi__MaTho__2F10007B",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK__NhanVien__MaChuc__1273C1CD",
                table: "NhanVien");

            migrationBuilder.DropForeignKey(
                name: "FK__PhieuNhap__MaNha__24927208",
                table: "PhieuNhap");

            migrationBuilder.DropForeignKey(
                name: "FK__PhieuNhap__MaNha__25869641",
                table: "PhieuNhap");

            migrationBuilder.DropTable(
                name: "PhieuNhapChiTiet");

            migrationBuilder.DropTable(
                name: "ThongTinSanPham");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropPrimaryKey(
                name: "PK__XuatXu__27BB6B197CC59C96",
                table: "XuatXu");

            migrationBuilder.DropPrimaryKey(
                name: "PK__PhieuNha__1470EF3B7D606C9C",
                table: "PhieuNhap");

            migrationBuilder.DropIndex(
                name: "IX_PhieuNhap_MaNhaCungCap",
                table: "PhieuNhap");

            migrationBuilder.DropIndex(
                name: "IX_PhieuNhap_MaNhanVien",
                table: "PhieuNhap");

            migrationBuilder.DropPrimaryKey(
                name: "PK__NhanVien__77B2CA474BA15FD3",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_MaChucVu",
                table: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK__NhaCungC__53DA9205C78767AF",
                table: "NhaCungCap");

            migrationBuilder.DropPrimaryKey(
                name: "PK__LoaiHang__5EEA4160BAF12530",
                table: "LoaiHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK__HoaDonCh__6C2FD0CE34F8C7B8",
                table: "HoaDonChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonChiTiet_MaHoaDon",
                table: "HoaDonChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonChiTiet_MaThongTin",
                table: "HoaDonChiTiet");

            migrationBuilder.DropPrimaryKey(
                name: "PK__HoaDon__835ED13BF13FB2F1",
                table: "HoaDon");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_MaNhanVien",
                table: "HoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK__DonViTin__ADD89AA2022E2F1B",
                table: "DonViTinh");

            migrationBuilder.DropIndex(
                name: "IX_DonViTinh_MaChatLieu",
                table: "DonViTinh");

            migrationBuilder.DropPrimaryKey(
                name: "PK__ChucVu__D4639533FC716D6C",
                table: "ChucVu");

            migrationBuilder.DropPrimaryKey(
                name: "PK__ChatLieu__453995BC8D0BF58A",
                table: "ChatLieu");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "XuatXu");

            migrationBuilder.DropColumn(
                name: "MaNhaCungCap",
                table: "PhieuNhap");

            migrationBuilder.DropColumn(
                name: "MaNhanVien",
                table: "PhieuNhap");

            migrationBuilder.DropColumn(
                name: "MaChucVu",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "NhaCungCap");

            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "MaHoaDon",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "MaThongTin",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "TenSanPham",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "MaNhanVien",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "MaChatLieu",
                table: "DonViTinh");

            migrationBuilder.RenameTable(
                name: "XuatXu",
                newName: "XUATXU");

            migrationBuilder.RenameTable(
                name: "PhieuNhap",
                newName: "PHIEUNHAP");

            migrationBuilder.RenameTable(
                name: "NhanVien",
                newName: "NHANVIEN");

            migrationBuilder.RenameTable(
                name: "NhaCungCap",
                newName: "NHACUNGCAP");

            migrationBuilder.RenameTable(
                name: "LoaiHang",
                newName: "LOAIHANG");

            migrationBuilder.RenameTable(
                name: "HoaDonChiTiet",
                newName: "HOADONCHITIET");

            migrationBuilder.RenameTable(
                name: "HoaDon",
                newName: "HOADON");

            migrationBuilder.RenameTable(
                name: "DonViTinh",
                newName: "DONVITINH");

            migrationBuilder.RenameTable(
                name: "ChucVu",
                newName: "CHUCVU");

            migrationBuilder.RenameTable(
                name: "ChatLieu",
                newName: "CHATLIEU");

            migrationBuilder.RenameColumn(
                name: "TenNuoc",
                table: "XUATXU",
                newName: "TENNUOC");

            migrationBuilder.RenameColumn(
                name: "MaXuatXu",
                table: "XUATXU",
                newName: "MAXUATXU");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "PHIEUNHAP",
                newName: "TRANGTHAI");

            migrationBuilder.RenameColumn(
                name: "NgayNhap",
                table: "PHIEUNHAP",
                newName: "NGAYNHAP");

            migrationBuilder.RenameColumn(
                name: "MaPhieuNhap",
                table: "PHIEUNHAP",
                newName: "MAPHIEUNHAP");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "NHANVIEN",
                newName: "TRANGTHAI");

            migrationBuilder.RenameColumn(
                name: "TenNhanVien",
                table: "NHANVIEN",
                newName: "TENNHANVIEN");

            migrationBuilder.RenameColumn(
                name: "SoDienThoai",
                table: "NHANVIEN",
                newName: "SODIENTHOAI");

            migrationBuilder.RenameColumn(
                name: "SoCMND",
                table: "NHANVIEN",
                newName: "SOCMND");

            migrationBuilder.RenameColumn(
                name: "NamSinh",
                table: "NHANVIEN",
                newName: "NAMSINH");

            migrationBuilder.RenameColumn(
                name: "MatKhau",
                table: "NHANVIEN",
                newName: "MATKHAU");

            migrationBuilder.RenameColumn(
                name: "DiaChi",
                table: "NHANVIEN",
                newName: "DIACHI");

            migrationBuilder.RenameColumn(
                name: "MaNhanVien",
                table: "NHANVIEN",
                newName: "MANHANVIEN");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "NHACUNGCAP",
                newName: "TRANGTHAI");

            migrationBuilder.RenameColumn(
                name: "TenNhaCungCap",
                table: "NHACUNGCAP",
                newName: "TENNHACUNGCAP");

            migrationBuilder.RenameColumn(
                name: "SoDienThoai",
                table: "NHACUNGCAP",
                newName: "SODIENTHOAI");

            migrationBuilder.RenameColumn(
                name: "MaNhaCungCap",
                table: "NHACUNGCAP",
                newName: "MANHACUNGCAP");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "LOAIHANG",
                newName: "TRANGTHAI");

            migrationBuilder.RenameColumn(
                name: "TenLoaiHang",
                table: "LOAIHANG",
                newName: "TENLOAIHANG");

            migrationBuilder.RenameColumn(
                name: "MaLoaiHang",
                table: "LOAIHANG",
                newName: "MALOAIHANG");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "HOADONCHITIET",
                newName: "TRANGTHAI");

            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "HOADONCHITIET",
                newName: "SOLUONG");

            migrationBuilder.RenameColumn(
                name: "DonGia",
                table: "HOADONCHITIET",
                newName: "DONGIA");

            migrationBuilder.RenameColumn(
                name: "BarCode",
                table: "HOADONCHITIET",
                newName: "BARCODE");

            migrationBuilder.RenameColumn(
                name: "MaHoaDonChiTiet",
                table: "HOADONCHITIET",
                newName: "MAHOADONCHITIET");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "HOADON",
                newName: "TRANGTHAI");

            migrationBuilder.RenameColumn(
                name: "ThanhTien",
                table: "HOADON",
                newName: "THANHTIEN");

            migrationBuilder.RenameColumn(
                name: "NgayXuat",
                table: "HOADON",
                newName: "NGAYXUAT");

            migrationBuilder.RenameColumn(
                name: "MaHoaDon",
                table: "HOADON",
                newName: "MAHOADON");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "DONVITINH",
                newName: "TRANGTHAI");

            migrationBuilder.RenameColumn(
                name: "TenDonViTinh",
                table: "DONVITINH",
                newName: "TENDONVITINH");

            migrationBuilder.RenameColumn(
                name: "MaDonViTinh",
                table: "DONVITINH",
                newName: "MADONVITINH");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "CHUCVU",
                newName: "TRANGTHAI");

            migrationBuilder.RenameColumn(
                name: "TenChucVu",
                table: "CHUCVU",
                newName: "TENCHUCVU");

            migrationBuilder.RenameColumn(
                name: "MaChucVu",
                table: "CHUCVU",
                newName: "MACHUCVU");

            migrationBuilder.RenameColumn(
                name: "TrangThai",
                table: "CHATLIEU",
                newName: "TRANGTHAI");

            migrationBuilder.RenameColumn(
                name: "TenChatLieu",
                table: "CHATLIEU",
                newName: "TENCHATLIEU");

            migrationBuilder.RenameColumn(
                name: "MaChatLieu",
                table: "CHATLIEU",
                newName: "MACHATLIEU");

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "PHIEUNHAP",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NGAYNHAP",
                table: "PHIEUNHAP",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NhacungcapsMANHACUNGCAP",
                table: "PHIEUNHAP",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NhanvienMANHANVIEN",
                table: "PHIEUNHAP",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "NHANVIEN",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TENNHANVIEN",
                table: "NHANVIEN",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SODIENTHOAI",
                table: "NHANVIEN",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SOCMND",
                table: "NHANVIEN",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NAMSINH",
                table: "NHANVIEN",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MATKHAU",
                table: "NHANVIEN",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChucvuMACHUCVU",
                table: "NHANVIEN",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TENNHACUNGCAP",
                table: "NHACUNGCAP",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SODIENTHOAI",
                table: "NHACUNGCAP",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TENLOAIHANG",
                table: "LOAIHANG",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "HOADONCHITIET",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SOLUONG",
                table: "HOADONCHITIET",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "HOADONCHITIET",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "DONGIA",
                table: "HOADONCHITIET",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HOADONMAHOADON",
                table: "HOADONCHITIET",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThongtinhanghoaMATHONGTIN",
                table: "HOADONCHITIET",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "HOADON",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "THANHTIEN",
                table: "HOADON",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "NGAYXUAT",
                table: "HOADON",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NhanvienMANHANVIEN",
                table: "HOADON",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChatlieusMACHATLIEU",
                table: "DONVITINH",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "CHUCVU",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_XUATXU",
                table: "XUATXU",
                column: "MAXUATXU");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PHIEUNHAP",
                table: "PHIEUNHAP",
                column: "MAPHIEUNHAP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NHANVIEN",
                table: "NHANVIEN",
                column: "MANHANVIEN");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NHACUNGCAP",
                table: "NHACUNGCAP",
                column: "MANHACUNGCAP");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LOAIHANG",
                table: "LOAIHANG",
                column: "MALOAIHANG");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HOADONCHITIET",
                table: "HOADONCHITIET",
                column: "MAHOADONCHITIET");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HOADON",
                table: "HOADON",
                column: "MAHOADON");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DONVITINH",
                table: "DONVITINH",
                column: "MADONVITINH");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CHUCVU",
                table: "CHUCVU",
                column: "MACHUCVU");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CHATLIEU",
                table: "CHATLIEU",
                column: "MACHATLIEU");

            migrationBuilder.CreateTable(
                name: "HANGHOA",
                columns: table => new
                {
                    MAHANGHOA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    TENHANGHOA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TRANGTHAI = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HANGHOA", x => x.MAHANGHOA);
                });

            migrationBuilder.CreateTable(
                name: "THONGTINHANGHOA",
                columns: table => new
                {
                    MATHONGTIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BARCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DONGIA = table.Column<double>(type: "float", nullable: false),
                    DonvitinhsMADONVITINH = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    HANSUDUNG = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HINHANH = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HanghoasMAHANGHOA = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: false),
                    LoaihangsMALOAIHANG = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    TRANGTHAI = table.Column<int>(type: "int", nullable: false),
                    XuatxusMAXUATXU = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THONGTINHANGHOA", x => x.MATHONGTIN);
                    table.ForeignKey(
                        name: "FK_THONGTINHANGHOA_DONVITINH_DonvitinhsMADONVITINH",
                        column: x => x.DonvitinhsMADONVITINH,
                        principalTable: "DONVITINH",
                        principalColumn: "MADONVITINH",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_THONGTINHANGHOA_HANGHOA_HanghoasMAHANGHOA",
                        column: x => x.HanghoasMAHANGHOA,
                        principalTable: "HANGHOA",
                        principalColumn: "MAHANGHOA",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_THONGTINHANGHOA_LOAIHANG_LoaihangsMALOAIHANG",
                        column: x => x.LoaihangsMALOAIHANG,
                        principalTable: "LOAIHANG",
                        principalColumn: "MALOAIHANG",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_THONGTINHANGHOA_XUATXU_XuatxusMAXUATXU",
                        column: x => x.XuatxusMAXUATXU,
                        principalTable: "XUATXU",
                        principalColumn: "MAXUATXU",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CHITIETPHIEUNHAP",
                columns: table => new
                {
                    MACHITIETPHIEUNHAP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DONGIA = table.Column<double>(type: "float", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: true),
                    PhieunhapsMAPHIEUNHAP = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SOLUONG = table.Column<float>(type: "real", nullable: false),
                    TRANGTHAI = table.Column<int>(type: "int", nullable: false),
                    ThongtinhanghoasMATHONGTIN = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETPHIEUNHAP", x => x.MACHITIETPHIEUNHAP);
                    table.ForeignKey(
                        name: "FK_CHITIETPHIEUNHAP_PHIEUNHAP_PhieunhapsMAPHIEUNHAP",
                        column: x => x.PhieunhapsMAPHIEUNHAP,
                        principalTable: "PHIEUNHAP",
                        principalColumn: "MAPHIEUNHAP",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CHITIETPHIEUNHAP_THONGTINHANGHOA_ThongtinhanghoasMATHONGTIN",
                        column: x => x.ThongtinhanghoasMATHONGTIN,
                        principalTable: "THONGTINHANGHOA",
                        principalColumn: "MATHONGTIN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUNHAP_NhacungcapsMANHACUNGCAP",
                table: "PHIEUNHAP",
                column: "NhacungcapsMANHACUNGCAP");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUNHAP_NhanvienMANHANVIEN",
                table: "PHIEUNHAP",
                column: "NhanvienMANHANVIEN");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_ChucvuMACHUCVU",
                table: "NHANVIEN",
                column: "ChucvuMACHUCVU");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCHITIET_HOADONMAHOADON",
                table: "HOADONCHITIET",
                column: "HOADONMAHOADON");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCHITIET_ThongtinhanghoaMATHONGTIN",
                table: "HOADONCHITIET",
                column: "ThongtinhanghoaMATHONGTIN");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_NhanvienMANHANVIEN",
                table: "HOADON",
                column: "NhanvienMANHANVIEN");

            migrationBuilder.CreateIndex(
                name: "IX_DONVITINH_ChatlieusMACHATLIEU",
                table: "DONVITINH",
                column: "ChatlieusMACHATLIEU");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETPHIEUNHAP_PhieunhapsMAPHIEUNHAP",
                table: "CHITIETPHIEUNHAP",
                column: "PhieunhapsMAPHIEUNHAP");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETPHIEUNHAP_ThongtinhanghoasMATHONGTIN",
                table: "CHITIETPHIEUNHAP",
                column: "ThongtinhanghoasMATHONGTIN");

            migrationBuilder.CreateIndex(
                name: "IX_THONGTINHANGHOA_DonvitinhsMADONVITINH",
                table: "THONGTINHANGHOA",
                column: "DonvitinhsMADONVITINH");

            migrationBuilder.CreateIndex(
                name: "IX_THONGTINHANGHOA_HanghoasMAHANGHOA",
                table: "THONGTINHANGHOA",
                column: "HanghoasMAHANGHOA");

            migrationBuilder.CreateIndex(
                name: "IX_THONGTINHANGHOA_LoaihangsMALOAIHANG",
                table: "THONGTINHANGHOA",
                column: "LoaihangsMALOAIHANG");

            migrationBuilder.CreateIndex(
                name: "IX_THONGTINHANGHOA_XuatxusMAXUATXU",
                table: "THONGTINHANGHOA",
                column: "XuatxusMAXUATXU");

            migrationBuilder.AddForeignKey(
                name: "FK_DONVITINH_CHATLIEU_ChatlieusMACHATLIEU",
                table: "DONVITINH",
                column: "ChatlieusMACHATLIEU",
                principalTable: "CHATLIEU",
                principalColumn: "MACHATLIEU",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HOADON_NHANVIEN_NhanvienMANHANVIEN",
                table: "HOADON",
                column: "NhanvienMANHANVIEN",
                principalTable: "NHANVIEN",
                principalColumn: "MANHANVIEN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HOADONCHITIET_HOADON_HOADONMAHOADON",
                table: "HOADONCHITIET",
                column: "HOADONMAHOADON",
                principalTable: "HOADON",
                principalColumn: "MAHOADON",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HOADONCHITIET_THONGTINHANGHOA_ThongtinhanghoaMATHONGTIN",
                table: "HOADONCHITIET",
                column: "ThongtinhanghoaMATHONGTIN",
                principalTable: "THONGTINHANGHOA",
                principalColumn: "MATHONGTIN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NHANVIEN_CHUCVU_ChucvuMACHUCVU",
                table: "NHANVIEN",
                column: "ChucvuMACHUCVU",
                principalTable: "CHUCVU",
                principalColumn: "MACHUCVU",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PHIEUNHAP_NHACUNGCAP_NhacungcapsMANHACUNGCAP",
                table: "PHIEUNHAP",
                column: "NhacungcapsMANHACUNGCAP",
                principalTable: "NHACUNGCAP",
                principalColumn: "MANHACUNGCAP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PHIEUNHAP_NHANVIEN_NhanvienMANHANVIEN",
                table: "PHIEUNHAP",
                column: "NhanvienMANHANVIEN",
                principalTable: "NHANVIEN",
                principalColumn: "MANHANVIEN",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
