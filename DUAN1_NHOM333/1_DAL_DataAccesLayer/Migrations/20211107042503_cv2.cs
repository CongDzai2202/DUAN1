using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class cv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NHANVIENPHIEUNHAP");

            migrationBuilder.AddColumn<string>(
                name: "NHANVIENMANHANVIEN",
                table: "PHIEUNHAP",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MACHUCVU",
                table: "NHANVIEN",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUNHAP_NHANVIENMANHANVIEN",
                table: "PHIEUNHAP",
                column: "NHANVIENMANHANVIEN");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_MACHUCVU",
                table: "NHANVIEN",
                column: "MACHUCVU");

            migrationBuilder.AddForeignKey(
                name: "FK_NHANVIEN_CHUCVU_MACHUCVU",
                table: "NHANVIEN",
                column: "MACHUCVU",
                principalTable: "CHUCVU",
                principalColumn: "MACHUCVU",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PHIEUNHAP_NHANVIEN_NHANVIENMANHANVIEN",
                table: "PHIEUNHAP",
                column: "NHANVIENMANHANVIEN",
                principalTable: "NHANVIEN",
                principalColumn: "MANHANVIEN",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NHANVIEN_CHUCVU_MACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropForeignKey(
                name: "FK_PHIEUNHAP_NHANVIEN_NHANVIENMANHANVIEN",
                table: "PHIEUNHAP");

            migrationBuilder.DropIndex(
                name: "IX_PHIEUNHAP_NHANVIENMANHANVIEN",
                table: "PHIEUNHAP");

            migrationBuilder.DropIndex(
                name: "IX_NHANVIEN_MACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropColumn(
                name: "NHANVIENMANHANVIEN",
                table: "PHIEUNHAP");

            migrationBuilder.DropColumn(
                name: "MACHUCVU",
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
    }
}
