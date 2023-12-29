using GreenHouse.Core;
using GreenHouse.VM.Category;
using MyEFSample.DAL.Concrete;
using MyEfSample.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using GreenHouse.VM.Company;
using GreenHouse.DAL.LogicsDAL;

namespace GreenHouse.BLL.Logic
{
	public class CompanyManager
	{
		CompanyDAL CompanyDAL;
        public CompanyManager()
        {
            CompanyDAL = new CompanyDAL();
        }

        public List<CompanySelectVM> GetCompany()
        {
            return CompanyDAL.GetCompany();

        }

        public CompanyInsertVM AddCompany(CompanyInsertVM company)
		{
			return CompanyDAL.AddCompany(company);
		}

		public CompanyUpdateVM UpdateCompany(CompanyUpdateVM company)
		{
			return CompanyDAL.UpdateCompany(company);
		}

		public CompanyDeleteVM DeleteCompany(CompanyDeleteVM company)
		{
			return CompanyDAL.DeleteCompany(company);
		}
	}
}

