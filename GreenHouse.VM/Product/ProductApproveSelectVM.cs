using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Product
{
    public class ProductApproveSelectVM
    {
        public Guid ProductID { get; set; }
        public Guid KullaniciRolID { get; set; }
        public Guid KullaniciID { get; set; }
        public string UrunAdi { get; set; }
        public string BarkodNumarasi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool? OnayDurumu { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
    }
}
