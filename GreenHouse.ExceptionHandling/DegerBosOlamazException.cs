using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class DegerBosOlamazException:Exception
    {
        public DegerBosOlamazException()
        {

        }
        public DegerBosOlamazException(string message) : base(message)
        {

        }
    }
}
