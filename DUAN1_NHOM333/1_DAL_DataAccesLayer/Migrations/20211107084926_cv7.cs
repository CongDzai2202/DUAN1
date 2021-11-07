using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAccesLayer.Migrations
{
    public partial class cv7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HANGHOA_THONGTINHANGHOA_THONGTINHANGHOAMATHONGTIN",
                table: "HANGHOA");

            migrationBuilder.DropForeignKey(
                name: "FK_HOADON_HOADONCHITIET_HOADONCHITIETMAHOADONCHITIET",
                table: "HOADON");

            migrationBuilder.DropForeignKey(
                name: "FK_HOADON_NHANVIEN_NHANVIENSMANHANVIEN",
                table: "HOADON");

            migrationBuilder.DropForeignKey(
                name: "FK_LOAIHANG_THONGTINHANGHOA_THONGTINHANGHOAMATHONGTIN",
                table: "LOAIHANG");

            migrationBuilder.DropForeignKey(
                name: "FK_PHIEUNHAP_CHITIETPHIEUNHAP_CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                table: "PHIEUNHAP");

            migrationBuilder.DropForeignKey(
                name: "FK_PHIEUNHAP_NHANVIEN_NHANVIENMANHANVIEN",
                table: "PHIEUNHAP");

            migrationBuilder.DropForeignKey(
                name: "FK_THONGTINHANGHOA_CHITIETPHIEUNHAP_CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                table: "THONGTINHANGHOA");

            migrationBuilder.DropForeignKey(
                name: "FK_THONGTINHANGHOA_HOADONCHITIET_HOADONCHITIETMAHOADONCHITIET",
                table: "THONGTINHANGHOA");

            migrationBuilder.DropTable(
                name: "KICHTHUOC");

            migrationBuilder.DropIndex(
                name: "IX_LOAIHANG_THONGTINHANGHOAMATHONGTIN",
                table: "LOAIHANG");

            migrationBuilder.DropIndex(
                name: "IX_HOADON_HOADONCHITIETMAHOADONCHITIET",
                table: "HOADON");

            migrationBuilder.DropIndex(
                name: "IX_HANGHOA_THONGTINHANGHOAMATHONGTIN",
                table: "HANGHOA");

            migrationBuilder.DropColumn(
                name: "THONGTINHANGHOAMATHONGTIN",
                table: "LOAIHANG");

            migrationBuilder.DropColumn(
                name: "HOADONCHITIETMAHOADONCHITIET",
                table: "HOADON");

            migrationBuilder.DropColumn(
                name: "MANHANVIEN",
                table: "HOADON");

            migrationBuilder.DropColumn(
                name: "THONGTINHANGHOAMATHONGTIN",
                table: "HANGHOA");

            migrationBuilder.RenameColumn(
                name: "HOADONCHITIETMAHOADONCHITIET",
                table: "THONGTINHANGHOA",
                newName: "XuatxusMAXUATXU");

            migrationBuilder.RenameColumn(
                name: "CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                table: "THONGTINHANGHOA",
                newName: "LoaihangsMALOAIHANG");

            migrationBuilder.RenameIndex(
                name: "IX_THONGTINHANGHOA_HOADONCHITIETMAHOADONCHITIET",
                table: "THONGTINHANGHOA",
                newName: "IX_THONGTINHANGHOA_XuatxusMAXUATXU");

            migrationBuilder.RenameIndex(
                name: "IX_THONGTINHANGHOA_CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                table: "THONGTINHANGHOA",
                newName: "IX_THONGTINHANGHOA_LoaihangsMALOAIHANG");

            migrationBuilder.RenameColumn(
                name: "NHANVIENMANHANVIEN",
                table: "PHIEUNHAP",
                newName: "NhanvienMANHANVIEN");

            migrationBuilder.RenameColumn(
                name: "CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                table: "PHIEUNHAP",
                newName: "NhacungcapsMANHACUNGCAP");

            migrationBuilder.RenameIndex(
                name: "IX_PHIEUNHAP_NHANVIENMANHANVIEN",
                table: "PHIEUNHAP",
                newName: "IX_PHIEUNHAP_NhanvienMANHANVIEN");

            migrationBuilder.RenameIndex(
                name: "IX_PHIEUNHAP_CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                table: "PHIEUNHAP",
                newName: "IX_PHIEUNHAP_NhacungcapsMANHACUNGCAP");

            migrationBuilder.RenameColumn(
                name: "NHANVIENSMANHANVIEN",
                table: "HOADON",
                newName: "NhanvienMANHANVIEN");

            migrationBuilder.RenameIndex(
                name: "IX_HOADON_NHANVIENSMANHANVIEN",
                table: "HOADON",
                newName: "IX_HOADON_NhanvienMANHANVIEN");

            migrationBuilder.AddColumn<string>(
                name: "DonvitinhsMADONVITINH",
                table: "THONGTINHANGHOA",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HanghoasMAHANGHOA",
                table: "THONGTINHANGHOA",
                type: "nvarchar(50)",
                nullable: true);

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
                name: "ChucvuMACHUCVU",
                table: "NHANVIEN",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "NHACUNGCAP",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "LOAIHANG",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "HOADONCHITIET",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "HOADONMAHOADON",
                table: "HOADONCHITIET",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThongtinhanghoaMATHONGTIN",
                table: "HOADONCHITIET",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "HOADON",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "HANGHOA",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CHUCVUMACHUCVU",
                table: "CHUCVU",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "CHITIETPHIEUNHAP",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "PhieunhapsMAPHIEUNHAP",
                table: "CHITIETPHIEUNHAP",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThongtinhanghoasMATHONGTIN",
                table: "CHITIETPHIEUNHAP",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CHATLIEU",
                columns: table => new
                {
                    MACHATLIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    TENCHATLIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TRANGTHAI = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHATLIEU", x => x.MACHATLIEU);
                });

            migrationBuilder.CreateTable(
                name: "XUATXU",
                columns: table => new
                {
                    MAXUATXU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    TENNUOC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XUATXU", x => x.MAXUATXU);
                });

            migrationBuilder.CreateTable(
                name: "DONVITINH",
                columns: table => new
                {
                    MADONVITINH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    TENDONVITINH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TRANGTHAI = table.Column<int>(type: "int", nullable: true),
                    ChatlieusMACHATLIEU = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DONVITINH", x => x.MADONVITINH);
                    table.ForeignKey(
                        name: "FK_DONVITINH_CHATLIEU_ChatlieusMACHATLIEU",
                        column: x => x.ChatlieusMACHATLIEU,
                        principalTable: "CHATLIEU",
                        principalColumn: "MACHATLIEU",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_THONGTINHANGHOA_DonvitinhsMADONVITINH",
                table: "THONGTINHANGHOA",
                column: "DonvitinhsMADONVITINH");

            migrationBuilder.CreateIndex(
                name: "IX_THONGTINHANGHOA_HanghoasMAHANGHOA",
                table: "THONGTINHANGHOA",
                column: "HanghoasMAHANGHOA");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_ChucvuMACHUCVU",
                table: "NHANVIEN",
                column: "ChucvuMACHUCVU");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCHITIET_HOADONMAHOADON",
                table: "HOADONCHITIET",
                column: "HOADONMAHOADON");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCHITIET_ThongtinhanghoaMATHONGTIN",
                table: "HOADONCHITIET",
                column: "ThongtinhanghoaMATHONGTIN");

            migrationBuilder.CreateIndex(
                name: "IX_CHUCVU_CHUCVUMACHUCVU",
                table: "CHUCVU",
                column: "CHUCVUMACHUCVU");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETPHIEUNHAP_PhieunhapsMAPHIEUNHAP",
                table: "CHITIETPHIEUNHAP",
                column: "PhieunhapsMAPHIEUNHAP");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETPHIEUNHAP_ThongtinhanghoasMATHONGTIN",
                table: "CHITIETPHIEUNHAP",
                column: "ThongtinhanghoasMATHONGTIN");

            migrationBuilder.CreateIndex(
                name: "IX_DONVITINH_ChatlieusMACHATLIEU",
                table: "DONVITINH",
                column: "ChatlieusMACHATLIEU");

            migrationBuilder.AddForeignKey(
                name: "FK_CHITIETPHIEUNHAP_PHIEUNHAP_PhieunhapsMAPHIEUNHAP",
                table: "CHITIETPHIEUNHAP",
                column: "PhieunhapsMAPHIEUNHAP",
                principalTable: "PHIEUNHAP",
                principalColumn: "MAPHIEUNHAP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CHITIETPHIEUNHAP_THONGTINHANGHOA_ThongtinhanghoasMATHONGTIN",
                table: "CHITIETPHIEUNHAP",
                column: "ThongtinhanghoasMATHONGTIN",
                principalTable: "THONGTINHANGHOA",
                principalColumn: "MATHONGTIN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CHUCVU_CHUCVU_CHUCVUMACHUCVU",
                table: "CHUCVU",
                column: "CHUCVUMACHUCVU",
                principalTable: "CHUCVU",
                principalColumn: "MACHUCVU",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HOADON_NHANVIEN_NhanvienMANHANVIEN",
                table: "HOADON",
                column: "NhanvienMANHANVIEN",
                principalTable: "NHANVIEN",
                principalColumn: "MANHANVIEN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HOADONCHITIET_HOADON_HOADONMAHOADON",
                table: "HOADONCHITIET",
                column: "HOADONMAHOADON",
                principalTable: "HOADON",
                principalColumn: "MAHOADON",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HOADONCHITIET_THONGTINHANGHOA_ThongtinhanghoaMATHONGTIN",
                table: "HOADONCHITIET",
                column: "ThongtinhanghoaMATHONGTIN",
                principalTable: "THONGTINHANGHOA",
                principalColumn: "MATHONGTIN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NHANVIEN_CHUCVU_ChucvuMACHUCVU",
                table: "NHANVIEN",
                column: "ChucvuMACHUCVU",
                principalTable: "CHUCVU",
                principalColumn: "MACHUCVU",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PHIEUNHAP_NHACUNGCAP_NhacungcapsMANHACUNGCAP",
                table: "PHIEUNHAP",
                column: "NhacungcapsMANHACUNGCAP",
                principalTable: "NHACUNGCAP",
                principalColumn: "MANHACUNGCAP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PHIEUNHAP_NHANVIEN_NhanvienMANHANVIEN",
                table: "PHIEUNHAP",
                column: "NhanvienMANHANVIEN",
                principalTable: "NHANVIEN",
                principalColumn: "MANHANVIEN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_THONGTINHANGHOA_DONVITINH_DonvitinhsMADONVITINH",
                table: "THONGTINHANGHOA",
                column: "DonvitinhsMADONVITINH",
                principalTable: "DONVITINH",
                principalColumn: "MADONVITINH",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_THONGTINHANGHOA_HANGHOA_HanghoasMAHANGHOA",
                table: "THONGTINHANGHOA",
                column: "HanghoasMAHANGHOA",
                principalTable: "HANGHOA",
                principalColumn: "MAHANGHOA",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_THONGTINHANGHOA_LOAIHANG_LoaihangsMALOAIHANG",
                table: "THONGTINHANGHOA",
                column: "LoaihangsMALOAIHANG",
                principalTable: "LOAIHANG",
                principalColumn: "MALOAIHANG",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_THONGTINHANGHOA_XUATXU_XuatxusMAXUATXU",
                table: "THONGTINHANGHOA",
                column: "XuatxusMAXUATXU",
                principalTable: "XUATXU",
                principalColumn: "MAXUATXU",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CHITIETPHIEUNHAP_PHIEUNHAP_PhieunhapsMAPHIEUNHAP",
                table: "CHITIETPHIEUNHAP");

            migrationBuilder.DropForeignKey(
                name: "FK_CHITIETPHIEUNHAP_THONGTINHANGHOA_ThongtinhanghoasMATHONGTIN",
                table: "CHITIETPHIEUNHAP");

            migrationBuilder.DropForeignKey(
                name: "FK_CHUCVU_CHUCVU_CHUCVUMACHUCVU",
                table: "CHUCVU");

            migrationBuilder.DropForeignKey(
                name: "FK_HOADON_NHANVIEN_NhanvienMANHANVIEN",
                table: "HOADON");

            migrationBuilder.DropForeignKey(
                name: "FK_HOADONCHITIET_HOADON_HOADONMAHOADON",
                table: "HOADONCHITIET");

            migrationBuilder.DropForeignKey(
                name: "FK_HOADONCHITIET_THONGTINHANGHOA_ThongtinhanghoaMATHONGTIN",
                table: "HOADONCHITIET");

            migrationBuilder.DropForeignKey(
                name: "FK_NHANVIEN_CHUCVU_ChucvuMACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropForeignKey(
                name: "FK_PHIEUNHAP_NHACUNGCAP_NhacungcapsMANHACUNGCAP",
                table: "PHIEUNHAP");

            migrationBuilder.DropForeignKey(
                name: "FK_PHIEUNHAP_NHANVIEN_NhanvienMANHANVIEN",
                table: "PHIEUNHAP");

            migrationBuilder.DropForeignKey(
                name: "FK_THONGTINHANGHOA_DONVITINH_DonvitinhsMADONVITINH",
                table: "THONGTINHANGHOA");

            migrationBuilder.DropForeignKey(
                name: "FK_THONGTINHANGHOA_HANGHOA_HanghoasMAHANGHOA",
                table: "THONGTINHANGHOA");

            migrationBuilder.DropForeignKey(
                name: "FK_THONGTINHANGHOA_LOAIHANG_LoaihangsMALOAIHANG",
                table: "THONGTINHANGHOA");

            migrationBuilder.DropForeignKey(
                name: "FK_THONGTINHANGHOA_XUATXU_XuatxusMAXUATXU",
                table: "THONGTINHANGHOA");

            migrationBuilder.DropTable(
                name: "DONVITINH");

            migrationBuilder.DropTable(
                name: "XUATXU");

            migrationBuilder.DropTable(
                name: "CHATLIEU");

            migrationBuilder.DropIndex(
                name: "IX_THONGTINHANGHOA_DonvitinhsMADONVITINH",
                table: "THONGTINHANGHOA");

            migrationBuilder.DropIndex(
                name: "IX_THONGTINHANGHOA_HanghoasMAHANGHOA",
                table: "THONGTINHANGHOA");

            migrationBuilder.DropIndex(
                name: "IX_NHANVIEN_ChucvuMACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropIndex(
                name: "IX_HOADONCHITIET_HOADONMAHOADON",
                table: "HOADONCHITIET");

            migrationBuilder.DropIndex(
                name: "IX_HOADONCHITIET_ThongtinhanghoaMATHONGTIN",
                table: "HOADONCHITIET");

            migrationBuilder.DropIndex(
                name: "IX_CHUCVU_CHUCVUMACHUCVU",
                table: "CHUCVU");

            migrationBuilder.DropIndex(
                name: "IX_CHITIETPHIEUNHAP_PhieunhapsMAPHIEUNHAP",
                table: "CHITIETPHIEUNHAP");

            migrationBuilder.DropIndex(
                name: "IX_CHITIETPHIEUNHAP_ThongtinhanghoasMATHONGTIN",
                table: "CHITIETPHIEUNHAP");

            migrationBuilder.DropColumn(
                name: "DonvitinhsMADONVITINH",
                table: "THONGTINHANGHOA");

            migrationBuilder.DropColumn(
                name: "HanghoasMAHANGHOA",
                table: "THONGTINHANGHOA");

            migrationBuilder.DropColumn(
                name: "ChucvuMACHUCVU",
                table: "NHANVIEN");

            migrationBuilder.DropColumn(
                name: "HOADONMAHOADON",
                table: "HOADONCHITIET");

            migrationBuilder.DropColumn(
                name: "ThongtinhanghoaMATHONGTIN",
                table: "HOADONCHITIET");

            migrationBuilder.DropColumn(
                name: "CHUCVUMACHUCVU",
                table: "CHUCVU");

            migrationBuilder.DropColumn(
                name: "PhieunhapsMAPHIEUNHAP",
                table: "CHITIETPHIEUNHAP");

            migrationBuilder.DropColumn(
                name: "ThongtinhanghoasMATHONGTIN",
                table: "CHITIETPHIEUNHAP");

            migrationBuilder.RenameColumn(
                name: "XuatxusMAXUATXU",
                table: "THONGTINHANGHOA",
                newName: "HOADONCHITIETMAHOADONCHITIET");

            migrationBuilder.RenameColumn(
                name: "LoaihangsMALOAIHANG",
                table: "THONGTINHANGHOA",
                newName: "CHITIETPHIEUNHAPMACHITIETPHIEUNHAP");

            migrationBuilder.RenameIndex(
                name: "IX_THONGTINHANGHOA_XuatxusMAXUATXU",
                table: "THONGTINHANGHOA",
                newName: "IX_THONGTINHANGHOA_HOADONCHITIETMAHOADONCHITIET");

            migrationBuilder.RenameIndex(
                name: "IX_THONGTINHANGHOA_LoaihangsMALOAIHANG",
                table: "THONGTINHANGHOA",
                newName: "IX_THONGTINHANGHOA_CHITIETPHIEUNHAPMACHITIETPHIEUNHAP");

            migrationBuilder.RenameColumn(
                name: "NhanvienMANHANVIEN",
                table: "PHIEUNHAP",
                newName: "NHANVIENMANHANVIEN");

            migrationBuilder.RenameColumn(
                name: "NhacungcapsMANHACUNGCAP",
                table: "PHIEUNHAP",
                newName: "CHITIETPHIEUNHAPMACHITIETPHIEUNHAP");

            migrationBuilder.RenameIndex(
                name: "IX_PHIEUNHAP_NhanvienMANHANVIEN",
                table: "PHIEUNHAP",
                newName: "IX_PHIEUNHAP_NHANVIENMANHANVIEN");

            migrationBuilder.RenameIndex(
                name: "IX_PHIEUNHAP_NhacungcapsMANHACUNGCAP",
                table: "PHIEUNHAP",
                newName: "IX_PHIEUNHAP_CHITIETPHIEUNHAPMACHITIETPHIEUNHAP");

            migrationBuilder.RenameColumn(
                name: "NhanvienMANHANVIEN",
                table: "HOADON",
                newName: "NHANVIENSMANHANVIEN");

            migrationBuilder.RenameIndex(
                name: "IX_HOADON_NhanvienMANHANVIEN",
                table: "HOADON",
                newName: "IX_HOADON_NHANVIENSMANHANVIEN");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "PHIEUNHAP",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "NHACUNGCAP",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "LOAIHANG",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "THONGTINHANGHOAMATHONGTIN",
                table: "LOAIHANG",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "HOADONCHITIET",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "HOADON",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "HOADONCHITIETMAHOADONCHITIET",
                table: "HOADON",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MANHANVIEN",
                table: "HOADON",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "HANGHOA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "THONGTINHANGHOAMATHONGTIN",
                table: "HANGHOA",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "CHITIETPHIEUNHAP",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "KICHTHUOC",
                columns: table => new
                {
                    MAKICHTHUOC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DONVITINH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID = table.Column<int>(type: "int", nullable: true),
                    THONGTINHANGHOAMATHONGTIN = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TRANGTHAI = table.Column<int>(type: "int", nullable: true),
                    TRONGLUONG = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KICHTHUOC", x => x.MAKICHTHUOC);
                    table.ForeignKey(
                        name: "FK_KICHTHUOC_THONGTINHANGHOA_THONGTINHANGHOAMATHONGTIN",
                        column: x => x.THONGTINHANGHOAMATHONGTIN,
                        principalTable: "THONGTINHANGHOA",
                        principalColumn: "MATHONGTIN",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LOAIHANG_THONGTINHANGHOAMATHONGTIN",
                table: "LOAIHANG",
                column: "THONGTINHANGHOAMATHONGTIN");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_HOADONCHITIETMAHOADONCHITIET",
                table: "HOADON",
                column: "HOADONCHITIETMAHOADONCHITIET");

            migrationBuilder.CreateIndex(
                name: "IX_HANGHOA_THONGTINHANGHOAMATHONGTIN",
                table: "HANGHOA",
                column: "THONGTINHANGHOAMATHONGTIN");

            migrationBuilder.CreateIndex(
                name: "IX_KICHTHUOC_THONGTINHANGHOAMATHONGTIN",
                table: "KICHTHUOC",
                column: "THONGTINHANGHOAMATHONGTIN");

            migrationBuilder.AddForeignKey(
                name: "FK_HANGHOA_THONGTINHANGHOA_THONGTINHANGHOAMATHONGTIN",
                table: "HANGHOA",
                column: "THONGTINHANGHOAMATHONGTIN",
                principalTable: "THONGTINHANGHOA",
                principalColumn: "MATHONGTIN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HOADON_HOADONCHITIET_HOADONCHITIETMAHOADONCHITIET",
                table: "HOADON",
                column: "HOADONCHITIETMAHOADONCHITIET",
                principalTable: "HOADONCHITIET",
                principalColumn: "MAHOADONCHITIET",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HOADON_NHANVIEN_NHANVIENSMANHANVIEN",
                table: "HOADON",
                column: "NHANVIENSMANHANVIEN",
                principalTable: "NHANVIEN",
                principalColumn: "MANHANVIEN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LOAIHANG_THONGTINHANGHOA_THONGTINHANGHOAMATHONGTIN",
                table: "LOAIHANG",
                column: "THONGTINHANGHOAMATHONGTIN",
                principalTable: "THONGTINHANGHOA",
                principalColumn: "MATHONGTIN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PHIEUNHAP_CHITIETPHIEUNHAP_CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                table: "PHIEUNHAP",
                column: "CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                principalTable: "CHITIETPHIEUNHAP",
                principalColumn: "MACHITIETPHIEUNHAP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PHIEUNHAP_NHANVIEN_NHANVIENMANHANVIEN",
                table: "PHIEUNHAP",
                column: "NHANVIENMANHANVIEN",
                principalTable: "NHANVIEN",
                principalColumn: "MANHANVIEN",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_THONGTINHANGHOA_CHITIETPHIEUNHAP_CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                table: "THONGTINHANGHOA",
                column: "CHITIETPHIEUNHAPMACHITIETPHIEUNHAP",
                principalTable: "CHITIETPHIEUNHAP",
                principalColumn: "MACHITIETPHIEUNHAP",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_THONGTINHANGHOA_HOADONCHITIET_HOADONCHITIETMAHOADONCHITIET",
                table: "THONGTINHANGHOA",
                column: "HOADONCHITIETMAHOADONCHITIET",
                principalTable: "HOADONCHITIET",
                principalColumn: "MAHOADONCHITIET",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
