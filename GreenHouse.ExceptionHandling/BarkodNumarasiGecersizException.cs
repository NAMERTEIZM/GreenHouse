using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class BarkodNumarasiGecersizException:Exception
    {
        public BarkodNumarasiGecersizException()
        {

        }
        public BarkodNumarasiGecersizException(string message) : base(message)
        {

        }
    }
}
