using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class CONG4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TRANGTHAI",
                table: "LOAIHANG",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TRANGTHAI",
                table: "KICHTHUOC",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TRANGTHAI",
                table: "LOAIHANG");

            migrationBuilder.DropColumn(
                name: "TRANGTHAI",
                table: "KICHTHUOC");
        }
    }
}
