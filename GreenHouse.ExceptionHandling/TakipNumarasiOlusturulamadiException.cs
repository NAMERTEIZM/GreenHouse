using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class TakipNumarasiOlusturulamadiException:Exception //UrunOnay takip numarası oluşturulamadı
    {
        public TakipNumarasiOlusturulamadiException()
        {

        }
        public TakipNumarasiOlusturulamadiException(string message) : base(message)
        {

        }
    }
}
