using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class vc8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CHUCVU_CHUCVU_CHUCVUMACHUCVU",
                table: "CHUCVU");

            migrationBuilder.DropIndex(
                name: "IX_CHUCVU_CHUCVUMACHUCVU",
                table: "CHUCVU");

            migrationBuilder.DropColumn(
                name: "CHUCVUMACHUCVU",
                table: "CHUCVU");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CHUCVUMACHUCVU",
                table: "CHUCVU",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CHUCVU_CHUCVUMACHUCVU",
                table: "CHUCVU",
                column: "CHUCVUMACHUCVU");

            migrationBuilder.AddForeignKey(
                name: "FK_CHUCVU_CHUCVU_CHUCVUMACHUCVU",
                table: "CHUCVU",
                column: "CHUCVUMACHUCVU",
                principalTable: "CHUCVU",
                principalColumn: "MACHUCVU",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
