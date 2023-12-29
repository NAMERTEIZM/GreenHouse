using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class MenuBulunamadiException:Exception
    {
        public MenuBulunamadiException()
        {

        }
        public MenuBulunamadiException(string message) : base(message)
        {

        }
    }
}
