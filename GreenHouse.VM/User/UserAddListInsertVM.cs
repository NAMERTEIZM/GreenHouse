using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.User
{
    public class UserAddListInsertVM
    {
        public Guid ID { get; set; }
        public Guid UserRoleID { get; set; }
        public string ListeAdi { get; set; }
        public UserListTypeSelectVM ListeTipi { get; set; }
        public List<UserListItemSelectVM> ListeIcerik { get; set; }
        public override string ToString()
        {
            return ListeAdi;
        }
    }
}
