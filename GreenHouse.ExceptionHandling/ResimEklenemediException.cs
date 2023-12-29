using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class ResimEklenemediException:Exception
    {
        public ResimEklenemediException()
        {

        }
        public ResimEklenemediException(string message) : base(message)
        {

        }
    }
}
