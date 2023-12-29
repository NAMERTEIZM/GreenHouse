using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class UrunBulunamadiException:Exception
    {
        public UrunBulunamadiException()
        {

        }
        public UrunBulunamadiException(string message) : base(message)
        {

        }
    }
}
