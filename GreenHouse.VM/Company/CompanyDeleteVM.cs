using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Company
{
	public class CompanyDeleteVM
	{
		public Guid ID { get; set; }

		public string FirmaAdi { get; set; }

		public string FirmaTel { get; set; }

		public string FirmaAdresi { get; set; }

		public bool? AktifMi { get; set; }
	}
}
