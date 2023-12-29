using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Product
{
    public class ProductUserAddedVM
    {
        public Guid ID { get; set; }

        public Guid EkleyenKullaniciRolID { get; set; }

        public string UrunAdi { get; set; }
        public string BarkodNumarasi { get; set; }

        public string TakipNumarasi { get; set; }

        public bool? OnayDurumu { get; set; }

        public bool? AktifMi { get; set; }
    }
}
