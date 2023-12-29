using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.ProductIngredient
{
    public class ProductIngredientSelectVM
    {
        public Guid UrunID { get; set; }
        public Guid BilesenID { get; set; }
        public IngredientSelectVM Bilesen { get; set; }

        public override string ToString()
        {
            return Bilesen.Adi;
        }
    }
}
