using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class BilesenEklenemdiException:Exception
    {
        public BilesenEklenemdiException()
        {

        }
        public BilesenEklenemdiException(string message) : base(message)
        {

        }
    }
}
