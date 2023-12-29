using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class FirmaEklenemediException:Exception
    {
        public FirmaEklenemediException()
        {

        }
        public FirmaEklenemediException(string message) : base(message)
        {

        }
    }
}
