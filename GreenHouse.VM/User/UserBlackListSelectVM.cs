using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.User
{
    public class UserBlackListSelectVM
    {
        public Guid ID { get; set; }
        public string ListeAdi { get; set; }
        public Guid KullaniciRolID { get; set; }
        public int ListeTipiID { get; set; }
        public string IcerikAdi { get; set; }
        public override string ToString()
        {
            return IcerikAdi;
        }
    }
}
