﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class KullaniciBilgileriGecersizException:Exception //Register
    {
        public KullaniciBilgileriGecersizException()
        {

        }
        public KullaniciBilgileriGecersizException(string message) : base(message)
        {

        }
    }
}
