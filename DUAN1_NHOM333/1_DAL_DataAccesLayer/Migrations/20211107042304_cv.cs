using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class cv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NHANVIEN_CHUCVU_MACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropIndex(
                name: "IX_NHANVIEN_MACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropColumn(
                name: "MACHUCVU",
                table: "NHANVIEN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MACHUCVU",
                table: "NHANVIEN",
                type: "nvarchar(50)",
                nullable: true);

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
    }
}
