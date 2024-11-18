using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
	public class Quyen
	{
		[Key]
		public int MaQuyen { get; set; }
		public string TenQuyen { get; set; }

		public ICollection<TaiKhoann>? TaiKhoans { get; set; }
	}
}
