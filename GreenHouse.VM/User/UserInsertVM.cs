using GreenHouse.Core;
using GreenHouse.VM.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.User
{
    public class UserInsertVM
    {
        public Guid ID { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public bool? EmailOnayliMi { get; set; }

        public bool? AktifMi { get; set; }

        public RoleSelectVM Rol { get; set; }

    }
}
