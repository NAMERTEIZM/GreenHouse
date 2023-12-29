using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM
{
    public class IngredientSelectVM
    {
        public Guid ID { get; set; }
        public string Adi { get; set; }
        public string RiskTur { get; set; }
        public string Aciklama { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
}