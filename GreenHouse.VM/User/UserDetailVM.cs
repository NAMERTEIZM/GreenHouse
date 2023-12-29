using GreenHouse.VM.UserRole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.User
{
    public class UserDetailVM
    {
        public Guid ID { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }

        public Guid UserRoleID { get; set; }
    }
}
