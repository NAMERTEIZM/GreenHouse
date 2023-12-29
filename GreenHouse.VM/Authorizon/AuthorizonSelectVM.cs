using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Authorizon
{
	public class AuthorizonSelectVM
	{
		public int ID { get; set; }

		public string Adi { get; set; }

		public override string ToString()
		{
			return Adi;
		}
	}
}
