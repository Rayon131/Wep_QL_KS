using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class DatPhong
	{
		[Key]
		public int MaDatPhong { get; set; }
		public int MaPhongChiTiet { get; set; }
		public int? MaKhachHang { get; set; }
		public DateTime NgayNhan { get; set; }
		public DateTime NgayTra { get; set; }
		public int SoNguoi { get; set; }
		public int SoLuongPhong { get; set; }
		public string TrangThai { get; set; }

		public PhongChiTiet? PhongChiTiet { get; set; }
		public KhachHang? KhachHang { get; set; }
		public ICollection<DichVuKhachDung>? DichVuKhachDungs { get; set; }
	}
}
