using GreenHouse.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.Category
{
    public class CategorySelectVM
    {
        public int? ID { get; set; }
        public string KategoriAdi { get; set; }
        public int? UstKategoriID { get; set; }
        public UrunKategori UstKategori { get; set; }
        public override string ToString()
        {
            return KategoriAdi;
        }
    }
}
