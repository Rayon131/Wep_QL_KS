using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    /// <inheritdoc />
    public partial class HOTEL1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaNhanVien",
                table: "TaiKhoans");

            migrationBuilder.DropColumn(
                name: "MaQuyen",
                table: "TaiKhoans");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaNhanVien",
                table: "TaiKhoans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaQuyen",
                table: "TaiKhoans",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
