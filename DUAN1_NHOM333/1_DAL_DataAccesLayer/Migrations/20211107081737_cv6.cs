using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class cv6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NHACUNGCAP_PHIEUNHAP_PHIEUNHAPMAPHIEUNHAP",
                table: "NHACUNGCAP");

            migrationBuilder.DropForeignKey(
                name: "FK_NHANVIEN_CHUCVU_MACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropForeignKey(
                name: "FK_NHANVIEN_PHIEUNHAP_PHIEUNHAPMAPHIEUNHAP",
                table: "NHANVIEN");

            migrationBuilder.DropIndex(
                name: "IX_NHANVIEN_MACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropIndex(
                name: "IX_NHANVIEN_PHIEUNHAPMAPHIEUNHAP",
                table: "NHANVIEN");

            migrationBuilder.DropIndex(
                name: "IX_NHACUNGCAP_PHIEUNHAPMAPHIEUNHAP",
                table: "NHACUNGCAP");

            migrationBuilder.DropColumn(
                name: "MACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropColumn(
                name: "PHIEUNHAPMAPHIEUNHAP",
                table: "NHANVIEN");

            migrationBuilder.DropColumn(
                name: "PHIEUNHAPMAPHIEUNHAP",
                table: "NHACUNGCAP");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "PHIEUNHAP",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "PHIEUNHAP",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MACHUCVU",
                table: "NHANVIEN",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PHIEUNHAPMAPHIEUNHAP",
                table: "NHANVIEN",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PHIEUNHAPMAPHIEUNHAP",
                table: "NHACUNGCAP",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_MACHUCVU",
                table: "NHANVIEN",
                column: "MACHUCVU");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_PHIEUNHAPMAPHIEUNHAP",
                table: "NHANVIEN",
                column: "PHIEUNHAPMAPHIEUNHAP");

            migrationBuilder.CreateIndex(
                name: "IX_NHACUNGCAP_PHIEUNHAPMAPHIEUNHAP",
                table: "NHACUNGCAP",
                column: "PHIEUNHAPMAPHIEUNHAP");

            migrationBuilder.AddForeignKey(
                name: "FK_NHACUNGCAP_PHIEUNHAP_PHIEUNHAPMAPHIEUNHAP",
                table: "NHACUNGCAP",
                column: "PHIEUNHAPMAPHIEUNHAP",
                principalTable: "PHIEUNHAP",
                principalColumn: "MAPHIEUNHAP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NHANVIEN_CHUCVU_MACHUCVU",
                table: "NHANVIEN",
                column: "MACHUCVU",
                principalTable: "CHUCVU",
                principalColumn: "MACHUCVU",
                onDelete: ReferentialAction.Restrict);

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
