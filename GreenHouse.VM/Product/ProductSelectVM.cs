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
    public class ProductSelectVM
    {
        public Guid ID { get; set; }

        public string BarkodNumarasi { get; set; }

        public string UrunAdi { get; set; }

        public int? KategoriID { get; set; }

        public string UrunAciklamasi { get; set; }

        public string NameAndSurname { get; set; }
        public bool HideState {  get; set; }
        public bool? AktifMi { get; set; }

        public CategorySelectVM Kategori {  get; set; }
        public virtual List<PictureSelectVM> Resims { get; set; }

        public virtual List<ProductCompanySelectVM> UrunFirmas { get; set; }

        public virtual List<ProductIngredientSelectVM> UrunIceriks { get; set; }
        

        public override string ToString()
        {
            return UrunAdi;
        }

    }
}
