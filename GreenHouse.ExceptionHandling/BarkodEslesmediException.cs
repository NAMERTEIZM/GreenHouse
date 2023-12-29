using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class BarkodEslesmediException : Exception
    {
        public BarkodEslesmediException()
        {

        }
        public BarkodEslesmediException(string message) : base(message)
        {

        }
    }
}
