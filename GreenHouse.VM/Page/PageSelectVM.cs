using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Page
{
    public class PageSelectVM
    {
        public int ID { get; set; }

        public string SayfaAdi { get; set; }
        public override string ToString()
        {
            return SayfaAdi;
        }
    }
}
