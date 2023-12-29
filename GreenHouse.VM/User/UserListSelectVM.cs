using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.User
{
    public class UserListSelectVM
    {
        public Guid UserRoleID { get; set; }
        public string ListeAdi { get; set; }
        public List<UserListItemSelectVM> ListeIcerigi { get; set; }

        public override string ToString()
        {
            return ListeAdi;
        }
    }
}
