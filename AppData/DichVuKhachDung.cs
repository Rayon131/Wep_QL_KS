using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class DichVuKhachDung
	{
		[Key]
		public int MaDichVuKhachDung { get; set; }
		public int MaDichVu { get; set; }
		public int MaDatPhong { get; set; }
		public decimal TongTien { get; set; }
		public int SoLuong { get; set; }
		public ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }

		public DichVu? DichVu { get; set; }
		public DatPhong? DatPhong { get; set; }
	}
}
