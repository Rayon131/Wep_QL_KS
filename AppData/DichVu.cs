using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class DichVu
	{
		[Key]
		public int MaDichVu { get; set; }
		public string Ten { get; set; }
		public decimal Gia { get; set; }
		public string MoTa { get; set; }
		public string Hinh { get; set; }

		public ICollection<DichVuKhachDung>? DichVuKhachDungs { get; set; }
	}
}
