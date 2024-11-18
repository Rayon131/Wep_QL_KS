using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    /// <inheritdoc />
    public partial class Hotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DichVus",
                columns: table => new
                {
                    MaDichVu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVus", x => x.MaDichVu);
                });

            migrationBuilder.CreateTable(
                name: "Gias",
                columns: table => new
                {
                    MaGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhongChiTiet = table.Column<int>(type: "int", nullable: true),
                    GiaNgayThuong = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaCuoiTuan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaBanDem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaNgayLe = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gias", x => x.MaGia);
                });

            migrationBuilder.CreateTable(
                name: "LoaiPhongs",
                columns: table => new
                {
                    MaLoaiPhong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiPhong = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhongs", x => x.MaLoaiPhong);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "Phongs",
                columns: table => new
                {
                    MaPhong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phongs", x => x.MaPhong);
                });

            migrationBuilder.CreateTable(
                name: "Quyens",
                columns: table => new
                {
                    MaQuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQuyen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quyens", x => x.MaQuyen);
                });

            migrationBuilder.CreateTable(
                name: "PhongChiTiets",
                columns: table => new
                {
                    MaPhongChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhong = table.Column<int>(type: "int", nullable: false),
                    MaGia = table.Column<int>(type: "int", nullable: true),
                    MaLoaiPhong = table.Column<int>(type: "int", nullable: false),
                    SoNguoi = table.Column<int>(type: "int", nullable: false),
                    PhongMaPhong = table.Column<int>(type: "int", nullable: true),
                    LoaiPhongMaLoaiPhong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongChiTiets", x => x.MaPhongChiTiet);
                    table.ForeignKey(
                        name: "FK_PhongChiTiets_Gias_MaGia",
                        column: x => x.MaGia,
                        principalTable: "Gias",
                        principalColumn: "MaGia");
                    table.ForeignKey(
                        name: "FK_PhongChiTiets_LoaiPhongs_LoaiPhongMaLoaiPhong",
                        column: x => x.LoaiPhongMaLoaiPhong,
                        principalTable: "LoaiPhongs",
                        principalColumn: "MaLoaiPhong");
                    table.ForeignKey(
                        name: "FK_PhongChiTiets_Phongs_PhongMaPhong",
                        column: x => x.PhongMaPhong,
                        principalTable: "Phongs",
                        principalColumn: "MaPhong");
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    MaTaiKhoan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false),
                    MaQuyen = table.Column<int>(type: "int", nullable: false),
                    NhanVienMaNhanVien = table.Column<int>(type: "int", nullable: true),
                    QuyenMaQuyen = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.MaTaiKhoan);
                    table.ForeignKey(
                        name: "FK_TaiKhoans_NhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien");
                    table.ForeignKey(
                        name: "FK_TaiKhoans_Quyens_QuyenMaQuyen",
                        column: x => x.QuyenMaQuyen,
                        principalTable: "Quyens",
                        principalColumn: "MaQuyen");
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMND = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaTaiKhoan = table.Column<int>(type: "int", nullable: true),
                    MaDatPhong = table.Column<int>(type: "int", nullable: true),
                    TaiKhoanMaTaiKhoan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.MaKhachHang);
                    table.ForeignKey(
                        name: "FK_KhachHangs_TaiKhoans_TaiKhoanMaTaiKhoan",
                        column: x => x.TaiKhoanMaTaiKhoan,
                        principalTable: "TaiKhoans",
                        principalColumn: "MaTaiKhoan");
                });

            migrationBuilder.CreateTable(
                name: "DatPhongs",
                columns: table => new
                {
                    MaDatPhong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhongChiTiet = table.Column<int>(type: "int", nullable: false),
                    MaKhachHang = table.Column<int>(type: "int", nullable: true),
                    NgayNhan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoNguoi = table.Column<int>(type: "int", nullable: false),
                    SoLuongPhong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongChiTietMaPhongChiTiet = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatPhongs", x => x.MaDatPhong);
                    table.ForeignKey(
                        name: "FK_DatPhongs_KhachHangs_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "MaKhachHang");
                    table.ForeignKey(
                        name: "FK_DatPhongs_PhongChiTiets_PhongChiTietMaPhongChiTiet",
                        column: x => x.PhongChiTietMaPhongChiTiet,
                        principalTable: "PhongChiTiets",
                        principalColumn: "MaPhongChiTiet");
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    MaHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhachHang = table.Column<int>(type: "int", nullable: false),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KhachHangMaKhachHang = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_KhachHangMaKhachHang",
                        column: x => x.KhachHangMaKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "MaKhachHang");
                    table.ForeignKey(
                        name: "FK_HoaDons_NhanViens_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DichVuKhachDungs",
                columns: table => new
                {
                    MaDichVuKhachDung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDichVu = table.Column<int>(type: "int", nullable: false),
                    MaDatPhong = table.Column<int>(type: "int", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DichVuMaDichVu = table.Column<int>(type: "int", nullable: true),
                    DatPhongMaDatPhong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVuKhachDungs", x => x.MaDichVuKhachDung);
                    table.ForeignKey(
                        name: "FK_DichVuKhachDungs_DatPhongs_DatPhongMaDatPhong",
                        column: x => x.DatPhongMaDatPhong,
                        principalTable: "DatPhongs",
                        principalColumn: "MaDatPhong");
                    table.ForeignKey(
                        name: "FK_DichVuKhachDungs_DichVus_DichVuMaDichVu",
                        column: x => x.DichVuMaDichVu,
                        principalTable: "DichVus",
                        principalColumn: "MaDichVu");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiets",
                columns: table => new
                {
                    MaHoaDonChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDichVuKhachDung = table.Column<int>(type: "int", nullable: false),
                    MaDatPhong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HoaDon = table.Column<int>(type: "int", nullable: false),
                    DatPhongMaDatPhong = table.Column<int>(type: "int", nullable: true),
                    HoaDonEntityMaHoaDon = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiets", x => x.MaHoaDonChiTiet);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_DatPhongs_DatPhongMaDatPhong",
                        column: x => x.DatPhongMaDatPhong,
                        principalTable: "DatPhongs",
                        principalColumn: "MaDatPhong");
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_DichVuKhachDungs_MaDichVuKhachDung",
                        column: x => x.MaDichVuKhachDung,
                        principalTable: "DichVuKhachDungs",
                        principalColumn: "MaDichVuKhachDung",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_HoaDons_HoaDonEntityMaHoaDon",
                        column: x => x.HoaDonEntityMaHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "MaHoaDon");
                });

            migrationBuilder.CreateTable(
                name: "ThuChis",
                columns: table => new
                {
                    MaThuChi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDatPhong = table.Column<int>(type: "int", nullable: false),
                    MaHoaDonChiTiet = table.Column<int>(type: "int", nullable: false),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayGiaoDich = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatPhongMaDatPhong = table.Column<int>(type: "int", nullable: true),
                    NhanVienMaNhanVien = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuChis", x => x.MaThuChi);
                    table.ForeignKey(
                        name: "FK_ThuChis_DatPhongs_DatPhongMaDatPhong",
                        column: x => x.DatPhongMaDatPhong,
                        principalTable: "DatPhongs",
                        principalColumn: "MaDatPhong");
                    table.ForeignKey(
                        name: "FK_ThuChis_HoaDonChiTiets_MaHoaDonChiTiet",
                        column: x => x.MaHoaDonChiTiet,
                        principalTable: "HoaDonChiTiets",
                        principalColumn: "MaHoaDonChiTiet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ThuChis_NhanViens_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatPhongs_MaKhachHang",
                table: "DatPhongs",
                column: "MaKhachHang",
                unique: true,
                filter: "[MaKhachHang] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DatPhongs_PhongChiTietMaPhongChiTiet",
                table: "DatPhongs",
                column: "PhongChiTietMaPhongChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_DichVuKhachDungs_DatPhongMaDatPhong",
                table: "DichVuKhachDungs",
                column: "DatPhongMaDatPhong");

            migrationBuilder.CreateIndex(
                name: "IX_DichVuKhachDungs_DichVuMaDichVu",
                table: "DichVuKhachDungs",
                column: "DichVuMaDichVu");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_DatPhongMaDatPhong",
                table: "HoaDonChiTiets",
                column: "DatPhongMaDatPhong");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_HoaDonEntityMaHoaDon",
                table: "HoaDonChiTiets",
                column: "HoaDonEntityMaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_MaDichVuKhachDung",
                table: "HoaDonChiTiets",
                column: "MaDichVuKhachDung");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangMaKhachHang",
                table: "HoaDons",
                column: "KhachHangMaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_MaNhanVien",
                table: "HoaDons",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHangs_TaiKhoanMaTaiKhoan",
                table: "KhachHangs",
                column: "TaiKhoanMaTaiKhoan");

            migrationBuilder.CreateIndex(
                name: "IX_PhongChiTiets_LoaiPhongMaLoaiPhong",
                table: "PhongChiTiets",
                column: "LoaiPhongMaLoaiPhong");

            migrationBuilder.CreateIndex(
                name: "IX_PhongChiTiets_MaGia",
                table: "PhongChiTiets",
                column: "MaGia",
                unique: true,
                filter: "[MaGia] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PhongChiTiets_PhongMaPhong",
                table: "PhongChiTiets",
                column: "PhongMaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_NhanVienMaNhanVien",
                table: "TaiKhoans",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_QuyenMaQuyen",
                table: "TaiKhoans",
                column: "QuyenMaQuyen");

            migrationBuilder.CreateIndex(
                name: "IX_ThuChis_DatPhongMaDatPhong",
                table: "ThuChis",
                column: "DatPhongMaDatPhong");

            migrationBuilder.CreateIndex(
                name: "IX_ThuChis_MaHoaDonChiTiet",
                table: "ThuChis",
                column: "MaHoaDonChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_ThuChis_NhanVienMaNhanVien",
                table: "ThuChis",
                column: "NhanVienMaNhanVien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThuChis");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "DichVuKhachDungs");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "DatPhongs");

            migrationBuilder.DropTable(
                name: "DichVus");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "PhongChiTiets");

            migrationBuilder.DropTable(
                name: "TaiKhoans");

            migrationBuilder.DropTable(
                name: "Gias");

            migrationBuilder.DropTable(
                name: "LoaiPhongs");

            migrationBuilder.DropTable(
                name: "Phongs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "Quyens");
        }
    }
}
