using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class GuncellencekUrunCekilemediException:Exception //Güncellenmesi gereken ürün bulunamadı
    {
        public GuncellencekUrunCekilemediException()
        {

        }
        public GuncellencekUrunCekilemediException(string message) : base(message)
        {

        }
    }
}
