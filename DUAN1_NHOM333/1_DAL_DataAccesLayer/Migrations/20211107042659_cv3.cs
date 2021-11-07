using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class cv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PHIEUNHAP_NHANVIEN_NHANVIENMANHANVIEN",
                table: "PHIEUNHAP");

            migrationBuilder.DropIndex(
                name: "IX_PHIEUNHAP_NHANVIENMANHANVIEN",
                table: "PHIEUNHAP");

            migrationBuilder.DropColumn(
                name: "NHANVIENMANHANVIEN",
                table: "PHIEUNHAP");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "NHANVIENMANHANVIEN",
                table: "PHIEUNHAP",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PHIEUNHAP_NHANVIENMANHANVIEN",
                table: "PHIEUNHAP",
                column: "NHANVIENMANHANVIEN");

            migrationBuilder.AddForeignKey(
                name: "FK_PHIEUNHAP_NHANVIEN_NHANVIENMANHANVIEN",
                table: "PHIEUNHAP",
                column: "NHANVIENMANHANVIEN",
                principalTable: "NHANVIEN",
                principalColumn: "MANHANVIEN",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
