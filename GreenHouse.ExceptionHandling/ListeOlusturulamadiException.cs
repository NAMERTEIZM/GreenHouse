using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class ListeOlusturulamadiException:Exception
    {
        public ListeOlusturulamadiException()
        {

        }
        public ListeOlusturulamadiException(string message) : base(message)
        {

        }
    }
}
