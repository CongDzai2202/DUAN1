using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class congâ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NHANVIEN_CHUCVU_CHUCVUSMACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropIndex(
                name: "IX_NHANVIEN_CHUCVUSMACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropColumn(
                name: "CHUCVUSMACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.AlterColumn<string>(
                name: "MACHUCVU",
                table: "NHANVIEN",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NHANVIEN_CHUCVU_MACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropIndex(
                name: "IX_NHANVIEN_MACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.AlterColumn<string>(
                name: "MACHUCVU",
                table: "NHANVIEN",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CHUCVUSMACHUCVU",
                table: "NHANVIEN",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_CHUCVUSMACHUCVU",
                table: "NHANVIEN",
                column: "CHUCVUSMACHUCVU");

            migrationBuilder.AddForeignKey(
                name: "FK_NHANVIEN_CHUCVU_CHUCVUSMACHUCVU",
                table: "NHANVIEN",
                column: "CHUCVUSMACHUCVU",
                principalTable: "CHUCVU",
                principalColumn: "MACHUCVU",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
