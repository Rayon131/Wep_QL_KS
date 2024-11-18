using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class HoaDonChiTiet
	{
		[Key]
		public int MaHoaDonChiTiet { get; set; }
		public int MaDichVuKhachDung { get; set; }
		public int MaDatPhong { get; set; }
		public decimal DonGia { get; set; }
		public int HoaDon { get; set; }

		public ICollection<ThuChi>? ThuChis { get; set; }

		public DichVuKhachDung? DichVuKhachDung { get; set; }
		public DatPhong? DatPhong { get; set; }
		public HoaDon? HoaDonEntity { get; set; }
	}
}
