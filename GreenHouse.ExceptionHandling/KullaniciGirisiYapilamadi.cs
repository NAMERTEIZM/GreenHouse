﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.ExceptionHandling
{
    public class KullaniciGirisiYapilamadi: Exception
    {
        public KullaniciGirisiYapilamadi()
        {

        }
        public KullaniciGirisiYapilamadi(string message) : base(message)
        {

        }
    }
}
