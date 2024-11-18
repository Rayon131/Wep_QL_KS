using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class KhachHang
	{
		[Key]
		public int MaKhachHang { get; set; }
		public string Ten { get; set; }
		public string CMND { get; set; }
		public string SDT { get; set; }
		public int? MaTaiKhoan { get; set; }
		public int? MaDatPhong { get; set; }

		public TaiKhoann? TaiKhoan { get; set; }
		public DatPhong? DatPhong { get; set; }
		public ICollection<HoaDon>? HoaDons { get; set; }
	}
}
