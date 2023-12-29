using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class UrunFotogramFormatException:Exception
    {
        public UrunFotogramFormatException()
        {

        }
        public UrunFotogramFormatException(string message) : base(message)
        {

        }
    }
}
