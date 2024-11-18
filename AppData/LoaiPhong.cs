using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class LoaiPhong
	{
		[Key]
		public int MaLoaiPhong { get; set; }
		public string TenLoaiPhong { get; set; }

		public ICollection<PhongChiTiet>? PhongChiTiets { get; set; }
	}
}
