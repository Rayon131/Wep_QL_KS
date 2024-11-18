using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class PhongChiTiet
	{
		[Key]
		public int MaPhongChiTiet { get; set; }
		public int MaPhong { get; set; }
		public int? MaGia { get; set; }
		public int MaLoaiPhong { get; set; }
		public int SoNguoi { get; set; }

		public Phong? Phong { get; set; }

		public LoaiPhong? LoaiPhong { get; set; }
		public Gia? Gia { get; set; }
	}
}
