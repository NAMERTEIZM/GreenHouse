using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class RiskEklenemediException:Exception
    {
        public RiskEklenemediException()
        {

        }
        public RiskEklenemediException(string message) : base(message)
        {

        }
    }
}
