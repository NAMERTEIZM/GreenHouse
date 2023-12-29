using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Role
{
    public class RoleInsertVM
    {
        public string RolAdi { get; set; }
        public bool? AktifMi { get; set; }

        public override string ToString()
        {
            return RolAdi;
        }
    }
}
