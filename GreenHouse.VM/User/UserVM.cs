using GreenHouse.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM
{
    public class UserVM
    {
        public Guid ID { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public bool? EmailOnayliMi { get; set; }

        public ICollection<KullaniciRolu> KullaniciRolus { get; set; }
    }
}
