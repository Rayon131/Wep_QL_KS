using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class HoaDon
	{
		[Key]
		public int MaHoaDon { get; set; }
		public int MaKhachHang { get; set; }
		public int MaNhanVien { get; set; }
		public string TrangThai { get; set; }
		public decimal TongTien { get; set; }

		public KhachHang? KhachHang { get; set; }
		public NhanVien? NhanVien { get; set; }
		public ICollection<HoaDonChiTiet>? HoaDonChiTiets { get; set; }
	}
}
