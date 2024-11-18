using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class TaiKhoann
	{
		[Key]
		public int MaTaiKhoan { get; set; }
		public string TaiKhoan { get; set; }
		public string MatKhau { get; set; }
		public string TrangThai { get; set; }
		

		public NhanVien? NhanVien { get; set; }
		public Quyen? Quyen { get; set; }
	}
}
