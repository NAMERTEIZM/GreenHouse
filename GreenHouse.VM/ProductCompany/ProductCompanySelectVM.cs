using GreenHouse.VM.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.VM.ProductCompany
{
    public class ProductCompanySelectVM
    {
        public Guid UrunID { get; set; }
        public Guid FirmaID { get; set; }
        public CompanySelectVM Firma { get; set; }
    }
}
