using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class ThuChi
	{
		[Key]
		public int MaThuChi { get; set; }
		public int MaDatPhong { get; set; }
		public int MaHoaDonChiTiet { get; set; }
		public int MaNhanVien { get; set; }
		public string MoTa { get; set; }
		public decimal SoTien { get; set; }
		public DateTime NgayGiaoDich { get; set; }

		public DatPhong? DatPhong { get; set; }
		public HoaDonChiTiet? HoaDonChiTiet { get; set; }
		public NhanVien? NhanVien { get; set; }
	}
}
