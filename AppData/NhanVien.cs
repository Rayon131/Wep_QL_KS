using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class NhanVien
	{
		[Key]
		public int MaNhanVien { get; set; }
		public string Ten { get; set; }
		public string SDT { get; set; }
		public string Email { get; set; }
		public string DiaChi { get; set; }

		public ICollection<HoaDon>? HoaDons { get; set; }

		public ICollection<TaiKhoann>? TaiKhoans { get; set; }
		public ICollection<ThuChi>? ThuChis { get; set; }
	}
}
