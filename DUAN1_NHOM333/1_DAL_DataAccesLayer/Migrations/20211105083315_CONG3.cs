using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class CONG3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TRANGTHAI",
                table: "NHACUNGCAP",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TRANGTHAI",
                table: "NHACUNGCAP");
        }
    }
}
