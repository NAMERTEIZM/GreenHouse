﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.User
{
    public class UserListTypeSelectVM
    {
        public int ID { get; set; }
        public string TipAdi { get; set; }

        public override string ToString()
        {
            return TipAdi;
        }
    }
}
