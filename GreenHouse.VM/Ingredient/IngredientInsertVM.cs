﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Ingredient
{
    public class IngredientInsertVM
    {
        public Guid ID { get; set; }

        public string Adi { get; set; }

        public string Aciklama { get; set; }

        public int RiskID { get; set; }

    }
}