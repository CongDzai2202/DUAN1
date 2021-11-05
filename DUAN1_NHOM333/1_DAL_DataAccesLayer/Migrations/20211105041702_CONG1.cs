using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class CONG1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHITIETPHIEUNHAP",
                columns: table => new
                {
                    MACHITIETPHIEUNHAP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    SOLUONG = table.Column<float>(type: "real", nullable: false),
                    DONGIA = table.Column<double>(type: "float", nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHITIETPHIEUNHAP", x => x.MACHITIETPHIEUNHAP);
                });

            migrationBuilder.CreateTable(
                name: "CHUCVU",
                columns: table => new
                {
                    MACHUCVU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    TENCHUCVU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHUCVU", x => x.MACHUCVU);
                });

            migrationBuilder.CreateTable(
                name: "HOADONCHITIET",
                columns: table => new
                {
                    MAHOADONCHITIET = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    DONGIA = table.Column<double>(type: "float", nullable: false),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    BARCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOADONCHITIET", x => x.MAHOADONCHITIET);
                });

            migrationBuilder.CreateTable(
                name: "PHIEUNHAP",
                columns: table => new
                {
                    MAPHIEUNHAP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    NGAYNHAP = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false),
                    CHITIETPHIEUNHAPMACHITIETPHIEUNHAP = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHIEUNHAP", x => x.MAPHIEUNHAP);
                    table.ForeignKey(
                        name: "FK_PHIEUNHAP_CHITIETPHIEUNHAP_CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                        column: x => x.CHITIETPHIEUNHAPMACHITIETPHIEUNHAP,
                        principalTable: "CHITIETPHIEUNHAP",
                        principalColumn: "MACHITIETPHIEUNHAP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "THONGTINHANGHOA",
                columns: table => new
                {
                    MATHONGTIN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    DONGIA = table.Column<double>(type: "float", nullable: false),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false),
                    BARCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HANSUDUNG = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HINHANH = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CHITIETPHIEUNHAPMACHITIETPHIEUNHAP = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    HOADONCHITIETMAHOADONCHITIET = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THONGTINHANGHOA", x => x.MATHONGTIN);
                    table.ForeignKey(
                        name: "FK_THONGTINHANGHOA_CHITIETPHIEUNHAP_CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                        column: x => x.CHITIETPHIEUNHAPMACHITIETPHIEUNHAP,
                        principalTable: "CHITIETPHIEUNHAP",
                        principalColumn: "MACHITIETPHIEUNHAP",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_THONGTINHANGHOA_HOADONCHITIET_HOADONCHITIETMAHOADONCHITIET",
                        column: x => x.HOADONCHITIETMAHOADONCHITIET,
                        principalTable: "HOADONCHITIET",
                        principalColumn: "MAHOADONCHITIET",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NHACUNGCAP",
                columns: table => new
                {
                    MANHACUNGCAP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: true),
                    TENNHACUNGCAP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SODIENTHOAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PHIEUNHAPMAPHIEUNHAP = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHACUNGCAP", x => x.MANHACUNGCAP);
                    table.ForeignKey(
                        name: "FK_NHACUNGCAP_PHIEUNHAP_PHIEUNHAPMAPHIEUNHAP",
                        column: x => x.PHIEUNHAPMAPHIEUNHAP,
                        principalTable: "PHIEUNHAP",
                        principalColumn: "MAPHIEUNHAP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    MANHANVIEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    TENNHANVIEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SOCMND = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NAMSINH = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    DIACHI = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SODIENTHOAI = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    MATKHAU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false),
                    MACHUCVU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHUCVUSMACHUCVU = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PHIEUNHAPMAPHIEUNHAP = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHANVIEN", x => x.MANHANVIEN);
                    table.ForeignKey(
                        name: "FK_NHANVIEN_CHUCVU_CHUCVUSMACHUCVU",
                        column: x => x.CHUCVUSMACHUCVU,
                        principalTable: "CHUCVU",
                        principalColumn: "MACHUCVU",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NHANVIEN_PHIEUNHAP_PHIEUNHAPMAPHIEUNHAP",
                        column: x => x.PHIEUNHAPMAPHIEUNHAP,
                        principalTable: "PHIEUNHAP",
                        principalColumn: "MAPHIEUNHAP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HANGHOA",
                columns: table => new
                {
                    MAHANGHOA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: true),
                    TENHANGHOA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    THONGTINHANGHOAMATHONGTIN = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HANGHOA", x => x.MAHANGHOA);
                    table.ForeignKey(
                        name: "FK_HANGHOA_THONGTINHANGHOA_THONGTINHANGHOAMATHONGTIN",
                        column: x => x.THONGTINHANGHOAMATHONGTIN,
                        principalTable: "THONGTINHANGHOA",
                        principalColumn: "MATHONGTIN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KICHTHUOC",
                columns: table => new
                {
                    MAKICHTHUOC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: true),
                    TRONGLUONG = table.Column<float>(type: "real", nullable: false),
                    DONVITINH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    THONGTINHANGHOAMATHONGTIN = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KICHTHUOC", x => x.MAKICHTHUOC);
                    table.ForeignKey(
                        name: "FK_KICHTHUOC_THONGTINHANGHOA_THONGTINHANGHOAMATHONGTIN",
                        column: x => x.THONGTINHANGHOAMATHONGTIN,
                        principalTable: "THONGTINHANGHOA",
                        principalColumn: "MATHONGTIN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LOAIHANG",
                columns: table => new
                {
                    MALOAIHANG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: true),
                    TENLOAIHANG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    THONGTINHANGHOAMATHONGTIN = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOAIHANG", x => x.MALOAIHANG);
                    table.ForeignKey(
                        name: "FK_LOAIHANG_THONGTINHANGHOA_THONGTINHANGHOAMATHONGTIN",
                        column: x => x.THONGTINHANGHOAMATHONGTIN,
                        principalTable: "THONGTINHANGHOA",
                        principalColumn: "MATHONGTIN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    MAHOADON = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: true),
                    NGAYXUAT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    THANHTIEN = table.Column<double>(type: "float", nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false),
                    MANHANVIEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NHANVIENSMANHANVIEN = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    HOADONCHITIETMAHOADONCHITIET = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOADON", x => x.MAHOADON);
                    table.ForeignKey(
                        name: "FK_HOADON_HOADONCHITIET_HOADONCHITIETMAHOADONCHITIET",
                        column: x => x.HOADONCHITIETMAHOADONCHITIET,
                        principalTable: "HOADONCHITIET",
                        principalColumn: "MAHOADONCHITIET",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HOADON_NHANVIEN_NHANVIENSMANHANVIEN",
                        column: x => x.NHANVIENSMANHANVIEN,
                        principalTable: "NHANVIEN",
                        principalColumn: "MANHANVIEN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HANGHOA_THONGTINHANGHOAMATHONGTIN",
                table: "HANGHOA",
                column: "THONGTINHANGHOAMATHONGTIN");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_HOADONCHITIETMAHOADONCHITIET",
                table: "HOADON",
                column: "HOADONCHITIETMAHOADONCHITIET");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_NHANVIENSMANHANVIEN",
                table: "HOADON",
                column: "NHANVIENSMANHANVIEN");

            migrationBuilder.CreateIndex(
                name: "IX_KICHTHUOC_THONGTINHANGHOAMATHONGTIN",
                table: "KICHTHUOC",
                column: "THONGTINHANGHOAMATHONGTIN");

            migrationBuilder.CreateIndex(
                name: "IX_LOAIHANG_THONGTINHANGHOAMATHONGTIN",
                table: "LOAIHANG",
                column: "THONGTINHANGHOAMATHONGTIN");

            migrationBuilder.CreateIndex(
                name: "IX_NHACUNGCAP_PHIEUNHAPMAPHIEUNHAP",
                table: "NHACUNGCAP",
                column: "PHIEUNHAPMAPHIEUNHAP");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_CHUCVUSMACHUCVU",
                table: "NHANVIEN",
                column: "CHUCVUSMACHUCVU");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_PHIEUNHAPMAPHIEUNHAP",
                table: "NHANVIEN",
                column: "PHIEUNHAPMAPHIEUNHAP");

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUNHAP_CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                table: "PHIEUNHAP",
                column: "CHITIETPHIEUNHAPMACHITIETPHIEUNHAP");

            migrationBuilder.CreateIndex(
                name: "IX_THONGTINHANGHOA_CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                table: "THONGTINHANGHOA",
                column: "CHITIETPHIEUNHAPMACHITIETPHIEUNHAP");

            migrationBuilder.CreateIndex(
                name: "IX_THONGTINHANGHOA_HOADONCHITIETMAHOADONCHITIET",
                table: "THONGTINHANGHOA",
                column: "HOADONCHITIETMAHOADONCHITIET");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HANGHOA");

            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "KICHTHUOC");

            migrationBuilder.DropTable(
                name: "LOAIHANG");

            migrationBuilder.DropTable(
                name: "NHACUNGCAP");

            migrationBuilder.DropTable(
                name: "NHANVIEN");

            migrationBuilder.DropTable(
                name: "THONGTINHANGHOA");

            migrationBuilder.DropTable(
                name: "CHUCVU");

            migrationBuilder.DropTable(
                name: "PHIEUNHAP");

            migrationBuilder.DropTable(
                name: "HOADONCHITIET");

            migrationBuilder.DropTable(
                name: "CHITIETPHIEUNHAP");
        }
    }
}
