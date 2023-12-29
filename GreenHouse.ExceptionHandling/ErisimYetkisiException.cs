using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class ErisimYetkisiException:Exception
    {
        public ErisimYetkisiException()
        {

        }
        public ErisimYetkisiException(string message) : base(message)
        {

        }
    }
}
