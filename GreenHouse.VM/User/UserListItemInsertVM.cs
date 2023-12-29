using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.User
{
    public class UserListItemInsertVM
    {
        public Guid ID { get; set; }
        public Guid ListeID { get; set; }
        public bool? UrunMu { get; set; }
        public Guid IcerikID { get; set; }
        public string IcerikAdi { get; set; }
    }
}
