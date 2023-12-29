using GreenHouse.Core;
using GreenHouse.VM.Category;
using GreenHouse.VM.Picture;
using GreenHouse.VM.ProductCompany;
using GreenHouse.VM.ProductIngredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Product
{
    public class ProductInsertVM
    {
        public Guid ID { get; set; }

        public string BarkodNumarasi { get; set; }

        public string UrunAdi { get; set; }

        public string UrunAciklamasi { get; set; }

        public List<PictureSelectVM> Resims { get; set; } = new List<PictureSelectVM>();

        public CategorySelectVM UrunKategori { get; set; } 

        public List<ProductCompanySelectVM> UrunFirmas { get; set; } = new List<ProductCompanySelectVM>();

        public List<ProductIngredientSelectVM> UrunIceriks { get; set; } = new List<ProductIngredientSelectVM>();
    }
}
