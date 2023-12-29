using GreenHouse.VM.Authorizon;
using GreenHouse.VM.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Role
{
    public class PageAuthorizationVM
    {
        public int ID { get; set; }
        public PageSelectVM Page { get; set; }
        public RoleSelectVM Role { get; set; }
        public AuthorizonSelectVM Authorizon { get; set; }
    }
}
