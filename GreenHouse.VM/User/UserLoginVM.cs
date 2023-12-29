using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.User
{
    public class UserLoginVM
    {
        public Guid ID { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

    }
}
