using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class KameraIzniReddedildiException:Exception
    {
        public KameraIzniReddedildiException(){}

        public KameraIzniReddedildiException(string message) : base(message)
        {

        }

    }
}
