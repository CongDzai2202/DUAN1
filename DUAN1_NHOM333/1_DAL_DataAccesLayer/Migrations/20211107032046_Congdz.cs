using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class Congdz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "THONGTINHANGHOA",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "PHIEUNHAP",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "NHANVIEN",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "NHACUNGCAP",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "LOAIHANG",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "KICHTHUOC",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "HOADONCHITIET",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "HOADON",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "TRANGTHAI",
                table: "HANGHOA",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "CHUCVU",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "TRANGTHAI",
                table: "CHITIETPHIEUNHAP",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TRANGTHAI",
                table: "HANGHOA");

            migrationBuilder.AlterColumn<bool>(
                name: "TRANGTHAI",
                table: "THONGTINHANGHOA",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "TRANGTHAI",
                table: "PHIEUNHAP",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "TRANGTHAI",
                table: "NHANVIEN",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "TRANGTHAI",
                table: "NHACUNGCAP",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "TRANGTHAI",
                table: "LOAIHANG",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "TRANGTHAI",
                table: "KICHTHUOC",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "TRANGTHAI",
                table: "HOADONCHITIET",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "TRANGTHAI",
                table: "HOADON",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "TRANGTHAI",
                table: "CHUCVU",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "TRANGTHAI",
                table: "CHITIETPHIEUNHAP",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
