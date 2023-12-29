using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class UrunEklenemediException:Exception
    {
        public UrunEklenemediException()
        {

        }
        public UrunEklenemediException(string message) : base(message)
        {

        }
    }
}
