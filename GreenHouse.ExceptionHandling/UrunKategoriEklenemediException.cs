using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class UrunKategoriEklenemediException:Exception
    {
        public UrunKategoriEklenemediException()
        {

        }
        public UrunKategoriEklenemediException(string message) : base(message)
        {

        }
    }
}
