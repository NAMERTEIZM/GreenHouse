using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class UrunFotograflariYetersizException:Exception
    {
        public UrunFotograflariYetersizException()
        {

        }
        public UrunFotograflariYetersizException(string message) : base(message)
        {

        }
    }
}
