using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class HotelDbContext : DbContext
	{
		public HotelDbContext(DbContextOptions options) : base(options)
		{
		}
		public HotelDbContext() { }
		public DbSet<Phong> Phongs { get; set; }
		public DbSet<LoaiPhong> LoaiPhongs { get; set; }
		public DbSet<NhanVien> NhanViens { get; set; }
		public DbSet<Quyen> Quyens { get; set; }
		public DbSet<DichVu> DichVus { get; set; }
		public DbSet<PhongChiTiet> PhongChiTiets { get; set; }
		public DbSet<Gia> Gias { get; set; }
		public DbSet<TaiKhoann> TaiKhoans { get; set; }
		public DbSet<DatPhong> DatPhongs { get; set; }
		public DbSet<KhachHang> KhachHangs { get; set; }
		public DbSet<HoaDon> HoaDons { get; set; }
		public DbSet<DichVuKhachDung> DichVuKhachDungs { get; set; }
		public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
		public DbSet<ThuChi> ThuChis { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<DatPhong>()
				.HasOne(dp => dp.KhachHang) 
				.WithOne(kh => kh.DatPhong) 
				.HasForeignKey<DatPhong>(dp => dp.MaKhachHang);

			modelBuilder.Entity<PhongChiTiet>()
				.HasOne(pc => pc.Gia)
				.WithOne(g => g.PhongChiTiet) 
				.HasForeignKey<PhongChiTiet>(pc => pc.MaGia);
			modelBuilder.Entity<HoaDon>()
				.HasOne(hd => hd.NhanVien)  
				.WithMany(nv => nv.HoaDons) 
				.HasForeignKey(hd => hd.MaNhanVien) 
				.OnDelete(DeleteBehavior.Restrict);
			modelBuilder.Entity<HoaDonChiTiet>()
				.HasOne(hdct => hdct.DichVuKhachDung)  
				.WithMany(dvkd => dvkd.HoaDonChiTiets) 
				.HasForeignKey(hdct => hdct.MaDichVuKhachDung) 
				.OnDelete(DeleteBehavior.Restrict);
			modelBuilder.Entity<ThuChi>()
				.HasOne(tc => tc.HoaDonChiTiet) 
				.WithMany(hdct => hdct.ThuChis)
				.HasForeignKey(tc => tc.MaHoaDonChiTiet) 
				.OnDelete(DeleteBehavior.Restrict);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=NOONE\\MSSQLSERVER02;Initial Catalog=HOTEL02;Integrated Security=True;Trust Server Certificate=True");
		}

	}
}

