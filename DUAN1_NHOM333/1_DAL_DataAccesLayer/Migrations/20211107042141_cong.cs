using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class cong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NHANVIEN_PHIEUNHAP_PHIEUNHAPMAPHIEUNHAP",
                table: "NHANVIEN");

            migrationBuilder.DropIndex(
                name: "IX_NHANVIEN_PHIEUNHAPMAPHIEUNHAP",
                table: "NHANVIEN");

            migrationBuilder.DropColumn(
                name: "PHIEUNHAPMAPHIEUNHAP",
                table: "NHANVIEN");

            migrationBuilder.CreateTable(
                name: "NHANVIENPHIEUNHAP",
                columns: table => new
                {
                    NhanviensMANHANVIEN = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PHIEUNHAPSMAPHIEUNHAP = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHANVIENPHIEUNHAP", x => new { x.NhanviensMANHANVIEN, x.PHIEUNHAPSMAPHIEUNHAP });
                    table.ForeignKey(
                        name: "FK_NHANVIENPHIEUNHAP_NHANVIEN_NhanviensMANHANVIEN",
                        column: x => x.NhanviensMANHANVIEN,
                        principalTable: "NHANVIEN",
                        principalColumn: "MANHANVIEN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NHANVIENPHIEUNHAP_PHIEUNHAP_PHIEUNHAPSMAPHIEUNHAP",
                        column: x => x.PHIEUNHAPSMAPHIEUNHAP,
                        principalTable: "PHIEUNHAP",
                        principalColumn: "MAPHIEUNHAP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIENPHIEUNHAP_PHIEUNHAPSMAPHIEUNHAP",
                table: "NHANVIENPHIEUNHAP",
                column: "PHIEUNHAPSMAPHIEUNHAP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NHANVIENPHIEUNHAP");

            migrationBuilder.AddColumn<string>(
                name: "PHIEUNHAPMAPHIEUNHAP",
                table: "NHANVIEN",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_PHIEUNHAPMAPHIEUNHAP",
                table: "NHANVIEN",
                column: "PHIEUNHAPMAPHIEUNHAP");

            migrationBuilder.AddForeignKey(
                name: "FK_NHANVIEN_PHIEUNHAP_PHIEUNHAPMAPHIEUNHAP",
                table: "NHANVIEN",
                column: "PHIEUNHAPMAPHIEUNHAP",
                principalTable: "PHIEUNHAP",
                principalColumn: "MAPHIEUNHAP",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
