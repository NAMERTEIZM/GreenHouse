using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class KategoriyeAitUrunBulunamadiException:Exception
    {
        public KategoriyeAitUrunBulunamadiException()
        {

        }
        public KategoriyeAitUrunBulunamadiException(string message) : base(message)
        {

        }
    }
}
