using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class ProfilBilgileriGetirilemediException:Exception
    {
        public ProfilBilgileriGetirilemediException()
        {

        }
        public ProfilBilgileriGetirilemediException(string message) : base(message)
        {

        }
    }
}
