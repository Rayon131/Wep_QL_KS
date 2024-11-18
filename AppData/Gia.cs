using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class Gia
	{
		[Key]
		public int MaGia { get; set; }
		public int? MaPhongChiTiet { get; set; }
		public decimal GiaNgayThuong { get; set; }
		public decimal GiaCuoiTuan { get; set; }
		public decimal GiaBanDem { get; set; }
		public decimal GiaNgayLe { get; set; }

		public PhongChiTiet? PhongChiTiet { get; set; }
	}
}
