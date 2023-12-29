using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Page
{
    public class RoleSelectVM
    {
        public int ID { get; set; }
        public string RolAdi { get; set; }
        public bool? AktifMi { get; set; }

        public override string ToString()
        {
            return RolAdi;
        }
    }
}
