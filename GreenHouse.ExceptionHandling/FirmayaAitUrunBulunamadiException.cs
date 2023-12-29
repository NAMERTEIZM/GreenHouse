using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class FirmayaAitUrunBulunamadiException:Exception
    {
        public FirmayaAitUrunBulunamadiException()
        {

        }
        public FirmayaAitUrunBulunamadiException(string message) : base(message)
        {

        }
    }
}
