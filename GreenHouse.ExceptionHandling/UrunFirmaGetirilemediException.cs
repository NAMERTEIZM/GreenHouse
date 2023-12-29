using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class UrunFirmaGetirilemediException:Exception
    {
        public UrunFirmaGetirilemediException()
        {

        }
        public UrunFirmaGetirilemediException(string message) : base(message)
        {

        }
    }
}
